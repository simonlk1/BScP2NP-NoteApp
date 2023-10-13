using System.Collections.ObjectModel;

namespace Mini_project_Note_App_np;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Category> Categories { get; set; }
	public MainPage()
	{
		Categories = new ObservableCollection<Category>()
		{
            new Category() { Title = "Test Title"},
			new Category() { Title = "Test Title 2"},
			new Category() { Title = "Test Title3"}
        };

		InitializeComponent();
		BindingContext = this;
	}
}

