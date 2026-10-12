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
    /// Container for the parameters to the DescribePullRequestEvents operation. Returns information
    /// about one or more pull request events.
    /// </summary>
    public partial class DescribePullRequestEventsRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property ActorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user whose actions resulted in the event. Examples
        /// include updating the pull request with more commits or changing the status of a pull
        /// request.
        /// </para>
        /// </summary>
        public string ActorArn { get; set; }

        /// <summary>
        /// Checks to see if the ActorArn property is set.
        /// </summary>
        internal bool IsSetActorArn() => this.ActorArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results. The
        /// default is 100 events, which is also the maximum number of events that can be returned
        /// in a result.
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
        /// Gets and sets the property PullRequestEventType. 
        /// <para>
        /// Optional. The pull request event type about which you want to return information.
        /// </para>
        /// </summary>
        public PullRequestEventType PullRequestEventType { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestEventType property is set.
        /// </summary>
        internal bool IsSetPullRequestEventType() => this.PullRequestEventType != null;

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request. To get this ID, use <a>ListPullRequests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PullRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestId property is set.
        /// </summary>
        internal bool IsSetPullRequestId() => this.PullRequestId != null;
    }
}
