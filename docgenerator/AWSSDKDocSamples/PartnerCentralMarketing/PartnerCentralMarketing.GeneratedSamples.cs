using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PartnerCentralMarketing;
using Amazon.PartnerCentralMarketing.Model;

namespace AWSSDKDocSamples.Amazon.PartnerCentralMarketing.Generated
{
    class PartnerCentralMarketingSamples : ISample
    {
        public void PartnerCentralMarketingBatchCreateCampaignAsset()
        {
            #region BatchCreateCampaignAsset-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.BatchCreateCampaignAsset(new BatchCreateCampaignAssetRequest
            {
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                Entries = new List<BatchCreateCampaignAssetEntry> {
                    new BatchCreateCampaignAssetEntry { SourceAssetTemplateIdentifier = "ta000000email" },
                    new BatchCreateCampaignAssetEntry { SourceAssetTemplateIdentifier = "ta0000000lp01" }
                }
            });

            List<BatchCreateCampaignAssetError> errors = response.Errors;
            List<BatchCreateCampaignAssetResult> successful = response.Successful;

            #endregion
        }

        public void PartnerCentralMarketingBatchCreateCampaignAsset()
        {
            #region BatchCreateCampaignAsset-2

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.BatchCreateCampaignAsset(new BatchCreateCampaignAssetRequest
            {
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                Entries = new List<BatchCreateCampaignAssetEntry> {
                    new BatchCreateCampaignAssetEntry { SourceAssetTemplateIdentifier = "ta000000email" },
                    new BatchCreateCampaignAssetEntry { SourceAssetTemplateIdentifier = "ta00000absent" }
                }
            });

            List<BatchCreateCampaignAssetError> errors = response.Errors;
            List<BatchCreateCampaignAssetResult> successful = response.Successful;

            #endregion
        }

        public void PartnerCentralMarketingCreateCampaign()
        {
            #region CreateCampaign-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.CreateCampaign(new CreateCampaignRequest
            {
                CampaignTemplateId = "tmpl-a1b2c3d4e5f6g",
                Catalog = "AWS",
                EndOn = "2026-12-31",
                Name = "Q4 GenAI Campaign",
                StartOn = "2026-11-01",
                TotalBudget = new MonetaryValue {
                    Amount = "25000.00",
                    CurrencyCode = "USD"
                }
            });

            string arn = response.Arn;
            string id = response.Id;

