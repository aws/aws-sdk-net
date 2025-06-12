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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _associationId;
        private string _branchInterfaceId;
        private int? _greKey;
        private InterfaceProtocolType _interfaceProtocol;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trunkInterfaceId;
        private int? _vlanId;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property BranchInterfaceId. 
        /// <para>
        /// The ID of the branch network interface.
        /// </para>
        /// </summary>
        public string BranchInterfaceId
        {
            get { return this._branchInterfaceId; }
            set { this._branchInterfaceId = value; }
        }

        // Check to see if BranchInterfaceId property is set
        internal bool IsSetBranchInterfaceId()
        {
            return this._branchInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property GreKey. 
        /// <para>
        /// The application key when you use the GRE protocol.
        /// </para>
        /// </summary>
        public int? GreKey
        {
            get { return this._greKey; }
            set { this._greKey = value; }
        }

        // Check to see if GreKey property is set
        internal bool IsSetGreKey()
        {
            return this._greKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InterfaceProtocol. 
        /// <para>
        /// The interface protocol. Valid values are <c>VLAN</c> and <c>GRE</c>.
        /// </para>
        /// </summary>
        public InterfaceProtocolType InterfaceProtocol
        {
            get { return this._interfaceProtocol; }
            set { this._interfaceProtocol = value; }
        }

        // Check to see if InterfaceProtocol property is set
        internal bool IsSetInterfaceProtocol()
        {
            return this._interfaceProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the trunk interface association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrunkInterfaceId. 
        /// <para>
        /// The ID of the trunk network interface.
        /// </para>
        /// </summary>
        public string TrunkInterfaceId
        {
            get { return this._trunkInterfaceId; }
            set { this._trunkInterfaceId = value; }
        }

        // Check to see if TrunkInterfaceId property is set
        internal bool IsSetTrunkInterfaceId()
        {
            return this._trunkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property VlanId. 
        /// <para>
        /// The ID of the VLAN when you use the VLAN protocol.
        /// </para>
        /// </summary>
        public int? VlanId
        {
            get { return this._vlanId; }
            set { this._vlanId = value; }
        }

        // Check to see if VlanId property is set
        internal bool IsSetVlanId()
        {
            return this._vlanId.HasValue; 
        }

    }
}