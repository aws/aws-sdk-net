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
    /// Describes a secondary interface specification for a launch template request.
    /// </summary>
    public partial class LaunchTemplateInstanceSecondaryInterfaceSpecificationRequest
    {
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
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The device index for the secondary interface attachment.
        /// </para>
        /// </summary>
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the DeviceIndex property is set.
        /// </summary>
        internal bool IsSetDeviceIndex() => this.DeviceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property InterfaceType. 
        /// <para>
        /// The type of secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceType InterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceType property is set.
        /// </summary>
        internal bool IsSetInterfaceType() => this.InterfaceType != null;

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card.
        /// </para>
        /// </summary>
        public int? NetworkCardIndex { get; set; }

        /// <summary>
        /// Checks to see if the NetworkCardIndex property is set.
        /// </summary>
        internal bool IsSetNetworkCardIndex() => this.NetworkCardIndex.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateIpAddressCount. 
        /// <para>
        /// The number of private IPv4 addresses to assign to the secondary interface.
        /// </para>
        /// </summary>
        public int? PrivateIpAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddressCount property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddressCount() => this.PrivateIpAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The private IPv4 addresses to assign to the secondary interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryInterfacePrivateIpAddressSpecificationRequest> PrivateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<SecondaryInterfacePrivateIpAddressSpecificationRequest>() : null;

        /// <summary>
        /// Checks to see if the PrivateIpAddresses property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddresses() => this.PrivateIpAddresses != null && (this.PrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondarySubnetId. 
        /// <para>
        /// The ID of the secondary subnet.
        /// </para>
        /// </summary>
        public string SecondarySubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SecondarySubnetId property is set.
        /// </summary>
        internal bool IsSetSecondarySubnetId() => this.SecondarySubnetId != null;
    }
}
