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
    /// Describes a secondary interface specification in a launch template.
    /// </summary>
    public partial class LaunchTemplateInstanceSecondaryInterfaceSpecification
    {
        private bool? _deleteOnTermination;
        private int? _deviceIndex;
        private SecondaryInterfaceType _interfaceType;
        private int? _networkCardIndex;
        private int? _privateIpAddressCount;
        private List<SecondaryInterfacePrivateIpAddressSpecification> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<SecondaryInterfacePrivateIpAddressSpecification>() : null;
        private string _secondarySubnetId;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the secondary interface is deleted when the instance is terminated.
        /// </para>
        ///  
        /// <para>
        /// The only supported value for this field is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination
        {
            get { return this._deleteOnTermination; }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The device index for the secondary interface attachment.
        /// </para>
        /// </summary>
        public int? DeviceIndex
        {
            get { return this._deviceIndex; }
            set { this._deviceIndex = value; }
        }

        // Check to see if DeviceIndex property is set
        internal bool IsSetDeviceIndex()
        {
            return this._deviceIndex.HasValue; 
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
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card.
        /// </para>
        /// </summary>
        public int? NetworkCardIndex
        {
            get { return this._networkCardIndex; }
            set { this._networkCardIndex = value; }
        }

        // Check to see if NetworkCardIndex property is set
        internal bool IsSetNetworkCardIndex()
        {
            return this._networkCardIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddressCount. 
        /// <para>
        /// The number of private IPv4 addresses to assign to the secondary interface.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>privateIpAddressCount</c> you cannot specify <c>privateIpAddresses</c>
        /// 
        /// </para>
        /// </summary>
        public int? PrivateIpAddressCount
        {
            get { return this._privateIpAddressCount; }
            set { this._privateIpAddressCount = value; }
        }

        // Check to see if PrivateIpAddressCount property is set
        internal bool IsSetPrivateIpAddressCount()
        {
            return this._privateIpAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The private IPv4 addresses to assign to the secondary interface.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>privateIpAddresses</c> you cannot specify <c>privateIpAddressCount</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryInterfacePrivateIpAddressSpecification> PrivateIpAddresses
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

    }
}