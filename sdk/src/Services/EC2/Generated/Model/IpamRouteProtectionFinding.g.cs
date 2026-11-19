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
    /// Contains information about a route protection finding, including the RPKI validation
    /// status of a BYOIP route announcement.
    /// </summary>
    public partial class IpamRouteProtectionFinding
    {
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
        public IpamByoipAdvertisementType AdvertisementType { get; set; }

        /// <summary>
        /// Checks to see if the AdvertisementType property is set.
        /// </summary>
        internal bool IsSetAdvertisementType() => this.AdvertisementType != null;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The Autonomous System Number (ASN) that originates the route.
        /// </para>
        /// </summary>
        public string Asn { get; set; }

        /// <summary>
        /// Checks to see if the Asn property is set.
        /// </summary>
        internal bool IsSetAsn() => this.Asn != null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address prefix in CIDR notation.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool associated with the finding.
        /// </para>
        /// </summary>
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The network border group.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the BYOIP pool.
        /// </para>
        /// </summary>
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The ID of the resource owner.
        /// </para>
        /// </summary>
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerId() => this.ResourceOwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The Amazon Web Services Region of the resource.
        /// </para>
        /// </summary>
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property RoaSampleTime. 
        /// <para>
        /// The time when the ROA data was last sampled.
        /// </para>
        /// </summary>
        public DateTime? RoaSampleTime { get; set; }

        /// <summary>
        /// Checks to see if the RoaSampleTime property is set.
        /// </summary>
        internal bool IsSetRoaSampleTime() => this.RoaSampleTime.HasValue;

        /// <summary>
        /// Gets and sets the property Roas. 
        /// <para>
        /// The Route Origin Authorizations (ROAs) that cover the prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamRouteOriginAuthorization> Roas { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamRouteOriginAuthorization>() : null;

        /// <summary>
        /// Checks to see if the Roas property is set.
        /// </summary>
        internal bool IsSetRoas() => this.Roas != null && (this.Roas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteOverlaps. 
        /// <para>
        /// The overlapping routes detected for this prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<IpamRouteOverlap> RouteOverlaps { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamRouteOverlap>() : null;

        /// <summary>
        /// Checks to see if the RouteOverlaps property is set.
        /// </summary>
        internal bool IsSetRouteOverlaps() => this.RouteOverlaps != null && (this.RouteOverlaps.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public IpamRpkiStatus RpkiStatus { get; set; }

        /// <summary>
        /// Checks to see if the RpkiStatus property is set.
        /// </summary>
        internal bool IsSetRpkiStatus() => this.RpkiStatus != null;

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
        public IpamRpkiStrength RpkiStrength { get; set; }

        /// <summary>
        /// Checks to see if the RpkiStrength property is set.
        /// </summary>
        internal bool IsSetRpkiStrength() => this.RpkiStrength != null;

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The time when the route was last sampled.
        /// </para>
        /// </summary>
        public DateTime? SampleTime { get; set; }

        /// <summary>
        /// Checks to see if the SampleTime property is set.
        /// </summary>
        internal bool IsSetSampleTime() => this.SampleTime.HasValue;

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
        public IpamByoipCidrState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
