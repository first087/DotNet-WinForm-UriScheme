using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UriSchemeWinApp {
    public partial class FrmDemo : Form {
        public FrmDemo() {
            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();

            foreach (var arg in args) {
                txtArgs.AppendText(arg + Environment.NewLine);
            }
        }
    }
}
