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
    /// Container for the parameters to the DescribeImageTags operation.
    /// Returns the image tag details for a repository in a public registry.
    /// </summary>
    public partial class DescribeImageTagsRequest : AmazonECRPublicRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository results that's returned by <code>DescribeImageTags</code>
        /// in paginated output. When this parameter is used, <code>DescribeImageTags</code> only
        /// returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. You can see the remaining results of the initial request by sending
        /// another <code>DescribeImageTags</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 1000. If this parameter isn't used, then <code>DescribeImageTags</code>
        /// returns up to 100 results and a <code>nextToken</code> value, if applicable. If you
        /// specify images with <code>imageIds</code>, you can't use this option.
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
        /// The <code>nextToken</code> value that's returned from a previous paginated <code>DescribeImageTags</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. If there are no more results to return,
        /// this value is <code>null</code>. If you specify images with <code>imageIds</code>,
        /// you can't use this option.
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
        /// The Amazon Web Services account ID that's associated with the public registry that
        /// contains the repository where images are described. If you do not specify a registry,
        /// the default public registry is assumed.
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
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the image tag details to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=205)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}