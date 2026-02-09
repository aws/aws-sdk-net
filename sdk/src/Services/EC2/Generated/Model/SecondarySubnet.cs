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
    /// Describes a secondary subnet.
    /// </summary>
    public partial class SecondarySubnet
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private List<SecondarySubnetIpv4CidrBlockAssociation> _ipv4CidrBlockAssociations = AWSConfigs.InitializeCollections ? new List<SecondarySubnetIpv4CidrBlockAssociation>() : null;
        private string _ownerId;
        private string _secondaryNetworkId;
        private SecondaryNetworkType _secondaryNetworkType;
        private string _secondarySubnetArn;
        private string _secondarySubnetId;
        private SecondarySubnetState _state;
        private string _stateReason;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the secondary subnet.
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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the secondary subnet.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4CidrBlockAssociations. 
        /// <para>
        /// Information about the IPv4 CIDR blocks associated with the secondary subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondarySubnetIpv4CidrBlockAssociation> Ipv4CidrBlockAssociations
        {
            get { return this._ipv4CidrBlockAssociations; }
            set { this._ipv4CidrBlockAssociations = value; }
        }

        // Check to see if Ipv4CidrBlockAssociations property is set
        internal bool IsSetIpv4CidrBlockAssociations()
        {
            return this._ipv4CidrBlockAssociations != null && (this._ipv4CidrBlockAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the secondary subnet.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryNetworkId. 
        /// <para>
        /// The ID of the secondary network.
        /// </para>
        /// </summary>
        public string SecondaryNetworkId
        {
            get { return this._secondaryNetworkId; }
            set { this._secondaryNetworkId = value; }
        }

        // Check to see if SecondaryNetworkId property is set
        internal bool IsSetSecondaryNetworkId()
        {
            return this._secondaryNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryNetworkType. 
        /// <para>
        /// The type of the secondary network.
        /// </para>
        /// </summary>
        public SecondaryNetworkType SecondaryNetworkType
        {
            get { return this._secondaryNetworkType; }
            set { this._secondaryNetworkType = value; }
        }

        // Check to see if SecondaryNetworkType property is set
        internal bool IsSetSecondaryNetworkType()
        {
            return this._secondaryNetworkType != null;
        }

        /// <summary>
        /// Gets and sets the property SecondarySubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secondary subnet.
        /// </para>
        /// </summary>
        public string SecondarySubnetArn
        {
            get { return this._secondarySubnetArn; }
            set { this._secondarySubnetArn = value; }
        }

        // Check to see if SecondarySubnetArn property is set
        internal bool IsSetSecondarySubnetArn()
        {
            return this._secondarySubnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecondarySubnetId. 
        /// <para>
        /// The ID of the secondary subnet.
        /// </para>
        /// </summary>
        public string SecondarySubnetId
        {
            get { return this._secondarySubnetId; }
            set { this._secondarySubnetId = value; }
        }

        // Check to see if SecondarySubnetId property is set
        internal bool IsSetSecondarySubnetId()
        {
            return this._secondarySubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the secondary subnet.
        /// </para>
        /// </summary>
        public SecondarySubnetState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the current state of the secondary subnet.
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the secondary subnet.
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

    }
}