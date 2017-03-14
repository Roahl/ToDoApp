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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listSelection(object sender, EventArgs e)
        {
            String name = listBox1.GetItemText(listBox1.SelectedItem);
            label1.Text = name;
            foreach(Control c in splitContainer1.Panel2.Controls)
            {
                if (c.GetType() == typeof(ToDoUserControl.ToDoTable))
                {
                    if (c.Name.CompareTo(name) == 0)
                    {
                        c.Visible = true;
                    }
                    else
                        c.Visible = false;
                }
            }
        }

        private void newToDoList(object sender, EventArgs e)
        {
            NameDialog nd = new NameDialog();
            var result = nd.ShowDialog();
            if(result == DialogResult.OK)
            {
                String name = nd.name + " - " + nd.date;
                listBox1.Items.Add(name);
                listBox1.SelectedIndex = listBox1.Items.Count-1;
                splitContainer1.Panel2.Controls.Add(new ToDoUserControl.ToDoTable() {Name = name,
                    Location = new System.Drawing.Point(3, 41),
                    Size = new System.Drawing.Size(600, 498) });
            }
        }
    }
}
