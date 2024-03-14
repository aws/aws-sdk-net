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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the ListProductSubscriptions operation.
    /// Lists the user-based subscription products available from an identity provider.
    /// </summary>
    public partial class ListProductSubscriptionsRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private IdentityProvider _identityProvider;
        private int? _maxResults;
        private string _nextToken;
        private string _product;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of structures that you can use to filter the results to those that match
        /// one or more sets of key-value pairs that you specify.
        /// </para>
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
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// An object that specifies details for the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityProvider IdentityProvider
        {
            get { return this._identityProvider; }
            set { this._identityProvider = value; }
        }

        // Check to see if IdentityProvider property is set
        internal bool IsSetIdentityProvider()
        {
            return this._identityProvider != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single call.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The name of the user-based subscription product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        // Check to see if Product property is set
        internal bool IsSetProduct()
        {
            return this._product != null;
        }

    }
}