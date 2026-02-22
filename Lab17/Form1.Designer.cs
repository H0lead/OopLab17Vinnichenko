namespace Lab17
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.dollarButton = new System.Windows.Forms.Button();
            this.euroButton = new System.Windows.Forms.Button();
            this.exportListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть число";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(13, 33);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(226, 22);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // dollarButton
            // 
            this.dollarButton.Location = new System.Drawing.Point(13, 62);
            this.dollarButton.Name = "dollarButton";
            this.dollarButton.Size = new System.Drawing.Size(100, 23);
            this.dollarButton.TabIndex = 2;
            this.dollarButton.Text = "Dollar";
            this.dollarButton.UseVisualStyleBackColor = true;
            this.dollarButton.Click += new System.EventHandler(this.dollarButton_Click);
            // 
            // euroButton
            // 
            this.euroButton.Location = new System.Drawing.Point(139, 62);
            this.euroButton.Name = "euroButton";
            this.euroButton.Size = new System.Drawing.Size(100, 23);
            this.euroButton.TabIndex = 3;
            this.euroButton.Text = "Euro";
            this.euroButton.UseVisualStyleBackColor = true;
            this.euroButton.Click += new System.EventHandler(this.euroButton_Click);
            // 
            // exportListBox
            // 
            this.exportListBox.FormattingEnabled = true;
            this.exportListBox.ItemHeight = 16;
            this.exportListBox.Location = new System.Drawing.Point(246, 13);
            this.exportListBox.Name = "exportListBox";
            this.exportListBox.Size = new System.Drawing.Size(542, 420);
            this.exportListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportListBox);
            this.Controls.Add(this.euroButton);
            this.Controls.Add(this.dollarButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button dollarButton;
        private System.Windows.Forms.Button euroButton;
        private System.Windows.Forms.ListBox exportListBox;
    }
}

