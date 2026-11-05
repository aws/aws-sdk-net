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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about an interconnect.
    /// </summary>
    public partial class Interconnect
    {
        /// <summary>
        /// Gets and sets the property AwsDevice. 
        /// <para>
        /// The Direct Connect endpoint on which the physical connection terminates.
        /// </para>
        /// </summary>
        public string AwsDevice { get; set; }

        /// <summary>
        /// Checks to see if the AwsDevice property is set.
        /// </summary>
        internal bool IsSetAwsDevice() => this.AwsDevice != null;

        /// <summary>
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The Direct Connect endpoint that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsDeviceV2 { get; set; }

        /// <summary>
        /// Checks to see if the AwsDeviceV2 property is set.
        /// </summary>
        internal bool IsSetAwsDeviceV2() => this.AwsDeviceV2 != null;

        /// <summary>
        /// Gets and sets the property AwsLogicalDeviceId. 
        /// <para>
        /// The Direct Connect endpoint that terminates the logical connection. This device might
        /// be different than the device that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsLogicalDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the AwsLogicalDeviceId property is set.
        /// </summary>
        internal bool IsSetAwsLogicalDeviceId() => this.AwsLogicalDeviceId != null;

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The bandwidth of the connection.
        /// </para>
        /// </summary>
        public string Bandwidth { get; set; }

        /// <summary>
        /// Checks to see if the Bandwidth property is set.
        /// </summary>
        internal bool IsSetBandwidth() => this.Bandwidth != null;

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The MAC Security (MACsec) encryption mode.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>no_encrypt</c>, <c>should_encrypt</c>, and <c>must_encrypt</c>.
        /// </para>
        /// </summary>
        public string EncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMode property is set.
        /// </summary>
        internal bool IsSetEncryptionMode() => this.EncryptionMode != null;

        /// <summary>
        /// Gets and sets the property HasLogicalRedundancy. 
        /// <para>
        /// Indicates whether the interconnect supports a secondary BGP in the same address family
        /// (IPv4/IPv6).
        /// </para>
        /// </summary>
        public HasLogicalRedundancy HasLogicalRedundancy { get; set; }

        /// <summary>
        /// Checks to see if the HasLogicalRedundancy property is set.
        /// </summary>
        internal bool IsSetHasLogicalRedundancy() => this.HasLogicalRedundancy != null;

        /// <summary>
        /// Gets and sets the property InterconnectId. 
        /// <para>
        /// The ID of the interconnect.
        /// </para>
        /// </summary>
        public string InterconnectId { get; set; }

        /// <summary>
        /// Checks to see if the InterconnectId property is set.
        /// </summary>
        internal bool IsSetInterconnectId() => this.InterconnectId != null;

        /// <summary>
        /// Gets and sets the property InterconnectName. 
        /// <para>
        /// The name of the interconnect.
        /// </para>
        /// </summary>
        public string InterconnectName { get; set; }

        /// <summary>
        /// Checks to see if the InterconnectName property is set.
        /// </summary>
        internal bool IsSetInterconnectName() => this.InterconnectName != null;

        /// <summary>
        /// Gets and sets the property InterconnectState. 
        /// <para>
        /// The state of the interconnect. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>requested</c>: The initial state of an interconnect. The interconnect stays in
        /// the requested state until the Letter of Authorization (LOA) is sent to the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The interconnect is approved, and is being initialized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The network link is up, and the interconnect is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: The network link is down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The interconnect is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The interconnect is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The state of the interconnect is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InterconnectState InterconnectState { get; set; }

        /// <summary>
        /// Checks to see if the InterconnectState property is set.
        /// </summary>
        internal bool IsSetInterconnectState() => this.InterconnectState != null;

        /// <summary>
        /// Gets and sets the property JumboFrameCapable. 
        /// <para>
        /// Indicates whether jumbo frames are supported.
        /// </para>
        /// </summary>
        public bool? JumboFrameCapable { get; set; }

        /// <summary>
        /// Checks to see if the JumboFrameCapable property is set.
        /// </summary>
        internal bool IsSetJumboFrameCapable() => this.JumboFrameCapable.HasValue;

        /// <summary>
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG.
        /// </para>
        /// </summary>
        public string LagId { get; set; }

        /// <summary>
        /// Checks to see if the LagId property is set.
        /// </summary>
        internal bool IsSetLagId() => this.LagId != null;

        /// <summary>
        /// Gets and sets the property LoaIssueTime. 
        /// <para>
        /// The time of the most recent call to <a>DescribeLoa</a> for this connection.
        /// </para>
        /// </summary>
        public DateTime? LoaIssueTime { get; set; }

        /// <summary>
        /// Checks to see if the LoaIssueTime property is set.
        /// </summary>
        internal bool IsSetLoaIssueTime() => this.LoaIssueTime.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the connection.
        /// </para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property MacSecCapable. 
        /// <para>
        /// Indicates whether the interconnect supports MAC Security (MACsec).
        /// </para>
        /// </summary>
        public bool? MacSecCapable { get; set; }

        /// <summary>
        /// Checks to see if the MacSecCapable property is set.
        /// </summary>
        internal bool IsSetMacSecCapable() => this.MacSecCapable.HasValue;

        /// <summary>
        /// Gets and sets the property MacSecKeys. 
        /// <para>
        /// The MAC Security (MACsec) security keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MacSecKey> MacSecKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<MacSecKey>() : null;

        /// <summary>
        /// Checks to see if the MacSecKeys property is set.
        /// </summary>
        internal bool IsSetMacSecKeys() => this.MacSecKeys != null && (this.MacSecKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PortEncryptionStatus. 
        /// <para>
        /// The MAC Security (MACsec) port link status.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>Encryption Up</c>, which means that there is an active Connection
        /// Key Name, or <c>Encryption Down</c>.
        /// </para>
        /// </summary>
        public string PortEncryptionStatus { get; set; }

        /// <summary>
        /// Checks to see if the PortEncryptionStatus property is set.
        /// </summary>
        internal bool IsSetPortEncryptionStatus() => this.PortEncryptionStatus != null;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the service provider associated with the interconnect.
        /// </para>
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the connection is located.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the interconnect.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
