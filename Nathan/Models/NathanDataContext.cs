namespace Nathan.Models
{
    using System.Linq;

    public partial class NathanDataContext
    {
        public void Save()
        {
            SubmitChanges();
        }
    }
}