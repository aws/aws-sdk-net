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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the ListRepositories operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_RepositorySummary.html">
    /// <code>RepositorySummary</code> </a> objects. Each <code>RepositorySummary</code> contains
    /// information about a repository in the specified AWS account and that matches the input
    /// parameters.
    /// </summary>
    public partial class ListRepositoriesRequest : AmazonCodeArtifactRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _repositoryPrefix;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return per page. 
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
        ///  The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property RepositoryPrefix. 
        /// <para>
        ///  A prefix used to filter returned repositories. Only repositories with names that
        /// start with <code>repositoryPrefix</code> are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string RepositoryPrefix
        {
            get { return this._repositoryPrefix; }
            set { this._repositoryPrefix = value; }
        }

        // Check to see if RepositoryPrefix property is set
        internal bool IsSetRepositoryPrefix()
        {
            return this._repositoryPrefix != null;
        }

    }
}