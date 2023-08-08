using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace KeywordsParseCollector.Models
{
    internal static class SitesList
    {
        internal static List<string> GetList()
        {
            List<string> urls = new List<string>()
            {
                "https://trimwork.co/Search?query=",
                "https://infotable.co/Search?query=",
                "https://prdctfindr.com/Search?query=",
                "https://info.catchanswers.com/serp?q=",
                "https://info.fastanswersonline.com/serp?q=",
                "https://info.makeanswer.com/serp?q=",
                "https://info.topicsmedia.com/serp?q=",
                "https://info.askfest.com/serp?q=",
                "https://info.freegetanswer.com/serp?q=",
                "https://info.groovyanswers.com/serp?q="
            };

            return urls;
        }

        private static List<string> GetListOld()
        {
            List<string> urls = new List<string>()
            {
                "https://trimwork.co",
                "https://infotable.co",
                "https://prdctfindr.com",
                "https://catchanswers.com",
                "https://fastanswersonline.com",
                "https://makeanswer.com",
                "https://topicsmedia.com",
                "https://askfest.com",
                "https://freegetanswer.com",
                "https://groovyanswers.com"
            };

            return urls;
        }

    }
}


