using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MarketplaceDiscovery;
using Amazon.MarketplaceDiscovery.Model;

namespace AWSSDKDocSamples.Amazon.MarketplaceDiscovery.Generated
{
    class MarketplaceDiscoverySamples : ISample
    {
        public void MarketplaceDiscoveryGetListing()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetListing(new GetListingRequest 
            {
                ListingId = "prodview-sampleSaasId"
            });

            List<ListingAssociatedEntity> associatedEntities = response.AssociatedEntities;
            List<ListingBadge> badges = response.Badges;
            string catalog = response.Catalog;
            List<Category> categories = response.Categories;
            List<FulfillmentOptionSummary> fulfillmentOptionSummaries = response.FulfillmentOptionSummaries;
            List<string> highlights = response.Highlights;
            string listingId = response.ListingId;
            string listingName = response.ListingName;
            string logoThumbnailUrl = response.LogoThumbnailUrl;
            string longDescription = response.LongDescription;
            List<PricingModel> pricingModels = response.PricingModels;
            List<PricingUnit> pricingUnits = response.PricingUnits;
            List<PromotionalMedia> promotionalMedia = response.PromotionalMedia;
            SellerInformation publisher = response.Publisher;
            List<Resource> resources = response.Resources;
            ReviewSummary reviewSummary = response.ReviewSummary;
            List<SellerEngagement> sellerEngagements = response.SellerEngagements;
            string shortDescription = response.ShortDescription;
            List<UseCaseEntry> useCases = response.UseCases;

            #endregion
        }

        public void MarketplaceDiscoveryGetListing()
        {
            #region example-2

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetListing(new GetListingRequest 
            {
                ListingId = "prodview-sampleAmiId"
            });

            List<ListingAssociatedEntity> associatedEntities = response.AssociatedEntities;
            List<ListingBadge> badges = response.Badges;
            string catalog = response.Catalog;
            List<Category> categories = response.Categories;
            List<FulfillmentOptionSummary> fulfillmentOptionSummaries = response.FulfillmentOptionSummaries;
            List<string> highlights = response.Highlights;
            string listingId = response.ListingId;
            string listingName = response.ListingName;
            string logoThumbnailUrl = response.LogoThumbnailUrl;
            string longDescription = response.LongDescription;
            List<PricingModel> pricingModels = response.PricingModels;
            List<PricingUnit> pricingUnits = response.PricingUnits;
            List<PromotionalMedia> promotionalMedia = response.PromotionalMedia;
            SellerInformation publisher = response.Publisher;
            List<Resource> resources = response.Resources;
            ReviewSummary reviewSummary = response.ReviewSummary;
            List<SellerEngagement> sellerEngagements = response.SellerEngagements;
            string shortDescription = response.ShortDescription;
            List<UseCaseEntry> useCases = response.UseCases;

            #endregion
        }

        public void MarketplaceDiscoveryGetListing()
        {
            #region example-3

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetListing(new GetListingRequest 
            {
                ListingId = "prodview-sampleMultiProductId"
            });

            List<ListingAssociatedEntity> associatedEntities = response.AssociatedEntities;
            List<ListingBadge> badges = response.Badges;
            string catalog = response.Catalog;
            List<Category> categories = response.Categories;
            List<FulfillmentOptionSummary> fulfillmentOptionSummaries = response.FulfillmentOptionSummaries;
            List<string> highlights = response.Highlights;
            string integrationGuide = response.IntegrationGuide;
            string listingId = response.ListingId;
            string listingName = response.ListingName;
            string logoThumbnailUrl = response.LogoThumbnailUrl;
            string longDescription = response.LongDescription;
            List<PricingModel> pricingModels = response.PricingModels;
            List<PricingUnit> pricingUnits = response.PricingUnits;
            List<PromotionalMedia> promotionalMedia = response.PromotionalMedia;
            SellerInformation publisher = response.Publisher;
            List<Resource> resources = response.Resources;
            ReviewSummary reviewSummary = response.ReviewSummary;
            List<SellerEngagement> sellerEngagements = response.SellerEngagements;
            string shortDescription = response.ShortDescription;
            List<UseCaseEntry> useCases = response.UseCases;

            #endregion
        }

