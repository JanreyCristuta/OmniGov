namespace LFS.Views.Transactions.JEV
{
    partial class ucGenJrnl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Check No.";
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox2.Location = new System.Drawing.Point(23, 38);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(229, 23);
            textBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(23, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "OR No.";
            // 
            // textBox4
            // 
            textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox4.Location = new System.Drawing.Point(23, 94);
            textBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(229, 23);
            textBox4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(23, 132);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "DV No.";
            // 
            // textBox5
            // 
            textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox5.Location = new System.Drawing.Point(23, 150);
            textBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(229, 23);
            textBox5.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // ucGenJrnl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Name = "ucGenJrnl";
            Padding = new System.Windows.Forms.Padding(20);
            Size = new System.Drawing.Size(278, 204);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
