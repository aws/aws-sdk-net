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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListSites operation.
    /// Create a list of the Outpost sites for your Amazon Web Services account. Add operating
    /// address filters to your request to return a more specific list of results. Use filters
    /// to match site city, country code, or state/region of the operating address. 
    /// 
    ///  
    /// <para>
    /// If you specify multiple filters, the filters are joined with an <code>AND</code>,
    /// and the request returns only results that match all of the specified filters.
    /// </para>
    /// </summary>
    public partial class ListSitesRequest : AmazonOutpostsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _operatingAddressCityFilter = new List<string>();
        private List<string> _operatingAddressCountryCodeFilter = new List<string>();
        private List<string> _operatingAddressStateOrRegionFilter = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults.
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
        /// </summary>
        [AWSProperty(Min=1, Max=1005)]
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
        /// Gets and sets the property OperatingAddressCityFilter. 
        /// <para>
        ///  A filter for the city of the Outpost site. 
        /// </para>
        ///  
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <code>OR</code>, and the request returns all results that
        /// match any of the specified values.
        /// </para>
        /// </summary>
        public List<string> OperatingAddressCityFilter
        {
            get { return this._operatingAddressCityFilter; }
            set { this._operatingAddressCityFilter = value; }
        }

        // Check to see if OperatingAddressCityFilter property is set
        internal bool IsSetOperatingAddressCityFilter()
        {
            return this._operatingAddressCityFilter != null && this._operatingAddressCityFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OperatingAddressCountryCodeFilter. 
        /// <para>
        ///  A filter for the country code of the Outpost site. 
        /// </para>
        ///  
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <code>OR</code>, and the request returns all results that
        /// match any of the specified values.
        /// </para>
        /// </summary>
        public List<string> OperatingAddressCountryCodeFilter
        {
            get { return this._operatingAddressCountryCodeFilter; }
            set { this._operatingAddressCountryCodeFilter = value; }
        }

        // Check to see if OperatingAddressCountryCodeFilter property is set
        internal bool IsSetOperatingAddressCountryCodeFilter()
        {
            return this._operatingAddressCountryCodeFilter != null && this._operatingAddressCountryCodeFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OperatingAddressStateOrRegionFilter. 
        /// <para>
        ///  A filter for the state/region of the Outpost site. 
        /// </para>
        ///  
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <code>OR</code>, and the request returns all results that
        /// match any of the specified values.
        /// </para>
        /// </summary>
        public List<string> OperatingAddressStateOrRegionFilter
        {
            get { return this._operatingAddressStateOrRegionFilter; }
            set { this._operatingAddressStateOrRegionFilter = value; }
        }

        // Check to see if OperatingAddressStateOrRegionFilter property is set
        internal bool IsSetOperatingAddressStateOrRegionFilter()
        {
            return this._operatingAddressStateOrRegionFilter != null && this._operatingAddressStateOrRegionFilter.Count > 0; 
        }

    }
}