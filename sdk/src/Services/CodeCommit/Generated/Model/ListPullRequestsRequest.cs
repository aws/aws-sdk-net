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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the ListPullRequests operation.
    /// Returns a list of pull requests for a specified repository. The return list can be
    /// refined by pull request status or pull request author ARN.
    /// </summary>
    public partial class ListPullRequestsRequest : AmazonCodeCommitRequest
    {
        private string _authorArn;
        private int? _maxResults;
        private string _nextToken;
        private PullRequestStatusEnum _pullRequestStatus;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property AuthorArn. 
        /// <para>
        /// Optional. The Amazon Resource Name (ARN) of the user who created the pull request.
        /// If used, this filters the results to pull requests created by that user.
        /// </para>
        /// </summary>
        public string AuthorArn
        {
            get { return this._authorArn; }
            set { this._authorArn = value; }
        }

        // Check to see if AuthorArn property is set
        internal bool IsSetAuthorArn()
        {
            return this._authorArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results.
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
        /// An enumeration token that, when provided in a request, returns the next batch of the
        /// results.
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
        /// Gets and sets the property PullRequestStatus. 
        /// <para>
        /// Optional. The status of the pull request. If used, this refines the results to the
        /// pull requests that match the specified status.
        /// </para>
        /// </summary>
        public PullRequestStatusEnum PullRequestStatus
        {
            get { return this._pullRequestStatus; }
            set { this._pullRequestStatus = value; }
        }

        // Check to see if PullRequestStatus property is set
        internal bool IsSetPullRequestStatus()
        {
            return this._pullRequestStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository for which you want to list pull requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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