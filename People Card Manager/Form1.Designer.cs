using System.Xml;

namespace test
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
            ID = new Label();
            NameLabel = new Label();
            Address = new Label();
            IDtextBox = new TextBox();
            NametextBox = new TextBox();
            AddresstextBox = new TextBox();
            AddNew = new Button();
            Find = new Button();
            ShowAll = new Button();
            Exit = new Button();
            toolTip1 = new ToolTip(components);
            SelectPicture = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Coral;
            ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ID.Location = new Point(83, 40);
            ID.Name = "ID";
            ID.Size = new Size(33, 28);
            ID.TabIndex = 0;
            ID.Text = "ID";
            ID.Click += ID_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Coral;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NameLabel.Location = new Point(83, 125);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(68, 28);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Coral;
            Address.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Address.Location = new Point(83, 219);
            Address.Name = "Address";
            Address.Size = new Size(87, 28);
            Address.TabIndex = 2;
            Address.Text = "Address";
            // 
            // IDtextBox
            // 
            IDtextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IDtextBox.Location = new Point(238, 40);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(280, 34);
            IDtextBox.TabIndex = 3;
            IDtextBox.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(IDtextBox, "Enter Person ID");
            // 
            // NametextBox
            // 
            NametextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NametextBox.Location = new Point(238, 122);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(280, 34);
            NametextBox.TabIndex = 4;
            NametextBox.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(NametextBox, "Enter Person Name");
            // 
            // AddresstextBox
            // 
            AddresstextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AddresstextBox.Location = new Point(238, 219);
            AddresstextBox.Name = "AddresstextBox";
            AddresstextBox.Size = new Size(280, 34);
            AddresstextBox.TabIndex = 5;
            AddresstextBox.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(AddresstextBox, "Enter Person Address");
            // 
            // AddNew
            // 
            AddNew.BackColor = SystemColors.MenuHighlight;
            AddNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AddNew.Location = new Point(102, 345);
            AddNew.Name = "AddNew";
            AddNew.Size = new Size(111, 43);
            AddNew.TabIndex = 6;
            AddNew.Text = "Add New";
            AddNew.UseVisualStyleBackColor = false;
            AddNew.Click += AddNew_Click;
            // 
            // Find
            // 
            Find.BackColor = SystemColors.Highlight;
            Find.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Find.Location = new Point(309, 345);
            Find.Name = "Find";
            Find.Size = new Size(111, 43);
            Find.TabIndex = 7;
            Find.Text = "Find";
            Find.UseVisualStyleBackColor = false;
            Find.Click += Find_Click;
            // 
            // ShowAll
            // 
            ShowAll.BackColor = SystemColors.Highlight;
            ShowAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ShowAll.Location = new Point(488, 345);
            ShowAll.Name = "ShowAll";
            ShowAll.Size = new Size(111, 43);
            ShowAll.TabIndex = 8;
            ShowAll.Text = "Show All";
            toolTip1.SetToolTip(ShowAll, "Show all Peaople");
            ShowAll.UseVisualStyleBackColor = false;
            ShowAll.Click += ShowAll_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.IndianRed;
            Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Exit.Location = new Point(708, 429);
            Exit.Name = "Exit";
            Exit.Size = new Size(111, 43);
            Exit.TabIndex = 9;
            Exit.Text = "Exit";
            toolTip1.SetToolTip(Exit, "Exit Program");
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.Popup += toolTip1_Popup;
            // 
            // SelectPicture
            // 
            SelectPicture.BackColor = Color.Lime;
            SelectPicture.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectPicture.Location = new Point(613, 284);
            SelectPicture.Name = "SelectPicture";
            SelectPicture.Size = new Size(180, 49);
            SelectPicture.TabIndex = 11;
            SelectPicture.Text = "Select Picture";
            toolTip1.SetToolTip(SelectPicture, "Select a Picture of the Person if you like");
            SelectPicture.UseVisualStyleBackColor = false;
            SelectPicture.Click += SelectPicture_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(613, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 474);
            label1.Name = "label1";
            label1.Size = new Size(227, 28);
            label1.TabIndex = 12;
            label1.Text = "Author: Saeed Soukiah";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(840, 511);
            Controls.Add(label1);
            Controls.Add(SelectPicture);
            Controls.Add(pictureBox1);
            Controls.Add(Exit);
            Controls.Add(ShowAll);
            Controls.Add(Find);
            Controls.Add(AddNew);
            Controls.Add(AddresstextBox);
            Controls.Add(NametextBox);
            Controls.Add(IDtextBox);
            Controls.Add(Address);
            Controls.Add(NameLabel);
            Controls.Add(ID);
            Cursor = Cursors.Hand;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Logger";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label NameLabel;
        private Label Address;
        private TextBox IDtextBox;
        private TextBox NametextBox;
        private TextBox AddresstextBox;
        private Button AddNew;
        private Button Find;
        private Button ShowAll;
        private Button Exit;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Button SelectPicture;
        private Label label1;
    }
}
