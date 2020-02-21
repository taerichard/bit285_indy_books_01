using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndyBooks.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<SearchViewModel> BookListViewModel {get; set;}
        public SearchViewModel SingleBookViewModel { get; set; }

  

    }
}
