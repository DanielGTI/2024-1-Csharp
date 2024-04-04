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
            pic_Carros = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_Carros).BeginInit();
            SuspendLayout();
            // 
            // btnTrocar
            // 
            btnTrocar.Location = new Point(205, 304);
            btnTrocar.Name = "btnTrocar";
            btnTrocar.Size = new Size(75, 23);
            btnTrocar.TabIndex = 0;
            btnTrocar.Text = "TROCAR";
            btnTrocar.UseVisualStyleBackColor = true;
            btnTrocar.Click += btnTrocar_Click;
            // 
            // pic_Carros
            // 
            pic_Carros.Image = Properties.Resources.ferrari_sf90_stradale;
            pic_Carros.Location = new Point(120, 41);
            pic_Carros.Name = "pic_Carros";
            pic_Carros.Size = new Size(237, 233);
            pic_Carros.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Carros.TabIndex = 1;
            pic_Carros.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 369);
            Controls.Add(pic_Carros);
            Controls.Add(btnTrocar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_Carros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTrocar;
        private PictureBox pic_Carros;
    }
}