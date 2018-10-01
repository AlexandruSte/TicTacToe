namespace TicTacToe
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPvC = new System.Windows.Forms.Button();
            this.btnPvP = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.m33 = new TicTacToe.NewButton();
            this.m32 = new TicTacToe.NewButton();
            this.m31 = new TicTacToe.NewButton();
            this.m12 = new TicTacToe.NewButton();
            this.m11 = new TicTacToe.NewButton();
            this.m23 = new TicTacToe.NewButton();
            this.m13 = new TicTacToe.NewButton();
            this.m22 = new TicTacToe.NewButton();
            this.m21 = new TicTacToe.NewButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnPvC);
            this.panel2.Controls.Add(this.btnPvP);
            this.panel2.Location = new System.Drawing.Point(25, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 329);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select the mode you want to play";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(18, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 200);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(144, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player2 (name)";
            this.label2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player1 (name)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnPvC
            // 
            this.btnPvC.Location = new System.Drawing.Point(156, 38);
            this.btnPvC.Name = "btnPvC";
            this.btnPvC.Size = new System.Drawing.Size(114, 37);
            this.btnPvC.TabIndex = 11;
            this.btnPvC.Text = "PvC";
            this.btnPvC.UseVisualStyleBackColor = true;
            this.btnPvC.Click += new System.EventHandler(this.btnPvC_Click);
            // 
            // btnPvP
            // 
            this.btnPvP.Location = new System.Drawing.Point(18, 38);
            this.btnPvP.Name = "btnPvP";
            this.btnPvP.Size = new System.Drawing.Size(114, 37);
            this.btnPvP.TabIndex = 10;
            this.btnPvP.Text = "PvP";
            this.btnPvP.UseVisualStyleBackColor = true;
            this.btnPvP.Click += new System.EventHandler(this.btnPvP_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.playerLabel);
            this.panel3.Controls.Add(this.m22);
            this.panel3.Controls.Add(this.m33);
            this.panel3.Controls.Add(this.m32);
            this.panel3.Controls.Add(this.m31);
            this.panel3.Controls.Add(this.m12);
            this.panel3.Controls.Add(this.m11);
            this.panel3.Controls.Add(this.m23);
            this.panel3.Controls.Add(this.m13);
            this.panel3.Controls.Add(this.m21);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(352, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 272);
            this.panel3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(35, 12);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(0, 13);
            this.playerLabel.TabIndex = 12;
            // 
            // m33
            // 
            this.m33.Location = new System.Drawing.Point(211, 186);
            this.m33.Name = "m33";
            this.m33.Size = new System.Drawing.Size(87, 67);
            this.m33.TabIndex = 11;
            this.m33.UseVisualStyleBackColor = true;
            this.m33.X = 2;
            this.m33.Y = 2;
            this.m33.Click += new System.EventHandler(this.nClick);
            // 
            // m32
            // 
            this.m32.Location = new System.Drawing.Point(118, 186);
            this.m32.Name = "m32";
            this.m32.Size = new System.Drawing.Size(87, 67);
            this.m32.TabIndex = 10;
            this.m32.UseVisualStyleBackColor = true;
            this.m32.X = 2;
            this.m32.Y = 1;
            this.m32.Click += new System.EventHandler(this.nClick);
            // 
            // m31
            // 
            this.m31.Location = new System.Drawing.Point(23, 186);
            this.m31.Name = "m31";
            this.m31.Size = new System.Drawing.Size(89, 67);
            this.m31.TabIndex = 9;
            this.m31.UseVisualStyleBackColor = true;
            this.m31.X = 2;
            this.m31.Y = 0;
            this.m31.Click += new System.EventHandler(this.nClick);
            // 
            // m12
            // 
            this.m12.Location = new System.Drawing.Point(118, 38);
            this.m12.Name = "m12";
            this.m12.Size = new System.Drawing.Size(87, 70);
            this.m12.TabIndex = 4;
            this.m12.UseVisualStyleBackColor = true;
            this.m12.X = 0;
            this.m12.Y = 1;
            this.m12.Click += new System.EventHandler(this.nClick);
            // 
            // m11
            // 
            this.m11.Location = new System.Drawing.Point(23, 38);
            this.m11.Name = "m11";
            this.m11.Size = new System.Drawing.Size(89, 70);
            this.m11.TabIndex = 3;
            this.m11.UseVisualStyleBackColor = true;
            this.m11.X = 0;
            this.m11.Y = 0;
            this.m11.Click += new System.EventHandler(this.nClick);
            // 
            // m23
            // 
            this.m23.Location = new System.Drawing.Point(211, 113);
            this.m23.Name = "m23";
            this.m23.Size = new System.Drawing.Size(87, 68);
            this.m23.TabIndex = 8;
            this.m23.UseVisualStyleBackColor = true;
            this.m23.X = 1;
            this.m23.Y = 2;
            this.m23.Click += new System.EventHandler(this.nClick);
            // 
            // m13
            // 
            this.m13.Location = new System.Drawing.Point(211, 38);
            this.m13.Name = "m13";
            this.m13.Size = new System.Drawing.Size(87, 69);
            this.m13.TabIndex = 5;
            this.m13.UseVisualStyleBackColor = true;
            this.m13.X = 0;
            this.m13.Y = 2;
            this.m13.Click += new System.EventHandler(this.nClick);
            // 
            // m22
            // 
            this.m22.Location = new System.Drawing.Point(118, 114);
            this.m22.Name = "m22";
            this.m22.Size = new System.Drawing.Size(87, 67);
            this.m22.TabIndex = 7;
            this.m22.UseVisualStyleBackColor = true;
            this.m22.X = 1;
            this.m22.Y = 1;
            this.m22.Click += new System.EventHandler(this.nClick);
            // 
            // m21
            // 
            this.m21.Location = new System.Drawing.Point(23, 114);
            this.m21.Name = "m21";
            this.m21.Size = new System.Drawing.Size(89, 67);
            this.m21.TabIndex = 6;
            this.m21.UseVisualStyleBackColor = true;
            this.m21.X = 1;
            this.m21.Y = 0;
            this.m21.Click += new System.EventHandler(this.nClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 389);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NewButton m11;
        private NewButton m12;
        private NewButton m13;
        private NewButton m21;
        private NewButton m22;
        private NewButton m23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPvC;
        private System.Windows.Forms.Button btnPvP;
        private System.Windows.Forms.Panel panel3;
        private NewButton m33;
        private NewButton m32;
        private NewButton m31;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

