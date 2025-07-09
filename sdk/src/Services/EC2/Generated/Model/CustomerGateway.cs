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
    /// Describes a customer gateway.
    /// </summary>
    public partial class CustomerGateway
    {
        private string _bgpAsn;
        private string _bgpAsnExtended;
        private string _certificateArn;
        private string _customerGatewayId;
        private string _deviceName;
        private string _ipAddress;
        private string _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _type;

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
        public string BgpAsn
        {
            get { return this._bgpAsn; }
            set { this._bgpAsn = value; }
        }

        // Check to see if BgpAsn property is set
        internal bool IsSetBgpAsn()
        {
            return this._bgpAsn != null;
        }

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
        public string BgpAsnExtended
        {
            get { return this._bgpAsnExtended; }
            set { this._bgpAsnExtended = value; }
        }

        // Check to see if BgpAsnExtended property is set
        internal bool IsSetBgpAsnExtended()
        {
            return this._bgpAsnExtended != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the customer gateway certificate.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway.
        /// </para>
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this._customerGatewayId; }
            set { this._customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this._customerGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of customer gateway device.
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

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
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the customer gateway (<c>pending | available | deleting | deleted</c>).
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the customer gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection the customer gateway supports (<c>ipsec.1</c>).
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}