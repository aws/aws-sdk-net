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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the networking features of the instance type.
    /// </summary>
    public partial class NetworkInfo
    {
        private int? _defaultNetworkCardIndex;
        private EfaInfo _efaInfo;
        private bool? _efaSupported;
        private bool? _enaSrdSupported;
        private EnaSupport _enaSupport;
        private bool? _encryptionInTransitSupported;
        private int? _ipv4AddressesPerInterface;
        private int? _ipv6AddressesPerInterface;
        private bool? _ipv6Supported;
        private int? _maximumNetworkCards;
        private int? _maximumNetworkInterfaces;
        private List<NetworkCardInfo> _networkCards = new List<NetworkCardInfo>();
        private string _networkPerformance;

        /// <summary>
        /// Gets and sets the property DefaultNetworkCardIndex. 
        /// <para>
        /// The index of the default network card, starting at 0.
        /// </para>
        /// </summary>
        public int DefaultNetworkCardIndex
        {
            get { return this._defaultNetworkCardIndex.GetValueOrDefault(); }
            set { this._defaultNetworkCardIndex = value; }
        }

        // Check to see if DefaultNetworkCardIndex property is set
        internal bool IsSetDefaultNetworkCardIndex()
        {
            return this._defaultNetworkCardIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EfaInfo. 
        /// <para>
        /// Describes the Elastic Fabric Adapters for the instance type.
        /// </para>
        /// </summary>
        public EfaInfo EfaInfo
        {
            get { return this._efaInfo; }
            set { this._efaInfo = value; }
        }

        // Check to see if EfaInfo property is set
        internal bool IsSetEfaInfo()
        {
            return this._efaInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EfaSupported. 
        /// <para>
        /// Indicates whether Elastic Fabric Adapter (EFA) is supported.
        /// </para>
        /// </summary>
        public bool EfaSupported
        {
            get { return this._efaSupported.GetValueOrDefault(); }
            set { this._efaSupported = value; }
        }

        // Check to see if EfaSupported property is set
        internal bool IsSetEfaSupported()
        {
            return this._efaSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSrdSupported. 
        /// <para>
        /// Indicates whether the instance type supports ENA Express. ENA Express uses Amazon
        /// Web Services Scalable Reliable Datagram (SRD) technology to increase the maximum bandwidth
        /// used per stream and minimize tail latency of network traffic between EC2 instances.
        /// </para>
        /// </summary>
        public bool EnaSrdSupported
        {
            get { return this._enaSrdSupported.GetValueOrDefault(); }
            set { this._enaSrdSupported = value; }
        }

        // Check to see if EnaSrdSupported property is set
        internal bool IsSetEnaSrdSupported()
        {
            return this._enaSrdSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Indicates whether Elastic Network Adapter (ENA) is supported.
        /// </para>
        /// </summary>
        public EnaSupport EnaSupport
        {
            get { return this._enaSupport; }
            set { this._enaSupport = value; }
        }

        // Check to see if EnaSupport property is set
        internal bool IsSetEnaSupport()
        {
            return this._enaSupport != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionInTransitSupported. 
        /// <para>
        /// Indicates whether the instance type automatically encrypts in-transit traffic between
        /// instances.
        /// </para>
        /// </summary>
        public bool EncryptionInTransitSupported
        {
            get { return this._encryptionInTransitSupported.GetValueOrDefault(); }
            set { this._encryptionInTransitSupported = value; }
        }

        // Check to see if EncryptionInTransitSupported property is set
        internal bool IsSetEncryptionInTransitSupported()
        {
            return this._encryptionInTransitSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv4AddressesPerInterface. 
        /// <para>
        /// The maximum number of IPv4 addresses per network interface.
        /// </para>
        /// </summary>
        public int Ipv4AddressesPerInterface
        {
            get { return this._ipv4AddressesPerInterface.GetValueOrDefault(); }
            set { this._ipv4AddressesPerInterface = value; }
        }

        // Check to see if Ipv4AddressesPerInterface property is set
        internal bool IsSetIpv4AddressesPerInterface()
        {
            return this._ipv4AddressesPerInterface.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6AddressesPerInterface. 
        /// <para>
        /// The maximum number of IPv6 addresses per network interface.
        /// </para>
        /// </summary>
        public int Ipv6AddressesPerInterface
        {
            get { return this._ipv6AddressesPerInterface.GetValueOrDefault(); }
            set { this._ipv6AddressesPerInterface = value; }
        }

        // Check to see if Ipv6AddressesPerInterface property is set
        internal bool IsSetIpv6AddressesPerInterface()
        {
            return this._ipv6AddressesPerInterface.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Supported. 
        /// <para>
        /// Indicates whether IPv6 is supported.
        /// </para>
        /// </summary>
        public bool Ipv6Supported
        {
            get { return this._ipv6Supported.GetValueOrDefault(); }
            set { this._ipv6Supported = value; }
        }

        // Check to see if Ipv6Supported property is set
        internal bool IsSetIpv6Supported()
        {
            return this._ipv6Supported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumNetworkCards. 
        /// <para>
        /// The maximum number of physical network cards that can be allocated to the instance.
        /// </para>
        /// </summary>
        public int MaximumNetworkCards
        {
            get { return this._maximumNetworkCards.GetValueOrDefault(); }
            set { this._maximumNetworkCards = value; }
        }

        // Check to see if MaximumNetworkCards property is set
        internal bool IsSetMaximumNetworkCards()
        {
            return this._maximumNetworkCards.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumNetworkInterfaces. 
        /// <para>
        /// The maximum number of network interfaces for the instance type.
        /// </para>
        /// </summary>
        public int MaximumNetworkInterfaces
        {
            get { return this._maximumNetworkInterfaces.GetValueOrDefault(); }
            set { this._maximumNetworkInterfaces = value; }
        }

        // Check to see if MaximumNetworkInterfaces property is set
        internal bool IsSetMaximumNetworkInterfaces()
        {
            return this._maximumNetworkInterfaces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkCards. 
        /// <para>
        /// Describes the network cards for the instance type.
        /// </para>
        /// </summary>
        public List<NetworkCardInfo> NetworkCards
        {
            get { return this._networkCards; }
            set { this._networkCards = value; }
        }

        // Check to see if NetworkCards property is set
        internal bool IsSetNetworkCards()
        {
            return this._networkCards != null && this._networkCards.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance.
        /// </para>
        /// </summary>
        public string NetworkPerformance
        {
            get { return this._networkPerformance; }
            set { this._networkPerformance = value; }
        }

        // Check to see if NetworkPerformance property is set
        internal bool IsSetNetworkPerformance()
        {
            return this._networkPerformance != null;
        }

    }
}