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
    /// Describes a flex cost allocation policy.
    /// </summary>
    public partial class FlexCostAllocationPolicyDescription
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the policy.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FcaPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FcaPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the FcaPolicyArn property is set.
        /// </summary>
        internal bool IsSetFcaPolicyArn() => this.FcaPolicyArn != null;

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
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The number of the latest version of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the policy. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The account that owns the policy created it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - An Amazon Web Services Organizations declarative policy
        /// created the policy. You can't modify or delete the policy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

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
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the account that owns the policy.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

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
        /// Gets and sets the property PolicyCreatedAt. 
        /// <para>
        /// The date and time when the policy was created.
        /// </para>
        /// </summary>
        public DateTime? PolicyCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the PolicyCreatedAt property is set.
        /// </summary>
        internal bool IsSetPolicyCreatedAt() => this.PolicyCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ShowBackEnabled. 
        /// <para>
        /// Indicates whether showback reporting is enabled for the policy.
        /// </para>
        /// </summary>
        public bool? ShowBackEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ShowBackEnabled property is set.
        /// </summary>
        internal bool IsSetShowBackEnabled() => this.ShowBackEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the policy was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VersionExpectedEffectiveAt. 
        /// <para>
        /// The date and time when the latest version of the policy is expected to apply to network
        /// traffic. The policy configuration in this response is from the latest version.
        /// </para>
        /// </summary>
        public DateTime? VersionExpectedEffectiveAt { get; set; }

        /// <summary>
        /// Checks to see if the VersionExpectedEffectiveAt property is set.
        /// </summary>
        internal bool IsSetVersionExpectedEffectiveAt() => this.VersionExpectedEffectiveAt.HasValue;
    }
}
