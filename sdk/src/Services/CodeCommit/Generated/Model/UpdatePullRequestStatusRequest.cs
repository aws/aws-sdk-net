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
    /// Container for the parameters to the UpdatePullRequestStatus operation.
    /// Updates the status of a pull request.
    /// </summary>
    public partial class UpdatePullRequestStatusRequest : AmazonCodeCommitRequest
    {
        private string _pullRequestId;
        private PullRequestStatusEnum _pullRequestStatus;

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request. To get this ID, use <a>ListPullRequests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PullRequestId
        {
            get { return this._pullRequestId; }
            set { this._pullRequestId = value; }
        }

        // Check to see if PullRequestId property is set
        internal bool IsSetPullRequestId()
        {
            return this._pullRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestStatus. 
        /// <para>
        /// The status of the pull request. The only valid operations are to update the status
        /// from <c>OPEN</c> to <c>OPEN</c>, <c>OPEN</c> to <c>CLOSED</c> or from <c>CLOSED</c>
        /// to <c>CLOSED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}