namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblsoruno = new Label();
            lbldogru = new Label();
            lblyanlis = new Label();
            btnsonraki = new Button();
            richTextBox1 = new RichTextBox();
            btna = new Button();
            btnb = new Button();
            btnc = new Button();
            btnd = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            btndogru = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(149, 27);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 39);
            label1.TabIndex = 0;
            label1.Text = "BİLGİ YARIŞMASI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(669, 33);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 33);
            label2.TabIndex = 1;
            label2.Text = "SORU NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 74);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 33);
            label3.TabIndex = 2;
            label3.Text = "DOĞRU:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(701, 119);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 33);
            label4.TabIndex = 3;
            label4.Text = "YANLIŞ:";
            // 
            // lblsoruno
            // 
            lblsoruno.AutoSize = true;
            lblsoruno.Location = new Point(823, 33);
            lblsoruno.Margin = new Padding(6, 0, 6, 0);
            lblsoruno.Name = "lblsoruno";
            lblsoruno.Size = new Size(58, 33);
            lblsoruno.TabIndex = 4;
            lblsoruno.Text = "00 ";
            // 
            // lbldogru
            // 
            lbldogru.AutoSize = true;
            lbldogru.Location = new Point(823, 75);
            lbldogru.Margin = new Padding(6, 0, 6, 0);
            lbldogru.Name = "lbldogru";
            lbldogru.Size = new Size(49, 33);
            lbldogru.TabIndex = 5;
            lbldogru.Text = "00";
            // 
            // lblyanlis
            // 
            lblyanlis.AutoSize = true;
            lblyanlis.Location = new Point(823, 119);
            lblyanlis.Margin = new Padding(6, 0, 6, 0);
            lblyanlis.Name = "lblyanlis";
            lblyanlis.Size = new Size(49, 33);
            lblyanlis.TabIndex = 6;
            lblyanlis.Text = "00";
            // 
            // btnsonraki
            // 
            btnsonraki.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnsonraki.Location = new Point(649, 164);
            btnsonraki.Name = "btnsonraki";
            btnsonraki.Size = new Size(279, 66);
            btnsonraki.TabIndex = 7;
            btnsonraki.Text = "SONRAKİ SORU";
            btnsonraki.UseVisualStyleBackColor = true;
            btnsonraki.Click += btnsonraki_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightGray;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(27, 91);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(564, 369);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // btna
            // 
            btna.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btna.Location = new Point(85, 191);
            btna.Name = "btna";
            btna.Size = new Size(178, 116);
            btna.TabIndex = 9;
            btna.Text = "A";
            btna.UseVisualStyleBackColor = true;
            btna.Click += btna_Click;
            // 
            // btnb
            // 
            btnb.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnb.Location = new Point(316, 191);
            btnb.Name = "btnb";
            btnb.Size = new Size(178, 116);
            btnb.TabIndex = 10;
            btnb.Text = "B";
            btnb.UseVisualStyleBackColor = true;
            btnb.Click += btnb_Click;
            // 
            // btnc
            // 
            btnc.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnc.Location = new Point(85, 328);
            btnc.Name = "btnc";
            btnc.Size = new Size(178, 116);
            btnc.TabIndex = 11;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // btnd
            // 
            btnd.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnd.Location = new Point(316, 328);
            btnd.Name = "btnd";
            btnd.Size = new Size(178, 116);
            btnd.TabIndex = 12;
            btnd.Text = "D";
            btnd.UseVisualStyleBackColor = true;
            btnd.Click += btnd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(669, 288);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(669, 288);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 172);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PeachPuff;
            label5.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(324, 473);
            label5.Name = "label5";
            label5.Size = new Size(95, 34);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(777, 494);
            label6.Name = "label6";
            label6.Size = new Size(95, 33);
            label6.TabIndex = 16;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // btndogru
            // 
            btndogru.BackColor = Color.PaleGreen;
            btndogru.Location = new Point(27, 466);
            btndogru.Name = "btndogru";
            btndogru.Size = new Size(291, 45);
            btndogru.TabIndex = 17;
            btndogru.Text = "DOĞRU CEVAP:";
            btndogru.UseVisualStyleBackColor = false;
            btndogru.Visible = false;
            btndogru.Click += btndogru_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1700, 721);
            Controls.Add(btndogru);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnd);
            Controls.Add(btnc);
            Controls.Add(btnb);
            Controls.Add(btna);
            Controls.Add(richTextBox1);
            Controls.Add(btnsonraki);
            Controls.Add(lblyanlis);
            Controls.Add(lbldogru);
            Controls.Add(lblsoruno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bookman Old Style", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "BİLGİ YARIŞMASI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblsoruno;
        private Label lbldogru;
        private Label lblyanlis;
        private Button btnsonraki;
        private RichTextBox richTextBox1;
        private Button btna;
        private Button btnb;
        private Button btnc;
        private Button btnd;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Button btndogru;
    }
}
