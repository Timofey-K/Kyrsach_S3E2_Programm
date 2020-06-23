using Kyrsach_K3S2_V1.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsach_K3S2_V1
{
    public partial class Log : Form
    {
        private LogOperation logOperation;
        public Log()
        {
            InitializeComponent();

            logOperation = new LogOperation();
            var operation = new List<LogOperation>();
            logOperation.GetLog(operation);
            dgvLog.DataSource = operation;
        }
    }
}
