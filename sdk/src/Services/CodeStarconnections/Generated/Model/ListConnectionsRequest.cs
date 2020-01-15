/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// Container for the parameters to the ListConnections operation.
    /// Lists the connections associated with your account.
    /// </summary>
    public partial class ListConnectionsRequest : AmazonCodeStarconnectionsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ProviderType _providerTypeFilter;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The token that was returned from the previous <code>ListConnections</code> call, which
        /// can be used to return the next set of connections in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ProviderTypeFilter. 
        /// <para>
        /// Filters the list of connections to those associated with a specified provider, such
        /// as Bitbucket.
        /// </para>
        /// </summary>
        public ProviderType ProviderTypeFilter
        {
            get { return this._providerTypeFilter; }
            set { this._providerTypeFilter = value; }
        }

        // Check to see if ProviderTypeFilter property is set
        internal bool IsSetProviderTypeFilter()
        {
            return this._providerTypeFilter != null;
        }

    }
}