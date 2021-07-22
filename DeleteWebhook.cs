using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WebhookSmasher
{
    internal class Delete
    {
        public static void DeleteWebhook(string webhook)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(webhook);
                byte[] bytes = Encoding.ASCII.GetBytes("{}");
                httpWebRequest.Method = "DELETE";
                httpWebRequest.UserAgent =
                    "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.3";
                httpWebRequest.ContentLength = bytes.Length;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                HttpWebResponse httpWebResponse2 = (HttpWebResponse) httpWebRequest.GetResponse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Successfully deleted.");
        }
    }
}