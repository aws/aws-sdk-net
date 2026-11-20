using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Payments;
using Amazon.Payments.Model;

namespace AWSSDKDocSamples.Amazon.Payments.Generated
{
    class PaymentsSamples : ISample
    {
        public void PaymentsBatchGetFinancialRecord()
        {
            #region BatchGetFinancialRecord-1

            var client = new AmazonPaymentsClient();
            var response = client.BatchGetFinancialRecord(new BatchGetFinancialRecordRequest
            {
                Keys = new List<FinancialRecordKey> {
                    new FinancialRecordKey { Identifier = "INV-1234-5678-9012-3456" },
                    new FinancialRecordKey { InvoiceIdentifier = "999999999999" }
                }
            });

            List<FinancialRecordError> errors = response.Errors;
            List<FinancialRecord> financialRecords = response.FinancialRecords;

            #endregion
        }

        public void PaymentsGetAccountBalance()
        {
            #region GetAccountBalance-1

            var client = new AmazonPaymentsClient();
            var response = client.GetAccountBalance(new GetAccountBalanceRequest
            {
                BalanceType = "INVOICES_PAST_DUE"
            });

            List<AccountBalance> accountBalances = response.AccountBalances;

            #endregion
        }

        public void PaymentsGetFinancialRecord()
        {
            #region GetFinancialRecord-1

            var client = new AmazonPaymentsClient();
            var response = client.GetFinancialRecord(new GetFinancialRecordRequest
            {
                Identifier = "INV-1234-5678-9012-3456"
            });

            FinancialRecord financialRecord = response.FinancialRecord;

            #endregion
        }

        public void PaymentsGetPaymentInstrument()
        {
            #region GetPaymentInstrument-1

            var client = new AmazonPaymentsClient();
            var response = client.GetPaymentInstrument(new GetPaymentInstrumentRequest
            {
                Identifier = "arn:aws:payments::123456789012:payment-instrument:1a2b3c4d-5e6f-7a8b-9c0d-111122223333"
            });

            PaymentInstrument paymentInstrument = response.PaymentInstrument;

            #endregion
        }

        public void PaymentsListFinancialRecords()
        {
            #region ListFinancialRecords-1

            var client = new AmazonPaymentsClient();
            var response = client.ListFinancialRecords(new ListFinancialRecordsRequest
            {
                MaxResults = 5,
                SettlementStatuses = new List<string> {
                    "CLOSED"
                },
                SortBy = "ISSUED_AT",
                SortOrder = "DESCENDING",
                Types = new List<string> {
                    "INVOICE"
                }
            });

            List<FinancialRecordSummary> financialRecordSummaries = response.FinancialRecordSummaries;

            #endregion
        }

        public void PaymentsListPaymentInstruments()
        {
            #region ListPaymentInstruments-1

            var client = new AmazonPaymentsClient();
            var response = client.ListPaymentInstruments(new ListPaymentInstrumentsRequest
            {
                MaxResults = 5
            });

            List<PaymentInstrumentSummary> paymentInstrumentSummaries = response.PaymentInstrumentSummaries;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
