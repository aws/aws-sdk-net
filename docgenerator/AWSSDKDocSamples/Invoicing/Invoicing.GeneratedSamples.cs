using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Invoicing;
using Amazon.Invoicing.Model;

namespace AWSSDKDocSamples.Amazon.Invoicing.Generated
{
    class InvoicingSamples : ISample
    {
        public void InvoicingBatchGetInvoiceProfile()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.BatchGetInvoiceProfile(new BatchGetInvoiceProfileRequest 
            {
                AccountIds = new List<string> {
                    "111111111111"
                }
            });

            List<InvoiceProfile> profiles = response.Profiles;

            #endregion
        }

        public void InvoicingCreateInvoiceUnit()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.CreateInvoiceUnit(new CreateInvoiceUnitRequest 
            {
                Description = "Example Invoice Unit Description",
                InvoiceReceiver = "111111111111",
                Name = "Example Invoice Unit",
                ResourceTags = new List<ResourceTag> {
                    new ResourceTag {
                        Key = "TagKey",
                        Value = "TagValue"
                    }
                },
                Rule = new InvoiceUnitRule { LinkedAccounts = new List<string> {
                    "222222222222"
                } },
                TaxInheritanceDisabled = false
            });

            string invoiceUnitArn = response.InvoiceUnitArn;

