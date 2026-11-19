using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MarketplaceAgreement;
using Amazon.MarketplaceAgreement.Model;

namespace AWSSDKDocSamples.Amazon.MarketplaceAgreement.Generated
{
    class MarketplaceAgreementSamples : ISample
    {
        public void MarketplaceAgreementAcceptAgreementApproval()
        {
            #region AcceptAgreementApproval-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.AcceptAgreementApproval(new AcceptAgreementApprovalRequest
            {
                BuyerAgreementApprovalApproverInput = new BuyerAgreementApprovalApproverInput {
                    AgreementApprovalId = "apr-EXAMPLE9s0t1u2v3w4x",
                    Note = "Approved. Budget confirmed for this fiscal year.",
                    PurchaseOrders = new List<AgreementApprovalPurchaseOrder> {
                        new AgreementApprovalPurchaseOrder {
                            ChargeId = "ch-EXAMPLE4b4296145c3EXAMPLE56",
                            PurchaseOrderReference = "PO-123"
                        }
                    }
                }
            });


            #endregion
        }

        public void MarketplaceAgreementBatchCreateBillingAdjustmentRequest()
        {
            #region BatchCreateBillingAdjustmentRequest-1

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
            #region CancelAgreementCancellationRequest-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.CancelAgreementCancellationRequest(new CancelAgreementCancellationRequestRequest
            {
                AgreementCancellationRequestId = "acr-752jqvg74yo7k4h56cakk6396",
                AgreementId = "agmt-752jqvg74yo7k4h56cakk6396",
                CancellationReason = "Requested agreement cancellation by mistake"
            });

            string agreementCancellationRequestId = response.AgreementCancellationRequestId;
            string agreementId = response.AgreementId;
            DateTime? createdAt = response.CreatedAt;
            string description = response.Description;
            AgreementCancellationRequestReasonCode reasonCode = response.ReasonCode;
            AgreementCancellationRequestStatus status = response.Status;
            string statusMessage = response.StatusMessage;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MarketplaceAgreementCancelAgreementRequest()
        {
            #region CancelAgreementRequest-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.CancelAgreementRequest(new CancelAgreementRequestRequest
            {
                AgreementRequestId = "ar-EXAMPLE4a539b123d4EXAMPLE78"
            });


