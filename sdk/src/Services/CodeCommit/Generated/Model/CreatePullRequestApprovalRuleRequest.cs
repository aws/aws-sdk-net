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
    /// Container for the parameters to the CreatePullRequestApprovalRule operation.
    /// Creates an approval rule for a pull request.
    /// </summary>
    public partial class CreatePullRequestApprovalRuleRequest : AmazonCodeCommitRequest
    {
        private string _approvalRuleContent;
        private string _approvalRuleName;
        private string _pullRequestId;

        /// <summary>
        /// Gets and sets the property ApprovalRuleContent. 
        /// <para>
        /// The content of the approval rule, including the number of approvals needed and the
        /// structure of an approval pool defined for approvals, if any. For more information
        /// about approval pools, see the CodeCommit User Guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you create the content of the approval rule, you can specify approvers in an
        /// approval pool in one of two ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CodeCommitApprovers</b>: This option only requires an Amazon Web Services account
        /// and a resource. It can be used for both IAM users and federated access users whose
        /// name matches the provided resource name. This is a very powerful option that offers
        /// a great deal of flexibility. For example, if you specify the Amazon Web Services account
        /// <i>123456789012</i> and <i>Mary_Major</i>, all of the following would be counted as
        /// approvals coming from that user:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An IAM user in the account (arn:aws:iam::<i>123456789012</i>:user/<i>Mary_Major</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A federated user identified in IAM as Mary_Major (arn:aws:sts::<i>123456789012</i>:federated-user/<i>Mary_Major</i>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This option does not recognize an active session of someone assuming the role of CodeCommitReview
        /// with a role session name of <i>Mary_Major</i> (arn:aws:sts::<i>123456789012</i>:assumed-role/CodeCommitReview/<i>Mary_Major</i>)
        /// unless you include a wildcard (*Mary_Major).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Fully qualified ARN</b>: This option allows you to specify the fully qualified
        /// Amazon Resource Name (ARN) of the IAM user or role. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about IAM ARNs, wildcards, and formats, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3000)]
        public string ApprovalRuleContent
        {
            get { return this._approvalRuleContent; }
            set { this._approvalRuleContent = value; }
        }

        // Check to see if ApprovalRuleContent property is set
        internal bool IsSetApprovalRuleContent()
        {
            return this._approvalRuleContent != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalRuleName. 
        /// <para>
        /// The name for the approval rule.
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
        /// The system-generated ID of the pull request for which you want to create the approval
        /// rule.
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