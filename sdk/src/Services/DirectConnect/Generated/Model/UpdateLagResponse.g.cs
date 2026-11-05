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
    /// This is the response object from the UpdateLag operation.
    /// </summary>
    public partial class UpdateLagResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowsHostedConnections. 
        /// <para>
        /// Indicates whether the LAG can host other connections.
        /// </para>
        /// </summary>
        public bool? AllowsHostedConnections { get; set; }

        /// <summary>
        /// Checks to see if the AllowsHostedConnections property is set.
        /// </summary>
        internal bool IsSetAllowsHostedConnections() => this.AllowsHostedConnections.HasValue;

        /// <summary>
        /// Gets and sets the property AwsDevice. 
        /// <para>
        /// The Direct Connect endpoint that hosts the LAG.
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
        /// The Direct Connect endpoint that hosts the LAG.
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
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// The billing mode of the LAG.
        /// </para>
        /// </summary>
        public BillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The connections bundled by the LAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Connection> Connections { get; set; } = AWSConfigs.InitializeCollections ? new List<Connection>() : null;

        /// <summary>
        /// Checks to see if the Connections property is set.
        /// </summary>
        internal bool IsSetConnections() => this.Connections != null && (this.Connections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionsBandwidth. 
        /// <para>
        /// The individual bandwidth of the physical connections bundled by the LAG. The possible
        /// values are 1Gbps, 10Gbps, 100Gbps, or 400 Gbps.. 
        /// </para>
        /// </summary>
        public string ConnectionsBandwidth { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionsBandwidth property is set.
        /// </summary>
        internal bool IsSetConnectionsBandwidth() => this.ConnectionsBandwidth != null;

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The LAG MAC Security (MACsec) encryption mode.
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
        /// Indicates whether the LAG supports a secondary BGP peer in the same address family
        /// (IPv4/IPv6).
        /// </para>
        /// </summary>
        public HasLogicalRedundancy HasLogicalRedundancy { get; set; }

        /// <summary>
        /// Checks to see if the HasLogicalRedundancy property is set.
        /// </summary>
        internal bool IsSetHasLogicalRedundancy() => this.HasLogicalRedundancy != null;

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
        /// Gets and sets the property LagName. 
        /// <para>
        /// The name of the LAG.
        /// </para>
        /// </summary>
        public string LagName { get; set; }

        /// <summary>
        /// Checks to see if the LagName property is set.
        /// </summary>
        internal bool IsSetLagName() => this.LagName != null;

        /// <summary>
        /// Gets and sets the property LagState. 
        /// <para>
        /// The state of the LAG. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>requested</c>: The initial state of a LAG. The LAG stays in the requested state
        /// until the Letter of Authorization (LOA) is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The LAG has been approved and is being initialized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The network link is established and the LAG is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: The network link is down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The LAG is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The LAG is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The state of the LAG is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LagState LagState { get; set; }

        /// <summary>
        /// Checks to see if the LagState property is set.
        /// </summary>
        internal bool IsSetLagState() => this.LagState != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the LAG.
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
        /// Indicates whether the LAG supports MAC Security (MACsec).
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
        /// The MAC Security (MACsec) security keys associated with the LAG.
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
        /// Gets and sets the property MinimumLinks. 
        /// <para>
        /// The minimum number of physical dedicated connections that must be operational for
        /// the LAG itself to be operational.
        /// </para>
        /// </summary>
        public int? MinimumLinks { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLinks property is set.
        /// </summary>
        internal bool IsSetMinimumLinks() => this.MinimumLinks.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfConnections. 
        /// <para>
        /// The number of physical dedicated connections initially provisioned and bundled by
        /// the LAG. You can have a maximum of four connections when the port speed is 1 Gbps
        /// or 10 Gbps, or two when the port speed is 100 Gbps or 400 Gbps.
        /// </para>
        /// </summary>
        public int? NumberOfConnections { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfConnections property is set.
        /// </summary>
        internal bool IsSetNumberOfConnections() => this.NumberOfConnections.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the LAG.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property PrefixPoolSizeIpv4. 
        /// <para>
        /// The total number of inbound IPv4 route prefixes you can allocate across the virtual
        /// interfaces on the LAG. Not applicable to LAGs that are interconnects and support hosted
        /// connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolSizeIpv4 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolSizeIpv4 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolSizeIpv4() => this.PrefixPoolSizeIpv4.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixPoolSizeIpv6. 
        /// <para>
        /// The total number of inbound IPv6 route prefixes you can allocate across the virtual
        /// interfaces on the LAG. Not applicable to LAGs that are interconnects and support hosted
        /// connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolSizeIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolSizeIpv6 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolSizeIpv6() => this.PrefixPoolSizeIpv6.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixPoolUnallocatedCountIpv4. 
        /// <para>
        /// The number of inbound IPv4 route prefixes in the LAG prefix pool not yet allocated
        /// to a virtual interface. Not applicable to LAGs that are interconnects and support
        /// hosted connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolUnallocatedCountIpv4 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolUnallocatedCountIpv4 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolUnallocatedCountIpv4() => this.PrefixPoolUnallocatedCountIpv4.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixPoolUnallocatedCountIpv6. 
        /// <para>
        /// The number of inbound IPv6 route prefixes in the LAG prefix pool not yet allocated
        /// to a virtual interface. Not applicable to LAGs that are interconnects and support
        /// hosted connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolUnallocatedCountIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolUnallocatedCountIpv6 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolUnallocatedCountIpv6() => this.PrefixPoolUnallocatedCountIpv6.HasValue;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the service provider associated with the LAG.
        /// </para>
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property RateLimiterStatus. 
        /// <para>
        /// The rate limiter status for the LAG, including how many rate limiters are in use and
        /// the maximum allowed.
        /// </para>
        /// </summary>
        public RateLimiterStatus RateLimiterStatus { get; set; }

        /// <summary>
        /// Checks to see if the RateLimiterStatus property is set.
        /// </summary>
        internal bool IsSetRateLimiterStatus() => this.RateLimiterStatus != null;

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
        /// The tags associated with the LAG.
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
