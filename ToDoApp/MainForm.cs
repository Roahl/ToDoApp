﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoUserControl;

namespace ToDoApp
{
    /// <summary>
    /// Main form of the project
    /// </summary>
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

        /// <summary>
        /// Method called when selecting an item from the listbox
        /// </summary>
        /// <param name="sender">the object that creates the event</param>
        /// <param name="e">parameters of the event</param>
        private void listSelection(object sender, EventArgs e)
        {
            String name = listBox.GetItemText(listBox.SelectedItem);
            lbListName.Text = name; 
            foreach (Control c in splitContainerMain.Panel2.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    foreach (Control cc in c.Controls)
                    {
                        if (cc.GetType() == typeof(ToDoTable))
                        {
                            string color = ((ToDoTable)cc).returnColor();
                            if (cc.Name.CompareTo(name) == 0)
                            {

                                recolor(color);
                                cc.Visible = true;
                            }
                            else
                                cc.Visible = false;
                        }
                    }
                }
            }            
        }
        /// <summary>
        /// Method called when clicked "new list" button either on toolbar, button
        /// or menu item
        /// </summary>
        /// <param name="sender">the object that creates the event</param>
        /// <param name="e">parameters of the event</param>
        private void newToDoList(object sender, EventArgs e)
        {
            NameDialog nd = new NameDialog();
            var result = nd.ShowDialog();
            if(result == DialogResult.OK)
            {
                String name = nd.name + " - " + nd.date;
                listBox.Items.Add(name);
                listBox.SelectedIndex = listBox.Items.Count-1;
                todoListPanel.Controls.Add(new ToDoTable() { Name = name,
                    Size = new Size(606, 503),
                    Location = new Point(0,0),
                    Dock = DockStyle.Fill });
            }
        }
        /// <summary>
        /// Method called by any of the buttons that changes color
        /// </summary>
        /// <param name="sender">the object that creates the event</param>
        /// <param name="e">parameters of the event</param>
        private void btnColor_Click(object sender, EventArgs e)
        {
            try
            {
                switch (((Button)sender).Name)
                {
                    case "btnOrange":
                        selectedColor = "orange";
                        break;
                    case "btnGreen":
                        selectedColor = "green";
                        break;
                    case "btnBlue":
                        selectedColor = "blue";
                        break;
                    case "btnPurple":
                        selectedColor = "purple";
                        break;
                }
            }
            catch
            {
                switch (((ToolStripMenuItem)sender).Name)
                {
                    case "tsmiOrange":
                        selectedColor = "orange";
                        break;
                    case "tsmiGreen":
                        selectedColor = "green";
                        break;
                    case "tsmiBlue":
                        selectedColor = "blue";
                        break;
                    case "tsmiPurple":
                        selectedColor = "purple";
                        break;
                }
            }
            recolor(selectedColor);
        }
        /// <summary>
        /// method called to recolor the user control and every text box in it
        /// </summary>
        /// <param name="color">string containing the color</param>
        private void recolor(string color)
        {
            String name = listBox.GetItemText(listBox.SelectedItem);
            foreach (Control c in splitContainerMain.Panel2.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    foreach (Control cc in c.Controls)
                    {
                        if (cc.GetType() == typeof(ToDoTable))
                        {
                            if (cc.Name.CompareTo(name) == 0)
                            {
                                ((ToDoTable)cc).changeColor(color);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method called by any delete button to remove the selected list
        /// </summary>
        /// <param name="sender">the object that creates the event</param>
        /// <param name="e">event arguments</param>
        private void deleteToDoList(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        /// <summary>
        /// Changes language to english
        /// </summary>
        /// <param name="sender">the object that creates the event</param>
        /// <param name="e">event arguments</param>
        private void tsmiEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Controls.Clear();
            InitializeComponent();
        }
        /// <summary>
        /// Changes language to default
        /// </summary>
        /// <param name="sender">the object that creates the event</param>
        /// <param name="e">event arguments</param>
        private void tsmiSpanish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            Controls.Clear();
            InitializeComponent();
        }
    }
}