            #endregion
        }

        public void MarketplaceAgreementGetAgreementApproval()
        {
            #region GetAgreementApproval-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetAgreementApproval(new GetAgreementApprovalRequest
            {
                AgreementApprovalId = "apr-EXAMPLE9s0t1u2v3w4x"
            });

            BuyerAgreementApproval buyerAgreementApproval = response.BuyerAgreementApproval;

            #endregion
        }

        public void MarketplaceAgreementGetAgreementCancellationRequest()
        {
            #region GetAgreementCancellationRequest-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetAgreementCancellationRequest(new GetAgreementCancellationRequestRequest
            {
                AgreementCancellationRequestId = "acr-sgew33rhsds",
                AgreementId = "agmt-752jqvg74yo7k"
            });

            string agreementCancellationRequestId = response.AgreementCancellationRequestId;
            string agreementId = response.AgreementId;
            DateTime? createdAt = response.CreatedAt;
            string description = response.Description;
            AgreementCancellationRequestReasonCode reasonCode = response.ReasonCode;
            AgreementCancellationRequestStatus status = response.Status;
            string statusMessage = response.StatusMessage;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MarketplaceAgreementGetAgreementContacts()
        {
            #region GetAgreementContacts-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetAgreementContacts(new GetAgreementContactsRequest
            {
                AgreementId = "agmt-xxxxxxx"
            });

            AcceptorContact acceptorContact = response.AcceptorContact;

            #endregion
        }

        public void MarketplaceAgreementGetAgreementRequest()
        {
            #region GetAgreementRequest-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetAgreementRequest(new GetAgreementRequestRequest
            {
                AgreementRequestId = "ar-EXAMPLE4a539b123d4EXAMPLE78"
            });

            string agreementRequestId = response.AgreementRequestId;
            string agreementType = response.AgreementType;
            ApprovalRequirement approvalRequirement = response.ApprovalRequirement;
            ChargeSummary chargeSummary = response.ChargeSummary;
            DateTime? createdAt = response.CreatedAt;
            Intent intent = response.Intent;
            ProposalSummary proposalSummary = response.ProposalSummary;
            Proposer proposer = response.Proposer;
            AgreementRequestStatus status = response.Status;

            #endregion
        }

        public void MarketplaceAgreementGetAgreementRequestApprovalPlans()
        {
            #region GetAgreementRequestApprovalPlans-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetAgreementRequestApprovalPlans(new GetAgreementRequestApprovalPlansRequest
            {
                AgreementRequestId = "ar-EXAMPLE4a539b123d4EXAMPLE78"
            });

            List<AgreementApprovalPlan> items = response.Items;

            #endregion
        }

        public void MarketplaceAgreementGetAgreementRequestTerms()
        {
            #region GetAgreementRequestTerms-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetAgreementRequestTerms(new GetAgreementRequestTermsRequest
            {
                AgreementRequestId = "ar-EXAMPLE4a539b123d4EXAMPLE78"
            });

            List<AgreementRequestTerm> terms = response.Terms;

            #endregion
        }

        public void MarketplaceAgreementGetBillingAdjustmentRequest()
        {
            #region GetBillingAdjustmentRequest-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.GetBillingAdjustmentRequest(new GetBillingAdjustmentRequestRequest
            {
                AgreementId = "agmt-SvIzsqYMyQwI3GWgJAe17URx",
                BillingAdjustmentRequestId = "ba-1a2b3c4d5e6f7g"
            });

            string adjustmentAmount = response.AdjustmentAmount;
            BillingAdjustmentReasonCode adjustmentReasonCode = response.AdjustmentReasonCode;
            string agreementId = response.AgreementId;
            string billingAdjustmentRequestId = response.BillingAdjustmentRequestId;
            DateTime? createdAt = response.CreatedAt;
            string currencyCode = response.CurrencyCode;
            string description = response.Description;
            string originalInvoiceId = response.OriginalInvoiceId;
            BillingAdjustmentStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MarketplaceAgreementListAgreementApprovals()
        {
            #region ListAgreementApprovals-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.ListAgreementApprovals(new ListAgreementApprovalsRequest
            {
                MaxResults = 10,
                PartyType = "REQUESTER",
                Status = "PENDING_APPROVAL"
            });

            List<AgreementApprovalSummary> items = response.Items;

            #endregion
        }

        public void MarketplaceAgreementListAgreementCancellationRequests()
        {
            #region ListAgreementCancellationRequests-1

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
            #region ListAgreementInvoiceLineItems-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.ListAgreementInvoiceLineItems(new ListAgreementInvoiceLineItemsRequest
            {
                AgreementId = "agmt-EXAMPLESvIzsqYMyQwI3",
                GroupBy = "INVOICE_ID"
            });

            List<AgreementInvoiceLineItemGroupSummary> agreementInvoiceLineItemGroupSummaries = response.AgreementInvoiceLineItemGroupSummaries;

            #endregion
        }

        public void MarketplaceAgreementListAgreementRequests()
        {
            #region ListAgreementRequests-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.ListAgreementRequests(new ListAgreementRequestsRequest
            {
                MaxResults = 10,
                Status = "PENDING_APPROVAL"
            });

            List<AgreementRequestSummary> items = response.Items;

            #endregion
        }

        public void MarketplaceAgreementListBillingAdjustmentRequests()
        {
            #region ListBillingAdjustmentRequests-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.ListBillingAdjustmentRequests(new ListBillingAdjustmentRequestsRequest
            {
                AgreementId = "agmt-SvIzsqYMyQwI3GWgJAe17URx"
            });

            List<BillingAdjustmentSummary> items = response.Items;

            #endregion
        }

        public void MarketplaceAgreementRejectAgreementApproval()
        {
            #region RejectAgreementApproval-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.RejectAgreementApproval(new RejectAgreementApprovalRequest
            {
                BuyerAgreementApprovalRejectionInput = new BuyerAgreementApprovalRejectionInput {
                    AgreementApprovalId = "apr-EXAMPLE9s0t1u2v3w4x",
                    Note = "Rejected. This purchase isn't in the approved budget."
                }
            });


            #endregion
        }

        public void MarketplaceAgreementSendAgreementCancellationRequest()
        {
            #region SendAgreementCancellationRequest-1

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
            DateTime? createdAt = response.CreatedAt;
            string description = response.Description;
            AgreementCancellationRequestReasonCode reasonCode = response.ReasonCode;
            AgreementCancellationRequestStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void MarketplaceAgreementStartAgreementApprovals()
        {
            #region StartAgreementApprovals-1

            var client = new AmazonMarketplaceAgreementClient();
            var response = client.StartAgreementApprovals(new StartAgreementApprovalsRequest
            {
                AgreementRequestId = "ar-EXAMPLE4a539b123d4EXAMPLE78",
                PlanInputs = new List<AgreementApprovalPlanInput> {
                    new AgreementApprovalPlanInput { BuyerAgreementApprovalPlanInput = new BuyerAgreementApprovalPlanInput {
                        PlanReference = "aplan-EXAMPLE7g8h9i0j1k2l",
                        RequesterNote = "Annual subscription for the data platform team."
                    } }
                },
                PurchaseOrders = new List<AgreementApprovalPurchaseOrder> {
                    new AgreementApprovalPurchaseOrder {
                        ChargeId = "ch-EXAMPLE4b4296145c3EXAMPLE56",
                        PurchaseOrderReference = "PO-123"
                    }
                }
            });

            List<AgreementApprovalSummary> approvalSummaries = response.ApprovalSummaries;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
