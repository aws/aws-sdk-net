using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MarketplaceAgreement;
using Amazon.MarketplaceAgreement.Model;

namespace AWSSDKDocSamples.Amazon.MarketplaceAgreement.Generated
{
    class MarketplaceAgreementSamples : ISample
    {
        public void MarketplaceAgreementBatchCreateBillingAdjustmentRequest()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.BatchCreateBillingAdjustmentRequest(new BatchCreateBillingAdjustmentRequestRequest 
            {
                BillingAdjustmentRequestEntries = new List<BatchCreateBillingAdjustmentRequestEntry> {
                    new BatchCreateBillingAdjustmentRequestEntry {
                        AdjustmentAmount = "500.00",
                        AdjustmentReasonCode = "OTHER",
                        AgreementId = "agmt-SvIzsqYMyQwI3GWgJAe17URx",
                        ClientToken = "71a5e82e-a49b-4075-8c7f-52df1d294379",
                        CurrencyCode = "USD",
                        Description = "Customer requested adjustment due to service outage during critical business period.",
                        OriginalInvoiceId = "E2E20230929a108cfae"
                    }
                }
            });

            List<BatchCreateBillingAdjustmentError> errors = response.Errors;
            List<BatchCreateBillingAdjustmentItem> items = response.Items;

            #endregion
        }

        public void MarketplaceAgreementCancelAgreementCancellationRequest()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.CancelAgreementCancellationRequest(new CancelAgreementCancellationRequestRequest 
            {
                AgreementCancellationRequestId = "acr-752jqvg74yo7k4h56cakk6396",
                AgreementId = "agmt-752jqvg74yo7k4h56cakk6396",
                CancellationReason = "Requested agreement cancellation by mistake"
            });

            string agreementCancellationRequestId = response.AgreementCancellationRequestId;
            string agreementId = response.AgreementId;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string reasonCode = response.ReasonCode;
            string status = response.Status;
            string statusMessage = response.StatusMessage;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MarketplaceAgreementGetAgreementCancellationRequest()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetAgreementCancellationRequest(new GetAgreementCancellationRequestRequest 
            {
                AgreementCancellationRequestId = "acr-sgew33rhsds",
                AgreementId = "agmt-752jqvg74yo7k"
            });

            string agreementCancellationRequestId = response.AgreementCancellationRequestId;
            string agreementId = response.AgreementId;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string reasonCode = response.ReasonCode;
            string status = response.Status;
            string statusMessage = response.StatusMessage;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MarketplaceAgreementGetBillingAdjustmentRequest()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetBillingAdjustmentRequest(new GetBillingAdjustmentRequestRequest 
            {
                AgreementId = "agmt-SvIzsqYMyQwI3GWgJAe17URx",
                BillingAdjustmentRequestId = "ba-1a2b3c4d5e6f7g"
            });

            string adjustmentAmount = response.AdjustmentAmount;
            string adjustmentReasonCode = response.AdjustmentReasonCode;
            string agreementId = response.AgreementId;
            string billingAdjustmentRequestId = response.BillingAdjustmentRequestId;
            DateTime createdAt = response.CreatedAt;
            string currencyCode = response.CurrencyCode;
            string description = response.Description;
            string originalInvoiceId = response.OriginalInvoiceId;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MarketplaceAgreementListAgreementCancellationRequests()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.ListAgreementCancellationRequests(new ListAgreementCancellationRequestsRequest 
            {
                MaxResults = 10,
                PartyType = "Proposer"
            });

            List<AgreementCancellationRequestSummary> items = response.Items;

            #endregion
        }

        public void MarketplaceAgreementListAgreementInvoiceLineItems()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.ListAgreementInvoiceLineItems(new ListAgreementInvoiceLineItemsRequest 
            {
                AgreementId = "agmt-EXAMPLESvIzsqYMyQwI3",
                GroupBy = "INVOICE_ID"
            });

            List<AgreementInvoiceLineItemGroupSummary> agreementInvoiceLineItemGroupSummaries = response.AgreementInvoiceLineItemGroupSummaries;

            #endregion
        }

        public void MarketplaceAgreementListBillingAdjustmentRequests()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.ListBillingAdjustmentRequests(new ListBillingAdjustmentRequestsRequest 
            {
                AgreementId = "agmt-SvIzsqYMyQwI3GWgJAe17URx"
            });

            List<BillingAdjustmentSummary> items = response.Items;

            #endregion
        }

        public void MarketplaceAgreementSendAgreementCancellationRequest()
        {
            #region example-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.SendAgreementCancellationRequest(new SendAgreementCancellationRequestRequest 
            {
                AgreementId = "agmt-752jqvg74yo7k4h56cakk6396",
                ClientToken = "53nQSKWt6AjrsiZPhzQyZT",
                Description = "Due to budget constraints, we are unable to continue with our current subscription",
                ReasonCode = "OTHER"
            });

            string agreementCancellationRequestId = response.AgreementCancellationRequestId;
            string agreementId = response.AgreementId;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string reasonCode = response.ReasonCode;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}