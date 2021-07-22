using System.Collections.Specialized;
using System.Net;

namespace WebhookSmasher
{
    internal class Spam
    {
        public static void SpamWebhook(string Webhook, string Message, string SenderName, string ProfilePicture)
        {
            NameValueCollection webhookInfo = new NameValueCollection();
            webhookInfo.Add("username", SenderName);
            webhookInfo.Add("avatar_url", ProfilePicture);
            webhookInfo.Add("content", Message);
            new WebClient().UploadValues(Webhook, webhookInfo);
        }
    }
}