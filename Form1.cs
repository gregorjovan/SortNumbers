namespace SortNumbers
{
	public partial class frmMain : Form
	{
		private System.Windows.Forms.Timer _textChangedTimer;
		public frmMain()
		{
			InitializeComponent();

			_textChangedTimer = new System.Windows.Forms.Timer();
			_textChangedTimer.Interval = 2000;
			_textChangedTimer.Tick += TextChangedTimer_Tick;
		}

		private void TextChangedTimer_Tick(object? sender, EventArgs e)
		{
			_textChangedTimer.Stop();
			ProcessInput(txtInputNumbers.Text);
		}
		private void btnSort_Click(object sender, EventArgs e)
		{
			ProcessInput(txtInputNumbers.Text);
		}

		private void txtInputNumbers_TextChanged(object sender, EventArgs e)
		{
			_textChangedTimer.Stop();
			_textChangedTimer.Start();
		}

		private void ProcessInput(string inputText)
		{
			throw new NotImplementedException("This method is not used in this example.");
		}


	}
}
