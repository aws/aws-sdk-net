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
    /// This is the response object from the DescribeSavingsPlanRates operation.
    /// </summary>
    public partial class DescribeSavingsPlanRatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private string _savingsPlanId;
        private List<SavingsPlanRate> _searchResults = new List<SavingsPlanRate>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is null when there
        /// are no more results to return.
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

        /// <summary>
        /// Gets and sets the property SearchResults. 
        /// <para>
        /// Information about the Savings Plans rates.
        /// </para>
        /// </summary>
        public List<SavingsPlanRate> SearchResults
        {
            get { return this._searchResults; }
            set { this._searchResults = value; }
        }

        // Check to see if SearchResults property is set
        internal bool IsSetSearchResults()
        {
            return this._searchResults != null && this._searchResults.Count > 0; 
        }

    }
}