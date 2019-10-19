namespace DiscountCalculator
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
            this.discountBox = new System.Windows.Forms.TextBox();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newCost = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(46, 261);
            this.discountBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(196, 31);
            this.discountBox.TabIndex = 0;
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(46, 121);
            this.itemBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(196, 31);
            this.itemBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discount Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost of Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "% Discount";
            // 
            // newCost
            // 
            this.newCost.AutoSize = true;
            this.newCost.Location = new System.Drawing.Point(388, 261);
            this.newCost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.newCost.Name = "newCost";
            this.newCost.Size = new System.Drawing.Size(104, 25);
            this.newCost.TabIndex = 5;
            this.newCost.Text = "New Cost";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(393, 121);
            this.calcButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(150, 44);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 469);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.newCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.discountBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newCost;
        private System.Windows.Forms.Button calcButton;
    }
}

