using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PartnerCentralRevenueMeasurement;
using Amazon.PartnerCentralRevenueMeasurement.Model;

namespace AWSSDKDocSamples.Amazon.PartnerCentralRevenueMeasurement.Generated
{
    class PartnerCentralRevenueMeasurementSamples : ISample
    {
        public void PartnerCentralRevenueMeasurementCreateMarketplaceRevenueShare()
        {
            #region CreateMarketplaceRevenueShare-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.CreateMarketplaceRevenueShare(new CreateMarketplaceRevenueShareRequest
            {
                Catalog = "AWS",
                ProductId = "prod-abc123def4567"
            });

            string arn = response.Arn;
            string productId = response.ProductId;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementCreateMarketplaceRevenueShareAllocation()
        {
            #region CreateMarketplaceRevenueShareAllocation-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.CreateMarketplaceRevenueShareAllocation(new CreateMarketplaceRevenueShareAllocationRequest
            {
                Catalog = "AWS",
                EffectiveFrom = "2026-07-01",
                ProductId = "prod-abc123def4567",
                RevenueSharePercent = "15.50"
            });

            string arn = response.Arn;
            string effectiveFrom = response.EffectiveFrom;
            string marketplaceRevenueShareAllocationId = response.MarketplaceRevenueShareAllocationId;
            string productId = response.ProductId;
            string revenueSharePercent = response.RevenueSharePercent;
            AllocationStatus status = response.Status;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementCreateRevenueAttribution()
        {
            #region CreateRevenueAttribution-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.CreateRevenueAttribution(new CreateRevenueAttributionRequest
            {
                Catalog = "AWS",
                Name = "My Revenue Attribution",
                TenancyModel = "MULTI_TENANT"
            });

            string arn = response.Arn;
            string id = response.Id;
            TenancyModel tenancyModel = response.TenancyModel;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementGetMarketplaceRevenueShare()
        {
            #region GetMarketplaceRevenueShare-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.GetMarketplaceRevenueShare(new GetMarketplaceRevenueShareRequest
            {
                Catalog = "AWS",
                ProductId = "prod-abc123def4567"
            });

            string arn = response.Arn;
            CatalogName catalog = response.Catalog;
            string productId = response.ProductId;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementGetMarketplaceRevenueShareAllocation()
        {
            #region GetMarketplaceRevenueShareAllocation-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.GetMarketplaceRevenueShareAllocation(new GetMarketplaceRevenueShareAllocationRequest
            {
                Catalog = "AWS",
                MarketplaceRevenueShareAllocationId = "mrsa-abc123def4567",
                ProductId = "prod-abc123def4567"
            });

            string arn = response.Arn;
            string effectiveFrom = response.EffectiveFrom;
            string marketplaceRevenueShareAllocationId = response.MarketplaceRevenueShareAllocationId;
            string productId = response.ProductId;
            string revenueSharePercent = response.RevenueSharePercent;
            AllocationStatus status = response.Status;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementGetRevenueAttribution()
        {
            #region GetRevenueAttribution-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.GetRevenueAttribution(new GetRevenueAttributionRequest
            {
                Catalog = "AWS",
                Identifier = "ra-0a1b2c3d4e5f6"
            });

            string arn = response.Arn;
            CatalogName catalog = response.Catalog;
            string id = response.Id;
            TenancyModel tenancyModel = response.TenancyModel;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementGetRevenueAttributionAllocation()
        {
            #region GetRevenueAttributionAllocation-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.GetRevenueAttributionAllocation(new GetRevenueAttributionAllocationRequest
            {
                Catalog = "AWS",
                RevenueAttributionAllocationId = "alloc-abc123def4567",
                RevenueAttributionIdentifier = "ra-0a1b2c3d4e5f6"
            });

            DateTime? createdDate = response.CreatedDate;
            string customerAwsAccountId = response.CustomerAwsAccountId;
            string effectiveFrom = response.EffectiveFrom;
            string effectiveUntil = response.EffectiveUntil;
            string entityIdentifier = response.EntityIdentifier;
            EntityType entityType = response.EntityType;
            DateTime? lastModifiedDate = response.LastModifiedDate;
            string revenueAttributionAllocationId = response.RevenueAttributionAllocationId;
            string revenueAttributionIdentifier = response.RevenueAttributionIdentifier;
            string revenueAttributionLatestRevision = response.RevenueAttributionLatestRevision;
            string revenueAttributionRevision = response.RevenueAttributionRevision;
            string revenueSharePercent = response.RevenueSharePercent;
            AllocationStatus status = response.Status;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementGetRevenueAttributionAllocationsTask()
        {
            #region GetRevenueAttributionAllocationsTask-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.GetRevenueAttributionAllocationsTask(new GetRevenueAttributionAllocationsTaskRequest
            {
                Catalog = "AWS",
                RevenueAttributionIdentifier = "ra-0a1b2c3d4e5f6"
            });

