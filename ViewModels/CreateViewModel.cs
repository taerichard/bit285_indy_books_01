using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndyBooks.ViewModels
{
    public class CreateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public string Edition { get; set; }

        public decimal Price { get; set; }

        public string Year { get; set; }
    }
}
