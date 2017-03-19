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
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel1.Controls.Add(this.btnAdd);
            this.splitContainerMain.Panel1.Controls.Add(this.listBox);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel2.Controls.Add(this.todoListPanel);
            this.splitContainerMain.Panel2.Controls.Add(this.btnPurple);
            this.splitContainerMain.Panel2.Controls.Add(this.btnGreen);
            this.splitContainerMain.Panel2.Controls.Add(this.btnBlue);
            this.splitContainerMain.Panel2.Controls.Add(this.lbListName);
            this.splitContainerMain.Panel2.Controls.Add(this.btnOrange);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAdd, "btnAdd");
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
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listSelection);
            // 
            // cmList
            // 
            this.cmList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctsmiDelete});
            this.cmList.Name = "cmList";
            resources.ApplyResources(this.cmList, "cmList");
            // 
            // ctsmiDelete
            // 
            this.ctsmiDelete.Image = global::ToDoApp.Properties.Resources.DeleteKPI_16x;
            this.ctsmiDelete.Name = "ctsmiDelete";
            resources.ApplyResources(this.ctsmiDelete, "ctsmiDelete");
            this.ctsmiDelete.Click += new System.EventHandler(this.deleteToDoList);
            // 
            // todoListPanel
            // 
            resources.ApplyResources(this.todoListPanel, "todoListPanel");
            this.todoListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.todoListPanel.Name = "todoListPanel";
            // 
            // btnPurple
            // 
            this.btnPurple.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPurple, "btnPurple");
            this.btnPurple.ForeColor = System.Drawing.Color.White;
            this.btnPurple.Image = global::ToDoApp.Properties.Resources.purple;
            this.btnPurple.Name = "btnPurple";
            this.tt.SetToolTip(this.btnPurple, resources.GetString("btnPurple.ToolTip"));
            this.btnPurple.UseVisualStyleBackColor = true;
            this.btnPurple.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnGreen, "btnGreen");
            this.btnGreen.Image = global::ToDoApp.Properties.Resources.green;
            this.btnGreen.Name = "btnGreen";
            this.tt.SetToolTip(this.btnGreen, resources.GetString("btnGreen.ToolTip"));
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnBlue, "btnBlue");
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
            // 
            // btnOrange
            // 
            this.btnOrange.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnOrange, "btnOrange");
            this.btnOrange.Image = global::ToDoApp.Properties.Resources.orange1;
            this.btnOrange.Name = "btnOrange";
            this.tt.SetToolTip(this.btnOrange, resources.GetString("btnOrange.ToolTip"));
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // ts1
            // 
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbDelete});
            resources.ApplyResources(this.ts1, "ts1");
            this.ts1.Name = "ts1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::ToDoApp.Properties.Resources.NewItem_16x;
            resources.ApplyResources(this.tsbNew, "tsbNew");
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Click += new System.EventHandler(this.newToDoList);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::ToDoApp.Properties.Resources.DeleteKPI_16x;
            resources.ApplyResources(this.tsbDelete, "tsbDelete");
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Click += new System.EventHandler(this.deleteToDoList);
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiList,
            this.tsmiColor,
            this.tsmiLanguage});
            resources.ApplyResources(this.ms1, "ms1");
            this.ms1.Name = "ms1";
            // 
            // tsmiList
            // 
            this.tsmiList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiDelete});
            this.tsmiList.Name = "tsmiList";
            resources.ApplyResources(this.tsmiList, "tsmiList");
            // 
            // tsmiNew
            // 
            this.tsmiNew.Image = global::ToDoApp.Properties.Resources.NewItem_16x;
            this.tsmiNew.Name = "tsmiNew";
            resources.ApplyResources(this.tsmiNew, "tsmiNew");
            this.tsmiNew.Click += new System.EventHandler(this.newToDoList);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::ToDoApp.Properties.Resources.DeleteKPI_16x;
            this.tsmiDelete.Name = "tsmiDelete";
            resources.ApplyResources(this.tsmiDelete, "tsmiDelete");
            this.tsmiDelete.Click += new System.EventHandler(this.deleteToDoList);
            // 
            // tsmiColor
            // 
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrange,
            this.tsmiBlue,
            this.tsmiGreen,
            this.tsmiPurple});
            this.tsmiColor.Name = "tsmiColor";
            resources.ApplyResources(this.tsmiColor, "tsmiColor");
            // 
            // tsmiOrange
            // 
            this.tsmiOrange.Image = global::ToDoApp.Properties.Resources.orange1;
            this.tsmiOrange.Name = "tsmiOrange";
            resources.ApplyResources(this.tsmiOrange, "tsmiOrange");
            this.tsmiOrange.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiBlue
            // 
            this.tsmiBlue.Image = global::ToDoApp.Properties.Resources.blue;
            this.tsmiBlue.Name = "tsmiBlue";
            resources.ApplyResources(this.tsmiBlue, "tsmiBlue");
            this.tsmiBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiGreen
            // 
            this.tsmiGreen.Image = global::ToDoApp.Properties.Resources.green;
            this.tsmiGreen.Name = "tsmiGreen";
            resources.ApplyResources(this.tsmiGreen, "tsmiGreen");
            this.tsmiGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiPurple
            // 
            this.tsmiPurple.Image = global::ToDoApp.Properties.Resources.purple;
            this.tsmiPurple.Name = "tsmiPurple";
            resources.ApplyResources(this.tsmiPurple, "tsmiPurple");
            this.tsmiPurple.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsmiLanguage
            // 
            this.tsmiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSpanish,
            this.tsmiEnglish});
            this.tsmiLanguage.Name = "tsmiLanguage";
            resources.ApplyResources(this.tsmiLanguage, "tsmiLanguage");
            // 
            // tsmiSpanish
            // 
            this.tsmiSpanish.Image = global::ToDoApp.Properties.Resources.ES;
            this.tsmiSpanish.Name = "tsmiSpanish";
            resources.ApplyResources(this.tsmiSpanish, "tsmiSpanish");
            // 
            // tsmiEnglish
            // 
            this.tsmiEnglish.Image = global::ToDoApp.Properties.Resources.GB;
            this.tsmiEnglish.Name = "tsmiEnglish";
            resources.ApplyResources(this.tsmiEnglish, "tsmiEnglish");
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

