namespace Proyecto_juego
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
            panel1 = new Panel();
            button1 = new Button();
            tresultado = new TextBox();
            label7 = new Label();
            n2 = new Label();
            op = new Label();
            n1 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            label5 = new Label();
            Label4 = new Label();
            laciertos = new Label();
            lerrores = new Label();
            lpuntos = new Label();
            label6 = new Label();
            lnivel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tresultado);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(n2);
            panel1.Controls.Add(op);
            panel1.Controls.Add(n1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(256, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 534);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(54, 332);
            button1.Name = "button1";
            button1.Size = new Size(293, 130);
            button1.TabIndex = 6;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tresultado
            // 
            tresultado.Font = new Font("Segoe UI", 12F);
            tresultado.Location = new Point(63, 263);
            tresultado.Name = "tresultado";
            tresultado.Size = new Size(205, 39);
            tresultado.TabIndex = 5;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(379, 126);
            label7.Name = "label7";
            label7.Size = new Size(63, 52);
            label7.TabIndex = 4;
            label7.Text = "=?";
            // 
            // n2
            // 
            n2.BorderStyle = BorderStyle.FixedSingle;
            n2.Font = new Font("Segoe UI", 16F);
            n2.Location = new Point(288, 123);
            n2.Name = "n2";
            n2.Size = new Size(73, 55);
            n2.TabIndex = 3;
            // 
            // op
            // 
            op.BorderStyle = BorderStyle.FixedSingle;
            op.Font = new Font("Segoe UI", 16F);
            op.Location = new Point(177, 123);
            op.Name = "op";
            op.Size = new Size(91, 55);
            op.TabIndex = 2;
            // 
            // n1
            // 
            n1.BorderStyle = BorderStyle.FixedSingle;
            n1.Font = new Font("Segoe UI", 16F);
            n1.Location = new Point(63, 123);
            n1.Name = "n1";
            n1.Size = new Size(95, 55);
            n1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(54, 59);
            label3.Name = "label3";
            label3.Size = new Size(625, 45);
            label3.TabIndex = 0;
            label3.Text = "DIGITE EL RESULTADO DE LA OPERACION :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(435, 21);
            label1.Name = "label1";
            label1.Size = new Size(373, 54);
            label1.TabIndex = 1;
            label1.Text = "JUEGO ARITMETICA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(1105, 102);
            label2.Name = "label2";
            label2.Size = new Size(255, 32);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de jugadores";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1114, 277);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 3;
            label10.Text = "Puntos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1111, 352);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 4;
            label5.Text = "Aciertos";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(1114, 408);
            Label4.Name = "Label4";
            Label4.Size = new Size(67, 25);
            Label4.TabIndex = 5;
            Label4.Text = "Errores";
            // 
            // laciertos
            // 
            laciertos.BorderStyle = BorderStyle.FixedSingle;
            laciertos.Location = new Point(1213, 352);
            laciertos.Name = "laciertos";
            laciertos.Size = new Size(66, 40);
            laciertos.TabIndex = 8;
            laciertos.Text = "0";
            // 
            // lerrores
            // 
            lerrores.BorderStyle = BorderStyle.FixedSingle;
            lerrores.Location = new Point(1213, 408);
            lerrores.Name = "lerrores";
            lerrores.Size = new Size(66, 36);
            lerrores.TabIndex = 9;
            lerrores.Text = "0";
            // 
            // lpuntos
            // 
            lpuntos.BorderStyle = BorderStyle.FixedSingle;
            lpuntos.Location = new Point(1230, 280);
            lpuntos.Name = "lpuntos";
            lpuntos.Size = new Size(62, 37);
            lpuntos.TabIndex = 10;
            lpuntos.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1105, 30);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 11;
            label6.Text = "nivel =";
            // 
            // lnivel
            // 
            lnivel.BorderStyle = BorderStyle.FixedSingle;
            lnivel.Location = new Point(1186, 21);
            lnivel.Name = "lnivel";
            lnivel.Size = new Size(106, 34);
            lnivel.TabIndex = 12;
            lnivel.Click += lnivel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1385, 769);
            Controls.Add(lnivel);
            Controls.Add(label6);
            Controls.Add(lpuntos);
            Controls.Add(lerrores);
            Controls.Add(laciertos);
            Controls.Add(Label4);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label n2;
        private Label op;
        private Label n1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label10;
        private Label label5;
        private Label Label4;
        private Button button1;
        private TextBox tresultado;
        private Label laciertos;
        private Label lerrores;
        private Label lpuntos;
        private Label label6;
        private Label lnivel;
    }
}
