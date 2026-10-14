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
    /// A rule group that Firewall Manager tried to associate with a VPC has the same priority
    /// as a rule group that's already associated.
    /// </summary>
    public partial class DnsRuleGroupPriorityConflictViolation
    {
        /// <summary>
        /// Gets and sets the property ConflictingPolicyId. 
        /// <para>
        /// The ID of the Firewall Manager DNS Firewall policy that was already applied to the
        /// VPC. This policy contains the rule group that's already associated with the VPC. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConflictingPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the ConflictingPolicyId property is set.
        /// </summary>
        internal bool IsSetConflictingPolicyId() => this.ConflictingPolicyId != null;

        /// <summary>
        /// Gets and sets the property ConflictingPriority. 
        /// <para>
        /// The priority setting of the two conflicting rule groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public int? ConflictingPriority { get; set; }

        /// <summary>
        /// Checks to see if the ConflictingPriority property is set.
        /// </summary>
        internal bool IsSetConflictingPriority() => this.ConflictingPriority.HasValue;

        /// <summary>
        /// Gets and sets the property UnavailablePriorities. 
        /// <para>
        /// The priorities of rule groups that are already associated with the VPC. To retry your
        /// operation, choose priority settings that aren't in this list for the rule groups in
        /// your new DNS Firewall policy. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> UnavailablePriorities { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the UnavailablePriorities property is set.
        /// </summary>
        internal bool IsSetUnavailablePriorities() => this.UnavailablePriorities != null && (this.UnavailablePriorities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// Information about the VPC ID. 
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
        /// A description of the violation that specifies the VPC and the rule group that's already
        /// associated with it.
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
