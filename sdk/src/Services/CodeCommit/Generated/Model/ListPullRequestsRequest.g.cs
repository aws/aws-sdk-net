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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListPullRequests operation. Returns a list of
    /// pull requests for a specified repository. The return list can be refined by pull request
    /// status or pull request author ARN.
    /// </summary>
    public partial class ListPullRequestsRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorArn. 
        /// <para>
        /// Optional. The Amazon Resource Name (ARN) of the user who created the pull request.
        /// If used, this filters the results to pull requests created by that user.
        /// </para>
        /// </summary>
        public string AuthorArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthorArn property is set.
        /// </summary>
        internal bool IsSetAuthorArn() => this.AuthorArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that, when provided in a request, returns the next batch of the
        /// results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PullRequestStatus. 
        /// <para>
        /// Optional. The status of the pull request. If used, this refines the results to the
        /// pull requests that match the specified status.
        /// </para>
        /// </summary>
        public PullRequestStatusEnum PullRequestStatus { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestStatus property is set.
        /// </summary>
        internal bool IsSetPullRequestStatus() => this.PullRequestStatus != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository for which you want to list pull requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
