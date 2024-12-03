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
    /// Container for the parameters to the ListBillingViews operation.
    /// Lists the billing views available for a given time period. 
    /// 
    ///  
    /// <para>
    /// Every Amazon Web Services account has a unique <c>PRIMARY</c> billing view that represents
    /// the billing data available by default. Accounts that use Billing Conductor also have
    /// <c>BILLING_GROUP</c> billing views representing pro forma costs associated with each
    /// created billing group.
    /// </para>
    /// </summary>
    public partial class ListBillingViewsRequest : AmazonBillingRequest
    {
        private ActiveTimeRange _activeTimeRange;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ActiveTimeRange. 
        /// <para>
        ///  The time range for the billing views listed. <c>PRIMARY</c> billing view is always
        /// listed. <c>BILLING_GROUP</c> billing views are listed for time ranges when the associated
        /// billing group resource in Billing Conductor is active. The time range must be within
        /// one calendar month. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActiveTimeRange ActiveTimeRange
        {
            get { return this._activeTimeRange; }
            set { this._activeTimeRange = value; }
        }

        // Check to see if ActiveTimeRange property is set
        internal bool IsSetActiveTimeRange()
        {
            return this._activeTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of billing views to retrieve. Default is 100. 
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
        /// The pagination token that is used on subsequent calls to list billing views.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2047)]
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