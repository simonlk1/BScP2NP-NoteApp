using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project_Note_App_np
{
    public class Category
    {
        public string Title { get; set; }
        public IList<Note> Notes { get; set; }
    }
}
