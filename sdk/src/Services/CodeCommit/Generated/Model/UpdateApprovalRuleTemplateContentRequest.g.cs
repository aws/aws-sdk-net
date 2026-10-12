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
    /// Container for the parameters to the UpdateApprovalRuleTemplateContent operation. Updates
    /// the content of an approval rule template. You can change the number of required approvals,
    /// the membership of the approval rule, and whether an approval pool is defined.
    /// </summary>
    public partial class UpdateApprovalRuleTemplateContentRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name of the approval rule template where you want to update the content of the
        /// rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApprovalRuleTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleTemplateName property is set.
        /// </summary>
        internal bool IsSetApprovalRuleTemplateName() => this.ApprovalRuleTemplateName != null;

        /// <summary>
        /// Gets and sets the property ExistingRuleContentSha256. 
        /// <para>
        /// The SHA-256 hash signature for the content of the approval rule. You can retrieve
        /// this information by using <a>GetPullRequest</a>.
        /// </para>
        /// </summary>
        public string ExistingRuleContentSha256 { get; set; }

        /// <summary>
        /// Checks to see if the ExistingRuleContentSha256 property is set.
        /// </summary>
        internal bool IsSetExistingRuleContentSha256() => this.ExistingRuleContentSha256 != null;

        /// <summary>
        /// Gets and sets the property NewRuleContent. 
        /// <para>
        /// The content that replaces the existing content of the rule. Content statements must
        /// be complete. You cannot provide only the changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 3000)]
        public string NewRuleContent { get; set; }

        /// <summary>
        /// Checks to see if the NewRuleContent property is set.
        /// </summary>
        internal bool IsSetNewRuleContent() => this.NewRuleContent != null;
    }
}
