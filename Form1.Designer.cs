﻿namespace Procedimientos_y_Funciones
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
            groupBox1 = new GroupBox();
            Limpiar = new Button();
            Dividir = new Button();
            Multiplicar = new Button();
            Restar = new Button();
            Sumar = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Limpiar);
            groupBox1.Controls.Add(Dividir);
            groupBox1.Controls.Add(Multiplicar);
            groupBox1.Controls.Add(Restar);
            groupBox1.Controls.Add(Sumar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(208, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Datos";
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(103, 140);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 8;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Dividir
            // 
            Dividir.Location = new Point(266, 106);
            Dividir.Name = "Dividir";
            Dividir.Size = new Size(75, 23);
            Dividir.TabIndex = 7;
            Dividir.Text = "Dividir";
            Dividir.UseVisualStyleBackColor = true;
            Dividir.Click += Dividir_Click;
            // 
            // Multiplicar
            // 
            Multiplicar.Location = new Point(266, 77);
            Multiplicar.Name = "Multiplicar";
            Multiplicar.Size = new Size(75, 23);
            Multiplicar.TabIndex = 6;
            Multiplicar.Text = "Multiplicar";
            Multiplicar.UseVisualStyleBackColor = true;
            Multiplicar.Click += Multiplicar_Click;
            // 
            // Restar
            // 
            Restar.Location = new Point(266, 48);
            Restar.Name = "Restar";
            Restar.Size = new Size(75, 23);
            Restar.TabIndex = 5;
            Restar.Text = "Restar";
            Restar.UseVisualStyleBackColor = true;
            Restar.Click += Restar_Click;
            // 
            // Sumar
            // 
            Sumar.Location = new Point(266, 22);
            Sumar.Name = "Sumar";
            Sumar.Size = new Size(75, 23);
            Sumar.TabIndex = 4;
            Sumar.Text = "Sumar";
            Sumar.UseVisualStyleBackColor = true;
            Sumar.Click += Sumar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 2:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 52);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(208, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 63);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 29);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 32);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 0;
            label3.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Procedimientos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button Limpiar;
        private Button Dividir;
        private Button Multiplicar;
        private Button Restar;
        private Button Sumar;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label label3;
    }
}