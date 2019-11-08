using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace libro
{
    class Correo
    {
        

        public void enviarCorreo(string emisor, string password,string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
                MailMessage correos = new MailMessage(emisor, destinatario, asunto, mensaje);

                if (ruta.Equals("") == false)
                {
                    correos.Attachments.Add(new Attachment(ruta));
                }
                correos.IsBodyHtml = true;
                SmtpClient oSmtpCliente = new SmtpClient("smtp.gmail.com");
                oSmtpCliente.EnableSsl = true;
                oSmtpCliente.UseDefaultCredentials = false;
                oSmtpCliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                oSmtpCliente.Host = "smtp.gmail.com";
                oSmtpCliente.Port = 587;
                oSmtpCliente.Credentials = new System.Net.NetworkCredential(emisor, password);

                oSmtpCliente.Send(correos);

                oSmtpCliente.Dispose();




                MessageBox.Show("El mensaje fue enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //==========================================================================================
            //System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();

            //mail.From = new MailAddress(emisor);

            //mail.To.Add(destinatario);
            //mail.Subject = asunto;
            //mail.Body = mensaje;

            //SmtpClient smtp = new SmtpClient();

            //smtp.Host = "smtp.gmail.com";
            //smtp.Port = 587;//25; //465; //587
            //smtp.Credentials = new NetworkCredential(emisor, password);
            //smtp.EnableSsl = true;
            //try
            //{
            //    smtp.Send(mail);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    smtp.Dispose();
            //}
        }
        
    }
}
