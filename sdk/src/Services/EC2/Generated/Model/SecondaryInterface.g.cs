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
    /// Describes a secondary interface.
    /// </summary>
    public partial class SecondaryInterface
    {
        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The attachment information for the secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceAttachment Attachment { get; set; }

        /// <summary>
        /// Checks to see if the Attachment property is set.
        /// </summary>
        internal bool IsSetAttachment() => this.Attachment != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the secondary interface.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the secondary interface.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address of the secondary interface.
        /// </para>
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// Checks to see if the MacAddress property is set.
        /// </summary>
        internal bool IsSetMacAddress() => this.MacAddress != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the secondary interface.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PrivateIpv4Addresses. 
        /// <para>
        /// The private IPv4 addresses associated with the secondary interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryInterfaceIpv4Address> PrivateIpv4Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<SecondaryInterfaceIpv4Address>() : null;

        /// <summary>
        /// Checks to see if the PrivateIpv4Addresses property is set.
        /// </summary>
        internal bool IsSetPrivateIpv4Addresses() => this.PrivateIpv4Addresses != null && (this.PrivateIpv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondaryInterfaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secondary interface.
        /// </para>
        /// </summary>
        public string SecondaryInterfaceArn { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryInterfaceArn property is set.
        /// </summary>
        internal bool IsSetSecondaryInterfaceArn() => this.SecondaryInterfaceArn != null;

        /// <summary>
        /// Gets and sets the property SecondaryInterfaceId. 
        /// <para>
        /// The ID of the secondary interface.
        /// </para>
        /// </summary>
        public string SecondaryInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryInterfaceId property is set.
        /// </summary>
        internal bool IsSetSecondaryInterfaceId() => this.SecondaryInterfaceId != null;

        /// <summary>
        /// Gets and sets the property SecondaryInterfaceType. 
        /// <para>
        /// The type of secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceType SecondaryInterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryInterfaceType property is set.
        /// </summary>
        internal bool IsSetSecondaryInterfaceType() => this.SecondaryInterfaceType != null;

        /// <summary>
        /// Gets and sets the property SecondaryNetworkId. 
        /// <para>
        /// The ID of the secondary network.
        /// </para>
        /// </summary>
        public string SecondaryNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryNetworkId property is set.
        /// </summary>
        internal bool IsSetSecondaryNetworkId() => this.SecondaryNetworkId != null;

        /// <summary>
        /// Gets and sets the property SecondaryNetworkType. 
        /// <para>
        /// The type of the secondary network.
        /// </para>
        /// </summary>
        public SecondaryNetworkType SecondaryNetworkType { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryNetworkType property is set.
        /// </summary>
        internal bool IsSetSecondaryNetworkType() => this.SecondaryNetworkType != null;

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

        /// <summary>
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checking is enabled.
        /// </para>
        /// </summary>
        public bool? SourceDestCheck { get; set; }

        /// <summary>
        /// Checks to see if the SourceDestCheck property is set.
        /// </summary>
        internal bool IsSetSourceDestCheck() => this.SourceDestCheck.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the secondary interface.
        /// </para>
        /// </summary>
        public SecondaryInterfaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the secondary interface.
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
    }
}
