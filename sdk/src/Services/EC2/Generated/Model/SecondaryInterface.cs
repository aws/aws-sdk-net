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
    /// Describes a secondary interface.
    /// </summary>
    public partial class SecondaryInterface
    {
        private SecondaryInterfaceAttachment _attachment;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _macAddress;
        private string _ownerId;
        private List<SecondaryInterfaceIpv4Address> _privateIpv4Addresses = AWSConfigs.InitializeCollections ? new List<SecondaryInterfaceIpv4Address>() : null;
        private string _secondaryInterfaceArn;
        private string _secondaryInterfaceId;
        private SecondaryInterfaceType _secondaryInterfaceType;
        private string _secondaryNetworkId;
        private SecondaryNetworkType _secondaryNetworkType;
        private string _secondarySubnetId;
        private bool? _sourceDestCheck;
        private SecondaryInterfaceStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The attachment information for the secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceAttachment Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the secondary interface.
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
        /// The ID of the Availability Zone of the secondary interface.
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
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address of the secondary interface.
        /// </para>
        /// </summary>
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the secondary interface.
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
        /// Gets and sets the property PrivateIpv4Addresses. 
        /// <para>
        /// The private IPv4 addresses associated with the secondary interface.
        /// </para>
        /// </summary>
        public List<SecondaryInterfaceIpv4Address> PrivateIpv4Addresses
        {
            get { return this._privateIpv4Addresses; }
            set { this._privateIpv4Addresses = value; }
        }

        // Check to see if PrivateIpv4Addresses property is set
        internal bool IsSetPrivateIpv4Addresses()
        {
            return this._privateIpv4Addresses != null && (this._privateIpv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondaryInterfaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secondary interface.
        /// </para>
        /// </summary>
        public string SecondaryInterfaceArn
        {
            get { return this._secondaryInterfaceArn; }
            set { this._secondaryInterfaceArn = value; }
        }

        // Check to see if SecondaryInterfaceArn property is set
        internal bool IsSetSecondaryInterfaceArn()
        {
            return this._secondaryInterfaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryInterfaceId. 
        /// <para>
        /// The ID of the secondary interface.
        /// </para>
        /// </summary>
        public string SecondaryInterfaceId
        {
            get { return this._secondaryInterfaceId; }
            set { this._secondaryInterfaceId = value; }
        }

        // Check to see if SecondaryInterfaceId property is set
        internal bool IsSetSecondaryInterfaceId()
        {
            return this._secondaryInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryInterfaceType. 
        /// <para>
        /// The type of secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceType SecondaryInterfaceType
        {
            get { return this._secondaryInterfaceType; }
            set { this._secondaryInterfaceType = value; }
        }

        // Check to see if SecondaryInterfaceType property is set
        internal bool IsSetSecondaryInterfaceType()
        {
            return this._secondaryInterfaceType != null;
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
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checking is enabled.
        /// </para>
        /// </summary>
        public bool SourceDestCheck
        {
            get { return this._sourceDestCheck.GetValueOrDefault(); }
            set { this._sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this._sourceDestCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceStatus Status
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
        /// The tags assigned to the secondary interface.
        /// </para>
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