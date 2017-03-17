using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoUserControl;

namespace ToDoApp
{
    public partial class MainForm : Form
    {
        private string selectedColor;
        private Color ORANGE = Color.FromArgb(255, 152, 1);
        private Color BLUE = Color.FromArgb(28, 175, 249);
        private Color GREEN = Color.FromArgb(101, 219, 58);
        private Color PURPLE = Color.FromArgb(209, 105, 233);
        public MainForm()
        {
            InitializeComponent();
        }

        private void listSelection(object sender, EventArgs e)
        {
            String name = listBox1.GetItemText(listBox1.SelectedItem);
            lbListName.Text = name;
            lbListName.ForeColor = ORANGE;
            foreach(Control c in splitContainer1.Panel2.Controls)
            {
                if (c.GetType() == typeof(ToDoTable))
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
                splitContainer1.Panel2.Controls.Add(new ToDoTable() {Name = name,
                    Location = new Point(3, 41),
                    Size = new Size(600, 498) });
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnOrange":
                    selectedColor = "orange";
                    
                    lbListName.ForeColor = ORANGE;
                    break;
                case "btnGreen":
                    selectedColor = "green";
                    lbListName.ForeColor = GREEN;
                    break;
                case "btnBlue":
                    selectedColor = "blue";
                    lbListName.ForeColor = BLUE;
                    break;
                case "btnPurple":
                    selectedColor = "purple";
                    lbListName.ForeColor = PURPLE;
                    break;
            }
            recolor(selectedColor);
        }

        private void recolor(string color)
        {
            String name = listBox1.GetItemText(listBox1.SelectedItem);
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                if (c.GetType() == typeof(ToDoTable))
                {
                    if (c.Name.CompareTo(name) == 0)
                    {
                       ((ToDoTable)c).changeColor(color);
                    }
                }
            }
        }
    }
}
