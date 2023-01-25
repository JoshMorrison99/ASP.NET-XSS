using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class SearchModel : PageModel
    {

        public string SearchResult = "Test";

        public void OnGet()
        {

        }

        public void OnPost(string query)
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
            SearchResult = query;
        }
    }
}
