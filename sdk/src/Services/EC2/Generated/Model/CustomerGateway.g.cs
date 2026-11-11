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
    /// Describes a customer gateway.
    /// </summary>
    public partial class CustomerGateway
    {
        /// <summary>
        /// Gets and sets the property BgpAsn. 
        /// <para>
        /// The customer gateway device's Border Gateway Protocol (BGP) Autonomous System Number
        /// (ASN).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>1</c> to <c>2,147,483,647</c> 
        /// </para>
        /// </summary>
        public string BgpAsn { get; set; }

        /// <summary>
        /// Checks to see if the BgpAsn property is set.
        /// </summary>
        internal bool IsSetBgpAsn() => this.BgpAsn != null;

        /// <summary>
        /// Gets and sets the property BgpAsnExtended. 
        /// <para>
        /// The customer gateway device's Border Gateway Protocol (BGP) Autonomous System Number
        /// (ASN).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2,147,483,648</c> to <c>4,294,967,295</c> 
        /// </para>
        /// </summary>
        public string BgpAsnExtended { get; set; }

        /// <summary>
        /// Checks to see if the BgpAsnExtended property is set.
        /// </summary>
        internal bool IsSetBgpAsnExtended() => this.BgpAsnExtended != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the customer gateway certificate.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway.
        /// </para>
        /// </summary>
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayId property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayId() => this.CustomerGatewayId != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of customer gateway device.
        /// </para>
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        ///  The IP address for the customer gateway device's outside interface. The address must
        /// be static. If <c>OutsideIpAddressType</c> in your VPN connection options is set to
        /// <c>PrivateIpv4</c>, you can use an RFC6598 or RFC1918 private IPv4 address. If <c>OutsideIpAddressType</c>
        /// is set to <c>PublicIpv4</c>, you can use a public IPv4 address. If <c>OutsideIpAddressType</c>
        /// is set to <c>Ipv6</c>, you can use a public IPv6 address. 
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the customer gateway (<c>pending | available | deleting | deleted</c>).
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the customer gateway.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection the customer gateway supports (<c>ipsec.1</c>).
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
