using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.TrustedAdvisor;
using Amazon.TrustedAdvisor.Model;

namespace AWSSDKDocSamples.Amazon.TrustedAdvisor.Generated
{
    class TrustedAdvisorSamples : ISample
    {
        public void TrustedAdvisorBatchUpdateRecommendationResourceExclusion()
        {
            #region BatchUpdateRecommendationResourceExclusion-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.BatchUpdateRecommendationResourceExclusion(new BatchUpdateRecommendationResourceExclusionRequest
            {
                RecommendationResourceExclusions = new List<RecommendationResourceExclusion> {
                    new RecommendationResourceExclusion {
                        Arn = "arn:aws:trustedadvisor::000000000000:recommendation-resource/55fa4d2e-bbb7-491a-833b-5773e9589578/18959a1f1973cff8e706e9d9bde28bba36cd602a6b2cb86c8b61252835236010",
                        IsExcluded = true
                    }
                }
            });

            List<UpdateRecommendationResourceExclusionError> batchUpdateRecommendationResourceExclusionErrors = response.BatchUpdateRecommendationResourceExclusionErrors;

            #endregion
        }

        public void TrustedAdvisorGetOrganizationRecommendation()
        {
            #region GetOrganizationRecommendation-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.GetOrganizationRecommendation(new GetOrganizationRecommendationRequest
            {
                OrganizationRecommendationIdentifier = "arn:aws:trustedadvisor:::organization-recommendation/9534ec9b-bf3a-44e8-8213-2ed68b39d9d5"
            });

            OrganizationRecommendation organizationRecommendation = response.OrganizationRecommendation;

