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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a version of a flex cost allocation policy.
    /// </summary>
    public partial class FlexCostAllocationPolicyVersion
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when this version of the policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of this version of the policy.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpectedEffectiveAt. 
        /// <para>
        /// The date and time when this version of the policy is expected to apply to network
        /// traffic.
        /// </para>
        /// </summary>
        public DateTime? ExpectedEffectiveAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedEffectiveAt property is set.
        /// </summary>
        internal bool IsSetExpectedEffectiveAt() => this.ExpectedEffectiveAt.HasValue;

        /// <summary>
        /// Gets and sets the property FcaPolicyId. 
        /// <para>
        /// The ID of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string FcaPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the FcaPolicyId property is set.
        /// </summary>
        internal bool IsSetFcaPolicyId() => this.FcaPolicyId != null;

        /// <summary>
        /// Gets and sets the property InstanceFcaPolicyDocument. 
        /// <para>
        /// The policy document that defines cost allocation for EC2 instances.
        /// </para>
        /// </summary>
        public InstanceFlexCostAllocationPolicyDocument InstanceFcaPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFcaPolicyDocument property is set.
        /// </summary>
        internal bool IsSetInstanceFcaPolicyDocument() => this.InstanceFcaPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property NatFcaPolicyDocument. 
        /// <para>
        /// The policy document that defines cost allocation for NAT gateways.
        /// </para>
        /// </summary>
        public NatFlexCostAllocationPolicyDocument NatFcaPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the NatFcaPolicyDocument property is set.
        /// </summary>
        internal bool IsSetNatFcaPolicyDocument() => this.NatFcaPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property NetworkResourceType. 
        /// <para>
        /// The type of network resource that the policy applies to.
        /// </para>
        /// </summary>
        public FlexCostAllocationNetworkResourceType NetworkResourceType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkResourceType property is set.
        /// </summary>
        internal bool IsSetNetworkResourceType() => this.NetworkResourceType != null;

        /// <summary>
        /// Gets and sets the property PcxFcaPolicyDocument. 
        /// <para>
        /// The policy document that defines cost allocation for Amazon VPC peering connections.
        /// </para>
        /// </summary>
        public PcxFlexCostAllocationPolicyDocument PcxFcaPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PcxFcaPolicyDocument property is set.
        /// </summary>
        internal bool IsSetPcxFcaPolicyDocument() => this.PcxFcaPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property ShowBackEnabled. 
        /// <para>
        /// Indicates whether showback reporting is enabled for this version of the policy.
        /// </para>
        /// </summary>
        public bool? ShowBackEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ShowBackEnabled property is set.
        /// </summary>
        internal bool IsSetShowBackEnabled() => this.ShowBackEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
