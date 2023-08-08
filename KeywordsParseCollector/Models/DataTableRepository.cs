using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsParseCollector.Models
{
    internal class DataTableRepository
    {
        // Number
        //public long Id { get; set; }

        // Keyword
        public string Keyword { get; set; }

        // Date Time
        public DateTime Date { get; set; }

        // Number of the ads in the page
        public int AllAdsInPageCount { get; set; }

        // Number of the Normal ads in the page
        public int NormalAdsInPageCount { get; set; }

        // Number of the Fake ads in the page
        public int FakeAdsInPageCount { get; set; }

        // Number of the ads on the top of the page
        public int TopAdsInPageCount { get; set; }

        // Number of the Normal ads on the top of the page
        public int TopNormalAdsInPageCount { get; set; }

        // Number of the Fake ads on the top of the page
        public int TopFakeAdsInPageCount { get; set; }

        public string Url { get; set; }
    }
}
