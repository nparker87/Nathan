namespace Nathan.ViewModels
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ContactViewModel : BaseViewModel
    {
        public ContactViewModel()
        {
            CurrentTab = "Contact";
        }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }

        [DisplayName("Subject")]
        public string Subject { get; set; }

        [DisplayName("Message")]
        [Required(ErrorMessage = "Message Required")]
        public string Message { get; set; }
    }
}