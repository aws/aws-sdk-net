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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRepositories operation.
    /// Describes repositories that are in a public registry.
    /// </summary>
    public partial class DescribeRepositoriesRequest : AmazonECRPublicRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _registryId;
        private List<string> _repositoryNames = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results that's returned by <code>DescribeRepositories</code>
        /// in paginated output. When this parameter is used, <code>DescribeRepositories</code>
        /// only returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. You can see the remaining results of the initial request by sending
        /// another <code>DescribeRepositories</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 1000. If this parameter isn't used, then <code>DescribeRepositories</code>
        /// returns up to 100 results and a <code>nextToken</code> value, if applicable. If you
        /// specify repositories with <code>repositoryNames</code>, you can't use this option.
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
        /// The <code>nextToken</code> value that's returned from a previous paginated <code>DescribeRepositories</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. If there are no more results to return,
        /// this value is <code>null</code>. If you specify repositories with <code>repositoryNames</code>,
        /// you can't use this option.
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
        /// The Amazon Web Services account ID that's associated with the registry that contains
        /// the repositories to be described. If you do not specify a registry, the default public
        /// registry is assumed.
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
            return this._repositoryNames != null && this._repositoryNames.Count > 0; 
        }

    }
}