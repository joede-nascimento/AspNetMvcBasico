using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Site01.Models;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0} </br> E-mail: {1} </br> Assunto: {2} </br> Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
            
            //Configurar Servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortalSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);


            //Mensagem de Email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("joedeferreira2@gmail.com");
            mensagem.To.Add("joedeferreira2@gmail.com");
            mensagem.Subject = "formulario de contato";
            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulario de contato</h1> </br>" +conteudo;

            smtp.Send(mensagem);

        }
    }
}
