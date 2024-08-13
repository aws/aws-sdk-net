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
    /// Describes the transit gateway multicast group resources.
    /// </summary>
    public partial class TransitGatewayMulticastGroup
    {
        private string _groupIpAddress;
        private bool? _groupMember;
        private bool? _groupSource;
        private MembershipType _memberType;
        private string _networkInterfaceId;
        private string _resourceId;
        private string _resourceOwnerId;
        private TransitGatewayAttachmentResourceType _resourceType;
        private MembershipType _sourceType;
        private string _subnetId;
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property GroupIpAddress. 
        /// <para>
        /// The IP address assigned to the transit gateway multicast group.
        /// </para>
        /// </summary>
        public string GroupIpAddress
        {
            get { return this._groupIpAddress; }
            set { this._groupIpAddress = value; }
        }

        // Check to see if GroupIpAddress property is set
        internal bool IsSetGroupIpAddress()
        {
            return this._groupIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property GroupMember. 
        /// <para>
        /// Indicates that the resource is a transit gateway multicast group member.
        /// </para>
        /// </summary>
        public bool? GroupMember
        {
            get { return this._groupMember; }
            set { this._groupMember = value; }
        }

        // Check to see if GroupMember property is set
        internal bool IsSetGroupMember()
        {
            return this._groupMember.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupSource. 
        /// <para>
        /// Indicates that the resource is a transit gateway multicast group member.
        /// </para>
        /// </summary>
        public bool? GroupSource
        {
            get { return this._groupSource; }
            set { this._groupSource = value; }
        }

        // Check to see if GroupSource property is set
        internal bool IsSetGroupSource()
        {
            return this._groupSource.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// The member type (for example, <c>static</c>).
        /// </para>
        /// </summary>
        public MembershipType MemberType
        {
            get { return this._memberType; }
            set { this._memberType = value; }
        }

        // Check to see if MemberType property is set
        internal bool IsSetMemberType()
        {
            return this._memberType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the transit gateway attachment.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        ///  The ID of the Amazon Web Services account that owns the transit gateway multicast
        /// domain group resource.
        /// </para>
        /// </summary>
        public string ResourceOwnerId
        {
            get { return this._resourceOwnerId; }
            set { this._resourceOwnerId = value; }
        }

        // Check to see if ResourceOwnerId property is set
        internal bool IsSetResourceOwnerId()
        {
            return this._resourceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource, for example a VPC attachment.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type.
        /// </para>
        /// </summary>
        public MembershipType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway attachment.
        /// </para>
        /// </summary>
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

    }
}