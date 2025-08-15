using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PrometheusService;
using Amazon.PrometheusService.Model;

namespace AWSSDKDocSamples.Amazon.PrometheusService.Generated
{
    class PrometheusServiceSamples : ISample
    {
        public void PrometheusServiceCreateScraper()
        {
            #region example-1

            var client = new AmazonPrometheusServiceClient();
            var response = client.CreateScraper(new CreateScraperRequest 
            {
                Alias = "alias",
                ClientToken = "token",
                Destination = new Destination { AmpConfiguration = new AmpConfiguration { WorkspaceArn = "arn:aws:aps:us-west-2:123456789012:workspace/ws-ogh2u499-ce12-hg89-v6c7-123412341234" } },
                ScrapeConfiguration = new ScrapeConfiguration { ConfigurationBlob = new MemoryStream(blob) },
                Source = new Source { EksConfiguration = new EksConfiguration {
                    ClusterArn = "arn:aws:eks:us-west-2:123456789012:cluster/example",
                    SecurityGroupIds = new List<string> {
                        "sg-abc123"
                    },
                    SubnetIds = new List<string> {
                        "subnet-abc123"
                    }
                } },
                Tags = new Dictionary<string, string> {
                    { "exampleTag", "exampleValue" }
                }
            });

            string arn = response.Arn;
            string scraperId = response.ScraperId;
            ScraperStatus status = response.Status;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void PrometheusServiceDeleteScraper()
        {
            #region example-1

            var client = new AmazonPrometheusServiceClient();
            var response = client.DeleteScraper(new DeleteScraperRequest 
            {
                ClientToken = "token",
                ScraperId = "scraper-123"
            });

            string scraperId = response.ScraperId;
            ScraperStatus status = response.Status;

            #endregion
        }

        public void PrometheusServiceDescribeScraper()
        {
            #region example-1

            var client = new AmazonPrometheusServiceClient();
            var response = client.DescribeScraper(new DescribeScraperRequest 
            {
                ScraperId = "scraper-123"
            });

            ScraperDescription scraper = response.Scraper;

            #endregion
        }

        public void PrometheusServiceGetDefaultScraperConfiguration()
        {
            #region example-1

            var client = new AmazonPrometheusServiceClient();
            var response = client.GetDefaultScraperConfiguration(new GetDefaultScraperConfigurationRequest 
            {
            });

            MemoryStream configuration = response.Configuration;

            #endregion
        }

        public void PrometheusServiceListScrapers()
        {
            #region example-1

            var client = new AmazonPrometheusServiceClient();
            var response = client.ListScrapers(new ListScrapersRequest 
            {
                MaxResults = 2,
                NextToken = "previouslyGeneratedToken"
            });

            List<ScraperSummary> scrapers = response.Scrapers;

            #endregion
        }

        public void PrometheusServiceListScrapers()
        {
            #region example-2

            var client = new AmazonPrometheusServiceClient();
            var response = client.ListScrapers(new ListScrapersRequest 
            {
                Filters = new Dictionary<string, List<string>> {
                    { "alias", new List<string> {
                        "alias1"
                    } },
                    { "sourceArn", new List<string> {
                        "arn:aws:eks:us-west-2:123456789012:cluster/example1"
                    } },
                    { "status", new List<string> {
                        "ACTIVE"
                    } }
                }
            });

            List<ScraperSummary> scrapers = response.Scrapers;

            #endregion
        }

        public void PrometheusServiceUpdateScraper()
        {
            #region example-1

            var client = new AmazonPrometheusServiceClient();
            var response = client.UpdateScraper(new UpdateScraperRequest 
            {
                Alias = "alias-update",
                ClientToken = "token",
                Destination = new Destination { AmpConfiguration = new AmpConfiguration { WorkspaceArn = "arn:aws:aps:us-west-2:123456789012:workspace/ws-ogh2u499-ce12-hg89-v6c7-123412341234-update" } },
                ScrapeConfiguration = new ScrapeConfiguration { ConfigurationBlob = new MemoryStream(blob-update) },
                ScraperId = "scraper-123"
            });

            string arn = response.Arn;
            string scraperId = response.ScraperId;
            ScraperStatus status = response.Status;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}