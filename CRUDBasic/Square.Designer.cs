namespace CRUDBasic
{
    partial class Square
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
            this.calculate = new System.Windows.Forms.Button();
            this.SquarePeri = new System.Windows.Forms.TextBox();
            this.SquareArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(340, 100);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 29);
            this.calculate.TabIndex = 17;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // SquarePeri
            // 
            this.SquarePeri.Location = new System.Drawing.Point(220, 171);
            this.SquarePeri.Name = "SquarePeri";
            this.SquarePeri.Size = new System.Drawing.Size(100, 22);
            this.SquarePeri.TabIndex = 16;
            // 
            // SquareArea
            // 
            this.SquareArea.Location = new System.Drawing.Point(220, 143);
            this.SquareArea.Name = "SquareArea";
            this.SquareArea.Size = new System.Drawing.Size(100, 22);
            this.SquareArea.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Perimeter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "length";
            // 
            // lengthtxt
            // 
            this.lengthtxt.Location = new System.Drawing.Point(191, 63);
            this.lengthtxt.Name = "lengthtxt";
            this.lengthtxt.Size = new System.Drawing.Size(224, 22);
            this.lengthtxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "SQUARE";
            // 
            // Square
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.SquarePeri);
            this.Controls.Add(this.SquareArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthtxt);
            this.Name = "Square";
            this.Text = "Square";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox SquarePeri;
        private System.Windows.Forms.TextBox SquareArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthtxt;
        private System.Windows.Forms.Label label2;
    }
}