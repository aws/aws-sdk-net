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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
    /// Container for the parameters to the ListEnterpriseSupportLinkedAccountCharges operation.
    /// Returns Support-eligible spend broken down at linked account level.
    /// </summary>
    public partial class ListEnterpriseSupportLinkedAccountChargesRequest : AmazonBillingRequest
    {
        private string _accountId;
        private string _billingMonth;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// An optional linked account ID to filter results to a specific account.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month in YYYY-MM format. This must be a month in the past.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BillingMonth
        {
            get { return this._billingMonth; }
            set { this._billingMonth = value; }
        }

        // Check to see if BillingMonth property is set
        internal bool IsSetBillingMonth()
        {
            return this._billingMonth != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4095)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}