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
    /// Returns information about an event for an approval rule.
    /// </summary>
    public partial class ApprovalRuleEventMetadata
    {
        private string _approvalRuleContent;
        private string _approvalRuleId;
        private string _approvalRuleName;

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

    }
}