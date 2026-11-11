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
    /// Describes the networking features of the instance type.
    /// </summary>
    public partial class NetworkInfo
    {
        /// <summary>
        /// Gets and sets the property BandwidthWeightings. 
        /// <para>
        /// A list of valid settings for configurable bandwidth weighting for the instance type,
        /// if supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BandwidthWeightings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BandwidthWeightings property is set.
        /// </summary>
        internal bool IsSetBandwidthWeightings() => this.BandwidthWeightings != null && (this.BandwidthWeightings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionTrackingConfiguration. 
        /// <para>
        /// Indicates conntrack information for the instance type
        /// </para>
        /// </summary>
        public DefaultConnectionTrackingConfiguration ConnectionTrackingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTrackingConfiguration property is set.
        /// </summary>
        internal bool IsSetConnectionTrackingConfiguration() => this.ConnectionTrackingConfiguration != null;

        /// <summary>
        /// Gets and sets the property DefaultNetworkCardIndex. 
        /// <para>
        /// The index of the default network card, starting at 0.
        /// </para>
        /// </summary>
        public int? DefaultNetworkCardIndex { get; set; }

        /// <summary>
        /// Checks to see if the DefaultNetworkCardIndex property is set.
        /// </summary>
        internal bool IsSetDefaultNetworkCardIndex() => this.DefaultNetworkCardIndex.HasValue;

        /// <summary>
        /// Gets and sets the property EfaInfo. 
        /// <para>
        /// Describes the Elastic Fabric Adapters for the instance type.
        /// </para>
        /// </summary>
        public EfaInfo EfaInfo { get; set; }

        /// <summary>
        /// Checks to see if the EfaInfo property is set.
        /// </summary>
        internal bool IsSetEfaInfo() => this.EfaInfo != null;

        /// <summary>
        /// Gets and sets the property EfaSupported. 
        /// <para>
        /// Indicates whether Elastic Fabric Adapter (EFA) is supported.
        /// </para>
        /// </summary>
        public bool? EfaSupported { get; set; }

        /// <summary>
        /// Checks to see if the EfaSupported property is set.
        /// </summary>
        internal bool IsSetEfaSupported() => this.EfaSupported.HasValue;

        /// <summary>
        /// Gets and sets the property EnaSrdSupported. 
        /// <para>
        /// Indicates whether the instance type supports ENA Express. ENA Express uses Amazon
        /// Web Services Scalable Reliable Datagram (SRD) technology to increase the maximum bandwidth
        /// used per stream and minimize tail latency of network traffic between EC2 instances.
        /// </para>
        /// </summary>
        public bool? EnaSrdSupported { get; set; }

        /// <summary>
        /// Checks to see if the EnaSrdSupported property is set.
        /// </summary>
        internal bool IsSetEnaSrdSupported() => this.EnaSrdSupported.HasValue;

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Indicates whether Elastic Network Adapter (ENA) is supported.
        /// </para>
        /// </summary>
        public EnaSupport EnaSupport { get; set; }

        /// <summary>
        /// Checks to see if the EnaSupport property is set.
        /// </summary>
        internal bool IsSetEnaSupport() => this.EnaSupport != null;

        /// <summary>
        /// Gets and sets the property EncryptionInTransitSupported. 
        /// <para>
        /// Indicates whether the instance type automatically encrypts in-transit traffic between
        /// instances.
        /// </para>
        /// </summary>
        public bool? EncryptionInTransitSupported { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionInTransitSupported property is set.
        /// </summary>
        internal bool IsSetEncryptionInTransitSupported() => this.EncryptionInTransitSupported.HasValue;

        /// <summary>
        /// Gets and sets the property FlexibleEnaQueuesSupport. 
        /// <para>
        /// Indicates whether changing the number of ENA queues is supported.
        /// </para>
        /// </summary>
        public FlexibleEnaQueuesSupport FlexibleEnaQueuesSupport { get; set; }

        /// <summary>
        /// Checks to see if the FlexibleEnaQueuesSupport property is set.
        /// </summary>
        internal bool IsSetFlexibleEnaQueuesSupport() => this.FlexibleEnaQueuesSupport != null;

        /// <summary>
        /// Gets and sets the property Ipv4AddressesPerInterface. 
        /// <para>
        /// The maximum number of IPv4 addresses per network interface.
        /// </para>
        /// </summary>
        public int? Ipv4AddressesPerInterface { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4AddressesPerInterface property is set.
        /// </summary>
        internal bool IsSetIpv4AddressesPerInterface() => this.Ipv4AddressesPerInterface.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv4AddressesPerSecondaryInterface. 
        /// <para>
        /// The maximum number of IPv4 addresses per secondary interface.
        /// </para>
        /// </summary>
        public int? Ipv4AddressesPerSecondaryInterface { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4AddressesPerSecondaryInterface property is set.
        /// </summary>
        internal bool IsSetIpv4AddressesPerSecondaryInterface() => this.Ipv4AddressesPerSecondaryInterface.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6AddressesPerInterface. 
        /// <para>
        /// The maximum number of IPv6 addresses per network interface.
        /// </para>
        /// </summary>
        public int? Ipv6AddressesPerInterface { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AddressesPerInterface property is set.
        /// </summary>
        internal bool IsSetIpv6AddressesPerInterface() => this.Ipv6AddressesPerInterface.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Supported. 
        /// <para>
        /// Indicates whether IPv6 is supported.
        /// </para>
        /// </summary>
        public bool? Ipv6Supported { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Supported property is set.
        /// </summary>
        internal bool IsSetIpv6Supported() => this.Ipv6Supported.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumNetworkCards. 
        /// <para>
        /// The maximum number of physical network cards that can be allocated to the instance.
        /// </para>
        /// </summary>
        public int? MaximumNetworkCards { get; set; }

        /// <summary>
        /// Checks to see if the MaximumNetworkCards property is set.
        /// </summary>
        internal bool IsSetMaximumNetworkCards() => this.MaximumNetworkCards.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumNetworkInterfaces. 
        /// <para>
        /// The maximum number of network interfaces for the instance type.
        /// </para>
        /// </summary>
        public int? MaximumNetworkInterfaces { get; set; }

        /// <summary>
        /// Checks to see if the MaximumNetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetMaximumNetworkInterfaces() => this.MaximumNetworkInterfaces.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumSecondaryNetworkInterfaces. 
        /// <para>
        /// The maximum number of secondary interfaces for the instance type.
        /// </para>
        /// </summary>
        public int? MaximumSecondaryNetworkInterfaces { get; set; }

        /// <summary>
        /// Checks to see if the MaximumSecondaryNetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetMaximumSecondaryNetworkInterfaces() => this.MaximumSecondaryNetworkInterfaces.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkCards. 
        /// <para>
        /// Describes the network cards for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkCardInfo> NetworkCards { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkCardInfo>() : null;

        /// <summary>
        /// Checks to see if the NetworkCards property is set.
        /// </summary>
        internal bool IsSetNetworkCards() => this.NetworkCards != null && (this.NetworkCards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance.
        /// </para>
        /// </summary>
        public string NetworkPerformance { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformance property is set.
        /// </summary>
        internal bool IsSetNetworkPerformance() => this.NetworkPerformance != null;

        /// <summary>
        /// Gets and sets the property SecondaryNetworkSupported. 
        /// <para>
        /// Indicates whether secondary interface attachments from secondary network are supported.
        /// </para>
        /// </summary>
        public bool? SecondaryNetworkSupported { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryNetworkSupported property is set.
        /// </summary>
        internal bool IsSetSecondaryNetworkSupported() => this.SecondaryNetworkSupported.HasValue;
    }
}
