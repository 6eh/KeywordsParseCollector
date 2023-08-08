using HtmlAgilityPack;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KeywordsParseCollector.Models
{
    internal class Parser
    {
        internal async Task<DataTableRepository> Start(List<string> htmls)
        {
            DataTableRepository dataTableRepository = new DataTableRepository();

            int downNormalAds = 0;
            int downFakeAds = 0;

            int i = 0;
            foreach (var html in htmls)
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                HtmlNodeCollection span = doc.DocumentNode.SelectNodes("//span[contains(@class, 'p_ si29 span')]");

                if (span != null)
                {
                    
                    foreach (var node in span)
                    {
                        // Top block
                        if (i == 0)
                        {
                            if (node.InnerText.ToLower().Contains("search") ||
                                node.InnerText.ToLower().Contains("find") ||
                                node.InnerText.ToLower().Contains("discover"))
                            {
                                dataTableRepository.TopFakeAdsInPageCount++;
                            }
                            else
                            {
                                dataTableRepository.TopNormalAdsInPageCount++;
                            }                            
                        }

                        // Down block
                        if (i == 1)
                        {
                            if (node.InnerText.ToLower().Contains("search") ||
                                node.InnerText.ToLower().Contains("find") ||
                                node.InnerText.ToLower().Contains("discover"))
                            {                                
                                downFakeAds++;
                            }
                            else
                            {
                                downNormalAds++;
                            }
                        }                        
                    }                                     
                }
                i++;
            }

            dataTableRepository.TopAdsInPageCount =
                            dataTableRepository.TopNormalAdsInPageCount +
                            dataTableRepository.TopFakeAdsInPageCount;

            dataTableRepository.NormalAdsInPageCount =
                dataTableRepository.TopNormalAdsInPageCount + downNormalAds;

            dataTableRepository.FakeAdsInPageCount =                
                dataTableRepository.TopFakeAdsInPageCount + downFakeAds;

            dataTableRepository.AllAdsInPageCount =
                dataTableRepository.NormalAdsInPageCount +
                dataTableRepository.FakeAdsInPageCount;

            await Task.Delay(500);

            return dataTableRepository;            
        }
    }
}
