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
    /// Describes a VPC peering connection.
    /// </summary>
    public partial class VpcPeeringConnection
    {
        private VpcPeeringConnectionVpcInfo _accepterVpcInfo;
        private DateTime? _expirationTime;
        private VpcPeeringConnectionVpcInfo _requesterVpcInfo;
        private VpcPeeringConnectionStateReason _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property AccepterVpcInfo. 
        /// <para>
        /// Information about the accepter VPC. CIDR block information is only returned when describing
        /// an active VPC peering connection.
        /// </para>
        /// </summary>
        public VpcPeeringConnectionVpcInfo AccepterVpcInfo
        {
            get { return this._accepterVpcInfo; }
            set { this._accepterVpcInfo = value; }
        }

        // Check to see if AccepterVpcInfo property is set
        internal bool IsSetAccepterVpcInfo()
        {
            return this._accepterVpcInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time that an unaccepted VPC peering connection will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterVpcInfo. 
        /// <para>
        /// Information about the requester VPC. CIDR block information is only returned when
        /// describing an active VPC peering connection.
        /// </para>
        /// </summary>
        public VpcPeeringConnectionVpcInfo RequesterVpcInfo
        {
            get { return this._requesterVpcInfo; }
            set { this._requesterVpcInfo = value; }
        }

        // Check to see if RequesterVpcInfo property is set
        internal bool IsSetRequesterVpcInfo()
        {
            return this._requesterVpcInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VPC peering connection.
        /// </para>
        /// </summary>
        public VpcPeeringConnectionStateReason Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the resource.
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
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this._vpcPeeringConnectionId; }
            set { this._vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this._vpcPeeringConnectionId != null;
        }

    }
}