        public void MarketplaceDiscoveryGetOffer()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOffer(new GetOfferRequest 
            {
                OfferId = "offer-sampleContractId"
            });

            string agreementProposalId = response.AgreementProposalId;
            List<OfferAssociatedEntity> associatedEntities = response.AssociatedEntities;
            DateTime availableFromTime = response.AvailableFromTime;
            List<PurchaseOptionBadge> badges = response.Badges;
            string catalog = response.Catalog;
            DateTime expirationTime = response.ExpirationTime;
            string offerId = response.OfferId;
            string offerName = response.OfferName;
            PricingModel pricingModel = response.PricingModel;
            string replacementAgreementId = response.ReplacementAgreementId;
            SellerInformation sellerOfRecord = response.SellerOfRecord;

            #endregion
        }

        public void MarketplaceDiscoveryGetOffer()
        {
            #region example-2

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOffer(new GetOfferRequest 
            {
                OfferId = "offer-sampleUsageId"
            });

            string agreementProposalId = response.AgreementProposalId;
            List<OfferAssociatedEntity> associatedEntities = response.AssociatedEntities;
            List<PurchaseOptionBadge> badges = response.Badges;
            string catalog = response.Catalog;
            DateTime expirationTime = response.ExpirationTime;
            string offerId = response.OfferId;
            string offerName = response.OfferName;
            PricingModel pricingModel = response.PricingModel;
            string replacementAgreementId = response.ReplacementAgreementId;
            SellerInformation sellerOfRecord = response.SellerOfRecord;

            #endregion
        }

        public void MarketplaceDiscoveryGetOffer()
        {
            #region example-3

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOffer(new GetOfferRequest 
            {
                OfferId = "offer-sampleByolId"
            });

            string agreementProposalId = response.AgreementProposalId;
            List<OfferAssociatedEntity> associatedEntities = response.AssociatedEntities;
            List<PurchaseOptionBadge> badges = response.Badges;
            string catalog = response.Catalog;
            DateTime expirationTime = response.ExpirationTime;
            string offerId = response.OfferId;
            string offerName = response.OfferName;
            PricingModel pricingModel = response.PricingModel;
            string replacementAgreementId = response.ReplacementAgreementId;
            SellerInformation sellerOfRecord = response.SellerOfRecord;

            #endregion
        }

        public void MarketplaceDiscoveryGetOffer()
        {
            #region example-4

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOffer(new GetOfferRequest 
            {
                OfferId = "offer-sampleFreeId"
            });

            string agreementProposalId = response.AgreementProposalId;
            List<OfferAssociatedEntity> associatedEntities = response.AssociatedEntities;
            List<PurchaseOptionBadge> badges = response.Badges;
            string catalog = response.Catalog;
            DateTime expirationTime = response.ExpirationTime;
            string offerId = response.OfferId;
            string offerName = response.OfferName;
            PricingModel pricingModel = response.PricingModel;
            string replacementAgreementId = response.ReplacementAgreementId;
            SellerInformation sellerOfRecord = response.SellerOfRecord;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferSet()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferSet(new GetOfferSetRequest 
            {
                OfferSetId = "offerset-sampleId"
            });

            List<OfferSetAssociatedEntity> associatedEntities = response.AssociatedEntities;
            DateTime availableFromTime = response.AvailableFromTime;
            List<PurchaseOptionBadge> badges = response.Badges;
            string buyerNotes = response.BuyerNotes;
            string catalog = response.Catalog;
            DateTime expirationTime = response.ExpirationTime;
            string offerSetId = response.OfferSetId;
            string offerSetName = response.OfferSetName;
            SellerInformation sellerOfRecord = response.SellerOfRecord;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleUsageBasedId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-2

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleByolId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-3

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleConfigUpfrontId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-4

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleFreeTrialId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-5

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleRecurringId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-6

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleVariableId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-7

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleRenewalId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-8

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleSupportId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetOfferTerms()
        {
            #region example-9

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetOfferTerms(new GetOfferTermsRequest 
            {
                OfferId = "offer-sampleValidityId"
            });

            List<OfferTerm> offerTerms = response.OfferTerms;

            #endregion
        }

        public void MarketplaceDiscoveryGetProduct()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetProduct(new GetProductRequest 
            {
                ProductId = "prod-sampleSaasId"
            });

            string catalog = response.Catalog;
            List<Category> categories = response.Categories;
            string deployedOnAws = response.DeployedOnAws;
            List<FulfillmentOptionSummary> fulfillmentOptionSummaries = response.FulfillmentOptionSummaries;
            List<string> highlights = response.Highlights;
            string logoThumbnailUrl = response.LogoThumbnailUrl;
            string longDescription = response.LongDescription;
            SellerInformation manufacturer = response.Manufacturer;
            string productId = response.ProductId;
            string productName = response.ProductName;
            List<PromotionalMedia> promotionalMedia = response.PromotionalMedia;
            List<Resource> resources = response.Resources;
            List<SellerEngagement> sellerEngagements = response.SellerEngagements;
            string shortDescription = response.ShortDescription;

            #endregion
        }

        public void MarketplaceDiscoveryGetProduct()
        {
            #region example-2

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetProduct(new GetProductRequest 
            {
                ProductId = "prod-sampleAmiId"
            });

            string catalog = response.Catalog;
            List<Category> categories = response.Categories;
            string deployedOnAws = response.DeployedOnAws;
            List<FulfillmentOptionSummary> fulfillmentOptionSummaries = response.FulfillmentOptionSummaries;
            List<string> highlights = response.Highlights;
            string logoThumbnailUrl = response.LogoThumbnailUrl;
            string longDescription = response.LongDescription;
            SellerInformation manufacturer = response.Manufacturer;
            string productId = response.ProductId;
            string productName = response.ProductName;
            List<PromotionalMedia> promotionalMedia = response.PromotionalMedia;
            List<Resource> resources = response.Resources;
            List<SellerEngagement> sellerEngagements = response.SellerEngagements;
            string shortDescription = response.ShortDescription;

            #endregion
        }

        public void MarketplaceDiscoveryGetProduct()
        {
            #region example-3

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.GetProduct(new GetProductRequest 
            {
                ProductId = "prod-sampleProServId"
            });

            string catalog = response.Catalog;
            List<Category> categories = response.Categories;
            string deployedOnAws = response.DeployedOnAws;
            List<FulfillmentOptionSummary> fulfillmentOptionSummaries = response.FulfillmentOptionSummaries;
            List<string> highlights = response.Highlights;
            string logoThumbnailUrl = response.LogoThumbnailUrl;
            string longDescription = response.LongDescription;
            SellerInformation manufacturer = response.Manufacturer;
            string productId = response.ProductId;
            string productName = response.ProductName;
            List<PromotionalMedia> promotionalMedia = response.PromotionalMedia;
            List<Resource> resources = response.Resources;
            List<SellerEngagement> sellerEngagements = response.SellerEngagements;
            string shortDescription = response.ShortDescription;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleAmiId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-2

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleApiId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-3

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleCftId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-4

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleContainerId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-5

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleHelmId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-6

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleEksId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-7

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleImageBuilderId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-8

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleDataExchangeId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-9

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleProServId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-10

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleSaasId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-11

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleSmAlgoId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListFulfillmentOptions()
        {
            #region example-12

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListFulfillmentOptions(new ListFulfillmentOptionsRequest 
            {
                ProductId = "prod-sampleSmModelId"
            });

            List<FulfillmentOption> fulfillmentOptions = response.FulfillmentOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListPurchaseOptions()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListPurchaseOptions(new ListPurchaseOptionsRequest 
            {
                Filters = new List<PurchaseOptionFilter> {
                    new PurchaseOptionFilter {
                        FilterType = "PRODUCT_ID",
                        FilterValues = new List<string> {
                            "prod-sampleOfferId"
                        }
                    }
                }
            });

            List<PurchaseOptionSummary> purchaseOptions = response.PurchaseOptions;

            #endregion
        }

        public void MarketplaceDiscoveryListPurchaseOptions()
        {
            #region example-2

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.ListPurchaseOptions(new ListPurchaseOptionsRequest 
            {
                Filters = new List<PurchaseOptionFilter> {
                    new PurchaseOptionFilter {
                        FilterType = "SELLER_OF_RECORD_PROFILE_ID",
                        FilterValues = new List<string> {
                            "seller-sampleResellerId"
                        }
                    },
                    new PurchaseOptionFilter {
                        FilterType = "PURCHASE_OPTION_TYPE",
                        FilterValues = new List<string> {
                            "OFFERSET"
                        }
                    },
                    new PurchaseOptionFilter {
                        FilterType = "VISIBILITY_SCOPE",
                        FilterValues = new List<string> {
                            "PRIVATE"
                        }
                    }
                }
            });

            List<PurchaseOptionSummary> purchaseOptions = response.PurchaseOptions;

            #endregion
        }

        public void MarketplaceDiscoverySearchFacets()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.SearchFacets(new SearchFacetsRequest 
            {
                FacetTypes = new List<string> {
                    "FULFILLMENT_OPTION_TYPE",
                    "PRICING_MODEL"
                },
                Filters = new List<SearchFilter> {
                    new SearchFilter {
                        FilterType = "CATEGORY",
                        FilterValues = new List<string> {
                            "machine-learning"
                        }
                    }
                },
                SearchText = "analytics"
            });

            Dictionary<string, List<ListingFacet>> listingFacets = response.ListingFacets;
            long totalResults = response.TotalResults;

            #endregion
        }

        public void MarketplaceDiscoverySearchFacets()
        {
            #region example-2

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.SearchFacets(new SearchFacetsRequest 
            {
                FacetTypes = new List<string> {
                    "PRICING_MODEL",
                    "AVERAGE_CUSTOMER_RATING"
                },
                Filters = new List<SearchFilter> {
                    new SearchFilter {
                        FilterType = "CATEGORY",
                        FilterValues = new List<string> {
                            "security"
                        }
                    },
                    new SearchFilter {
                        FilterType = "MIN_AVERAGE_CUSTOMER_RATING",
                        FilterValues = new List<string> {
                            "3.0"
                        }
                    },
                    new SearchFilter {
                        FilterType = "MAX_AVERAGE_CUSTOMER_RATING",
                        FilterValues = new List<string> {
                            "5.0"
                        }
                    }
                }
            });

            Dictionary<string, List<ListingFacet>> listingFacets = response.ListingFacets;
            long totalResults = response.TotalResults;

            #endregion
        }

        public void MarketplaceDiscoverySearchListings()
        {
            #region example-1

            var client = new AmazonMarketplaceDiscoveryClient();
            var response = client.SearchListings(new SearchListingsRequest 
            {
                Filters = new List<SearchFilter> {
                    new SearchFilter {
                        FilterType = "CATEGORY",
                        FilterValues = new List<string> {
                            "machine-learning"
                        }
                    },
                    new SearchFilter {
                        FilterType = "FULFILLMENT_OPTION_TYPE",
                        FilterValues = new List<string> {
                            "SAAS"
                        }
                    }
                },
                MaxResults = 25,
                SearchText = "computer vision",
                SortBy = "RELEVANCE",
                SortOrder = "DESCENDING"
            });

            List<ListingSummary> listingSummaries = response.ListingSummaries;
            string nextToken = response.NextToken;
            long totalResults = response.TotalResults;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}