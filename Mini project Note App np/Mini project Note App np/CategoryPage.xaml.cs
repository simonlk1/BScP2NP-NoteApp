using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project_Note_App_np
{
    public partial class CategoryPage : ContentPage
    {
        Category Category { get; set; }

        public CategoryPage(Category category)
        {
            this.Category = category;
            InitializeComponent();
        }
    }
}
