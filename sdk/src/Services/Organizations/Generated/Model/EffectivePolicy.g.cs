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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains rules to be applied to the affected accounts. The effective policy is the
    /// aggregation of any policies the account inherits, plus any policy directly attached
    /// to the account.
    /// </summary>
    public partial class EffectivePolicy
    {
        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time of the last update to this policy.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyContent. 
        /// <para>
        /// The text content of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string PolicyContent { get; set; }

        /// <summary>
        /// Checks to see if the PolicyContent property is set.
        /// </summary>
        internal bool IsSetPolicyContent() => this.PolicyContent != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type.
        /// </para>
        /// </summary>
        public EffectivePolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The account ID of the policy target. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;
    }
}
