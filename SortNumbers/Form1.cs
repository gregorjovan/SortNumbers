using SortNumbers.Application;

namespace SortNumbers
{
	public partial class frmMain : Form
	{
		private readonly ISortService _sortService;
		private readonly System.Windows.Forms.Timer _textChangedTimer;

		public frmMain(ISortService sortService)
		{
			InitializeComponent();
			_sortService = sortService;

			_textChangedTimer = new System.Windows.Forms.Timer
			{
				Interval = 1000
			};
			_textChangedTimer.Tick += TextChangedTimer_Tick;
		}

		private void TextChangedTimer_Tick(object? sender, EventArgs e)
		{
			_textChangedTimer.Stop();

			string txtToSort = txtInputNumbers.Text;
			
			if(txtToSort.Length > 0 && chkAddSemicolon.Checked && txtToSort.TakeLast(1).FirstOrDefault() != ';')
			{
				AddSemicolonToTextBox(this.txtInputNumbers);
			}

			ProcessInput(txtToSort);
		}
		private void btnSort_Click(object sender, EventArgs e)
		{
			_textChangedTimer.Stop();
			ProcessInput(txtInputNumbers.Text);
			
			if(chkDownload.Checked)
			{
				WriteToDisc(lblResult.Text);
			}
		}

		private void txtInputNumbers_TextChanged(object sender, EventArgs e)
		{
			_textChangedTimer.Stop();
			_textChangedTimer.Start();
		}

		private static void AddSemicolonToTextBox(TextBox textBox)
		{
			if (textBox == null) return;

			textBox.Text += ';';

			textBox.SelectionStart = textBox.Text.Length;
			textBox.SelectionLength = 0;
			textBox.Focus();
		}

		private void ProcessInput(string inputText)
		{
			if (string.IsNullOrEmpty(inputText))
			{
				lblResult.Text = "Vnesite kako število.";
				return;
			}

			char[] unallowed = { ' ', ';', ';', '\n', '\r' };
			inputText = inputText.Trim(unallowed);
			int[] myInts;
			
			try
			{
				myInts = Array.ConvertAll(inputText.Split(';'), int.Parse);
				
			}
			catch (Exception ex)
			{
				lblResult.Text = $"Error: {ex.Message}";
				return;
			}
			
			lblResult.Text = String.Join(" ", _sortService.Sort(myInts));
		}

		private static void WriteToDisc(string sortedNumbers)
		{
			string filePath = AppContext.BaseDirectory + "\\" + DateTime.Now.Date.ToString("yyyy_MM_dd")+".txt";

			//source: https://learn.microsoft.com/en-us/dotnet/api/system.io.file.writealltext?view=net-9.0
			File.WriteAllText(filePath, sortedNumbers);
		}
	}
}
