namespace WinFormsApp1
{

    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            selected_priCB = new ComboBox();
            label1 = new Label();
            setButton = new Button();
            selectLB = new Label();
            selected_tb1 = new TextBox();
            selected_PriorityLB = new Label();
            selected_PriorityTB = new TextBox();
            label2 = new Label();
            current_PIDTB = new TextBox();
            reg_mkTB = new RichTextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cpupriclassLB = new Label();
            label6 = new Label();
            sk_statusLB = new Label();
            mk_statusLB = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            howToUseToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 409);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // selected_priCB
            // 
            selected_priCB.FormattingEnabled = true;
            selected_priCB.Items.AddRange(new object[] { "High", "Above Normal", "Normal", "Below Normal", "Idle" });
            selected_priCB.Location = new Point(14, 196);
            selected_priCB.Name = "selected_priCB";
            selected_priCB.Size = new Size(160, 23);
            selected_priCB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 178);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Select Priority:";
            label1.Click += label1_Click;
            // 
            // setButton
            // 
            setButton.Location = new Point(108, 225);
            setButton.Name = "setButton";
            setButton.Size = new Size(66, 23);
            setButton.TabIndex = 3;
            setButton.Text = "SET";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // selectLB
            // 
            selectLB.AutoSize = true;
            selectLB.Location = new Point(592, 31);
            selectLB.Name = "selectLB";
            selectLB.Size = new Size(89, 15);
            selectLB.TabIndex = 4;
            selectLB.Text = "Selected Name:";
            // 
            // selected_tb1
            // 
            selected_tb1.Location = new Point(592, 49);
            selected_tb1.Name = "selected_tb1";
            selected_tb1.ReadOnly = true;
            selected_tb1.Size = new Size(160, 23);
            selected_tb1.TabIndex = 5;
            // 
            // selected_PriorityLB
            // 
            selected_PriorityLB.AutoSize = true;
            selected_PriorityLB.Location = new Point(592, 127);
            selected_PriorityLB.Name = "selected_PriorityLB";
            selected_PriorityLB.Size = new Size(96, 15);
            selected_PriorityLB.TabIndex = 6;
            selected_PriorityLB.Text = "Running Priority:";
            selected_PriorityLB.Click += label2_Click;
            // 
            // selected_PriorityTB
            // 
            selected_PriorityTB.HideSelection = false;
            selected_PriorityTB.Location = new Point(592, 145);
            selected_PriorityTB.Name = "selected_PriorityTB";
            selected_PriorityTB.ReadOnly = true;
            selected_PriorityTB.Size = new Size(158, 23);
            selected_PriorityTB.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 83);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Selected PID:";
            // 
            // current_PIDTB
            // 
            current_PIDTB.Location = new Point(592, 101);
            current_PIDTB.Name = "current_PIDTB";
            current_PIDTB.ReadOnly = true;
            current_PIDTB.Size = new Size(160, 23);
            current_PIDTB.TabIndex = 9;
            // 
            // reg_mkTB
            // 
            reg_mkTB.Location = new Point(10, 22);
            reg_mkTB.Name = "reg_mkTB";
            reg_mkTB.Size = new Size(198, 73);
            reg_mkTB.TabIndex = 14;
            reg_mkTB.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(10, 97);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 15;
            label5.Text = "Main Key Status:";
            label5.Click += label5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cpupriclassLB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(sk_statusLB);
            groupBox1.Controls.Add(mk_statusLB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(reg_mkTB);
            groupBox1.Controls.Add(selected_priCB);
            groupBox1.Controls.Add(setButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(582, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 270);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registry Key:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cpupriclassLB
            // 
            cpupriclassLB.Anchor = AnchorStyles.Bottom;
            cpupriclassLB.AutoSize = true;
            cpupriclassLB.Location = new Point(120, 127);
            cpupriclassLB.Name = "cpupriclassLB";
            cpupriclassLB.Size = new Size(15, 15);
            cpupriclassLB.TabIndex = 23;
            cpupriclassLB.Text = "()";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(10, 127);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 22;
            label6.Text = "CPU Priority Class:";
            // 
            // sk_statusLB
            // 
            sk_statusLB.Anchor = AnchorStyles.Bottom;
            sk_statusLB.AutoSize = true;
            sk_statusLB.Location = new Point(120, 112);
            sk_statusLB.Name = "sk_statusLB";
            sk_statusLB.Size = new Size(15, 15);
            sk_statusLB.TabIndex = 21;
            sk_statusLB.Text = "()";
            // 
            // mk_statusLB
            // 
            mk_statusLB.Anchor = AnchorStyles.Bottom;
            mk_statusLB.AutoSize = true;
            mk_statusLB.Location = new Point(120, 97);
            mk_statusLB.Name = "mk_statusLB";
            mk_statusLB.Size = new Size(15, 15);
            mk_statusLB.TabIndex = 20;
            mk_statusLB.Text = "()";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(10, 112);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 20;
            label4.Text = "Sub Key Status:";
            label4.Click += label4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, refreshToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(813, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(58, 20);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, howToUseToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // howToUseToolStripMenuItem
            // 
            howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            howToUseToolStripMenuItem.Size = new Size(180, 22);
            howToUseToolStripMenuItem.Text = "How to use";
            howToUseToolStripMenuItem.Click += howToUseToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 455);
            Controls.Add(groupBox1);
            Controls.Add(current_PIDTB);
            Controls.Add(label2);
            Controls.Add(selected_PriorityTB);
            Controls.Add(selected_PriorityLB);
            Controls.Add(selected_tb1);
            Controls.Add(selectLB);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "CPU Priority Changer (CPUPC)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox selected_priCB;
        private Label label1;
        private Button setButton;
        private Label selectLB;
        private TextBox selected_tb1;
        private Label selected_PriorityLB;
        private TextBox selected_PriorityTB;
        private Label label2;
        private TextBox current_PIDTB;
        private RichTextBox reg_mkTB;
        private Label label5;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label sk_statusLB;
        private Label mk_statusLB;
        private Label label4;
        private Label label6;
        private Label cpupriclassLB;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem howToUseToolStripMenuItem;
    }
}
