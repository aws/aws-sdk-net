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
    /// Contains information about a route protection finding, including the RPKI validation
    /// status of a BYOIP route announcement.
    /// </summary>
    public partial class IpamRouteProtectionFinding
    {
        private IpamByoipAdvertisementType _advertisementType;
        private string _asn;
        private string _cidr;
        private string _ipamPoolId;
        private string _networkBorderGroup;
        private string _poolId;
        private string _resourceOwnerId;
        private string _resourceRegion;
        private List<IpamRouteOriginAuthorization> _roas = AWSConfigs.InitializeCollections ? new List<IpamRouteOriginAuthorization>() : null;
        private DateTime? _roaSampleTime;
        private List<IpamRouteOverlap> _routeOverlaps = AWSConfigs.InitializeCollections ? new List<IpamRouteOverlap>() : null;
        private IpamRpkiStatus _rpkiStatus;
        private IpamRpkiStrength _rpkiStrength;
        private DateTime? _sampleTime;
        private IpamByoipCidrState _state;

        /// <summary>
        /// Gets and sets the property AdvertisementType. 
        /// <para>
        /// The advertisement type. Possible values:
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
        /// The IP address prefix in CIDR notation.
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
        /// The ID of the IPAM pool associated with the finding.
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
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The network border group.
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
        /// The ID of the BYOIP pool.
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
        /// The Amazon Web Services Region of the resource.
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
        /// Gets and sets the property Roas. 
        /// <para>
        /// The Route Origin Authorizations (ROAs) that cover the prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamRouteOriginAuthorization> Roas
        {
            get { return this._roas; }
            set { this._roas = value; }
        }

        // Check to see if Roas property is set
        internal bool IsSetRoas()
        {
            return this._roas != null && (this._roas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoaSampleTime. 
        /// <para>
        /// The time when the ROA data was last sampled.
        /// </para>
        /// </summary>
        public DateTime? RoaSampleTime
        {
            get { return this._roaSampleTime; }
            set { this._roaSampleTime = value; }
        }

        // Check to see if RoaSampleTime property is set
        internal bool IsSetRoaSampleTime()
        {
            return this._roaSampleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteOverlaps. 
        /// <para>
        /// The overlapping routes detected for this prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<IpamRouteOverlap> RouteOverlaps
        {
            get { return this._routeOverlaps; }
            set { this._routeOverlaps = value; }
        }

        // Check to see if RouteOverlaps property is set
        internal bool IsSetRouteOverlaps()
        {
            return this._routeOverlaps != null && (this._routeOverlaps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RpkiStatus. 
        /// <para>
        /// The RPKI validation status of the route. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>valid</c> - The route has a matching ROA that covers the prefix and origin ASN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>invalid</c> - The route has a ROA for the prefix, but the origin ASN or prefix
        /// length does not match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c> - No ROA exists for the prefix, so RPKI validation cannot be performed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamRpkiStatus RpkiStatus
        {
            get { return this._rpkiStatus; }
            set { this._rpkiStatus = value; }
        }

        // Check to see if RpkiStatus property is set
        internal bool IsSetRpkiStatus()
        {
            return this._rpkiStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RpkiStrength. 
        /// <para>
        /// The RPKI enforcement strength for the route. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>strict</c> - Invalid routes are rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>permissive</c> - Invalid routes are accepted but flagged.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamRpkiStrength RpkiStrength
        {
            get { return this._rpkiStrength; }
            set { this._rpkiStrength = value; }
        }

        // Check to see if RpkiStrength property is set
        internal bool IsSetRpkiStrength()
        {
            return this._rpkiStrength != null;
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