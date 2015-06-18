namespace Nathan.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Mail;

    public class Emailer
    {
        /// <summary> Sends an email </summary>
        /// <param name="toAddress"></param>
        /// <param name="fromAddress"></param>
        /// <param name="fromName"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="cc">List of type EmailList</param>
        /// <param name="bcc">List of type EmailList</param>
        public static void SendMsg(string from, string fromName, string subject, string body, EmailList cc, EmailList bcc)
        {
            var fromAddress = new MailAddress(from, fromName);

            var msg = new MailMessage
            {
                To = { new MailAddress("wshcaps1987@gmail.com") },
                Body = body,
                IsBodyHtml = true,
                Priority = MailPriority.Normal,
                Subject = subject
            };

            // Add any cc'd
            if (cc != null)
                foreach (var email in cc.Emails)
                    if (IsValidEmail(email))
                        msg.CC.Add(new MailAddress(cc.ToString()));

            // Add any bcc'd
            if (bcc != null)
                foreach (var email in bcc.Emails)
                    if (IsValidEmail(email))
                        msg.CC.Add(new MailAddress(bcc.ToString()));

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("wshcaps1987@gmail.com", "T3rryboo!")
            };
            smtp.Send(msg);
        }

        public static bool IsValidEmail(string email)
        {
            if (String.IsNullOrWhiteSpace(email))
                return false;

            // checks to make sure e-mail is valid
            var reg = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b");
            return reg.IsMatch(email);
        }

        /// <summary> Used for a list of cc or bcc emails </summary>
        public class EmailList
        {
            public List<string> Emails { get; set; }
        }
    }
}