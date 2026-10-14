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
    /// Returns information about an approval rule template.
    /// </summary>
    public partial class ApprovalRuleTemplate
    {
        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateContent. 
        /// <para>
        /// The content of the approval rule template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3000)]
        public string ApprovalRuleTemplateContent { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleTemplateContent property is set.
        /// </summary>
        internal bool IsSetApprovalRuleTemplateContent() => this.ApprovalRuleTemplateContent != null;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateDescription. 
        /// <para>
        /// The description of the approval rule template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ApprovalRuleTemplateDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleTemplateDescription property is set.
        /// </summary>
        internal bool IsSetApprovalRuleTemplateDescription() => this.ApprovalRuleTemplateDescription != null;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateId. 
        /// <para>
        /// The system-generated ID of the approval rule template.
        /// </para>
        /// </summary>
        public string ApprovalRuleTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleTemplateId property is set.
        /// </summary>
        internal bool IsSetApprovalRuleTemplateId() => this.ApprovalRuleTemplateId != null;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name of the approval rule template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApprovalRuleTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleTemplateName property is set.
        /// </summary>
        internal bool IsSetApprovalRuleTemplateName() => this.ApprovalRuleTemplateName != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the approval rule template was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the approval rule template was most recently changed, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who made the most recent changes to the
        /// approval rule template.
        /// </para>
        /// </summary>
        public string LastModifiedUser { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedUser property is set.
        /// </summary>
        internal bool IsSetLastModifiedUser() => this.LastModifiedUser != null;

        /// <summary>
        /// Gets and sets the property RuleContentSha256. 
        /// <para>
        /// The SHA-256 hash signature for the content of the approval rule template.
        /// </para>
        /// </summary>
        public string RuleContentSha256 { get; set; }

        /// <summary>
        /// Checks to see if the RuleContentSha256 property is set.
        /// </summary>
        internal bool IsSetRuleContentSha256() => this.RuleContentSha256 != null;
    }
}
