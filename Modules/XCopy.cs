﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace madFurry
{
    /// <summary>
    /// PInvoke wrapper for CopyEx
    /// http://msdn.microsoft.com/en-us/library/windows/desktop/aa363852.aspx
    /// </summary>
    public class XCopy
    {
        public void RegularCopy(string source, string destination, int bytesPerChunk, EventHandler<ProgressChangedEventArgs> handler)
        {
           
            
            if (handler != null)
                ProgressChanged += handler;

            using (FileStream fs = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    using (FileStream fsDest = new FileStream(destination, FileMode.Create))
                    {
                        BinaryWriter bw = new BinaryWriter(fsDest);
                        byte[] buffer;

                        double bytesRead = 0;
                        while (bytesRead < fs.Length)
                        {
                            buffer = br.ReadBytes(bytesPerChunk);
                            bw.Write(buffer);
                            bytesRead += buffer.Length;
                            var percentageCopied = (bytesRead * 100 / fs.Length);
                            OnProgressChanged(percentageCopied);  //report the progress
                        }
                       
                        ProgressChanged -= handler;
                        OnCompleted();
                    }
                }
            }
        }

        public static void Copy(string source, string destination, bool overwrite, bool nobuffering)
        {
            new XCopy().CopyInternal(source, destination, overwrite, nobuffering, null, null);
        }
        public static void Copy(string source, string destination, bool overwrite, bool nobuffering, EventHandler<ProgressChangedEventArgs> progressHandler)
        {
            new XCopy().CopyInternal(source, destination, overwrite, nobuffering, progressHandler, null);
        }

        public static void Copy(string source, string destination, bool overwrite, bool nobuffering, EventHandler<ProgressChangedEventArgs> progressHandler, EventHandler completedHandler)
        {
            new XCopy().CopyInternal(source, destination, overwrite, nobuffering, progressHandler, completedHandler);
        }

        private event EventHandler Completed;
        private event EventHandler<ProgressChangedEventArgs> ProgressChanged;

        public bool IsCompleted = false;
        private int IsCancelled;
        private int FilePercentCompleted;
        private string Source;
        private string Destination;
        public string error;

        public XCopy()
        {
            IsCancelled = 0;
        }

        private void CopyInternal(string source, string destination, bool overwrite, bool nobuffering, EventHandler<ProgressChangedEventArgs> progressHandler, EventHandler completedHandler )
        {
            try
            {
                CopyFileFlags copyFileFlags = 0;
                if (!overwrite)
                    copyFileFlags |= CopyFileFlags.COPY_FILE_FAIL_IF_EXISTS;

                if (nobuffering)
                    copyFileFlags |= CopyFileFlags.COPY_FILE_NO_BUFFERING;

                Source = source;
                Destination = destination;

                if (progressHandler != null)
                    ProgressChanged += progressHandler;
                if (completedHandler != null)
                    Completed += completedHandler;

                bool result = CopyFileEx(Source, Destination, new CopyProgressRoutine(CopyProgressHandler), IntPtr.Zero, ref IsCancelled, copyFileFlags);
                if (!result)
                    throw new Win32Exception(Marshal.GetLastWin32Error());
            }
            catch (Exception ex)
            {
                if (progressHandler != null)
                    ProgressChanged -= progressHandler;
                if (completedHandler != null)
                    ProgressChanged -= progressHandler;
                error = ex.Message + ex.StackTrace;
                File.AppendAllLines(Source+"_log", new List<string>() { error });
                throw;
            }
        }

        private void OnProgressChanged(double percent)
        {
            // only raise an event when progress has changed
            if ((int)percent > FilePercentCompleted)
            {
                FilePercentCompleted = (int)percent;

                var handler = ProgressChanged;
                if (handler != null)
                    handler(this, new ProgressChangedEventArgs((int)FilePercentCompleted, null));
            }
        }

        private void OnCompleted()
        {
            IsCompleted = true;
            var handler = Completed;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        #region PInvoke

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CopyFileEx(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref Int32 pbCancel, CopyFileFlags dwCopyFlags);

        private delegate CopyProgressResult CopyProgressRoutine(long TotalFileSize, long TotalBytesTransferred, long StreamSize, long StreamBytesTransferred, uint dwStreamNumber, CopyProgressCallbackReason dwCallbackReason,
                                                        IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

        private enum CopyProgressResult : uint
        {
            PROGRESS_CONTINUE = 0,
            PROGRESS_CANCEL = 1,
            PROGRESS_STOP = 2,
            PROGRESS_QUIET = 3
        }

        private enum CopyProgressCallbackReason : uint
        {
            CALLBACK_CHUNK_FINISHED = 0x00000000,
            CALLBACK_STREAM_SWITCH = 0x00000001
        }

        [Flags]
        private enum CopyFileFlags : uint
        {
            COPY_FILE_FAIL_IF_EXISTS = 0x00000001,
            COPY_FILE_NO_BUFFERING = 0x00001000,
            COPY_FILE_RESTARTABLE = 0x00000002,
            COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004,
            COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008
        }

        private CopyProgressResult CopyProgressHandler(long total, long transferred, long streamSize, long streamByteTrans, uint dwStreamNumber,
                                                       CopyProgressCallbackReason reason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData)
        {
            if (reason == CopyProgressCallbackReason.CALLBACK_CHUNK_FINISHED)
                OnProgressChanged((transferred / (double)total) * 100.0);

            if (transferred >= total)
                OnCompleted();

            return CopyProgressResult.PROGRESS_CONTINUE;
        }

        #endregion

    }
}
