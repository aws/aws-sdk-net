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
    /// Returns information about the template that created the approval rule for a pull request.
    /// </summary>
    public partial class OriginApprovalRuleTemplate
    {
        private string _approvalRuleTemplateId;
        private string _approvalRuleTemplateName;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateId. 
        /// <para>
        /// The ID of the template that created the approval rule.
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
        /// The name of the template that created the approval rule.
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

    }
}