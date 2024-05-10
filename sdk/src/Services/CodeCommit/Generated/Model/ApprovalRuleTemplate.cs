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
    /// Returns information about an approval rule template.
    /// </summary>
    public partial class ApprovalRuleTemplate
    {
        private string _approvalRuleTemplateContent;
        private string _approvalRuleTemplateDescription;
        private string _approvalRuleTemplateId;
        private string _approvalRuleTemplateName;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedUser;
        private string _ruleContentSha256;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateContent. 
        /// <para>
        /// The content of the approval rule template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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
        /// The description of the approval rule template.
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
        /// Gets and sets the property ApprovalRuleTemplateId. 
        /// <para>
        /// The system-generated ID of the approval rule template.
        /// </para>
        /// </summary>
        public string ApprovalRuleTemplateId
        {
            get { return this._approvalRuleTemplateId; }
            set { this._approvalRuleTemplateId = value; }
        }

        // Check to see if ApprovalRuleTemplateId property is set
        internal bool IsSetApprovalRuleTemplateId()
        {
            return this._approvalRuleTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name of the approval rule template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the approval rule template was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the approval rule template was most recently changed, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who made the most recent changes to the
        /// approval rule template.
        /// </para>
        /// </summary>
        public string LastModifiedUser
        {
            get { return this._lastModifiedUser; }
            set { this._lastModifiedUser = value; }
        }

        // Check to see if LastModifiedUser property is set
        internal bool IsSetLastModifiedUser()
        {
            return this._lastModifiedUser != null;
        }

        /// <summary>
        /// Gets and sets the property RuleContentSha256. 
        /// <para>
        /// The SHA-256 hash signature for the content of the approval rule template.
        /// </para>
        /// </summary>
        public string RuleContentSha256
        {
            get { return this._ruleContentSha256; }
            set { this._ruleContentSha256 = value; }
        }

        // Check to see if RuleContentSha256 property is set
        internal bool IsSetRuleContentSha256()
        {
            return this._ruleContentSha256 != null;
        }

    }
}