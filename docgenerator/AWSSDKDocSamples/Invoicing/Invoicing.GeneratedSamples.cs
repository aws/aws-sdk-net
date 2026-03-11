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

        public void InvoicingCreateProcurementPortalPreference()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.CreateProcurementPortalPreference(new CreateProcurementPortalPreferenceRequest 
            {
                BuyerDomain = "NetworkID",
                BuyerIdentifier = "BuyerId_1",
                ClientToken = "e362c68e-4e74-48d7-9228-0bc5aa447b42",
                Contacts = new List<Contact> {
                    new Contact {
                        Email = "example-placeholder@amazon.com",
                        Name = "John Doe"
                    }
                },
                EinvoiceDeliveryEnabled = true,
                EinvoiceDeliveryPreference = new EinvoiceDeliveryPreference {
                    ConnectionTestingMethod = "PROD_ENV_DOLLAR_TEST",
                    EinvoiceDeliveryActivationDate = DateTime.UtcNow,
                    EinvoiceDeliveryAttachmentTypes = new List<string> {
                        "INVOICE_PDF"
                    },
                    EinvoiceDeliveryDocumentTypes = new List<string> {
                        "AWS_CLOUD_INVOICE"
                    },
                    Protocol = "CXML",
                    PurchaseOrderDataSources = new List<PurchaseOrderDataSource> {
                        new PurchaseOrderDataSource {
                            EinvoiceDeliveryDocumentType = "AWS_CLOUD_INVOICE",
                            PurchaseOrderDataSourceType = "ASSOCIATED_PURCHASE_ORDER_REQUIRED"
                        }
                    }
                },
                ProcurementPortalInstanceEndpoint = "https://www.placeholder-domain.test",
                ProcurementPortalName = "COUPA",
                ProcurementPortalSharedSecret = "Coupa_Secret",
                PurchaseOrderRetrievalEnabled = true,
                ResourceTags = new List<ResourceTag> {
                    new ResourceTag {
                        Key = "testKey",
                        Value = "testValue"
                    }
                },
                Selector = new ProcurementPortalPreferenceSelector {
                    InvoiceUnitArns = new List<string> {
                        "arn:aws:invoicing::111111111111:invoice-unit/12345678",
                        "arn:aws:invoicing::111111111111:invoice-unit/12345679"
                    },
                    SellerOfRecords = new List<string> {
                        "AWS_INC",
                        "AWS_EUROPE"
                    }
                },
                SupplierDomain = "NetworkID",
                SupplierIdentifier = "SupplierId_1",
                TestEnvPreference = new TestEnvPreferenceInput {
                    BuyerDomain = "NetworkID",
                    BuyerIdentifier = "BuyerId_1_Test",
                    ProcurementPortalInstanceEndpoint = "https://www.placeholder-domain.test",
                    ProcurementPortalSharedSecret = "Coupa_Secret_test",
                    SupplierDomain = "NetworkID",
                    SupplierIdentifier = "SupplierId_1_Test"
                }
            });

            string procurementPortalPreferenceArn = response.ProcurementPortalPreferenceArn;

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

        public void InvoicingDeleteProcurementPortalPreference()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.DeleteProcurementPortalPreference(new DeleteProcurementPortalPreferenceRequest 
            {
                ProcurementPortalPreferenceArn = "arn:aws:invoicing::111111111111:procurement-portal-preference/f71dd02e-f855-4b13-b793-0fd25c0b3ecd"
            });

            string procurementPortalPreferenceArn = response.ProcurementPortalPreferenceArn;

            #endregion
        }

        public void InvoicingGetInvoicePDF()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.GetInvoicePDF(new GetInvoicePDFRequest 
            {
                InvoiceId = "abc123"
            });

            InvoicePDF invoicePDF = response.InvoicePDF;

            #endregion
        }

        public void InvoicingGetInvoicePDF()
        {
            #region example-2

            var client = new AmazonInvoicingClient();
            var response = client.GetInvoicePDF(new GetInvoicePDFRequest 
            {
                InvoiceId = "abc123"
            });

            InvoicePDF invoicePDF = response.InvoicePDF;

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

        public void InvoicingGetProcurementPortalPreference()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.GetProcurementPortalPreference(new GetProcurementPortalPreferenceRequest 
            {
                ProcurementPortalPreferenceArn = "arn:aws:invoicing::111111111111:procurement-portal-preference/a34fd666-7810-4414-9360-aaa4bcab0abd"
            });

            ProcurementPortalPreference procurementPortalPreference = response.ProcurementPortalPreference;

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

        public void InvoicingListProcurementPortalPreferences()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.ListProcurementPortalPreferences(new ListProcurementPortalPreferencesRequest 
            {
                MaxResults = 2
            });

            string nextToken = response.NextToken;
            List<ProcurementPortalPreferenceSummary> procurementPortalPreferences = response.ProcurementPortalPreferences;

            #endregion
        }

        public void InvoicingListProcurementPortalPreferences()
        {
            #region example-2

            var client = new AmazonInvoicingClient();
            var response = client.ListProcurementPortalPreferences(new ListProcurementPortalPreferencesRequest 
            {
                MaxResults = 2,
                NextToken = "AAQA-EFRSURBSGpkVFU5MVNUVWNXTzNoUEptWEFGcEt0QzBBeHZaZmRUU2w3L0hRQmdDeEx3R0NuSnF2NjM5NGNmM1I5KzNIQzNnT0FBQUFmakI4QmdrcWhraUc5dzBCQndhZ2J6QnRBZ0VBTUdnR0NTcUdTSWIzRFFFSEFUQWVCZ2xnaGtnQlpRTUVBUzR3RVFRTVhPSnhEQ04rWk1idnAyb1RBZ0VRZ0RzbFJBeFlXMk9RRGFtTU8vdFc0MUJlTFFNU2hPR1E5bDM3MHcyS05mSjIzbU93MG1aVXk1MzBiWWVsZ3FaZzhjMndhTjZtNzNYTWd3bnpsZz09E8JRNUKK1r2-b9X8Qd1RAOSKHZOCy-UCpOQjJdSfZHcUefTH0YmlIW8ykllegYUWB1D1NjDjC3u2z2e4cLBTmQhrQewSBW-I_i8okXup9RWN60eMOnB6dl5jUiinJ-FjY_jGjbOkiWuJhXteDKP16RfVRW7mxp2-v1-B8gPPxGLolXHBHrb8gt18P8eWs8RcvRRmmbGUy5qa6nFH5WiCq9Bx2fTUTy9Iz_xZooNuiqC6y119EGQqJ9WsWsIUa8MbWHFXtn9-Uriz7osYocbFm1Evv_NCn3YK-wFy9rUlUskcM2n9AqvPYhOyf0reV7E8cErZFR_Ev8l008QcxQfaqK19-gKR9clddwoDzMVfVuyiW3vbzUXz7fzQLr-UMLCGdE3yHf1oz2SEbcxhHZ2eh7-9wEYDv0v92wXg7m7xaYvaKuVBPKqBaq66GdpS1HTfakkjRGvsoBStXWVgPahISglPO__-Ym5NnXOw2wENBVXZ7RsVe6nJ1X15bB1RDkqLV8xJD0L83snuCEBtM9pyUUQOPvfGHzC4yRusMgBav_y1kq0wjqsbJV5EhHV_SIwf-WZa_A=="
            });

            List<ProcurementPortalPreferenceSummary> procurementPortalPreferences = response.ProcurementPortalPreferences;

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

        public void InvoicingPutProcurementPortalPreference()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.PutProcurementPortalPreference(new PutProcurementPortalPreferenceRequest 
            {
                Contacts = new List<Contact> {
                    new Contact {
                        Email = "example-placeholder2@amazon.com",
                        Name = "John Doe2"
                    }
                },
                EinvoiceDeliveryEnabled = true,
                EinvoiceDeliveryPreference = new EinvoiceDeliveryPreference {
                    ConnectionTestingMethod = "PROD_ENV_DOLLAR_TEST",
                    EinvoiceDeliveryActivationDate = DateTime.UtcNow,
                    EinvoiceDeliveryAttachmentTypes = new List<string> {
                        "INVOICE_PDF"
                    },
                    EinvoiceDeliveryDocumentTypes = new List<string> {
                        "AWS_CLOUD_INVOICE"
                    },
                    Protocol = "CXML",
                    PurchaseOrderDataSources = new List<PurchaseOrderDataSource> {
                        new PurchaseOrderDataSource {
                            EinvoiceDeliveryDocumentType = "AWS_CLOUD_INVOICE",
                            PurchaseOrderDataSourceType = "ASSOCIATED_PURCHASE_ORDER_REQUIRED"
                        }
                    }
                },
                ProcurementPortalInstanceEndpoint = "https://www.placeholder-domain.test",
                ProcurementPortalPreferenceArn = "arn:aws:invoicing::111111111111:procurement-portal-preference/f71dd02e-f855-4b13-b793-0fd25c0b3ecd",
                ProcurementPortalSharedSecret = "Coupa_Secret_2",
                PurchaseOrderRetrievalEnabled = true,
                Selector = new ProcurementPortalPreferenceSelector {
                    InvoiceUnitArns = new List<string> {
                        "arn:aws:invoicing::111111111111:invoice-unit/12345679"
                    },
                    SellerOfRecords = new List<string> {
                        "AWS_INC"
                    }
                },
                TestEnvPreference = new TestEnvPreferenceInput {
                    BuyerDomain = "NetworkID",
                    BuyerIdentifier = "BuyerId_1_Test",
                    ProcurementPortalInstanceEndpoint = "https://www.placeholder-domain.test",
                    ProcurementPortalSharedSecret = "Coupa_Secret_test_2",
                    SupplierDomain = "NetworkID",
                    SupplierIdentifier = "SupplierId_1_Test"
                }
            });

            string procurementPortalPreferenceArn = response.ProcurementPortalPreferenceArn;

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

        public void InvoicingUpdateProcurementPortalPreferenceStatus()
        {
            #region example-1

            var client = new AmazonInvoicingClient();
            var response = client.UpdateProcurementPortalPreferenceStatus(new UpdateProcurementPortalPreferenceStatusRequest 
            {
                EinvoiceDeliveryPreferenceStatus = "SUSPENDED",
                EinvoiceDeliveryPreferenceStatusReason = "suspended example reason",
                ProcurementPortalPreferenceArn = "arn:aws:invoicing::111111111111:procurement-portal-preference/f71dd02e-f855-4b13-b793-0fd25c0b3ecd",
                PurchaseOrderRetrievalPreferenceStatus = "SUSPENDED",
                PurchaseOrderRetrievalPreferenceStatusReason = "suspended example reason"
            });

            string procurementPortalPreferenceArn = response.ProcurementPortalPreferenceArn;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}