            CatalogName catalog = response.Catalog;
            string revenueAttributionArn = response.RevenueAttributionArn;
            DateTime? startedAt = response.StartedAt;
            RevenueAttributionAllocationTaskStatus status = response.Status;
            string taskId = response.TaskId;
            int? totalRevenueAttributionAllocationRecords = response.TotalRevenueAttributionAllocationRecords;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementListMarketplaceRevenueShareAllocations()
        {
            #region ListMarketplaceRevenueShareAllocations-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.ListMarketplaceRevenueShareAllocations(new ListMarketplaceRevenueShareAllocationsRequest
            {
                Catalog = "AWS",
                ProductId = "prod-abc123def4567"
            });

            List<MarketplaceRevenueShareAllocationSummary> marketplaceRevenueShareAllocationSummaries = response.MarketplaceRevenueShareAllocationSummaries;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementListMarketplaceRevenueShares()
        {
            #region ListMarketplaceRevenueShares-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.ListMarketplaceRevenueShares(new ListMarketplaceRevenueSharesRequest
            {
                Catalog = "AWS",
                MaxResults = 10
            });

            List<MarketplaceRevenueShareSummary> marketplaceRevenueShareSummaries = response.MarketplaceRevenueShareSummaries;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementListRevenueAttributionAllocations()
        {
            #region ListRevenueAttributionAllocations-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.ListRevenueAttributionAllocations(new ListRevenueAttributionAllocationsRequest
            {
                Catalog = "AWS",
                RevenueAttributionIdentifier = "ra-0a1b2c3d4e5f6"
            });

            List<RevenueAttributionAllocationSummary> revenueAttributionAllocationSummaries = response.RevenueAttributionAllocationSummaries;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementListRevenueAttributions()
        {
            #region ListRevenueAttributions-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.ListRevenueAttributions(new ListRevenueAttributionsRequest
            {
                Catalog = "AWS"
            });

            List<AttributionSummary> revenueAttributionSummaries = response.RevenueAttributionSummaries;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementStartRevenueAttributionAllocationsTask()
        {
            #region StartRevenueAttributionAllocationsTask-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.StartRevenueAttributionAllocationsTask(new StartRevenueAttributionAllocationsTaskRequest
            {
                Catalog = "AWS",
                ClientToken = "unique-token-123",
                RevenueAttributionIdentifier = "ra-0a1b2c3d4e5f6",
                RevenueAttributionRevision = "1",
                RevenueShareAllocations = new List<RevenueShareAllocation> {
                    new RevenueShareAllocation {
                        Action = "CREATE",
                        CustomerAwsAccountId = "123456789012",
                        EffectiveFrom = "2026-07-01",
                        EffectiveUntil = "2026-07-31",
                        EntityIdentifier = "offer-abc123",
                        EntityType = "OFFER",
                        RevenueSharePercent = "15.50"
                    }
                }
            });

            CatalogName catalog = response.Catalog;
            string revenueAttributionArn = response.RevenueAttributionArn;
            DateTime? startedAt = response.StartedAt;
            RevenueAttributionAllocationTaskStatus status = response.Status;
            string taskId = response.TaskId;
            int? totalRevenueAttributionAllocationRecords = response.TotalRevenueAttributionAllocationRecords;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementUpdateMarketplaceRevenueShareAllocation()
        {
            #region UpdateMarketplaceRevenueShareAllocation-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.UpdateMarketplaceRevenueShareAllocation(new UpdateMarketplaceRevenueShareAllocationRequest
            {
                Catalog = "AWS",
                MarketplaceRevenueShareAllocationId = "mrsa-abc123def4567",
                MarketplaceRevenueShareRevision = "1",
                ProductId = "prod-abc123def4567",
                RevenueSharePercent = "20.00"
            });

            string arn = response.Arn;
            string effectiveFrom = response.EffectiveFrom;
            string marketplaceRevenueShareAllocationId = response.MarketplaceRevenueShareAllocationId;
            string productId = response.ProductId;
            string revenueSharePercent = response.RevenueSharePercent;
            AllocationStatus status = response.Status;

            #endregion
        }

        public void PartnerCentralRevenueMeasurementUpdateRevenueAttribution()
        {
            #region UpdateRevenueAttribution-1

            var client = new AmazonPartnerCentralRevenueMeasurementClient();
            var response = client.UpdateRevenueAttribution(new UpdateRevenueAttributionRequest
            {
                Catalog = "AWS",
                Identifier = "ra-0a1b2c3d4e5f6",
                Revision = "1"
            });

            string arn = response.Arn;
            string id = response.Id;
            DateTime? lastModifiedDate = response.LastModifiedDate;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
