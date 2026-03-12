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
    /// Describes a secondary interface attached to an instance.
    /// </summary>
    public partial class InstanceSecondaryInterface
    {
        private InstanceSecondaryInterfaceAttachment _attachment;
        private SecondaryInterfaceType _interfaceType;
        private string _macAddress;
        private string _ownerId;
        private List<InstanceSecondaryInterfacePrivateIpAddress> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<InstanceSecondaryInterfacePrivateIpAddress>() : null;
        private string _secondaryInterfaceId;
        private string _secondaryNetworkId;
        private string _secondarySubnetId;
        private bool? _sourceDestCheck;
        private SecondaryInterfaceStatus _status;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The attachment information for the secondary interface.
        /// </para>
        /// </summary>
        public InstanceSecondaryInterfaceAttachment Attachment
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
        /// Gets and sets the property InterfaceType. 
        /// <para>
        /// The type of secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceType InterfaceType
        {
            get { return this._interfaceType; }
            set { this._interfaceType = value; }
        }

        // Check to see if InterfaceType property is set
        internal bool IsSetInterfaceType()
        {
            return this._interfaceType != null;
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
        /// The Amazon Web Services account ID of the owner of the secondary interface.
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
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The private IPv4 addresses associated with the secondary interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceSecondaryInterfacePrivateIpAddress> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && (this._privateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        public bool? SourceDestCheck
        {
            get { return this._sourceDestCheck; }
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

    }
}