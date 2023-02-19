using System;
using System.Net;
using System.Net.Mail;

namespace CourseProject
{
    class SendEmail
    {
        const string mailFrom = "clothingshopallinone@gmail.com";
        const string password = "clothingShop2020";

        public static void ConfirmDelivery(string userMail, string confirmMessage)
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(mailFrom, password),
            };

            MailMessage message = new MailMessage(mailFrom, userMail, "Підтвердження успішного замовлення", confirmMessage);

            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw new Exception("Mail.Send: " + ex.Message);
            }
        }
    }
}
