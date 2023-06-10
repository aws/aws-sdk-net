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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListReceivedGrants operation.
    /// Lists grants that are received. Received grants are grants created while specifying
    /// the recipient as this Amazon Web Services account, your organization, or an organizational
    /// unit (OU) to which this member account belongs.
    /// </summary>
    public partial class ListReceivedGrantsRequest : AmazonLicenseManagerRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _grantArns = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to scope the results. The following filters are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ProductSKU</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LicenseIssuerName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LicenseArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GrantStatus</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GranterAccountId</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
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
        /// Gets and sets the property GrantArns. 
        /// <para>
        /// Amazon Resource Names (ARNs) of the grants.
        /// </para>
        /// </summary>
        public List<string> GrantArns
        {
            get { return this._grantArns; }
            set { this._grantArns = value; }
        }

        // Check to see if GrantArns property is set
        internal bool IsSetGrantArns()
        {
            return this._grantArns != null && this._grantArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Token for the next set of results.
        /// </para>
        /// </summary>
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