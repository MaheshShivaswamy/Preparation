using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperLibrary;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadConfigKeyValue_Click(object sender, EventArgs e)
        {
            txtStatus.Text = ConfigurationManager.AppSettings[cmbSelectConfigKey.Text];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            int result = helper.AddNumbers(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtStatus.Text = result.ToString();
        }
    }
}
