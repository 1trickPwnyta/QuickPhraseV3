namespace QuickPhraseV3;

public partial class MainPage : ContentPage
{
	Random random = new Random();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnNextClicked(object sender, EventArgs e)
	{
		List<String> phrases = new List<String>()
		{
			"donut hole", 
			"hot dog", 
			"point of view"
		};

		PhraseLabel.Text = phrases[random.Next(phrases.Count)];
		NextButton.Text = "Next";
	}
}

