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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePullThroughCacheRules operation.
    /// Returns the pull through cache rules for a registry.
    /// </summary>
    public partial class DescribePullThroughCacheRulesRequest : AmazonECRRequest
    {
        private List<string> _ecrRepositoryPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _registryId;

        /// <summary>
        /// Gets and sets the property EcrRepositoryPrefixes. 
        /// <para>
        /// The Amazon ECR repository prefixes associated with the pull through cache rules to
        /// return. If no repository prefix value is specified, all pull through cache rules are
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> EcrRepositoryPrefixes
        {
            get { return this._ecrRepositoryPrefixes; }
            set { this._ecrRepositoryPrefixes = value; }
        }

        // Check to see if EcrRepositoryPrefixes property is set
        internal bool IsSetEcrRepositoryPrefixes()
        {
            return this._ecrRepositoryPrefixes != null && (this._ecrRepositoryPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of pull through cache rules returned by <c>DescribePullThroughCacheRulesRequest</c>
        /// in paginated output. When this parameter is used, <c>DescribePullThroughCacheRulesRequest</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>DescribePullThroughCacheRulesRequest</c> request with the returned <c>nextToken</c>
        /// value. This value can be between 1 and 1000. If this parameter is not used, then <c>DescribePullThroughCacheRulesRequest</c>
        /// returns up to 100 results and a <c>nextToken</c> value, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The <c>nextToken</c> value returned from a previous paginated <c>DescribePullThroughCacheRulesRequest</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. This value is null when there are no more results to return.
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry to return the pull
        /// through cache rules for. If you do not specify a registry, the default registry is
        /// assumed.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

    }
}