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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// The VLANs that Amazon EVS creates during environment creation.
    /// </summary>
    public partial class Vlan
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone of the VLAN.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR block of the VLAN. Amazon EVS VLAN subnets have a minimum CIDR block size
        /// of /28 and a maximum size of /24.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the VLAN was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EipAssociations. 
        /// <para>
        /// An array of Elastic IP address associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EipAssociation> EipAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<EipAssociation>() : null;

        /// <summary>
        /// Checks to see if the EipAssociations property is set.
        /// </summary>
        internal bool IsSetEipAssociations() => this.EipAssociations != null && (this.EipAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The VMware VCF traffic type that is carried over the VLAN. For example, a VLAN with
        /// a <c>functionName</c> of <c>hcx</c> is being used to carry VMware HCX traffic.
        /// </para>
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Determines if the VLAN that Amazon EVS provisions is public or private.
        /// </para>
        /// </summary>
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Checks to see if the IsPublic property is set.
        /// </summary>
        internal bool IsSetIsPublic() => this.IsPublic.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the VLAN was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkAclId. 
        /// <para>
        /// A unique ID for a network access control list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 21)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAclId property is set.
        /// </summary>
        internal bool IsSetNetworkAclId() => this.NetworkAclId != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// The state details of the VLAN.
        /// </para>
        /// </summary>
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        ///  The unique ID of the VLAN subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 24)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VlanId. 
        /// <para>
        /// The unique ID of the VLAN.
        /// </para>
        /// </summary>
        public int? VlanId { get; set; }

        /// <summary>
        /// Checks to see if the VlanId property is set.
        /// </summary>
        internal bool IsSetVlanId() => this.VlanId.HasValue;

        /// <summary>
        /// Gets and sets the property VlanState. 
        /// <para>
        ///  The state of the VLAN.
        /// </para>
        /// </summary>
        public VlanState VlanState { get; set; }

        /// <summary>
        /// Checks to see if the VlanState property is set.
        /// </summary>
        internal bool IsSetVlanState() => this.VlanState != null;
    }
}
