namespace Aula_1
{
    partial class frm_Calculadora
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
            txt_ValorA = new TextBox();
            lbl_ValorA = new Label();
            lbl_ValorB = new Label();
            txt_ValorB = new TextBox();
            lbl_Resultado = new Label();
            txt_Resultado = new TextBox();
            lbl_Operacao = new Label();
            lbl_Igual = new Label();
            btn_Somar = new Button();
            btn_Subtrair = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txt_ValorA
            // 
            txt_ValorA.Location = new Point(83, 52);
            txt_ValorA.Name = "txt_ValorA";
            txt_ValorA.Size = new Size(100, 23);
            txt_ValorA.TabIndex = 0;
            // 
            // lbl_ValorA
            // 
            lbl_ValorA.AutoSize = true;
            lbl_ValorA.Location = new Point(35, 55);
            lbl_ValorA.Name = "lbl_ValorA";
            lbl_ValorA.Size = new Size(42, 15);
            lbl_ValorA.TabIndex = 1;
            lbl_ValorA.Text = "Valor 1";
            // 
            // lbl_ValorB
            // 
            lbl_ValorB.AutoSize = true;
            lbl_ValorB.Location = new Point(35, 125);
            lbl_ValorB.Name = "lbl_ValorB";
            lbl_ValorB.Size = new Size(42, 15);
            lbl_ValorB.TabIndex = 3;
            lbl_ValorB.Text = "Valor 2";
            // 
            // txt_ValorB
            // 
            txt_ValorB.Location = new Point(83, 121);
            txt_ValorB.Name = "txt_ValorB";
            txt_ValorB.Size = new Size(100, 23);
            txt_ValorB.TabIndex = 2;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Location = new Point(18, 203);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(59, 15);
            lbl_Resultado.TabIndex = 4;
            lbl_Resultado.Text = "Resultado";
            // 
            // txt_Resultado
            // 
            txt_Resultado.Location = new Point(83, 199);
            txt_Resultado.Name = "txt_Resultado";
            txt_Resultado.Size = new Size(100, 23);
            txt_Resultado.TabIndex = 5;
            // 
            // lbl_Operacao
            // 
            lbl_Operacao.AutoSize = true;
            lbl_Operacao.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Operacao.Location = new Point(117, 75);
            lbl_Operacao.Name = "lbl_Operacao";
            lbl_Operacao.Size = new Size(35, 37);
            lbl_Operacao.TabIndex = 6;
            lbl_Operacao.Text = "+";
            // 
            // lbl_Igual
            // 
            lbl_Igual.AutoSize = true;
            lbl_Igual.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Igual.Location = new Point(117, 154);
            lbl_Igual.Name = "lbl_Igual";
            lbl_Igual.Size = new Size(35, 37);
            lbl_Igual.TabIndex = 7;
            lbl_Igual.Text = "=";
            // 
            // btn_Somar
            // 
            btn_Somar.Location = new Point(238, 65);
            btn_Somar.Name = "btn_Somar";
            btn_Somar.Size = new Size(95, 23);
            btn_Somar.TabIndex = 8;
            btn_Somar.Text = "Somar";
            btn_Somar.UseVisualStyleBackColor = true;
            btn_Somar.Click += btn_Somar_Click;
            // 
            // btn_Subtrair
            // 
            btn_Subtrair.Location = new Point(238, 103);
            btn_Subtrair.Name = "btn_Subtrair";
            btn_Subtrair.Size = new Size(95, 23);
            btn_Subtrair.TabIndex = 9;
            btn_Subtrair.Text = "Subtrair";
            btn_Subtrair.UseVisualStyleBackColor = true;
            btn_Subtrair.Click += btn_Subtrair_Click;
            // 
            // button1
            // 
            button1.Location = new Point(238, 142);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 10;
            button1.Text = "Multiplicação";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(238, 181);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 11;
            button2.Text = "Divisão";
            button2.UseVisualStyleBackColor = true;
            // 
            // frm_Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 271);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_Subtrair);
            Controls.Add(btn_Somar);
            Controls.Add(lbl_Igual);
            Controls.Add(lbl_Operacao);
            Controls.Add(txt_Resultado);
            Controls.Add(lbl_Resultado);
            Controls.Add(lbl_ValorB);
            Controls.Add(txt_ValorB);
            Controls.Add(lbl_ValorA);
            Controls.Add(txt_ValorA);
            Name = "frm_Calculadora";
            Text = "Calculadora Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ValorA;
        private Label lbl_ValorA;
        private Label lbl_ValorB;
        private TextBox txt_ValorB;
        private Label lbl_Resultado;
        private TextBox txt_Resultado;
        private Label lbl_Operacao;
        private Label lbl_Igual;
        private Button btn_Somar;
        private Button btn_Subtrair;
        private Button button1;
        private Button button2;
    }
}