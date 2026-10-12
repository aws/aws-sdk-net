using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Billing;
using Amazon.Billing.Model;

namespace AWSSDKDocSamples.Amazon.Billing.Generated
{
    class BillingSamples : ISample
    {
        public void BillingAssociateSourceViews()
        {
            #region AssociateSourceViews-1

            var client = new AmazonBillingClient();
            var response = client.AssociateSourceViews(new AssociateSourceViewsRequest
            {
                Arn = "arn:aws:billing::123456789012:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899",
                SourceViews = new List<string> {
                    "arn:aws:billing::123456789012:billingview/primary",
                    "arn:aws:billing::123456789012:billingview/custom-d3f9c7e4-8b2f-4a6e-9d3b-2f7c8a1e5f6d"
                }
            });

            string arn = response.Arn;

            #endregion
        }

        public void BillingCreateBillingView()
        {
            #region CreateBillingView-1

            var client = new AmazonBillingClient();
            var response = client.CreateBillingView(new CreateBillingViewRequest
            {
                DataFilterExpression = new Expression { Dimensions = new DimensionValues {
                    Key = "LINKED_ACCOUNT",
                    Values = new List<string> {
                        "000000000000"
                    }
                } },
                Description = "Custom Billing View Example",
                Name = "Example Custom Billing View",
                SourceViews = new List<string> {
                    "arn:aws:billing::123456789101:billingview/primary"
                }
            });

            string arn = response.Arn;
            DateTime? createdAt = response.CreatedAt;

            #endregion
        }

        public void BillingDeleteBillingView()
        {
            #region DeleteBillingView-1

            var client = new AmazonBillingClient();
            var response = client.DeleteBillingView(new DeleteBillingViewRequest
            {
                Arn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899"
            });

            string arn = response.Arn;

            #endregion
        }

        public void BillingDisassociateSourceViews()
        {
            #region DisassociateSourceViews-1

            var client = new AmazonBillingClient();
            var response = client.DisassociateSourceViews(new DisassociateSourceViewsRequest
            {
                Arn = "arn:aws:billing::123456789012:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899",
                SourceViews = new List<string> {
                    "arn:aws:billing::123456789012:billingview/primary",
                    "arn:aws:billing::123456789012:billingview/custom-d3f9c7e4-8b2f-4a6e-9d3b-2f7c8a1e5f6d"
                }
            });

            string arn = response.Arn;

            #endregion
        }

        public void BillingGetBillingView()
        {
            #region GetBillingView-1

            var client = new AmazonBillingClient();
            var response = client.GetBillingView(new GetBillingViewRequest
            {
                Arn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899"
            });

            BillingViewElement billingView = response.BillingView;

            #endregion
        }

        public void BillingGetResourcePolicy()
        {
            #region GetResourcePolicy-1

            var client = new AmazonBillingClient();
            var response = client.GetResourcePolicy(new GetResourcePolicyRequest
            {
                ResourceArn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899"
            });

            string policy = response.Policy;
            string resourceArn = response.ResourceArn;

            #endregion
        }

        public void BillingListBillingViews()
        {
            #region ListBillingViews-1

            var client = new AmazonBillingClient();
            var response = client.ListBillingViews(new ListBillingViewsRequest
            {
                ActiveTimeRange = new ActiveTimeRange {
                    ActiveAfterInclusive = new DateTime(2024, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                    ActiveBeforeInclusive = new DateTime(2024, 7, 31, 23, 59, 59, 999, DateTimeKind.Utc)
                }
            });

            List<BillingViewListElement> billingViews = response.BillingViews;

            #endregion
        }

        public void BillingListBillingViews()
        {
            #region ListBillingViews-2

            var client = new AmazonBillingClient();
            var response = client.ListBillingViews(new ListBillingViewsRequest
            {
                ActiveTimeRange = new ActiveTimeRange {
                    ActiveAfterInclusive = new DateTime(2024, 7, 1, 0, 0, 1, DateTimeKind.Utc),
                    ActiveBeforeInclusive = new DateTime(2024, 7, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            });


            #endregion
        }

        public void BillingListBillingViewSegments()
        {
            #region ListBillingViewSegments-1

            var client = new AmazonBillingClient();
            var response = client.ListBillingViewSegments(new ListBillingViewSegmentsRequest
            {
                TimeRange = new BillingViewSegmentTimeRange {
                    BeginDateInclusive = new DateTime(2024, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                    EndDateExclusive = new DateTime(2024, 8, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            });

            List<BillingViewSegmentsListElement> items = response.Items;

            #endregion
        }

        public void BillingListBillingViewSegments()
        {
            #region ListBillingViewSegments-2

            var client = new AmazonBillingClient();
            var response = client.ListBillingViewSegments(new ListBillingViewSegmentsRequest
            {
                TimeRange = new BillingViewSegmentTimeRange {
                    BeginDateInclusive = new DateTime(2024, 8, 1, 0, 0, 0, DateTimeKind.Utc),
                    EndDateExclusive = new DateTime(2024, 7, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            });


            #endregion
        }

        public void BillingListSourceViewsForBillingView()
        {
            #region ListSourceViewsForBillingView-1

            var client = new AmazonBillingClient();
            var response = client.ListSourceViewsForBillingView(new ListSourceViewsForBillingViewRequest
            {
                Arn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899"
            });

            List<string> sourceViews = response.SourceViews;

            #endregion
        }

        public void BillingListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonBillingClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899"
            });

            List<ResourceTag> resourceTags = response.ResourceTags;

            #endregion
        }

        public void BillingTagResource()
        {
            #region TagResource-1

            var client = new AmazonBillingClient();
            var response = client.TagResource(new TagResourceRequest
            {
                ResourceArn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899",
                ResourceTags = new List<ResourceTag> {
                    new ResourceTag {
                        Key = "ExampleTagKey",
                        Value = "ExampleTagValue"
                    }
                }
            });


            #endregion
        }

        public void BillingUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonBillingClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceArn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899",
                ResourceTagKeys = new List<string> {
                    "ExampleTagKey"
                }
            });


            #endregion
        }

        public void BillingUpdateBillingView()
        {
            #region UpdateBillingView-1

            var client = new AmazonBillingClient();
            var response = client.UpdateBillingView(new UpdateBillingViewRequest
            {
                Arn = "arn:aws:billing::123456789101:billingview/custom-46f47cb2-a11d-43f3-983d-470b5708a899",
                DataFilterExpression = new Expression { Dimensions = new DimensionValues {
                    Key = "LINKED_ACCOUNT",
                    Values = new List<string> {
                        "000000000000"
                    }
                } },
                Description = "Custom Billing View Example -- updated description",
                Name = "Example Custom Billing View"
            });

            string arn = response.Arn;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
