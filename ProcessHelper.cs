using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Text;

namespace madMaxGUI
{
    public static class ProcessHelper
    {
        public static IEnumerable<Process> GetChildProcesses(this Process process)
        {
            List<Process> children = new List<Process>();
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher(String.Format("Select * From Win32_Process where ParentProcessID={0}", process.Id));

                foreach (ManagementObject mo in mos.Get())
                {

                    children.Add(Process.GetProcessById(Convert.ToInt32(mo["ProcessID"])));
                }
            }
            catch (Exception ex)
            {
                // nothing to do 
            }
            return children;
        }
    }
}
