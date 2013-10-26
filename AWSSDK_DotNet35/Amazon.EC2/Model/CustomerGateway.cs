/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The CustomerGateway data type. </para>
    /// </summary>
    public class CustomerGateway
    {
        
        private string customerGatewayId;
        private string state;
        private string type;
        private string ipAddress;
        private string bgpAsn;
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// Specifies the ID of the customer gateway.
        ///  
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this.customerGatewayId; }
            set { this.customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this.customerGatewayId != null;
        }

        /// <summary>
        /// Describes the current state of the customer gateway. Valid values are <c>pending</c>, <c>available</c>, <c>deleting</c>, and <c>deleted</c>.
        ///  
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// Specifies the type of VPN connection the customer gateway supports.
        ///  
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// Contains the Internet-routable IP address of the customer gateway's outside interface.
        ///  
        /// </summary>
        public string IpAddress
        {
            get { return this.ipAddress; }
            set { this.ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this.ipAddress != null;
        }

        /// <summary>
        /// Specifies the customer gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
        ///  
        /// </summary>
        public string BgpAsn
        {
            get { return this.bgpAsn; }
            set { this.bgpAsn = value; }
        }

        // Check to see if BgpAsn property is set
        internal bool IsSetBgpAsn()
        {
            return this.bgpAsn != null;
        }

        /// <summary>
        /// A list of tags for the CustomerGateway.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
