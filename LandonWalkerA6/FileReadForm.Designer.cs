namespace LandonWalkerA6
{
    partial class FileReadForm
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
            ChooseBtn = new Button();
            ExportCSVBtn = new Button();
            ExportJSNBtn = new Button();
            DescribeLbl = new Label();
            NumLbl = new Label();
            SuspendLayout();
            // 
            // ChooseBtn
            // 
            ChooseBtn.Location = new Point(711, 114);
            ChooseBtn.Name = "ChooseBtn";
            ChooseBtn.Size = new Size(250, 102);
            ChooseBtn.TabIndex = 0;
            ChooseBtn.Text = "Choose File";
            ChooseBtn.UseVisualStyleBackColor = true;
            ChooseBtn.Click += ChooseBtn_Click;
            // 
            // ExportCSVBtn
            // 
            ExportCSVBtn.Location = new Point(687, 324);
            ExportCSVBtn.Name = "ExportCSVBtn";
            ExportCSVBtn.Size = new Size(314, 108);
            ExportCSVBtn.TabIndex = 1;
            ExportCSVBtn.Text = "Export Data as CSV";
            ExportCSVBtn.UseVisualStyleBackColor = true;
            ExportCSVBtn.Click += ExportCSVBtn_Click;
            // 
            // ExportJSNBtn
            // 
            ExportJSNBtn.Location = new Point(687, 536);
            ExportJSNBtn.Name = "ExportJSNBtn";
            ExportJSNBtn.Size = new Size(314, 110);
            ExportJSNBtn.TabIndex = 2;
            ExportJSNBtn.Text = "Export Data as JSON";
            ExportJSNBtn.UseVisualStyleBackColor = true;
            ExportJSNBtn.Click += ExportJSNBtn_Click;
            // 
            // DescribeLbl
            // 
            DescribeLbl.AutoSize = true;
            DescribeLbl.Font = new Font("Segoe UI", 14F);
            DescribeLbl.Location = new Point(469, 806);
            DescribeLbl.Name = "DescribeLbl";
            DescribeLbl.Size = new Size(550, 51);
            DescribeLbl.TabIndex = 3;
            DescribeLbl.Text = "Number of Objects Mapped In: ";
            // 
            // NumLbl
            // 
            NumLbl.AutoSize = true;
            NumLbl.Font = new Font("Segoe UI", 14F);
            NumLbl.Location = new Point(1037, 806);
            NumLbl.Name = "NumLbl";
            NumLbl.Size = new Size(121, 51);
            NumLbl.TabIndex = 4;
            NumLbl.Text = "label1";
            // 
            // FileReadForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 994);
            Controls.Add(NumLbl);
            Controls.Add(DescribeLbl);
            Controls.Add(ExportJSNBtn);
            Controls.Add(ExportCSVBtn);
            Controls.Add(ChooseBtn);
            Name = "FileReadForm";
            Text = "Landon Walker Assignment 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChooseBtn;
        private Button ExportCSVBtn;
        private Button ExportJSNBtn;
        private Label DescribeLbl;
        private Label NumLbl;
    }
}
