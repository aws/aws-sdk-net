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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Container for the parameters to the ListBillScenarios operation.
    /// Lists all bill scenarios for the account.
    /// </summary>
    public partial class ListBillScenariosRequest : AmazonBCMPricingCalculatorRequest
    {
        private FilterTimestamp _createdAtFilter;
        private FilterTimestamp _expiresAtFilter;
        private List<ListBillScenariosFilter> _filters = AWSConfigs.InitializeCollections ? new List<ListBillScenariosFilter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CreatedAtFilter. 
        /// <para>
        ///  Filter bill scenarios based on the creation date. 
        /// </para>
        /// </summary>
        public FilterTimestamp CreatedAtFilter
        {
            get { return this._createdAtFilter; }
            set { this._createdAtFilter = value; }
        }

        // Check to see if CreatedAtFilter property is set
        internal bool IsSetCreatedAtFilter()
        {
            return this._createdAtFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAtFilter. 
        /// <para>
        ///  Filter bill scenarios based on the expiration date. 
        /// </para>
        /// </summary>
        public FilterTimestamp ExpiresAtFilter
        {
            get { return this._expiresAtFilter; }
            set { this._expiresAtFilter = value; }
        }

        // Check to see if ExpiresAtFilter property is set
        internal bool IsSetExpiresAtFilter()
        {
            return this._expiresAtFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  Filters to apply to the list of bill scenarios. 
        /// </para>
        /// </summary>
        public List<ListBillScenariosFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        ///  A token to retrieve the next page of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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