namespace ToDoApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.cmList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.todoListPanel = new System.Windows.Forms.Panel();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.lbListName = new System.Windows.Forms.Label();
            this.btnOrange = new System.Windows.Forms.Button();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.tsmiList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPurple = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.cmList.SuspendLayout();
            this.ts1.SuspendLayout();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            resources.ApplyResources(this.splitContainerMain, "splitContainerMain");
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            resources.ApplyResources(this.splitContainerMain.Panel1, "splitContainerMain.Panel1");
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel1.Controls.Add(this.btnAdd);
            this.splitContainerMain.Panel1.Controls.Add(this.listBox);
            this.tt.SetToolTip(this.splitContainerMain.Panel1, resources.GetString("splitContainerMain.Panel1.ToolTip"));
            // 
            // splitContainerMain.Panel2
            // 
            resources.ApplyResources(this.splitContainerMain.Panel2, "splitContainerMain.Panel2");
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel2.Controls.Add(this.todoListPanel);
            this.splitContainerMain.Panel2.Controls.Add(this.btnPurple);
            this.splitContainerMain.Panel2.Controls.Add(this.btnGreen);
            this.splitContainerMain.Panel2.Controls.Add(this.btnBlue);
            this.splitContainerMain.Panel2.Controls.Add(this.lbListName);
            this.splitContainerMain.Panel2.Controls.Add(this.btnOrange);
            this.tt.SetToolTip(this.splitContainerMain.Panel2, resources.GetString("splitContainerMain.Panel2.ToolTip"));
            this.tt.SetToolTip(this.splitContainerMain, resources.GetString("splitContainerMain.ToolTip"));
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Image = global::ToDoApp.Properties.Resources.add;
            this.btnAdd.Name = "btnAdd";
            this.tt.SetToolTip(this.btnAdd, resources.GetString("btnAdd.ToolTip"));
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.newToDoList);
            // 
            // listBox
            // 
            resources.ApplyResources(this.listBox, "listBox");
            this.listBox.BackColor = System.Drawing.SystemColors.Control;
            this.listBox.ContextMenuStrip = this.cmList;
            this.listBox.FormattingEnabled = true;
            this.listBox.Name = "listBox";
            this.tt.SetToolTip(this.listBox, resources.GetString("listBox.ToolTip"));
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listSelection);
            // 
            // cmList
            // 
            resources.ApplyResources(this.cmList, "cmList");
            this.cmList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctsmiDelete});
            this.cmList.Name = "cmList";
            this.tt.SetToolTip(this.cmList, resources.GetString("cmList.ToolTip"));
            // 
            // ctsmiDelete
            // 
            resources.ApplyResources(this.ctsmiDelete, "ctsmiDelete");
            this.ctsmiDelete.Image = global::ToDoApp.Properties.Resources.DeleteKPI_16x;
            this.ctsmiDelete.Name = "ctsmiDelete";
            this.ctsmiDelete.Click += new System.EventHandler(this.deleteToDoList);
            // 
            // todoListPanel
            // 
            resources.ApplyResources(this.todoListPanel, "todoListPanel");
            this.todoListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.todoListPanel.Name = "todoListPanel";
            this.tt.SetToolTip(this.todoListPanel, resources.GetString("todoListPanel.ToolTip"));
            // 
            // btnPurple
            // 
            resources.ApplyResources(this.btnPurple, "btnPurple");
            this.btnPurple.FlatAppearance.BorderSize = 0;
            this.btnPurple.ForeColor = System.Drawing.Color.White;
            this.btnPurple.Image = global::ToDoApp.Properties.Resources.purple;
            this.btnPurple.Name = "btnPurple";
            this.tt.SetToolTip(this.btnPurple, resources.GetString("btnPurple.ToolTip"));
            this.btnPurple.UseVisualStyleBackColor = true;
            this.btnPurple.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            resources.ApplyResources(this.btnGreen, "btnGreen");
            this.btnGreen.FlatAppearance.BorderSize = 0;
            this.btnGreen.Image = global::ToDoApp.Properties.Resources.green;
            this.btnGreen.Name = "btnGreen";
            this.tt.SetToolTip(this.btnGreen, resources.GetString("btnGreen.ToolTip"));
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            resources.ApplyResources(this.btnBlue, "btnBlue");
            this.btnBlue.FlatAppearance.BorderSize = 0;
            this.btnBlue.Image = global::ToDoApp.Properties.Resources.blue;
            this.btnBlue.Name = "btnBlue";
            this.tt.SetToolTip(this.btnBlue, resources.GetString("btnBlue.ToolTip"));
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lbListName
            // 
            resources.ApplyResources(this.lbListName, "lbListName");
            this.lbListName.Name = "lbListName";
            this.tt.SetToolTip(this.lbListName, resources.GetString("lbListName.ToolTip"));
            // 
            // btnOrange
            // 
            resources.ApplyResources(this.btnOrange, "btnOrange");
            this.btnOrange.FlatAppearance.BorderSize = 0;
            this.btnOrange.Image = global::ToDoApp.Properties.Resources.orange1;
            this.btnOrange.Name = "btnOrange";
            this.tt.SetToolTip(this.btnOrange, resources.GetString("btnOrange.ToolTip"));
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // ts1
            // 
            resources.ApplyResources(this.ts1, "ts1");
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbDelete});
            this.ts1.Name = "ts1";
            this.tt.SetToolTip(this.ts1, resources.GetString("ts1.ToolTip"));
            // 
            // tsbNew
            // 
            resources.ApplyResources(this.tsbNew, "tsbNew");
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::ToDoApp.Properties.Resources.NewItem_16x;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Click += new System.EventHandler(this.newToDoList);
            // 
            // tsbDelete
            // 
            resources.ApplyResources(this.tsbDelete, "tsbDelete");
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::ToDoApp.Properties.Resources.DeleteKPI_16x;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Click += new System.EventHandler(this.deleteToDoList);
            // 
            // ms1
            // 
            resources.ApplyResources(this.ms1, "ms1");
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiList,
            this.tsmiColor,
            this.tsmiLanguage});
            this.ms1.Name = "ms1";
            this.tt.SetToolTip(this.ms1, resources.GetString("ms1.ToolTip"));
            // 
            // tsmiList
            // 
            resources.ApplyResources(this.tsmiList, "tsmiList");
            this.tsmiList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiDelete});
            this.tsmiList.Name = "tsmiList";
            // 
            // tsmiNew
            // 
            resources.ApplyResources(this.tsmiNew, "tsmiNew");
            this.tsmiNew.Image = global::ToDoApp.Properties.Resources.NewItem_16x;
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Click += new System.EventHandler(this.newToDoList);
            // 
            // tsmiDelete
            // 
            resources.ApplyResources(this.tsmiDelete, "tsmiDelete");
            this.tsmiDelete.Image = global::ToDoApp.Properties.Resources.DeleteKPI_16x;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Click += new System.EventHandler(this.deleteToDoList);
            // 
            // tsmiColor
            // 
            resources.ApplyResources(this.tsmiColor, "tsmiColor");
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrange,
            this.tsmiBlue,
            this.tsmiGreen,
            this.tsmiPurple});
            this.tsmiColor.Name = "tsmiColor";
            // 
            // tsmiOrange
            // 
            resources.ApplyResources(this.tsmiOrange, "tsmiOrange");
            this.tsmiOrange.Image = global::ToDoApp.Properties.Resources.orange1;
            this.tsmiOrange.Name = "tsmiOrange";
            this.tsmiOrange.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiBlue
            // 
            resources.ApplyResources(this.tsmiBlue, "tsmiBlue");
            this.tsmiBlue.Image = global::ToDoApp.Properties.Resources.blue;
            this.tsmiBlue.Name = "tsmiBlue";
            this.tsmiBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiGreen
            // 
            resources.ApplyResources(this.tsmiGreen, "tsmiGreen");
            this.tsmiGreen.Image = global::ToDoApp.Properties.Resources.green;
            this.tsmiGreen.Name = "tsmiGreen";
            this.tsmiGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiPurple
            // 
            resources.ApplyResources(this.tsmiPurple, "tsmiPurple");
            this.tsmiPurple.Image = global::ToDoApp.Properties.Resources.purple;
            this.tsmiPurple.Name = "tsmiPurple";
            this.tsmiPurple.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiLanguage
            // 
            resources.ApplyResources(this.tsmiLanguage, "tsmiLanguage");
            this.tsmiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpanish,
            this.tsmiEnglish});
            this.tsmiLanguage.Name = "tsmiLanguage";
            // 
            // tsmiSpanish
            // 
            resources.ApplyResources(this.tsmiSpanish, "tsmiSpanish");
            this.tsmiSpanish.Image = global::ToDoApp.Properties.Resources.ES;
            this.tsmiSpanish.Name = "tsmiSpanish";
            this.tsmiSpanish.Click += new System.EventHandler(this.tsmiSpanish_Click);
            // 
            // tsmiEnglish
            // 
            resources.ApplyResources(this.tsmiEnglish, "tsmiEnglish");
            this.tsmiEnglish.Image = global::ToDoApp.Properties.Resources.GB;
            this.tsmiEnglish.Name = "tsmiEnglish";
            this.tsmiEnglish.Click += new System.EventHandler(this.tsmiEnglish_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ts1);
            this.Controls.Add(this.ms1);
            this.Controls.Add(this.splitContainerMain);
            this.MainMenuStrip = this.ms1;
            this.Name = "MainForm";
            this.tt.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.cmList.ResumeLayout(false);
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbListName;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem tsmiList;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrange;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlue;
        private System.Windows.Forms.ToolStripMenuItem tsmiGreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiPurple;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpanish;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnglish;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ContextMenuStrip cmList;
        private System.Windows.Forms.ToolStripMenuItem ctsmiDelete;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Panel todoListPanel;
    }
}

