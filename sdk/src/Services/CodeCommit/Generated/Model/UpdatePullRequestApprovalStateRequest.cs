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
    /// Container for the parameters to the UpdatePullRequestApprovalState operation.
    /// Updates the state of a user's approval on a pull request. The user is derived from
    /// the signed-in account when the request is made.
    /// </summary>
    public partial class UpdatePullRequestApprovalStateRequest : AmazonCodeCommitRequest
    {
        private ApprovalState _approvalState;
        private string _pullRequestId;
        private string _revisionId;

        /// <summary>
        /// Gets and sets the property ApprovalState. 
        /// <para>
        /// The approval state to associate with the user on the pull request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApprovalState ApprovalState
        {
            get { return this._approvalState; }
            set { this._approvalState = value; }
        }

        // Check to see if ApprovalState property is set
        internal bool IsSetApprovalState()
        {
            return this._approvalState != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request.
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The system-generated ID of the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

    }
}