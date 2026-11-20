/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
#pragma warning disable CS0612,CS0618

namespace Amazon.Payments.Model
{
    /// <summary>
    /// Paginators for the Payments service
    /// </summary>
    public class PaymentsPaginatorFactory : IPaymentsPaginatorFactory
    {
        private readonly IAmazonPayments client;

        internal PaymentsPaginatorFactory(IAmazonPayments client)
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetAccountBalance operation
        /// </summary>
        public IGetAccountBalancePaginator GetAccountBalance(GetAccountBalanceRequest request)
        {
            return new GetAccountBalancePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFinancialRecords operation
        /// </summary>
        public IListFinancialRecordsPaginator ListFinancialRecords(ListFinancialRecordsRequest request)
        {
            return new ListFinancialRecordsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPaymentInstruments operation
        /// </summary>
        public IListPaymentInstrumentsPaginator ListPaymentInstruments(ListPaymentInstrumentsRequest request)
        {
            return new ListPaymentInstrumentsPaginator(this.client, request);
        }
    }
}
