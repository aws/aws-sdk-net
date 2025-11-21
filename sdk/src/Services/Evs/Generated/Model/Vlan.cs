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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
        private string _availabilityZone;
        private string _cidr;
        private DateTime? _createdAt;
        private List<EipAssociation> _eipAssociations = AWSConfigs.InitializeCollections ? new List<EipAssociation>() : null;
        private string _functionName;
        private bool? _isPublic;
        private DateTime? _modifiedAt;
        private string _networkAclId;
        private string _stateDetails;
        private string _subnetId;
        private int? _vlanId;
        private VlanState _vlanState;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone of the VLAN.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR block of the VLAN. Amazon EVS VLAN subnets have a minimum CIDR block size
        /// of /28 and a maximum size of /24.
        /// </para>
        /// </summary>
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the VLAN was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EipAssociations. 
        /// <para>
        /// An array of Elastic IP address associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EipAssociation> EipAssociations
        {
            get { return this._eipAssociations; }
            set { this._eipAssociations = value; }
        }

        // Check to see if EipAssociations property is set
        internal bool IsSetEipAssociations()
        {
            return this._eipAssociations != null && (this._eipAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The VMware VCF traffic type that is carried over the VLAN. For example, a VLAN with
        /// a <c>functionName</c> of <c>hcx</c> is being used to carry VMware HCX traffic.
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Determines if the VLAN that Amazon EVS provisions is public or private.
        /// </para>
        /// </summary>
        public bool? IsPublic
        {
            get { return this._isPublic; }
            set { this._isPublic = value; }
        }

        // Check to see if IsPublic property is set
        internal bool IsSetIsPublic()
        {
            return this._isPublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the VLAN was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkAclId. 
        /// <para>
        /// A unique ID for a network access control list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=21)]
        public string NetworkAclId
        {
            get { return this._networkAclId; }
            set { this._networkAclId = value; }
        }

        // Check to see if NetworkAclId property is set
        internal bool IsSetNetworkAclId()
        {
            return this._networkAclId != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// The state details of the VLAN.
        /// </para>
        /// </summary>
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        ///  The unique ID of the VLAN subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=24)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property VlanId. 
        /// <para>
        /// The unique ID of the VLAN.
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

        /// <summary>
        /// Gets and sets the property VlanState. 
        /// <para>
        ///  The state of the VLAN.
        /// </para>
        /// </summary>
        public VlanState VlanState
        {
            get { return this._vlanState; }
            set { this._vlanState = value; }
        }

        // Check to see if VlanState property is set
        internal bool IsSetVlanState()
        {
            return this._vlanState != null;
        }

    }
}