using RazorEngine.Templating;
using System;
using System.IO;
using System.Net.Mail;

namespace EmailViews
{
    class Program
    {
        static readonly string TemplateFolderPath =
         Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmailTemplates");

        static void Main(string[] args)
        {
            var model = new Person() { Name = "Joe Doe" };

            var emailTemplatePath = Path.Combine(TemplateFolderPath, "InviteEmailTemplate.cshtml");
            var templateService = new TemplateService();
            var emailHtmlBody = templateService.Parse(File.ReadAllText(emailTemplatePath), model, null, null);

            Console.WriteLine(emailHtmlBody);

            Console.ReadLine();

        }
    }
}
