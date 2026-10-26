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
        public void BillingAssociateContract()
        {
            #region AssociateContract-1

            var client = new AmazonBillingClient();
            var response = client.AssociateContract(new AssociateContractRequest
            {
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                ContractDocumentId = "CC OTH XXXXXXXX XXXX TR"
            });


            #endregion
        }

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

        public void BillingCancelContractualInvestmentAttestation()
        {
            #region CancelContractualInvestmentAttestation-1

            var client = new AmazonBillingClient();
            var response = client.CancelContractualInvestmentAttestation(new CancelContractualInvestmentAttestationRequest
            {
                AttestationId = "a1b2c3d4-5678-90ab-cdef-111122223333",
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                Reason = "Example cancellation reason"
            });


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

        public void BillingCreateContractualInvestmentAttestation()
        {
            #region CreateContractualInvestmentAttestation-1

            var client = new AmazonBillingClient();
            var response = client.CreateContractualInvestmentAttestation(new CreateContractualInvestmentAttestationRequest
            {
                AdditionalRecipients = new List<AdditionalRecipient> {
                    new AdditionalRecipient { Email = "recipient@example.com" }
                },
                ApproverDetails = new ApproverDetails {
                    Email = "first-name.last-name@example.com",
                    Name = "First-Name Last-Name",
                    Title = "Title"
                },
                AttestationDetails = new AttestationDetails {
                    AttestationValue = new AttestationValue { AttestationAmount = new Amount {
                        CurrencyAmount = "1.00",
                        CurrencyCode = "USD"
                    } },
                    InvestmentDistributions = new List<InvestmentDistribution> {
                        new InvestmentDistribution {
                            AccountId = "123456789012",
                            InvestmentAmount = new Amount {
                                CurrencyAmount = "1.00",
                                CurrencyCode = "USD"
                            }
                        }
                    }
                },
                ClientToken = "c0ffee00-1234-4abc-9def-0123456789ab",
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                ContractDocumentId = "CC OTH XXXXXXXX XXXX TR",
                InvestmentDisbursedAt = new DateTime(2008, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                InvestmentId = "Investment-Id",
                InvestmentSummaryId = "Example-Investment-Summary-Id"
            });

            string attestationId = response.AttestationId;

            #endregion
        }

        public void BillingCreateContractualInvestmentAttestation()
        {
            #region CreateContractualInvestmentAttestation-2

            var client = new AmazonBillingClient();
            var response = client.CreateContractualInvestmentAttestation(new CreateContractualInvestmentAttestationRequest
            {
                ApproverDetails = new ApproverDetails {
                    Email = "first-name.last-name@example.com",
                    Name = "First-Name Last-Name",
                    Title = "Title"
                },
                AttestationDetails = new AttestationDetails {
                    AttestationValue = new AttestationValue { AttestationQuantities = new List<AttestationQuantity> {
                        new AttestationQuantity {
                            AttestationUnit = "Example attestation unit",
                            AttestationVolume = "3"
                        }
                    } },
                    InvestmentDistributions = new List<InvestmentDistribution> {
                        new InvestmentDistribution {
                            AccountId = "123456789012",
                            InvestmentAmount = new Amount {
                                CurrencyAmount = "1500.00",
                                CurrencyCode = "USD"
                            }
                        }
                    }
                },
                ClientToken = "c0ffee00-1234-4abc-9def-0123456789ac",
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                ContractDocumentId = "CC OTH XXXXXXXX XXXX TR",
                InvestmentDisbursedAt = new DateTime(2008, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                InvestmentId = "Investment-Id",
                InvestmentSummaryId = "Example-Investment-Summary-Id"
            });

            string attestationId = response.AttestationId;

            #endregion
        }

        public void BillingCreateContractualInvestmentAttestation()
        {
            #region CreateContractualInvestmentAttestation-3

            var client = new AmazonBillingClient();
            var response = client.CreateContractualInvestmentAttestation(new CreateContractualInvestmentAttestationRequest
            {
                ApproverDetails = new ApproverDetails {
                    Email = "first-name.last-name@example.com",
                    Name = "First-Name Last-Name",
                    Title = "Title"
                },
                AttestationDetails = new AttestationDetails {
                    AttestationValue = new AttestationValue { AttestationQuantities = new List<AttestationQuantity> {
                        new AttestationQuantity {
                            AttestationUnit = "Example attestation unit",
                            AttestationVolume = "1000"
                        }
                    } },
                    InvestmentDistributions = new List<InvestmentDistribution> {
                        new InvestmentDistribution {
                            AccountId = "123456789012",
                            InvestmentAmount = new Amount {
                                CurrencyAmount = "150.00",
                                CurrencyCode = "USD"
                            }
                        }
                    }
                },
                ClientToken = "c0ffee00-1234-4abc-9def-0123456789ad",
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                ContractDocumentId = "CC OTH XXXXXXXX XXXX TR",
                InvestmentDisbursedAt = new DateTime(2008, 1, 10, 0, 0, 0, DateTimeKind.Utc),
                InvestmentId = "Investment-Id",
                InvestmentSummaryId = "Example-Investment-Summary-Id"
            });

            string attestationId = response.AttestationId;

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

        public void BillingDisassociateContract()
        {
            #region DisassociateContract-1

            var client = new AmazonBillingClient();
            var response = client.DisassociateContract(new DisassociateContractRequest
            {
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333"
            });


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

        public void BillingGetContractInformation()
        {
            #region GetContractInformation-1

            var client = new AmazonBillingClient();
            var response = client.GetContractInformation(new GetContractInformationRequest
            {
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333"
            });

            ContractDetails contract = response.Contract;

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

        public void BillingListContracts()
        {
            #region ListContracts-1

            var client = new AmazonBillingClient();
            var response = client.ListContracts(new ListContractsRequest
            {
                MaxResults = 100
            });

            List<ContractSummary> items = response.Items;

            #endregion
        }

        public void BillingListContractualInvestmentAttestations()
        {
            #region ListContractualInvestmentAttestations-1

            var client = new AmazonBillingClient();
            var response = client.ListContractualInvestmentAttestations(new ListContractualInvestmentAttestationsRequest
            {
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                MaxResults = 25
            });

            List<InvestmentAttestation> items = response.Items;

            #endregion
        }

        public void BillingListContractualInvestments()
        {
            #region ListContractualInvestments-1

            var client = new AmazonBillingClient();
            var response = client.ListContractualInvestments(new ListContractualInvestmentsRequest
            {
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                InvestmentSummaryId = "Example-Investment-Summary-Id",
                MaxResults = 100
            });

            List<Investment> items = response.Items;

            #endregion
        }

        public void BillingListContractualInvestmentSummaries()
        {
            #region ListContractualInvestmentSummaries-1

            var client = new AmazonBillingClient();
            var response = client.ListContractualInvestmentSummaries(new ListContractualInvestmentSummariesRequest
            {
                ContractArn = "arn:aws:billing::123456789012:contract/1a2b3c4d-5e6f-7a8b-9c0d-111122223333",
                MaxResults = 100
            });

            List<InvestmentSummary> items = response.Items;

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
