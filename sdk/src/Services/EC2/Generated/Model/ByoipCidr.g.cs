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
    /// Information about an address range that is provisioned for use with your Amazon Web
    /// Services resources through bring your own IP addresses (BYOIP).
    /// </summary>
    public partial class ByoipCidr
    {
        /// <summary>
        /// Gets and sets the property AdvertisementType. 
        /// <para>
        /// Specifies the advertisement method for the BYOIP CIDR. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>unicast</c>: IP is advertised from a single location (regional services like EC2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>anycast</c>: IP is advertised from multiple global locations simultaneously (global
        /// services like CloudFront)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/tutorials-byoip-cloudfront.html">Bring
        /// your own IP to CloudFront using IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public string AdvertisementType { get; set; }

        /// <summary>
        /// Checks to see if the AdvertisementType property is set.
        /// </summary>
        internal bool IsSetAdvertisementType() => this.AdvertisementType != null;

        /// <summary>
        /// Gets and sets the property AsnAssociations. 
        /// <para>
        /// The BYOIP CIDR associations with ASNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AsnAssociation> AsnAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<AsnAssociation>() : null;

        /// <summary>
        /// Checks to see if the AsnAssociations property is set.
        /// </summary>
        internal bool IsSetAsnAssociations() => this.AsnAssociations != null && (this.AsnAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The address range, in CIDR notation.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the address range.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool associated with the CIDR.
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
        /// If you have <a href="https://docs.aws.amazon.com/local-zones/latest/ug/how-local-zones-work.html">Local
        /// Zones</a> enabled, you can choose a network border group for Local Zones when you
        /// provision and advertise a BYOIPv4 CIDR. Choose the network border group carefully
        /// as the EIP and the Amazon Web Services resource it is associated with must reside
        /// in the same network border group.
        /// </para>
        ///  
        /// <para>
        /// You can provision BYOIP address ranges to and advertise them in the following Local
        /// Zone network border groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// us-east-1-dfw-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-lax-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-phx-2
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot provision or advertise BYOIPv6 address ranges in Local Zones at this time.
        /// </para>
        ///  </note>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the address pool associated with the CIDR.
        /// </para>
        /// </summary>
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the address range.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>advertised</c>: The address range is being advertised to the internet by Amazon
        /// Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deprovisioned</c>: The address range is deprovisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-deprovision</c>: The request to deprovision the address range was unsuccessful.
        /// Ensure that all EIPs from the range have been deallocated and try again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-provision</c>: The request to provision the address range was unsuccessful.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-deprovision</c>: You’ve submitted a request to deprovision an address
        /// range and it's pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-provision</c>: You’ve submitted a request to provision an address range
        /// and it's pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned</c>: The address range is provisioned and can be advertised. The range
        /// is not currently advertised.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned-not-publicly-advertisable</c>: The address range is provisioned and
        /// cannot be advertised.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ByoipCidrState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Upon success, contains the ID of the address pool. Otherwise, contains an error message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
