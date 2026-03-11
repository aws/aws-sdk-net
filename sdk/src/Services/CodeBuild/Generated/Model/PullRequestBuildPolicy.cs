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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// A PullRequestBuildPolicy object that defines comment-based approval requirements for
    /// triggering builds on pull requests. This policy helps control when automated builds
    /// are executed based on contributor permissions and approval workflows.
    /// </summary>
    public partial class PullRequestBuildPolicy
    {
        private List<string> _approverRoles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PullRequestBuildCommentApproval _requiresCommentApproval;

        /// <summary>
        /// Gets and sets the property ApproverRoles. 
        /// <para>
        /// List of repository roles that have approval privileges for pull request builds when
        /// comment approval is required. Only users with these roles can provide valid comment
        /// approvals. If a pull request contributor is one of these roles, their pull request
        /// builds will trigger automatically. This field is only applicable when <c>requiresCommentApproval</c>
        /// is not <i>DISABLED</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApproverRoles
        {
            get { return this._approverRoles; }
            set { this._approverRoles = value; }
        }

        // Check to see if ApproverRoles property is set
        internal bool IsSetApproverRoles()
        {
            return this._approverRoles != null && (this._approverRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequiresCommentApproval. 
        /// <para>
        /// Specifies when comment-based approval is required before triggering a build on pull
        /// requests. This setting determines whether builds run automatically or require explicit
        /// approval through comments.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>DISABLED</i>: Builds trigger automatically without requiring comment approval
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>ALL_PULL_REQUESTS</i>: All pull requests require comment approval before builds
        /// execute (unless contributor is one of the approver roles)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>FORK_PULL_REQUESTS</i>: Only pull requests from forked repositories require comment
        /// approval (unless contributor is one of the approver roles)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PullRequestBuildCommentApproval RequiresCommentApproval
        {
            get { return this._requiresCommentApproval; }
            set { this._requiresCommentApproval = value; }
        }

        // Check to see if RequiresCommentApproval property is set
        internal bool IsSetRequiresCommentApproval()
        {
            return this._requiresCommentApproval != null;
        }

    }
}