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
    /// Container for the parameters to the CreateApprovalRuleTemplate operation.
    /// Creates a template for approval rules that can then be associated with one or more
    /// repositories in your Amazon Web Services account. When you associate a template with
    /// a repository, CodeCommit creates an approval rule that matches the conditions of the
    /// template for all pull requests that meet the conditions of the template. For more
    /// information, see <a>AssociateApprovalRuleTemplateWithRepository</a>.
    /// </summary>
    public partial class CreateApprovalRuleTemplateRequest : AmazonCodeCommitRequest
    {
        private string _approvalRuleTemplateContent;
        private string _approvalRuleTemplateDescription;
        private string _approvalRuleTemplateName;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateContent. 
        /// <para>
        /// The content of the approval rule that is created on pull requests in associated repositories.
        /// If you specify one or more destination references (branches), approval rules are created
        /// in an associated repository only if their destination references (branches) match
        /// those specified in the template.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you create the content of the approval rule template, you can specify approvers
        /// in an approval pool in one of two ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CodeCommitApprovers</b>: This option only requires an Amazon Web Services account
        /// and a resource. It can be used for both IAM users and federated access users whose
        /// name matches the provided resource name. This is a very powerful option that offers
        /// a great deal of flexibility. For example, if you specify the Amazon Web Services account
        /// <i>123456789012</i> and <i>Mary_Major</i>, all of the following are counted as approvals
        /// coming from that user:
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
        public string ApprovalRuleTemplateContent
        {
            get { return this._approvalRuleTemplateContent; }
            set { this._approvalRuleTemplateContent = value; }
        }

        // Check to see if ApprovalRuleTemplateContent property is set
        internal bool IsSetApprovalRuleTemplateContent()
        {
            return this._approvalRuleTemplateContent != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateDescription. 
        /// <para>
        /// The description of the approval rule template. Consider providing a description that
        /// explains what this template does and when it might be appropriate to associate it
        /// with repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ApprovalRuleTemplateDescription
        {
            get { return this._approvalRuleTemplateDescription; }
            set { this._approvalRuleTemplateDescription = value; }
        }

        // Check to see if ApprovalRuleTemplateDescription property is set
        internal bool IsSetApprovalRuleTemplateDescription()
        {
            return this._approvalRuleTemplateDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name of the approval rule template. Provide descriptive names, because this name
        /// is applied to the approval rules created automatically in associated repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApprovalRuleTemplateName
        {
            get { return this._approvalRuleTemplateName; }
            set { this._approvalRuleTemplateName = value; }
        }

        // Check to see if ApprovalRuleTemplateName property is set
        internal bool IsSetApprovalRuleTemplateName()
        {
            return this._approvalRuleTemplateName != null;
        }

    }
}