            #endregion
        }

        public void InvoicingDeleteInvoiceUnit()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.DeleteInvoiceUnit(new DeleteInvoiceUnitRequest 
            {
                InvoiceUnitArn = "arn:aws:invoicing::000000000000:invoice-unit/12345678"
            });

            string invoiceUnitArn = response.InvoiceUnitArn;

            #endregion
        }

        public void InvoicingGetInvoiceUnit()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.GetInvoiceUnit(new GetInvoiceUnitRequest 
            {
                InvoiceUnitArn = "arn:aws:invoicing::000000000000:invoice-unit/12345678"
            });

            string description = response.Description;
            string invoiceReceiver = response.InvoiceReceiver;
            string invoiceUnitArn = response.InvoiceUnitArn;
            DateTime lastModified = response.LastModified;
            string name = response.Name;
            InvoiceUnitRule rule = response.Rule;
            bool taxInheritanceDisabled = response.TaxInheritanceDisabled;

            #endregion
        }

        public void InvoicingGetInvoiceUnit()
        {
            #region example-2

            var client = new AmazonInvoicingClient();
            var response = client.GetInvoiceUnit(new GetInvoiceUnitRequest 
            {
                AsOf = DateTime.UtcNow,
                InvoiceUnitArn = "arn:aws:invoicing::000000000000:invoice-unit/87654321"
            });

            string description = response.Description;
            string invoiceReceiver = response.InvoiceReceiver;
            string invoiceUnitArn = response.InvoiceUnitArn;
            DateTime lastModified = response.LastModified;
            string name = response.Name;
            InvoiceUnitRule rule = response.Rule;
            bool taxInheritanceDisabled = response.TaxInheritanceDisabled;

            #endregion
        }

        public void InvoicingListInvoiceSummaries()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceSummaries(new ListInvoiceSummariesRequest 
            {
                Selector = new InvoiceSummariesSelector {
                    ResourceType = "INVOICE_ID",
                    Value = "1111111111"
                }
            });

            List<InvoiceSummary> invoiceSummaries = response.InvoiceSummaries;

            #endregion
        }

        public void InvoicingListInvoiceSummaries()
        {
            #region example-2

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceSummaries(new ListInvoiceSummariesRequest 
            {
                Filter = new InvoiceSummariesFilter { BillingPeriod = new BillingPeriod {
                    Month = 1,
                    Year = 2025
                } },
                Selector = new InvoiceSummariesSelector {
                    ResourceType = "ACCOUNT_ID",
                    Value = "111111111111"
                }
            });

            List<InvoiceSummary> invoiceSummaries = response.InvoiceSummaries;

            #endregion
        }

        public void InvoicingListInvoiceSummaries()
        {
            #region example-3

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceSummaries(new ListInvoiceSummariesRequest 
            {
                Filter = new InvoiceSummariesFilter { TimeInterval = new DateInterval {
                    EndDate = DateTime.UtcNow,
                    StartDate = DateTime.UtcNow
                } },
                Selector = new InvoiceSummariesSelector {
                    ResourceType = "ACCOUNT_ID",
                    Value = "111111111111"
                }
            });

            List<InvoiceSummary> invoiceSummaries = response.InvoiceSummaries;

            #endregion
        }

        public void InvoicingListInvoiceSummaries()
        {
            #region example-4

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceSummaries(new ListInvoiceSummariesRequest 
            {
                Filter = new InvoiceSummariesFilter { BillingPeriod = new BillingPeriod {
                    Month = 1,
                    Year = 2025
                } },
                MaxResults = 1,
                Selector = new InvoiceSummariesSelector {
                    ResourceType = "ACCOUNT_ID",
                    Value = "111111111111"
                }
            });

            List<InvoiceSummary> invoiceSummaries = response.InvoiceSummaries;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InvoicingListInvoiceSummaries()
        {
            #region example-5

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceSummaries(new ListInvoiceSummariesRequest 
            {
                Filter = new InvoiceSummariesFilter { BillingPeriod = new BillingPeriod {
                    Month = 1,
                    Year = 2025
                } },
                NextToken = "abcde12345",
                Selector = new InvoiceSummariesSelector {
                    ResourceType = "ACCOUNT_ID",
                    Value = "111111111111"
                }
            });

            List<InvoiceSummary> invoiceSummaries = response.InvoiceSummaries;

            #endregion
        }

        public void InvoicingListInvoiceUnits()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceUnits(new ListInvoiceUnitsRequest 
            {
            });

            List<InvoiceUnit> invoiceUnits = response.InvoiceUnits;

            #endregion
        }

        public void InvoicingListInvoiceUnits()
        {
            #region example-2

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceUnits(new ListInvoiceUnitsRequest 
            {
                AsOf = DateTime.UtcNow,
                Filters = new Filters { InvoiceReceivers = new List<string> {
                    "333333333333"
                } }
            });

            List<InvoiceUnit> invoiceUnits = response.InvoiceUnits;

            #endregion
        }

        public void InvoicingListInvoiceUnits()
        {
            #region example-3

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceUnits(new ListInvoiceUnitsRequest 
            {
                MaxResults = 1
            });

            List<InvoiceUnit> invoiceUnits = response.InvoiceUnits;
            string nextToken = response.NextToken;

            #endregion
        }

        public void InvoicingListInvoiceUnits()
        {
            #region example-4

            var client = new AmazonInvoicingClient();
            var response = client.ListInvoiceUnits(new ListInvoiceUnitsRequest 
            {
                MaxResults = 1,
                NextToken = "nextTokenExample"
            });

            List<InvoiceUnit> invoiceUnits = response.InvoiceUnits;

            #endregion
        }

        public void InvoicingListTagsForResource()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:invoicing::000000000000:invoice-unit/12345678"
            });

            List<ResourceTag> resourceTags = response.ResourceTags;

            #endregion
        }

        public void InvoicingTagResource()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:invoicing::000000000000:invoice-unit/12345678",
                ResourceTags = new List<ResourceTag> {
                    new ResourceTag {
                        Key = "TagKey",
                        Value = "TagValue"
                    }
                }
            });


            #endregion
        }

        public void InvoicingUntagResource()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:invoicing::000000000000:invoice-unit/12345678",
                ResourceTagKeys = new List<string> {
                    "TagKey"
                }
            });


            #endregion
        }

        public void InvoicingUpdateInvoiceUnit()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.UpdateInvoiceUnit(new UpdateInvoiceUnitRequest 
            {
                Description = "Updated IU description",
                InvoiceUnitArn = "arn:aws:invoicing::000000000000:invoice-unit/12345678",
                Rule = new InvoiceUnitRule { LinkedAccounts = new List<string> {
                    "111111111111",
                    "222222222222"
                } },
                TaxInheritanceDisabled = false
            });

            string invoiceUnitArn = response.InvoiceUnitArn;

            #endregion
        }

        public void InvoicingUpdateInvoiceUnit()
        {
            #region example-2

            var client = new AmazonInvoicingClient();
            var response = client.UpdateInvoiceUnit(new UpdateInvoiceUnitRequest 
            {
                Description = "Updated IU description. All other fields remain unchanged",
                InvoiceUnitArn = "arn:aws:invoicing::000000000000:invoice-unit/12345678"
            });

            string invoiceUnitArn = response.InvoiceUnitArn;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}