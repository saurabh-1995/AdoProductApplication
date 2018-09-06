namespace AdoProductApplication.Models
{
    public class SearchViewModel
    {
        public string SearchText { set; get; }
        public int ProductCategoryById { set; get; }
        public int MinRange { set; get; }
        public int MaxRange { set; get; }
    }
}
