namespace Practica_16
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 22);
            label1.Name = "label1";
            label1.Size = new Size(273, 28);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato un número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 50);
            label2.Name = "label2";
            label2.Size = new Size(272, 28);
            label2.TabIndex = 1;
            label2.Text = "determinar si es par o impar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 125);
            label3.Name = "label3";
            label3.Size = new Size(297, 28);
            label3.TabIndex = 2;
            label3.Text = "Ingresar un número cualquiera";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(144, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 36);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(60, 277);
            button1.Name = "button1";
            button1.Size = new Size(127, 40);
            button1.TabIndex = 4;
            button1.Text = "Determinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(250, 277);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 5;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(440, 342);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Pares e impares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}