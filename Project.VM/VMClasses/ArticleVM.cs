using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.VM.VMClasses
{
    public class ArticleVM
    {
        public List<Article> Articles { get; set; }
        public Article Article { get; set; }
        public Author Author { get; set; }
        public Editor Editor { get; set; }

      
    }
}
