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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an EC2 VPC.
    /// </summary>
    public partial class AwsEc2VpcDetails
    {
        private List<CidrBlockAssociation> _cidrBlockAssociationSet = new List<CidrBlockAssociation>();
        private string _dhcpOptionsId;
        private List<Ipv6CidrBlockAssociation> _ipv6CidrBlockAssociationSet = new List<Ipv6CidrBlockAssociation>();
        private string _state;

        /// <summary>
        /// Gets and sets the property CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv4 CIDR blocks associated with the VPC.
        /// </para>
        /// </summary>
        public List<CidrBlockAssociation> CidrBlockAssociationSet
        {
            get { return this._cidrBlockAssociationSet; }
            set { this._cidrBlockAssociationSet = value; }
        }

        // Check to see if CidrBlockAssociationSet property is set
        internal bool IsSetCidrBlockAssociationSet()
        {
            return this._cidrBlockAssociationSet != null && this._cidrBlockAssociationSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DhcpOptionsId. 
        /// <para>
        /// The identifier of the set of Dynamic Host Configuration Protocol (DHCP) options that
        /// are associated with the VPC. If the default options are associated with the VPC, then
        /// this is default.
        /// </para>
        /// </summary>
        public string DhcpOptionsId
        {
            get { return this._dhcpOptionsId; }
            set { this._dhcpOptionsId = value; }
        }

        // Check to see if DhcpOptionsId property is set
        internal bool IsSetDhcpOptionsId()
        {
            return this._dhcpOptionsId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockAssociationSet. 
        /// <para>
        /// Information about the IPv6 CIDR blocks associated with the VPC.
        /// </para>
        /// </summary>
        public List<Ipv6CidrBlockAssociation> Ipv6CidrBlockAssociationSet
        {
            get { return this._ipv6CidrBlockAssociationSet; }
            set { this._ipv6CidrBlockAssociationSet = value; }
        }

        // Check to see if Ipv6CidrBlockAssociationSet property is set
        internal bool IsSetIpv6CidrBlockAssociationSet()
        {
            return this._ipv6CidrBlockAssociationSet != null && this._ipv6CidrBlockAssociationSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPC.
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

    }
}