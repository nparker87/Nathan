namespace Nathan.ViewModels
{
    using System.ComponentModel;

    public class ContactViewModel : BaseViewModel
    {
        public ContactViewModel()
        {
            CurrentTab = "Contact";
        }

        [DisplayName("First name:")]
        public string FirstName { get; set; }

        [DisplayName("Last name:")]
        public string LastName { get; set; }

        [DisplayName("Email:")]
        public string Email { get; set; }

        [DisplayName("Message:")]
        public string Message { get; set; }
    }
}