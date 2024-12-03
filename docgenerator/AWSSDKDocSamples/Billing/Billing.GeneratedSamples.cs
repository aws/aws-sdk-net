using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Billing;
using Amazon.Billing.Model;

namespace AWSSDKDocSamples.Amazon.Billing.Generated
{
    class BillingSamples : ISample
    {
        public void BillingListBillingViews()
        {
            #region example-1

            var client = new AmazonBillingClient();
            var response = client.ListBillingViews(new ListBillingViewsRequest 
            {
                ActiveTimeRange = new ActiveTimeRange {
                    ActiveAfterInclusive = DateTime.UtcNow,
                    ActiveBeforeInclusive = DateTime.UtcNow
                }
            });

            List<BillingViewListElement> billingViews = response.BillingViews;

            #endregion
        }

        public void BillingListBillingViews()
        {
            #region example-2

            var client = new AmazonBillingClient();
            var response = client.ListBillingViews(new ListBillingViewsRequest 
            {
                ActiveTimeRange = new ActiveTimeRange {
                    ActiveAfterInclusive = DateTime.UtcNow,
                    ActiveBeforeInclusive = DateTime.UtcNow
                }
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