using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace madFurry
{
    public static class DataGridViewHelper
    {
        public static List<string> GetColumnsAsList(this DataGridView dgv, string columnName)
        {
            var result = new List<string>();
            if (dgv.InvokeRequired)
            {
                dgv.Invoke(new Action(() =>
                {
                    result = dgv.Rows.Cast<DataGridViewRow>().Where(r => !String.IsNullOrEmpty(r.Cells[columnName].Value.ToString())).Select(r=>r.Cells[columnName].Value.ToString()).ToList();
                }));
            }
            else
            {
                result = dgv.Rows.Cast<DataGridViewRow>().Where(r => !String.IsNullOrEmpty(r.Cells[columnName].Value.ToString())).Select(r => r.Cells[columnName].Value.ToString()).ToList();
            }
            return result;
        }
        public static DataGridViewRow GetRowByColumnValue(this DataGridView dgv, string ColumnName, object ColumnValue)
        {
            return dgv.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[ColumnName].Value.Equals(ColumnValue)).FirstOrDefault();
        }

        public static void SetRowCellByColumnValue(this DataGridView dgv, DataGridViewRow row, string ColumnName, object ColumnValue)
        {
            if (row != null)
            {
                if (dgv.InvokeRequired)
                {
                    dgv.Invoke(new Action(() =>
                    {
                        dgv.Rows[row.Index].Cells[ColumnName].Value = ColumnValue;
                        dgv.Refresh();
                    }));
                } else
                {
                    dgv.Rows[row.Index].Cells[ColumnName].Value = ColumnValue;
                    dgv.Refresh();
                }
            }
        }

        public static void RemoveRowByColumnValue(this DataGridView dgv, string ColumnName, object ColumnValue)
        {
            var row = dgv.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[ColumnName].Value.Equals(ColumnValue)).FirstOrDefault();
            if (row != null)
            {
                if (dgv.InvokeRequired)
                {
                    dgv.Invoke(new Action(() =>
                    {
                        dgv.Rows.Remove(row);
                        dgv.Refresh();
                    }));
                } else
                {
                    dgv.Rows.Remove(row);
                    dgv.Refresh();
                }
            }
        }

        public static void DisableButtonByColumnValue(this DataGridView dgv, string ColumnName, string ColumnValue, string buttonColumnName )
        {
            var row = GetRowByColumnValue(dgv, ColumnName, ColumnValue);
            if (row != null)
            {
                if (dgv.InvokeRequired)
                {
                    dgv.Invoke(new Action(() =>
                    {
                        var t = new DataGridViewTextBoxCell() { Value = String.Empty };
                        row.Cells[buttonColumnName] = t;
                        dgv.Refresh();
                    }));
                } else
                {
                    var t = new DataGridViewTextBoxCell() { Value = String.Empty };
                    row.Cells[buttonColumnName] = t;
                    dgv.Refresh();
                }
                
            }
        }
    }
}
