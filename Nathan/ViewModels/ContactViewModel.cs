namespace Nathan.ViewModels
{
    using System.ComponentModel;

    public class ContactViewModel : BaseViewModel
    {
        public ContactViewModel()
        {
            CurrentTab = "Contact";
        }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Subject")]
        public string Subject { get; set; }

        [DisplayName("Message")]
        public string Message { get; set; }
    }
}