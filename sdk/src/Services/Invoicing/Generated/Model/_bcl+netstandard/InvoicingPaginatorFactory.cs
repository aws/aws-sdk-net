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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Paginators for the Invoicing service
    ///</summary>
    public class InvoicingPaginatorFactory : IInvoicingPaginatorFactory
    {
        private readonly IAmazonInvoicing client;

        internal InvoicingPaginatorFactory(IAmazonInvoicing client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListInvoiceSummaries operation
        ///</summary>
        public IListInvoiceSummariesPaginator ListInvoiceSummaries(ListInvoiceSummariesRequest request) 
        {
            return new ListInvoiceSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvoiceUnits operation
        ///</summary>
        public IListInvoiceUnitsPaginator ListInvoiceUnits(ListInvoiceUnitsRequest request) 
        {
            return new ListInvoiceUnitsPaginator(this.client, request);
        }
    }
}