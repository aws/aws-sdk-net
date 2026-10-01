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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Configuration for the registry's record approval workflow. Controls whether records
    /// submitted for approval require manual review before they become approved and discoverable,
    /// or are auto-approved. When no auto-approval rules are configured, submitted records
    /// require manual review.
    /// </summary>
    public partial class ApprovalConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutoApprovalRules. 
        /// <para>
        /// The rules that determine which registry records are automatically approved on submission.
        /// When omitted or empty, submitted records require manual review.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> AutoApprovalRules { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoApprovalRules property is set.
        /// </summary>
        internal bool IsSetAutoApprovalRules() => this.AutoApprovalRules != null && (this.AutoApprovalRules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
