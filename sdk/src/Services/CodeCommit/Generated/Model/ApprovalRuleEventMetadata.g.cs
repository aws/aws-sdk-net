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
    /// Returns information about an event for an approval rule.
    /// </summary>
    public partial class ApprovalRuleEventMetadata
    {
        /// <summary>
        /// Gets and sets the property ApprovalRuleContent. 
        /// <para>
        /// The content of the approval rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3000)]
        public string ApprovalRuleContent { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleContent property is set.
        /// </summary>
        internal bool IsSetApprovalRuleContent() => this.ApprovalRuleContent != null;

        /// <summary>
        /// Gets and sets the property ApprovalRuleId. 
        /// <para>
        /// The system-generated ID of the approval rule.
        /// </para>
        /// </summary>
        public string ApprovalRuleId { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleId property is set.
        /// </summary>
        internal bool IsSetApprovalRuleId() => this.ApprovalRuleId != null;

        /// <summary>
        /// Gets and sets the property ApprovalRuleName. 
        /// <para>
        /// The name of the approval rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApprovalRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleName property is set.
        /// </summary>
        internal bool IsSetApprovalRuleName() => this.ApprovalRuleName != null;
    }
}