            #endregion
        }

        public void TrustedAdvisorGetRecommendation()
        {
            #region GetRecommendation-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.GetRecommendation(new GetRecommendationRequest
            {
                RecommendationIdentifier = "arn:aws:trustedadvisor::000000000000:recommendation/55fa4d2e-bbb7-491a-833b-5773e9589578"
            });

            Recommendation recommendation = response.Recommendation;

            #endregion
        }

        public void TrustedAdvisorListChecks()
        {
            #region ListChecks-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListChecks(new ListChecksRequest
            {
            });

            List<CheckSummary> checkSummaries = response.CheckSummaries;
            string nextToken = response.NextToken;

            #endregion
        }

        public void TrustedAdvisorListOrganizationRecommendationAccounts()
        {
            #region ListOrganizationRecommendationAccounts-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListOrganizationRecommendationAccounts(new ListOrganizationRecommendationAccountsRequest
            {
                OrganizationRecommendationIdentifier = "arn:aws:trustedadvisor:::organization-recommendation/9534ec9b-bf3a-44e8-8213-2ed68b39d9d5"
            });

            List<AccountRecommendationLifecycleSummary> accountRecommendationLifecycleSummaries = response.AccountRecommendationLifecycleSummaries;
            string nextToken = response.NextToken;

            #endregion
        }

        public void TrustedAdvisorListOrganizationRecommendationResources()
        {
            #region ListOrganizationRecommendationResources-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListOrganizationRecommendationResources(new ListOrganizationRecommendationResourcesRequest
            {
                OrganizationRecommendationIdentifier = "arn:aws:trustedadvisor:::organization-recommendation/5a694939-2e54-45a2-ae72-730598fa89d0"
            });

            string nextToken = response.NextToken;
            List<OrganizationRecommendationResourceSummary> organizationRecommendationResourceSummaries = response.OrganizationRecommendationResourceSummaries;

            #endregion
        }

        public void TrustedAdvisorListOrganizationRecommendations()
        {
            #region ListOrganizationRecommendations-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListOrganizationRecommendations(new ListOrganizationRecommendationsRequest
            {
            });

            string nextToken = response.NextToken;
            List<OrganizationRecommendationSummary> organizationRecommendationSummaries = response.OrganizationRecommendationSummaries;

            #endregion
        }

        public void TrustedAdvisorListOrganizationRecommendations()
        {
            #region ListOrganizationRecommendations-2

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListOrganizationRecommendations(new ListOrganizationRecommendationsRequest
            {
                MaxResults = 100,
                Pillar = "security"
            });

            string nextToken = response.NextToken;
            List<OrganizationRecommendationSummary> organizationRecommendationSummaries = response.OrganizationRecommendationSummaries;

            #endregion
        }

        public void TrustedAdvisorListOrganizationRecommendations()
        {
            #region ListOrganizationRecommendations-3

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListOrganizationRecommendations(new ListOrganizationRecommendationsRequest
            {
                MaxResults = 100,
                NextToken = "<REDACTED>",
                Pillar = "security"
            });

            List<OrganizationRecommendationSummary> organizationRecommendationSummaries = response.OrganizationRecommendationSummaries;

            #endregion
        }

        public void TrustedAdvisorListRecommendationResources()
        {
            #region ListRecommendationResources-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListRecommendationResources(new ListRecommendationResourcesRequest
            {
                RecommendationIdentifier = "arn:aws:trustedadvisor::000000000000:recommendation/55fa4d2e-bbb7-491a-833b-5773e9589578"
            });

            string nextToken = response.NextToken;
            List<RecommendationResourceSummary> recommendationResourceSummaries = response.RecommendationResourceSummaries;

            #endregion
        }

        public void TrustedAdvisorListRecommendations()
        {
            #region ListRecommendations-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListRecommendations(new ListRecommendationsRequest
            {
            });

            string nextToken = response.NextToken;
            List<RecommendationSummary> recommendationSummaries = response.RecommendationSummaries;

            #endregion
        }

        public void TrustedAdvisorListRecommendations()
        {
            #region ListRecommendations-2

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListRecommendations(new ListRecommendationsRequest
            {
                AwsService = "iam",
                MaxResults = 100
            });

            string nextToken = response.NextToken;
            List<RecommendationSummary> recommendationSummaries = response.RecommendationSummaries;

            #endregion
        }

        public void TrustedAdvisorListRecommendations()
        {
            #region ListRecommendations-3

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListRecommendations(new ListRecommendationsRequest
            {
                AwsService = "rds",
                MaxResults = 100,
                NextToken = "<REDACTED>"
            });

            List<RecommendationSummary> recommendationSummaries = response.RecommendationSummaries;

            #endregion
        }

        public void TrustedAdvisorListRecommendationsForResource()
        {
            #region ListRecommendationsForResource-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.ListRecommendationsForResource(new ListRecommendationsForResourceRequest
            {
                AwsResourceArn = "arn:aws:ec2:us-east-1:000000000000:instance/i-0abcd1234efgh5678"
            });

            string nextToken = response.NextToken;
            List<RecommendationForResourceSummary> recommendationForResourceSummaries = response.RecommendationForResourceSummaries;

            #endregion
        }

        public void TrustedAdvisorUpdateOrganizationRecommendationLifecycle()
        {
            #region UpdateOrganizationRecommendationLifecycle-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.UpdateOrganizationRecommendationLifecycle(new UpdateOrganizationRecommendationLifecycleRequest
            {
                LifecycleStage = "dismissed",
                OrganizationRecommendationIdentifier = "arn:aws:trustedadvisor:::organization-recommendation/96b5e5ca-7930-444c-90c6-06d386128100",
                UpdateReason = "Does not apply to this resource",
                UpdateReasonCode = "not_applicable"
            });


            #endregion
        }

        public void TrustedAdvisorUpdateRecommendationLifecycle()
        {
            #region UpdateRecommendationLifecycle-1

            var client = new AmazonTrustedAdvisorClient();
            var response = client.UpdateRecommendationLifecycle(new UpdateRecommendationLifecycleRequest
            {
                LifecycleStage = "resolved",
                RecommendationIdentifier = "arn:aws:trustedadvisor::000000000000:recommendation/861c9c6e-f169-405a-8b59-537a8caccd7a",
                UpdateReason = "Resolved the recommendation",
                UpdateReasonCode = "valid_business_case"
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
