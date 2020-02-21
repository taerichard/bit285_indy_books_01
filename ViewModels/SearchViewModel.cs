using System;
using IndyBooks.Models; 

namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public Book book { get; set; }
        public String Title { get; set; }

        //TODO: Add properties needed for searching
        public String Author { get; set; }

        public string Edition { get; set; }
 
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string Year { get; set; }

    }
}
