namespace Nathan.ViewModels
{
    using Models;

    public class BaseViewModel
    {
        // private readonly NathanDataContext _model = new NathanDataContext();

        public BaseViewModel()
        {
            CurrentTab = "Home";
        }

        public string CurrentTab { get; set; }
    }
}