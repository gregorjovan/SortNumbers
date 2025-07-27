namespace SortNumbers
{
    partial class frmMain
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
			txtInputNumbers = new TextBox();
			lblInput = new Label();
			btnSort = new Button();
			lblResult = new Label();
			chkDownload = new CheckBox();
			chkAddSemicolon = new CheckBox();
			SuspendLayout();
			// 
			// txtInputNumbers
			// 
			txtInputNumbers.Location = new Point(10, 110);
			txtInputNumbers.Margin = new Padding(3, 2, 3, 2);
			txtInputNumbers.Multiline = true;
			txtInputNumbers.Name = "txtInputNumbers";
			txtInputNumbers.Size = new Size(561, 63);
			txtInputNumbers.TabIndex = 0;
			txtInputNumbers.TextChanged += txtInputNumbers_TextChanged;
			// 
			// lblInput
			// 
			lblInput.AutoSize = true;
			lblInput.Location = new Point(10, 83);
			lblInput.Name = "lblInput";
			lblInput.Size = new Size(74, 15);
			lblInput.TabIndex = 1;
			lblInput.Text = "Vnesi števila:";
			// 
			// btnSort
			// 
			btnSort.Location = new Point(577, 110);
			btnSort.Margin = new Padding(3, 2, 3, 2);
			btnSort.Name = "btnSort";
			btnSort.Size = new Size(113, 62);
			btnSort.TabIndex = 2;
			btnSort.Text = "Uredi";
			btnSort.UseVisualStyleBackColor = true;
			btnSort.Click += btnSort_Click;
			// 
			// lblResult
			// 
			lblResult.AutoSize = true;
			lblResult.Location = new Point(10, 251);
			lblResult.Name = "lblResult";
			lblResult.Size = new Size(49, 15);
			lblResult.TabIndex = 3;
			lblResult.Text = "Rezultat";
			// 
			// chkDownload
			// 
			chkDownload.AutoSize = true;
			chkDownload.Location = new Point(12, 192);
			chkDownload.Name = "chkDownload";
			chkDownload.Size = new Size(191, 19);
			chkDownload.TabIndex = 4;
			chkDownload.Text = "Ob kliku na uredi shrani na disk";
			chkDownload.UseVisualStyleBackColor = true;
			// 
			// chkAddSemicolon
			// 
			chkAddSemicolon.AutoSize = true;
			chkAddSemicolon.Location = new Point(209, 192);
			chkAddSemicolon.Name = "chkAddSemicolon";
			chkAddSemicolon.Size = new Size(172, 19);
			chkAddSemicolon.TabIndex = 5;
			chkAddSemicolon.Text = "Avtomatsko dodaj podpičje";
			chkAddSemicolon.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 338);
			Controls.Add(chkAddSemicolon);
			Controls.Add(chkDownload);
			Controls.Add(lblResult);
			Controls.Add(btnSort);
			Controls.Add(lblInput);
			Controls.Add(txtInputNumbers);
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmMain";
			Text = "Sort your numbers!";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtInputNumbers;
		private Label lblInput;
		private Button btnSort;
		private Label lblResult;
		private CheckBox chkDownload;
		private CheckBox chkAddSemicolon;
	}
}
