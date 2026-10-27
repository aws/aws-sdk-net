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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail for the rule violation in a security group when compared to the primary
    /// security group of the Firewall Manager policy.
    /// </summary>
    public partial class AwsVPCSecurityGroupViolation
    {
        /// <summary>
        /// Gets and sets the property PartialMatches. 
        /// <para>
        /// List of rules specified in the security group of the Firewall Manager policy that
        /// partially match the <c>ViolationTarget</c> rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PartialMatch> PartialMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<PartialMatch>() : null;

        /// <summary>
        /// Checks to see if the PartialMatches property is set.
        /// </summary>
        internal bool IsSetPartialMatches() => this.PartialMatches != null && (this.PartialMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PossibleSecurityGroupRemediationActions. 
        /// <para>
        /// Remediation options for the rule specified in the <c>ViolationTarget</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityGroupRemediationAction> PossibleSecurityGroupRemediationActions { get; set; } = AWSConfigs.InitializeCollections ? new List<SecurityGroupRemediationAction>() : null;

        /// <summary>
        /// Checks to see if the PossibleSecurityGroupRemediationActions property is set.
        /// </summary>
        internal bool IsSetPossibleSecurityGroupRemediationActions() => this.PossibleSecurityGroupRemediationActions != null && (this.PossibleSecurityGroupRemediationActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// The security group rule that is being evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ViolationTarget { get; set; }

        /// <summary>
        /// Checks to see if the ViolationTarget property is set.
        /// </summary>
        internal bool IsSetViolationTarget() => this.ViolationTarget != null;

        /// <summary>
        /// Gets and sets the property ViolationTargetDescription. 
        /// <para>
        /// A description of the security group that violates the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ViolationTargetDescription { get; set; }

        /// <summary>
        /// Checks to see if the ViolationTargetDescription property is set.
        /// </summary>
        internal bool IsSetViolationTargetDescription() => this.ViolationTargetDescription != null;
    }
}
