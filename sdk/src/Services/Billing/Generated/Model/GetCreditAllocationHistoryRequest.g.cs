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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// Container for the parameters to the GetCreditAllocationHistory operation. Returns
    /// the per-billing-month allocation history for credits applied to an Amazon Web Services
    /// account's bills. Traverses the consolidated billing family to capture cross-account
    /// credit applications. Supports pagination and optional filtering to a single credit.
    /// </summary>
    public partial class GetCreditAllocationHistoryRequest : AmazonBillingRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID whose allocation history to retrieve. Must be a
        /// 12-digit numeric string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CreditId. 
        /// <para>
        /// Filters the result to a single credit. When omitted, returns allocation entries for
        /// all credits.
        /// </para>
        /// </summary>
        public long? CreditId { get; set; }

        /// <summary>
        /// Checks to see if the CreditId property is set.
        /// </summary>
        internal bool IsSetCreditId() => this.CreditId.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// Inclusive end date as Unix epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to return per page. Range: 1 to 1000. Default: 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from a previous response. Pass the value returned in <c>nextToken</c>
        /// to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4095)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// Inclusive start date as Unix epoch seconds. Must be on or before <c>endDate</c>. The
        /// range from <c>startDate</c> to <c>endDate</c> cannot exceed 24 billing months.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
