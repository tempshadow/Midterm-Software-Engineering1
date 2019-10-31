using System.Text;
using System;
using HtmlAgilityPack;
namespace Midterm_RNG
{
    public static class PingIP
    {
        public static string GetRng(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                return "";
            }
            HtmlWeb website = new HtmlWeb();
            HtmlDocument Doc = website.Load(address);
            return Doc.Text;
        }
    }
}