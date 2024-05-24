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
    /// Container for the parameters to the DeletePullRequestApprovalRule operation.
    /// Deletes an approval rule from a specified pull request. Approval rules can be deleted
    /// from a pull request only if the pull request is open, and if the approval rule was
    /// created specifically for a pull request and not generated from an approval rule template
    /// associated with the repository where the pull request was created. You cannot delete
    /// an approval rule from a merged or closed pull request.
    /// </summary>
    public partial class DeletePullRequestApprovalRuleRequest : AmazonCodeCommitRequest
    {
        private string _approvalRuleName;
        private string _pullRequestId;

        /// <summary>
        /// Gets and sets the property ApprovalRuleName. 
        /// <para>
        /// The name of the approval rule you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApprovalRuleName
        {
            get { return this._approvalRuleName; }
            set { this._approvalRuleName = value; }
        }

        // Check to see if ApprovalRuleName property is set
        internal bool IsSetApprovalRuleName()
        {
            return this._approvalRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request that contains the approval rule you want
        /// to delete.
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

    }
}