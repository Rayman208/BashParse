using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HtmlAgilityPack;
using System.Net;

namespace bashParse
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlDocument doc = new HtmlDocument();

            //WebClient wc = new WebClient();
            //string code = wc.DownloadString("http://bash.im/random");

            doc.LoadHtml(new WebClient().DownloadString("http://bash.im/random"));

            HtmlNodeCollection result = doc.DocumentNode.SelectNodes("//div[@class='text']");

            foreach (HtmlNode node in result)
            {
                Console.WriteLine(node.InnerText);
                Console.WriteLine("*************");
            }

            Console.ReadKey();
        }
    }
}