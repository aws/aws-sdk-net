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
    /// Returns information about an approval rule.
    /// </summary>
    public partial class ApprovalRule
    {
        private string _approvalRuleContent;
        private string _approvalRuleId;
        private string _approvalRuleName;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedUser;
        private OriginApprovalRuleTemplate _originApprovalRuleTemplate;
        private string _ruleContentSha256;

        /// <summary>
        /// Gets and sets the property ApprovalRuleContent. 
        /// <para>
        /// The content of the approval rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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
        /// Gets and sets the property ApprovalRuleId. 
        /// <para>
        /// The system-generated ID of the approval rule.
        /// </para>
        /// </summary>
        public string ApprovalRuleId
        {
            get { return this._approvalRuleId; }
            set { this._approvalRuleId = value; }
        }

        // Check to see if ApprovalRuleId property is set
        internal bool IsSetApprovalRuleId()
        {
            return this._approvalRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalRuleName. 
        /// <para>
        /// The name of the approval rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the approval rule was created, in timestamp format.
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
        /// The date the approval rule was most recently changed, in timestamp format.
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
        /// approval rule.
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
        /// Gets and sets the property OriginApprovalRuleTemplate. 
        /// <para>
        /// The approval rule template used to create the rule.
        /// </para>
        /// </summary>
        public OriginApprovalRuleTemplate OriginApprovalRuleTemplate
        {
            get { return this._originApprovalRuleTemplate; }
            set { this._originApprovalRuleTemplate = value; }
        }

        // Check to see if OriginApprovalRuleTemplate property is set
        internal bool IsSetOriginApprovalRuleTemplate()
        {
            return this._originApprovalRuleTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property RuleContentSha256. 
        /// <para>
        /// The SHA-256 hash signature for the content of the approval rule.
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