            #endregion
        }

        public void PartnerCentralMarketingDeleteCampaign()
        {
            #region DeleteCampaign-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.DeleteCampaign(new DeleteCampaignRequest
            {
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });


            #endregion
        }

        public void PartnerCentralMarketingDeleteCampaignAsset()
        {
            #region DeleteCampaignAsset-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.DeleteCampaignAsset(new DeleteCampaignAssetRequest
            {
                CampaignAssetIdentifier = "ast-4b81e0c9f2a7b",
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });


            #endregion
        }

        public void PartnerCentralMarketingGetCampaign()
        {
            #region GetCampaign-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.GetCampaign(new GetCampaignRequest
            {
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });

            Campaign campaign = response.Campaign;

            #endregion
        }

        public void PartnerCentralMarketingGetCampaignAsset()
        {
            #region GetCampaignAsset-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.GetCampaignAsset(new GetCampaignAssetRequest
            {
                CampaignAssetIdentifier = "ast-4b81e0c9f2a7b",
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });

            CampaignAsset asset = response.Asset;

            #endregion
        }

        public void PartnerCentralMarketingGetCampaignAssetActivationTask()
        {
            #region GetCampaignAssetActivationTask-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.GetCampaignAssetActivationTask(new GetCampaignAssetActivationTaskRequest
            {
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });

            List<CampaignAssetActivationOutcome> assets = response.Assets;
            string campaignId = response.CampaignId;
            DateTime? endedAt = response.EndedAt;
            DateTime? startedAt = response.StartedAt;
            string taskId = response.TaskId;
            CampaignAssetActivationTaskStatus taskStatus = response.TaskStatus;

            #endregion
        }

        public void PartnerCentralMarketingGetCampaignTemplate()
        {
            #region GetCampaignTemplate-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.GetCampaignTemplate(new GetCampaignTemplateRequest
            {
                Catalog = "AWS",
                Identifier = "tmpl-987xyz654abcd"
            });

            CampaignTemplate campaignTemplate = response.CampaignTemplate;

            #endregion
        }

        public void PartnerCentralMarketingListCampaignAssets()
        {
            #region ListCampaignAssets-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.ListCampaignAssets(new ListCampaignAssetsRequest
            {
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });

            List<CampaignAssetSummary> items = response.Items;

            #endregion
        }

        public void PartnerCentralMarketingListCampaigns()
        {
            #region ListCampaigns-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.ListCampaigns(new ListCampaignsRequest
            {
                Catalog = "AWS"
            });

            List<CampaignSummary> items = response.Items;

            #endregion
        }

        public void PartnerCentralMarketingListCampaigns()
        {
            #region ListCampaigns-2

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.ListCampaigns(new ListCampaignsRequest
            {
                CampaignIdentifiers = new List<string> {
                    "arn:aws:partnercentral:us-east-1:123456789012:catalog/AWS/campaign/camp-5Hq2m8x4k1p9w",
                    "camp-8Rt3w6y1n4b2v"
                },
                Catalog = "AWS"
            });

            List<CampaignSummary> items = response.Items;

            #endregion
        }

        public void PartnerCentralMarketingListCampaigns()
        {
            #region ListCampaigns-3

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.ListCampaigns(new ListCampaignsRequest
            {
                Catalog = "AWS",
                MaxResults = 20,
                Name = "genai",
                Sort = new CampaignSort {
                    SortBy = "START_ON",
                    SortOrder = "ASCENDING"
                },
                States = new List<string> {
                    "ACTIVE"
                }
            });

            List<CampaignSummary> items = response.Items;

            #endregion
        }

        public void PartnerCentralMarketingSearchCampaignTemplates()
        {
            #region SearchCampaignTemplates-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.SearchCampaignTemplates(new SearchCampaignTemplatesRequest
            {
                Catalog = "AWS"
            });

            List<CampaignTemplateSummary> campaignTemplates = response.CampaignTemplates;
            int? totalResults = response.TotalResults;

            #endregion
        }

        public void PartnerCentralMarketingSearchCampaignTemplates()
        {
            #region SearchCampaignTemplates-2

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.SearchCampaignTemplates(new SearchCampaignTemplatesRequest
            {
                Catalog = "AWS",
                Industry = new List<string> {
                    "TELECOMMUNICATIONS"
                },
                SearchText = "contact center"
            });

            List<CampaignTemplateSummary> campaignTemplates = response.CampaignTemplates;
            int? totalResults = response.TotalResults;

            #endregion
        }

        public void PartnerCentralMarketingSearchCampaignTemplates()
        {
            #region SearchCampaignTemplates-3

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.SearchCampaignTemplates(new SearchCampaignTemplatesRequest
            {
                Catalog = "AWS",
                Collection = new List<string> {
                    "BUILD_WITH_AI"
                },
                Language = new List<string> {
                    "ja"
                }
            });

            List<CampaignTemplateSummary> campaignTemplates = response.CampaignTemplates;
            int? totalResults = response.TotalResults;

            #endregion
        }

        public void PartnerCentralMarketingStartCampaignAssetActivationTask()
        {
            #region StartCampaignAssetActivationTask-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.StartCampaignAssetActivationTask(new StartCampaignAssetActivationTaskRequest
            {
                CampaignAssetIdentifiers = new List<string> {
                    "ast-4b81e0c9f2a7b",
                    "ast-9f3c1a2b7d40e",
                    "ast-2k7m4p9x1c6qd",
                    "ast-7w3n8r5t2h1ya"
                },
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });

            List<CampaignAssetActivationOutcome> assets = response.Assets;
            string campaignId = response.CampaignId;
            DateTime? startedAt = response.StartedAt;
            string taskId = response.TaskId;
            CampaignAssetActivationTaskStatus taskStatus = response.TaskStatus;

            #endregion
        }

        public void PartnerCentralMarketingStartCampaignAssetActivationTask()
        {
            #region StartCampaignAssetActivationTask-2

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.StartCampaignAssetActivationTask(new StartCampaignAssetActivationTaskRequest
            {
                CampaignAssetIdentifiers = new List<string> {
                    "ast-4b81e0c9f2a7b",
                    "ast-9f3c1a2b7d40e",
                    "ast-2k7m4p9x1c6qd",
                    "ast-7w3n8r5t2h1ya"
                },
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });

            List<CampaignAssetActivationOutcome> assets = response.Assets;
            string campaignId = response.CampaignId;
            DateTime? startedAt = response.StartedAt;
            string taskId = response.TaskId;
            CampaignAssetActivationTaskStatus taskStatus = response.TaskStatus;

            #endregion
        }

        public void PartnerCentralMarketingStartCampaignAssetActivationTask()
        {
            #region StartCampaignAssetActivationTask-3

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.StartCampaignAssetActivationTask(new StartCampaignAssetActivationTaskRequest
            {
                CampaignAssetIdentifiers = new List<string> {
                    "ast-2k7m4p9x1c6qd"
                },
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS"
            });

            List<CampaignAssetActivationOutcome> assets = response.Assets;
            string campaignId = response.CampaignId;
            DateTime? endedAt = response.EndedAt;
            DateTime? startedAt = response.StartedAt;
            string taskId = response.TaskId;
            CampaignAssetActivationTaskStatus taskStatus = response.TaskStatus;

            #endregion
        }

        public void PartnerCentralMarketingUpdateCampaign()
        {
            #region UpdateCampaign-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.UpdateCampaign(new UpdateCampaignRequest
            {
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                Name = "Q4 GenAI Campaign (EMEA)",
                TotalBudget = new MonetaryValue {
                    Amount = "40000.00",
                    CurrencyCode = "USD"
                }
            });

            string id = response.Id;

            #endregion
        }

        public void PartnerCentralMarketingUpdateCampaignAsset()
        {
            #region UpdateCampaignAsset-1

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.UpdateCampaignAsset(new UpdateCampaignAssetRequest
            {
                CampaignAssetIdentifier = "ast-4b81e0c9f2a7b",
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                FieldValues = new List<FieldValueInput> {
                    new FieldValueInput {
                        FieldId = "Subject",
                        Value = new TemplateFieldValue { Text = "New subject line" }
                    }
                }
            });

            List<ActivationIssue> activationIssues = response.ActivationIssues;
            string id = response.Id;
            CampaignAssetState state = response.State;

            #endregion
        }

        public void PartnerCentralMarketingUpdateCampaignAsset()
        {
            #region UpdateCampaignAsset-2

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.UpdateCampaignAsset(new UpdateCampaignAssetRequest
            {
                CampaignAssetIdentifier = "ast-4b81e0c9f2a7b",
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                ClientToken = "f2a7c1e4-9b3d-4a51-8e6f-0c2d5b8a7e13",
                ScheduledSendAt = new DateTime(2026, 11, 1, 0, 0, 0, DateTimeKind.Utc),
                SendMode = "SCHEDULED"
            });

            List<ActivationIssue> activationIssues = response.ActivationIssues;
            string id = response.Id;
            CampaignAssetState state = response.State;

            #endregion
        }

        public void PartnerCentralMarketingUpdateCampaignAsset()
        {
            #region UpdateCampaignAsset-3

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.UpdateCampaignAsset(new UpdateCampaignAssetRequest
            {
                CampaignAssetIdentifier = "ast-4b81e0c9f2a7b",
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                FieldValues = new List<FieldValueInput> {
                    new FieldValueInput {
                        FieldId = "HeaderImage",
                        Value = new TemplateFieldValue { CampaignAssetImage = new CampaignAssetImageSource {
                            CampaignAssetIdentifier = "ast-0f9e8d7c6b5a2",
                            CampaignIdentifier = "camp-2Lp7d9f3j6s1z",
                            FieldId = "HeaderImage"
                        } }
                    }
                }
            });

            List<ActivationIssue> activationIssues = response.ActivationIssues;
            string id = response.Id;
            CampaignAssetState state = response.State;

            #endregion
        }

        public void PartnerCentralMarketingUpdateCampaignAsset()
        {
            #region UpdateCampaignAsset-4

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.UpdateCampaignAsset(new UpdateCampaignAssetRequest
            {
                CampaignAssetIdentifier = "ast-4b81e0c9f2a7b",
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                FieldValues = new List<FieldValueInput> {
                    new FieldValueInput {
                        FieldId = "HeaderImage",
                        Value = new TemplateFieldValue { ImageReference = "https://d111111abcdef8.cloudfront.net/suggested-image-url-from-build-with-ai.jpg" }
                    }
                }
            });

            List<ActivationIssue> activationIssues = response.ActivationIssues;
            string id = response.Id;
            CampaignAssetState state = response.State;

            #endregion
        }

        public void PartnerCentralMarketingUpdateCampaignAsset()
        {
            #region UpdateCampaignAsset-5

            var client = new AmazonPartnerCentralMarketingClient();
            var response = client.UpdateCampaignAsset(new UpdateCampaignAssetRequest
            {
                CampaignAssetIdentifier = "ast-4b81e0c9f2a7b",
                CampaignIdentifier = "camp-5Hq2m8x4k1p9w",
                Catalog = "AWS",
                FieldValues = new List<FieldValueInput> {
                    new FieldValueInput {
                        FieldId = "HeaderImage",
                        Value = new TemplateFieldValue { ImageReference = "s3://staging-bucket/123456789012/hero.png?versionId=v1" }
                    },
                    new FieldValueInput {
                        FieldId = "Headline",
                        Value = new TemplateFieldValue { Text = "This headline is far longer than the field allows" }
                    }
                }
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
