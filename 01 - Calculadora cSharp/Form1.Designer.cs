
namespace _01___Calculadora_cSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultados = new System.Windows.Forms.TextBox();
            this.lbloperacaio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultados
            // 
            this.resultados.Location = new System.Drawing.Point(101, 70);
            this.resultados.Multiline = true;
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(220, 40);
            this.resultados.TabIndex = 0;
            this.resultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbloperacaio
            // 
            this.lbloperacaio.AllowDrop = true;
            this.lbloperacaio.AutoEllipsis = true;
            this.lbloperacaio.BackColor = System.Drawing.Color.DarkGray;
            this.lbloperacaio.Location = new System.Drawing.Point(35, 70);
            this.lbloperacaio.Name = "lbloperacaio";
            this.lbloperacaio.Size = new System.Drawing.Size(45, 40);
            this.lbloperacaio.TabIndex = 1;
            this.lbloperacaio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbloperacaio.Click += new System.EventHandler(this.lbloperacaio_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(25, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FloralWhite;
            this.button2.Location = new System.Drawing.Point(101, 120);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Coral;
            this.button4.Location = new System.Drawing.Point(177, 120);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GhostWhite;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(25, 380);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 57);
            this.button6.TabIndex = 8;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Coral;
            this.button7.Location = new System.Drawing.Point(253, 120);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.GhostWhite;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(177, 185);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 57);
            this.button8.TabIndex = 10;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.GhostWhite;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(101, 185);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 57);
            this.button9.TabIndex = 9;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.GhostWhite;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(25, 185);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 57);
            this.button10.TabIndex = 12;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.AliceBlue;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Coral;
            this.button12.Location = new System.Drawing.Point(253, 185);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 57);
            this.button12.TabIndex = 14;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.GhostWhite;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(177, 249);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 57);
            this.button13.TabIndex = 13;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.GhostWhite;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(101, 250);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 57);
            this.button14.TabIndex = 16;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.GhostWhite;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(25, 250);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 57);
            this.button15.TabIndex = 15;
            this.button15.Text = "4";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Coral;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Location = new System.Drawing.Point(253, 315);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 121);
            this.button16.TabIndex = 18;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.AliceBlue;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Coral;
            this.button17.Location = new System.Drawing.Point(253, 250);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 57);
            this.button17.TabIndex = 17;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.GhostWhite;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(177, 315);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(68, 57);
            this.button18.TabIndex = 20;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.GhostWhite;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(101, 315);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(68, 57);
            this.button19.TabIndex = 19;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.GhostWhite;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(25, 315);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(68, 57);
            this.button20.TabIndex = 22;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.GhostWhite;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(177, 379);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 57);
            this.button11.TabIndex = 11;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 23;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "@csaalvador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "cSharp Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(352, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbloperacaio);
            this.Controls.Add(this.resultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultados;
        private System.Windows.Forms.Label lbloperacaio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

