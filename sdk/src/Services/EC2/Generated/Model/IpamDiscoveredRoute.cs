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
    /// Contains information about a BGP route discovered by IPAM resource discovery.
    /// </summary>
    public partial class IpamDiscoveredRoute
    {
        private IpamByoipAdvertisementType _advertisementType;
        private string _asn;
        private string _cidr;
        private string _ipamPoolId;
        private string _ipamResourceDiscoveryId;
        private string _networkBorderGroup;
        private string _poolId;
        private string _resourceOwnerId;
        private string _resourceRegion;
        private DateTime? _sampleTime;
        private IpamByoipCidrState _state;

        /// <summary>
        /// Gets and sets the property AdvertisementType. 
        /// <para>
        /// The advertisement type of the route. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>regional</c> - The IP address is advertised from a single location (regional services
        /// such as Amazon EC2).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>global</c> - The IP address is advertised from multiple global locations simultaneously
        /// (global services such as Amazon CloudFront).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamByoipAdvertisementType AdvertisementType
        {
            get { return this._advertisementType; }
            set { this._advertisementType = value; }
        }

        // Check to see if AdvertisementType property is set
        internal bool IsSetAdvertisementType()
        {
            return this._advertisementType != null;
        }

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The Autonomous System Number (ASN) that originates the route.
        /// </para>
        /// </summary>
        public string Asn
        {
            get { return this._asn; }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn != null;
        }

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address prefix of the discovered route in CIDR notation.
        /// </para>
        /// </summary>
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool associated with the route.
        /// </para>
        /// </summary>
        public string IpamPoolId
        {
            get { return this._ipamPoolId; }
            set { this._ipamPoolId = value; }
        }

        // Check to see if IpamPoolId property is set
        internal bool IsSetIpamPoolId()
        {
            return this._ipamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// The ID of the IPAM resource discovery that discovered the route.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryId
        {
            get { return this._ipamResourceDiscoveryId; }
            set { this._ipamResourceDiscoveryId = value; }
        }

        // Check to see if IpamResourceDiscoveryId property is set
        internal bool IsSetIpamResourceDiscoveryId()
        {
            return this._ipamResourceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The network border group for the route.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the BYOIP pool associated with the route.
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The ID of the resource owner.
        /// </para>
        /// </summary>
        public string ResourceOwnerId
        {
            get { return this._resourceOwnerId; }
            set { this._resourceOwnerId = value; }
        }

        // Check to see if ResourceOwnerId property is set
        internal bool IsSetResourceOwnerId()
        {
            return this._resourceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region where the route was discovered.
        /// </para>
        /// </summary>
        public string ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The time when the route was last sampled.
        /// </para>
        /// </summary>
        public DateTime? SampleTime
        {
            get { return this._sampleTime; }
            set { this._sampleTime = value; }
        }

        // Check to see if SampleTime property is set
        internal bool IsSetSampleTime()
        {
            return this._sampleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the BYOIP CIDR. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>advertised</c> - The CIDR is being advertised.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deprovisioned</c> - The CIDR has been deprovisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-deprovision</c> - Deprovisioning failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-provision</c> - Provisioning failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-deprovision</c> - Deprovisioning is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-provision</c> - Provisioning is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned</c> - The CIDR is provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned-not-publicly-advertisable</c> - The CIDR is provisioned but not publicly
        /// advertisable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamByoipCidrState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}