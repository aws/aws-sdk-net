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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRepositories operation.
    /// Describes image repositories in a registry.
    /// </summary>
    public partial class DescribeRepositoriesRequest : AmazonECRRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _registryId;
        private List<string> _repositoryNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results returned by <c>DescribeRepositories</c> in
        /// paginated output. When this parameter is used, <c>DescribeRepositories</c> only returns
        /// <c>maxResults</c> results in a single page along with a <c>nextToken</c> response
        /// element. The remaining results of the initial request can be seen by sending another
        /// <c>DescribeRepositories</c> request with the returned <c>nextToken</c> value. This
        /// value can be between 1 and 1000. If this parameter is not used, then <c>DescribeRepositories</c>
        /// returns up to 100 results and a <c>nextToken</c> value, if applicable. This option
        /// cannot be used when you specify repositories with <c>repositoryNames</c>.
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
        /// The <c>nextToken</c> value returned from a previous paginated <c>DescribeRepositories</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. This value is <c>null</c> when there are no more results
        /// to return. This option cannot be used when you specify repositories with <c>repositoryNames</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// repositories to be described. If you do not specify a registry, the default registry
        /// is assumed.
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

        /// <summary>
        /// Gets and sets the property RepositoryNames. 
        /// <para>
        /// A list of repositories to describe. If this parameter is omitted, then all repositories
        /// in a registry are described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> RepositoryNames
        {
            get { return this._repositoryNames; }
            set { this._repositoryNames = value; }
        }

        // Check to see if RepositoryNames property is set
        internal bool IsSetRepositoryNames()
        {
            return this._repositoryNames != null && (this._repositoryNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}