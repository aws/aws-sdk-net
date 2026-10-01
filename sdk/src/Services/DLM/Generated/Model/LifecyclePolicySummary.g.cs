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

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Summary information about a lifecycle policy.
    /// </summary>
    public partial class LifecyclePolicySummary
    {
        /// <summary>
        /// Gets and sets the property DefaultPolicy. 
        /// <para>
        ///  <b>[Default policies only]</b> The type of default policy. Values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VOLUME</c> - Default policy for EBS snapshots
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE</c> - Default policy for EBS-backed AMIs
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? DefaultPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DefaultPolicy property is set.
        /// </summary>
        internal bool IsSetDefaultPolicy() => this.DefaultPolicy.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The identifier of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy. <c>EBS_SNAPSHOT_MANAGEMENT</c> indicates that the policy manages
        /// the lifecycle of Amazon EBS snapshots. <c>IMAGE_MANAGEMENT</c> indicates that the
        /// policy manages the lifecycle of EBS-backed AMIs. <c>EVENT_BASED_POLICY</c> indicates
        /// that the policy automates cross-account snapshot copies for snapshots that are shared
        /// with your account.
        /// </para>
        /// </summary>
        public PolicyTypeValues PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The activation state of the lifecycle policy.
        /// </para>
        /// </summary>
        public GettablePolicyStateValues State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
