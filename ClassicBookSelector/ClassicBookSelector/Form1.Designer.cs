namespace ClassicBookSelector
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
            this.booksListbox = new System.Windows.Forms.ListBox();
            this.hoverLabel = new System.Windows.Forms.Label();
            this.synopsisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // booksListbox
            // 
            this.booksListbox.FormattingEnabled = true;
            this.booksListbox.ItemHeight = 16;
            this.booksListbox.Items.AddRange(new object[] {
            "The Dictionary",
            "Book 1",
            "Book 2",
            "The book before book 2",
            "The final book"});
            this.booksListbox.Location = new System.Drawing.Point(12, 62);
            this.booksListbox.Name = "booksListbox";
            this.booksListbox.Size = new System.Drawing.Size(258, 84);
            this.booksListbox.TabIndex = 0;
            this.booksListbox.SelectedIndexChanged += new System.EventHandler(this.booksListbox_SelectedIndexChanged);
            this.booksListbox.MouseEnter += new System.EventHandler(this.booksListbox_MouseEnter);
            this.booksListbox.MouseLeave += new System.EventHandler(this.booksListbox_MouseLeave);
            // 
            // hoverLabel
            // 
            this.hoverLabel.AutoSize = true;
            this.hoverLabel.Location = new System.Drawing.Point(79, 149);
            this.hoverLabel.Name = "hoverLabel";
            this.hoverLabel.Size = new System.Drawing.Size(114, 17);
            this.hoverLabel.TabIndex = 1;
            this.hoverLabel.Text = "Reading is good!";
            this.hoverLabel.Visible = false;
            // 
            // synopsisLabel
            // 
            this.synopsisLabel.AutoSize = true;
            this.synopsisLabel.Location = new System.Drawing.Point(32, 187);
            this.synopsisLabel.Name = "synopsisLabel";
            this.synopsisLabel.Size = new System.Drawing.Size(0, 17);
            this.synopsisLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.synopsisLabel);
            this.Controls.Add(this.hoverLabel);
            this.Controls.Add(this.booksListbox);
            this.Name = "Form1";
            this.Text = "ClassicBookSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox booksListbox;
        private System.Windows.Forms.Label hoverLabel;
        private System.Windows.Forms.Label synopsisLabel;
    }
}

