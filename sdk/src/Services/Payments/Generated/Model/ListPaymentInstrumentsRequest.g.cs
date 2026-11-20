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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Payments.Model
{
    /// <summary>
    /// Container for the parameters to the ListPaymentInstruments operation. Lists the payment
    /// instruments on your account. This operation returns summaries. To get the details
    /// that are specific to an instrument's payment method, use <c>GetPaymentInstrument</c>.
    /// Results are paginated. Use <c>nextToken</c> to retrieve more results. <para> To use
    /// this operation, you must have Amazon Web Services Identity and Access Management (IAM)
    /// permission for <c>payments:ListPaymentInstruments</c>. </para>
    /// </summary>
    public partial class ListPaymentInstrumentsRequest : AmazonPaymentsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of payment instruments to return in one page. The default is 25.
        /// A page can contain fewer payment instruments even when more remain. Use <c>nextToken</c>
        /// to find out whether more payment instruments are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from the <c>nextToken</c> of the previous response. Omit it to
        /// get the first page. Tokens expire. If the token is malformed or expired, or doesn't
        /// match the original request, the request fails with <c>ValidationException</c> and
        /// the reason <c>INVALID_PAGINATION_TOKEN</c>. In that case, start again from the first
        /// page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
