namespace Aula_2
{
    partial class frmCalculadora
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
            btn_Porcentagem = new Button();
            btn_LimparVisor = new Button();
            btn_LimparCalculo = new Button();
            btn_Voltar = new Button();
            btn_Dividir = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_Multiplicar = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_Subtrair = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_Somar = new Button();
            btn_Calcular = new Button();
            btn_0 = new Button();
            btn_Virgula = new Button();
            txt_Visor = new TextBox();
            SuspendLayout();
            // 
            // btn_Porcentagem
            // 
            btn_Porcentagem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Porcentagem.Location = new Point(20, 80);
            btn_Porcentagem.Name = "btn_Porcentagem";
            btn_Porcentagem.Size = new Size(40, 40);
            btn_Porcentagem.TabIndex = 0;
            btn_Porcentagem.Text = "%";
            btn_Porcentagem.UseVisualStyleBackColor = true;
            // 
            // btn_LimparVisor
            // 
            btn_LimparVisor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LimparVisor.Location = new Point(65, 80);
            btn_LimparVisor.Name = "btn_LimparVisor";
            btn_LimparVisor.Size = new Size(40, 40);
            btn_LimparVisor.TabIndex = 1;
            btn_LimparVisor.Text = "CE";
            btn_LimparVisor.UseVisualStyleBackColor = true;
            btn_LimparVisor.Click += btn_LimparVisor_Click;
            // 
            // btn_LimparCalculo
            // 
            btn_LimparCalculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LimparCalculo.Location = new Point(110, 80);
            btn_LimparCalculo.Name = "btn_LimparCalculo";
            btn_LimparCalculo.Size = new Size(40, 40);
            btn_LimparCalculo.TabIndex = 2;
            btn_LimparCalculo.Text = "C";
            btn_LimparCalculo.UseVisualStyleBackColor = true;
            btn_LimparCalculo.Click += btn_LimparCalculo_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(155, 80);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(40, 40);
            btn_Voltar.TabIndex = 3;
            btn_Voltar.Text = "<-";
            btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // btn_Dividir
            // 
            btn_Dividir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Dividir.Location = new Point(155, 125);
            btn_Dividir.Name = "btn_Dividir";
            btn_Dividir.Size = new Size(40, 40);
            btn_Dividir.TabIndex = 7;
            btn_Dividir.Text = "/";
            btn_Dividir.UseVisualStyleBackColor = true;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.Location = new Point(110, 125);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(40, 40);
            btn_9.TabIndex = 6;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.Location = new Point(65, 125);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(40, 40);
            btn_8.TabIndex = 5;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.Location = new Point(20, 125);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(40, 40);
            btn_7.TabIndex = 4;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_Multiplicar
            // 
            btn_Multiplicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Multiplicar.Location = new Point(155, 170);
            btn_Multiplicar.Name = "btn_Multiplicar";
            btn_Multiplicar.Size = new Size(40, 40);
            btn_Multiplicar.TabIndex = 11;
            btn_Multiplicar.Text = "*";
            btn_Multiplicar.UseVisualStyleBackColor = true;
            btn_Multiplicar.Click += btn_Multiplicar_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.Location = new Point(110, 170);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(40, 40);
            btn_6.TabIndex = 10;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.Location = new Point(65, 170);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(40, 40);
            btn_5.TabIndex = 9;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.Location = new Point(20, 170);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(40, 40);
            btn_4.TabIndex = 8;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_Subtrair
            // 
            btn_Subtrair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Subtrair.Location = new Point(155, 215);
            btn_Subtrair.Name = "btn_Subtrair";
            btn_Subtrair.Size = new Size(40, 40);
            btn_Subtrair.TabIndex = 15;
            btn_Subtrair.Text = "-";
            btn_Subtrair.UseVisualStyleBackColor = true;
            btn_Subtrair.Click += btn_Subtrair_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.Location = new Point(110, 215);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(40, 40);
            btn_3.TabIndex = 14;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.Location = new Point(65, 215);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(40, 40);
            btn_2.TabIndex = 13;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(20, 215);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(40, 40);
            btn_1.TabIndex = 12;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_Somar
            // 
            btn_Somar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Somar.Location = new Point(155, 260);
            btn_Somar.Name = "btn_Somar";
            btn_Somar.Size = new Size(40, 40);
            btn_Somar.TabIndex = 19;
            btn_Somar.Text = "+";
            btn_Somar.UseVisualStyleBackColor = true;
            btn_Somar.Click += btn_Somar_Click;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(110, 260);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(40, 40);
            btn_Calcular.TabIndex = 18;
            btn_Calcular.Text = "=";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_0.Location = new Point(65, 260);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(40, 40);
            btn_0.TabIndex = 17;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_Virgula
            // 
            btn_Virgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Virgula.Location = new Point(20, 260);
            btn_Virgula.Name = "btn_Virgula";
            btn_Virgula.Size = new Size(40, 40);
            btn_Virgula.TabIndex = 16;
            btn_Virgula.Text = ",";
            btn_Virgula.UseVisualStyleBackColor = true;
            btn_Virgula.Click += btn_Virgula_Click;
            // 
            // txt_Visor
            // 
            txt_Visor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Visor.Location = new Point(20, 20);
            txt_Visor.Name = "txt_Visor";
            txt_Visor.RightToLeft = RightToLeft.Yes;
            txt_Visor.Size = new Size(175, 35);
            txt_Visor.TabIndex = 20;
            txt_Visor.KeyPress += txt_Visor_KeyPress;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 316);
            Controls.Add(txt_Visor);
            Controls.Add(btn_Somar);
            Controls.Add(btn_Calcular);
            Controls.Add(btn_0);
            Controls.Add(btn_Virgula);
            Controls.Add(btn_Subtrair);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_Multiplicar);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_Dividir);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_Voltar);
            Controls.Add(btn_LimparCalculo);
            Controls.Add(btn_LimparVisor);
            Controls.Add(btn_Porcentagem);
            Name = "frmCalculadora";
            Text = "CALCULADORA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Porcentagem;
        private Button btn_LimparVisor;
        private Button btn_LimparCalculo;
        private Button btn_Voltar;
        private Button btn_Dividir;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_Multiplicar;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_Subtrair;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_Somar;
        private Button btn_Calcular;
        private Button btn_0;
        private Button btn_Virgula;
        private TextBox txt_Visor;
    }
}