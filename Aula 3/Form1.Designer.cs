namespace Aula_3
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
            btnTrocar = new Button();
            pic_Carros_01 = new PictureBox();
            pic_Carros_02 = new PictureBox();
            rdb_Player1_E = new RadioButton();
            rdb_Player1_D = new RadioButton();
            rdb_Player1_C = new RadioButton();
            rdb_Player1_B = new RadioButton();
            rdb_Player1_A = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pic_Carros_01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Carros_02).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTrocar
            // 
            btnTrocar.Location = new Point(331, 225);
            btnTrocar.Name = "btnTrocar";
            btnTrocar.Size = new Size(91, 53);
            btnTrocar.TabIndex = 0;
            btnTrocar.Text = "SUPERNERD";
            btnTrocar.UseVisualStyleBackColor = true;
            btnTrocar.Click += btnTrocar_Click;
            // 
            // pic_Carros_01
            // 
            pic_Carros_01.Image = Properties.Resources.Fundo_Supernerd;
            pic_Carros_01.Location = new Point(12, 12);
            pic_Carros_01.Name = "pic_Carros_01";
            pic_Carros_01.Size = new Size(299, 479);
            pic_Carros_01.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Carros_01.TabIndex = 1;
            pic_Carros_01.TabStop = false;
            // 
            // pic_Carros_02
            // 
            pic_Carros_02.Image = Properties.Resources.Fundo_Supernerd;
            pic_Carros_02.Location = new Point(438, 12);
            pic_Carros_02.Name = "pic_Carros_02";
            pic_Carros_02.Size = new Size(299, 479);
            pic_Carros_02.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Carros_02.TabIndex = 2;
            pic_Carros_02.TabStop = false;
            // 
            // rdb_Player1_E
            // 
            rdb_Player1_E.AutoSize = true;
            rdb_Player1_E.Location = new Point(40, 145);
            rdb_Player1_E.Name = "rdb_Player1_E";
            rdb_Player1_E.Size = new Size(67, 19);
            rdb_Player1_E.TabIndex = 8;
            rdb_Player1_E.TabStop = true;
            rdb_Player1_E.Text = "opção E";
            rdb_Player1_E.UseVisualStyleBackColor = true;
            // 
            // rdb_Player1_D
            // 
            rdb_Player1_D.AutoSize = true;
            rdb_Player1_D.Location = new Point(40, 114);
            rdb_Player1_D.Name = "rdb_Player1_D";
            rdb_Player1_D.Size = new Size(69, 19);
            rdb_Player1_D.TabIndex = 7;
            rdb_Player1_D.TabStop = true;
            rdb_Player1_D.Text = "opção D";
            rdb_Player1_D.UseVisualStyleBackColor = true;
            // 
            // rdb_Player1_C
            // 
            rdb_Player1_C.AutoSize = true;
            rdb_Player1_C.Location = new Point(40, 81);
            rdb_Player1_C.Name = "rdb_Player1_C";
            rdb_Player1_C.Size = new Size(69, 19);
            rdb_Player1_C.TabIndex = 6;
            rdb_Player1_C.TabStop = true;
            rdb_Player1_C.Text = "opção C";
            rdb_Player1_C.UseVisualStyleBackColor = true;
            rdb_Player1_C.CheckedChanged += rdb_Player1_C_CheckedChanged;
            // 
            // rdb_Player1_B
            // 
            rdb_Player1_B.AutoSize = true;
            rdb_Player1_B.Location = new Point(40, 47);
            rdb_Player1_B.Name = "rdb_Player1_B";
            rdb_Player1_B.Size = new Size(68, 19);
            rdb_Player1_B.TabIndex = 5;
            rdb_Player1_B.TabStop = true;
            rdb_Player1_B.Text = "opção B";
            rdb_Player1_B.UseVisualStyleBackColor = true;
            // 
            // rdb_Player1_A
            // 
            rdb_Player1_A.AutoSize = true;
            rdb_Player1_A.Location = new Point(40, 14);
            rdb_Player1_A.Name = "rdb_Player1_A";
            rdb_Player1_A.Size = new Size(69, 19);
            rdb_Player1_A.TabIndex = 4;
            rdb_Player1_A.TabStop = true;
            rdb_Player1_A.Text = "opção A";
            rdb_Player1_A.UseVisualStyleBackColor = true;
            rdb_Player1_A.CheckedChanged += rdb_Player1_A_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.dados_Supernerd;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(rdb_Player1_A);
            groupBox1.Controls.Add(rdb_Player1_E);
            groupBox1.Controls.Add(rdb_Player1_B);
            groupBox1.Controls.Add(rdb_Player1_D);
            groupBox1.Controls.Add(rdb_Player1_C);
            groupBox1.Location = new Point(30, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 185);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.BackgroundImage = Properties.Resources.dados_Supernerd;
            groupBox2.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Location = new Point(457, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 185);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(40, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "opção A";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(40, 145);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "opção E";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(40, 47);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(68, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "opção B";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(40, 114);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(69, 19);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "opção D";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(40, 81);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(69, 19);
            radioButton5.TabIndex = 6;
            radioButton5.TabStop = true;
            radioButton5.Text = "opção C";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(749, 503);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pic_Carros_02);
            Controls.Add(btnTrocar);
            Controls.Add(pic_Carros_01);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Carros_01).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Carros_02).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTrocar;
        private PictureBox pic_Carros_01;
        private PictureBox pic_Carros_02;
        private RadioButton rdb_Player1_A;
        private RadioButton rdb_Player1_B;
        private RadioButton rdb_Player1_E;
        private RadioButton rdb_Player1_D;
        private RadioButton rdb_Player1_C;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
    }
}