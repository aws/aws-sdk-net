using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.FreeTier;
using Amazon.FreeTier.Model;

namespace AWSSDKDocSamples.Amazon.FreeTier.Generated
{
    class FreeTierSamples : ISample
    {
        public void FreeTierGetAccountActivity()
        {
            #region example-1

            var client = new AmazonFreeTierClient();
            var response = client.GetAccountActivity(new GetAccountActivityRequest 
            {
                ActivityId = "d622f48bf4014286a2686ab10cacfb2e",
                LanguageCode = "en-US"
            });

            string activityId = response.ActivityId;
            DateTime completedAt = response.CompletedAt;
            string description = response.Description;
            int estimatedTimeToCompleteInMinutes = response.EstimatedTimeToCompleteInMinutes;
            DateTime expiresAt = response.ExpiresAt;
            string instructionsUrl = response.InstructionsUrl;
            ActivityReward reward = response.Reward;
            DateTime startedAt = response.StartedAt;
            string status = response.Status;
            string title = response.Title;

            #endregion
        }

        public void FreeTierGetAccountPlanState()
        {
            #region example-1

            var client = new AmazonFreeTierClient();
            var response = client.GetAccountPlanState(new GetAccountPlanStateRequest 
            {
            });

            string accountId = response.AccountId;
            DateTime accountPlanExpirationDate = response.AccountPlanExpirationDate;
            MonetaryAmount accountPlanRemainingCredits = response.AccountPlanRemainingCredits;
            string accountPlanStatus = response.AccountPlanStatus;
            string accountPlanType = response.AccountPlanType;

            #endregion
        }

        public void FreeTierGetAccountPlanState()
        {
            #region example-2

            var client = new AmazonFreeTierClient();
            var response = client.GetAccountPlanState(new GetAccountPlanStateRequest 
            {
            });


            #endregion
        }

        public void FreeTierGetAccountPlanState()
        {
            #region example-3

            var client = new AmazonFreeTierClient();
            var response = client.GetAccountPlanState(new GetAccountPlanStateRequest 
            {
            });


            #endregion
        }

        public void FreeTierGetAccountPlanState()
        {
            #region example-4

            var client = new AmazonFreeTierClient();
            var response = client.GetAccountPlanState(new GetAccountPlanStateRequest 
            {
            });


            #endregion
        }

        public void FreeTierGetAccountPlanState()
        {
            #region example-5

            var client = new AmazonFreeTierClient();
            var response = client.GetAccountPlanState(new GetAccountPlanStateRequest 
            {
            });


            #endregion
        }

        public void FreeTierListAccountActivities()
        {
            #region example-1

            var client = new AmazonFreeTierClient();
            var response = client.ListAccountActivities(new ListAccountActivitiesRequest 
            {
                FilterActivityStatuses = new List<string> {
                    "COMPLETED"
                },
                LanguageCode = "en-US",
                MaxResults = 1
            });

            List<ActivitySummary> activities = response.Activities;
            string nextToken = response.NextToken;

            #endregion
        }

        public void FreeTierUpgradeAccountPlan()
        {
            #region example-1

            var client = new AmazonFreeTierClient();
            var response = client.UpgradeAccountPlan(new UpgradeAccountPlanRequest 
            {
                AccountPlanType = "PAID"
            });

            string accountId = response.AccountId;
            string accountPlanStatus = response.AccountPlanStatus;
            string accountPlanType = response.AccountPlanType;

            #endregion
        }

        public void FreeTierUpgradeAccountPlan()
        {
            #region example-2

            var client = new AmazonFreeTierClient();
            var response = client.UpgradeAccountPlan(new UpgradeAccountPlanRequest 
            {
                AccountPlanType = "PAID"
            });


            #endregion
        }

        public void FreeTierUpgradeAccountPlan()
        {
            #region example-3

            var client = new AmazonFreeTierClient();
            var response = client.UpgradeAccountPlan(new UpgradeAccountPlanRequest 
            {
                AccountPlanType = "FREE"
            });


            #endregion
        }

        public void FreeTierUpgradeAccountPlan()
        {
            #region example-4

            var client = new AmazonFreeTierClient();
            var response = client.UpgradeAccountPlan(new UpgradeAccountPlanRequest 
            {
                AccountPlanType = "PAID"
            });


            #endregion
        }

        public void FreeTierUpgradeAccountPlan()
        {
            #region example-5

            var client = new AmazonFreeTierClient();
            var response = client.UpgradeAccountPlan(new UpgradeAccountPlanRequest 
            {
                AccountPlanType = "PAID"
            });


            #endregion
        }

        public void FreeTierUpgradeAccountPlan()
        {
            #region example-6

            var client = new AmazonFreeTierClient();
            var response = client.UpgradeAccountPlan(new UpgradeAccountPlanRequest 
            {
                AccountPlanType = "PAID"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}