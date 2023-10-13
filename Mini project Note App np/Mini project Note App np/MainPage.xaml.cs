using System.Collections.ObjectModel;

namespace Mini_project_Note_App_np;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Category> Categories { get; set; }
	public MainPage()
	{
		var hmmCategory = new Category()
		{
			Title = "hmm",
			Notes = new ObservableCollection<Note>()
			{
				new Note()
				{
					Title = "Navy Seals",
					Content = "What the fuck ..."
				}
			}
		};
		Categories = new ObservableCollection<Category>()
		{
            new Category() { Title = "School"},
			hmmCategory,
			new Category() { Title = "(ono)"},
			new Category() { Title = "Stuff I should remember"},
            new Category() { Title = "Workouts"}
        };

		InitializeComponent();
		BindingContext = this;
	}

	public void OnCategoryTapped(object sender, EventArgs e)
	{
		Navigation.PushAsync(new CategoryPage(Categories.Take(2).Last()));
	}
}

