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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSavingsPlanRates operation.
    /// Describes the specified Savings Plans rates.
    /// </summary>
    public partial class DescribeSavingsPlanRatesRequest : AmazonSavingsPlansRequest
    {
        private List<SavingsPlanRateFilter> _filters = new List<SavingsPlanRateFilter>();
        private int? _maxResults;
        private string _nextToken;
        private string _savingsPlanId;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        /// </summary>
        public List<SavingsPlanRateFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve additional
        /// results, make another call with the returned token value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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

        /// <summary>
        /// Gets and sets the property SavingsPlanId. 
        /// <para>
        /// The ID of the Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SavingsPlanId
        {
            get { return this._savingsPlanId; }
            set { this._savingsPlanId = value; }
        }

        // Check to see if SavingsPlanId property is set
        internal bool IsSetSavingsPlanId()
        {
            return this._savingsPlanId != null;
        }

    }
}