using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.PricingPlanManager;
using Amazon.PricingPlanManager.Model;

namespace AWSSDKDocSamples.Amazon.PricingPlanManager.Generated
{
    class PricingPlanManagerSamples : ISample
    {
        public void PricingPlanManagerApprovePaidSubscription()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.ApprovePaidSubscription(new ApprovePaidSubscriptionRequest 
            {
                Arn = "arn:aws:pricingplanmanager::123456789012:subscription/sub-1234567890",
                IfMatch = "1"
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerAssociateResourcesToSubscription()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.AssociateResourcesToSubscription(new AssociateResourcesToSubscriptionRequest 
            {
                Arn = "arn:aws:pricingplanmanager::123456789012:subscription/sub-1234567890",
                IfMatch = "1",
                ResourceArns = new List<string> {
                    "arn:aws:route53:::hostedzone/Z0123456789EXAMPLE"
                }
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerCancelSubscription()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.CancelSubscription(new CancelSubscriptionRequest 
            {
                Arn = "arn:aws:pricingplanmanager::123456789012:subscription/sub-1234567890",
                IfMatch = "2"
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerCancelSubscriptionChange()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.CancelSubscriptionChange(new CancelSubscriptionChangeRequest 
            {
                Arn = "arn:aws:pricingplanmanager::123456789012:subscription/sub-1234567890",
                IfMatch = "3"
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerCreateSubscription()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.CreateSubscription(new CreateSubscriptionRequest 
            {
                ApprovalMode = "MANUAL",
                PlanFamily = "CloudFront",
                PlanTier = "PRO",
                ResourceArns = new List<string> {
                    "arn:aws:cloudfront::123456789012:distribution/EDFDVBD6EXAMPLE",
                    "arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/a1b2c3d4"
                }
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerCreateSubscription()
        {
            #region example-2

            var client = new AmazonPricingPlanManagerClient();
            var response = client.CreateSubscription(new CreateSubscriptionRequest 
            {
                ApprovalMode = "IMMEDIATE",
                PlanFamily = "CloudFront",
                PlanTier = "PRO",
                ResourceArns = new List<string> {
                    "arn:aws:cloudfront::123456789012:distribution/EDFDVBD6EXAMPLE",
                    "arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/a1b2c3d4"
                }
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerDisassociateResourcesFromSubscription()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.DisassociateResourcesFromSubscription(new DisassociateResourcesFromSubscriptionRequest 
            {
                Arn = "arn:aws:pricingplanmanager::123456789012:subscription/sub-1234567890",
                IfMatch = "2",
                ResourceArns = new List<string> {
                    "arn:aws:route53:::hostedzone/Z0123456789EXAMPLE"
                }
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerGetSubscription()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.GetSubscription(new GetSubscriptionRequest 
            {
                Arn = "arn:aws:pricingplanmanager::123456789012:subscription/sub-1234567890"
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        public void PricingPlanManagerListSubscriptions()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.ListSubscriptions(new ListSubscriptionsRequest 
            {
            });

            List<SubscriptionSummary> subscriptionSummaries = response.SubscriptionSummaries;

            #endregion
        }

        public void PricingPlanManagerUpdateSubscription()
        {
            #region example-1

            var client = new AmazonPricingPlanManagerClient();
            var response = client.UpdateSubscription(new UpdateSubscriptionRequest 
            {
                Arn = "arn:aws:pricingplanmanager::123456789012:subscription/sub-1234567890",
                IfMatch = "1",
                PlanTier = "BUSINESS"
            });

            string eTag = response.ETag;
            Subscription subscription = response.Subscription;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}