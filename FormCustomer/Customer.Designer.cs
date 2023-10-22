namespace FormCustomer
{
    partial class Customer
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
            idCustomer = new TextBox();
            nameCustomer = new TextBox();
            LastNameCustomer = new TextBox();
            PictureCustomer = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            ofCustomer = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)PictureCustomer).BeginInit();
            SuspendLayout();
            // 
            // idCustomer
            // 
            idCustomer.Enabled = false;
            idCustomer.Location = new Point(131, 91);
            idCustomer.Name = "idCustomer";
            idCustomer.Size = new Size(273, 27);
            idCustomer.TabIndex = 0;
            // 
            // nameCustomer
            // 
            nameCustomer.Location = new Point(131, 171);
            nameCustomer.Name = "nameCustomer";
            nameCustomer.Size = new Size(273, 27);
            nameCustomer.TabIndex = 1;
            // 
            // LastNameCustomer
            // 
            LastNameCustomer.Location = new Point(131, 256);
            LastNameCustomer.Name = "LastNameCustomer";
            LastNameCustomer.Size = new Size(273, 27);
            LastNameCustomer.TabIndex = 2;
            // 
            // PictureCustomer
            // 
            PictureCustomer.BorderStyle = BorderStyle.Fixed3D;
            PictureCustomer.Location = new Point(470, 91);
            PictureCustomer.Name = "PictureCustomer";
            PictureCustomer.Size = new Size(364, 212);
            PictureCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureCustomer.TabIndex = 3;
            PictureCustomer.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 98);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 178);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 263);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(470, 68);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Update Picture";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(146, 354);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(126, 47);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(544, 354);
            button2.Name = "button2";
            button2.Size = new Size(127, 47);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ofCustomer
            // 
            ofCustomer.FileName = "ofCustomer";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PictureCustomer);
            Controls.Add(LastNameCustomer);
            Controls.Add(nameCustomer);
            Controls.Add(idCustomer);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)PictureCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        public TextBox idCustomer;
        public TextBox nameCustomer;
        public TextBox LastNameCustomer;
        public PictureBox PictureCustomer;
        private OpenFileDialog ofCustomer;
    }
}