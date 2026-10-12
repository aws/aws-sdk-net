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
    /// Returns information about the approval rules applied to a pull request and whether
    /// conditions have been met.
    /// </summary>
    public partial class Evaluation
    {
        /// <summary>
        /// Gets and sets the property ApprovalRulesNotSatisfied. 
        /// <para>
        /// The names of the approval rules that have not had their conditions met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApprovalRulesNotSatisfied { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApprovalRulesNotSatisfied property is set.
        /// </summary>
        internal bool IsSetApprovalRulesNotSatisfied() => this.ApprovalRulesNotSatisfied != null && (this.ApprovalRulesNotSatisfied.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApprovalRulesSatisfied. 
        /// <para>
        /// The names of the approval rules that have had their conditions met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApprovalRulesSatisfied { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApprovalRulesSatisfied property is set.
        /// </summary>
        internal bool IsSetApprovalRulesSatisfied() => this.ApprovalRulesSatisfied != null && (this.ApprovalRulesSatisfied.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Approved. 
        /// <para>
        /// Whether the state of the pull request is approved.
        /// </para>
        /// </summary>
        public bool? Approved { get; set; }

        /// <summary>
        /// Checks to see if the Approved property is set.
        /// </summary>
        internal bool IsSetApproved() => this.Approved.HasValue;

        /// <summary>
        /// Gets and sets the property Overridden. 
        /// <para>
        /// Whether the approval rule requirements for the pull request have been overridden and
        /// no longer need to be met.
        /// </para>
        /// </summary>
        public bool? Overridden { get; set; }

        /// <summary>
        /// Checks to see if the Overridden property is set.
        /// </summary>
        internal bool IsSetOverridden() => this.Overridden.HasValue;
    }
}
