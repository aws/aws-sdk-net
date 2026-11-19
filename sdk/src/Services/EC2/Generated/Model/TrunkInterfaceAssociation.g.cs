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
    /// Information about an association between a branch network interface with a trunk network
    /// interface.
    /// </summary>
    public partial class TrunkInterfaceAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property BranchInterfaceId. 
        /// <para>
        /// The ID of the branch network interface.
        /// </para>
        /// </summary>
        public string BranchInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the BranchInterfaceId property is set.
        /// </summary>
        internal bool IsSetBranchInterfaceId() => this.BranchInterfaceId != null;

        /// <summary>
        /// Gets and sets the property GreKey. 
        /// <para>
        /// The application key when you use the GRE protocol.
        /// </para>
        /// </summary>
        public int? GreKey { get; set; }

        /// <summary>
        /// Checks to see if the GreKey property is set.
        /// </summary>
        internal bool IsSetGreKey() => this.GreKey.HasValue;

        /// <summary>
        /// Gets and sets the property InterfaceProtocol. 
        /// <para>
        /// The interface protocol. Valid values are <c>VLAN</c> and <c>GRE</c>.
        /// </para>
        /// </summary>
        public InterfaceProtocolType InterfaceProtocol { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceProtocol property is set.
        /// </summary>
        internal bool IsSetInterfaceProtocol() => this.InterfaceProtocol != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the trunk interface association.
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
        /// Gets and sets the property TrunkInterfaceId. 
        /// <para>
        /// The ID of the trunk network interface.
        /// </para>
        /// </summary>
        public string TrunkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the TrunkInterfaceId property is set.
        /// </summary>
        internal bool IsSetTrunkInterfaceId() => this.TrunkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property VlanId. 
        /// <para>
        /// The ID of the VLAN when you use the VLAN protocol.
        /// </para>
        /// </summary>
        public int? VlanId { get; set; }

        /// <summary>
        /// Checks to see if the VlanId property is set.
        /// </summary>
        internal bool IsSetVlanId() => this.VlanId.HasValue;
    }
}
