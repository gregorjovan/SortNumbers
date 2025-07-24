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
			label1 = new Label();
			SuspendLayout();
			// 
			// txtInputNumbers
			// 
			txtInputNumbers.Location = new Point(12, 147);
			txtInputNumbers.Multiline = true;
			txtInputNumbers.Name = "txtInputNumbers";
			txtInputNumbers.Size = new Size(641, 83);
			txtInputNumbers.TabIndex = 0;
			// 
			// lblInput
			// 
			lblInput.AutoSize = true;
			lblInput.Location = new Point(12, 111);
			lblInput.Name = "lblInput";
			lblInput.Size = new Size(92, 20);
			lblInput.TabIndex = 1;
			lblInput.Text = "Vnesi števila:";
			// 
			// btnSort
			// 
			btnSort.Location = new Point(659, 147);
			btnSort.Name = "btnSort";
			btnSort.Size = new Size(129, 83);
			btnSort.TabIndex = 2;
			btnSort.Text = "Uredi";
			btnSort.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 252);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 3;
			label1.Text = "label1";
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Controls.Add(btnSort);
			Controls.Add(lblInput);
			Controls.Add(txtInputNumbers);
			Name = "frmMain";
			Text = "Sort your numbers!";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtInputNumbers;
		private Label lblInput;
		private Button btnSort;
		private Label label1;
	}
}
