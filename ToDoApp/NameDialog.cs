using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class NameDialog : Form
    {
        public string name { get; set;}
        public string date { get; set;}
        public NameDialog()
        {
            InitializeComponent();
        }

        private void SendName(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                this.name = tbName.Text;
                this.date = DateTime.Now.ToShortDateString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                tbName.BackColor = System.Drawing.Color.LightCoral;
            }
        }

        private void paintWhite(object sender, EventArgs e)
        {
            tbName.BackColor = System.Drawing.SystemColors.Window;
        }
    }
}
