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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>A structure containing information about a public virtual interface that will be provisioned on a connection.</para>
    /// </summary>
    public class NewPublicVirtualInterfaceAllocation
    {
        
        private string virtualInterfaceName;
        private int? vlan;
        private int? asn;
        private string authKey;
        private string amazonAddress;
        private string customerAddress;
        private List<RouteFilterPrefix> routeFilterPrefixes = new List<RouteFilterPrefix>();


        /// <summary>
        /// The name of the virtual interface assigned by the customer Example: "My VPC"
        ///  
        /// </summary>
        public string VirtualInterfaceName
        {
            get { return this.virtualInterfaceName; }
            set { this.virtualInterfaceName = value; }
        }

        // Check to see if VirtualInterfaceName property is set
        internal bool IsSetVirtualInterfaceName()
        {
            return this.virtualInterfaceName != null;
        }

        /// <summary>
        /// VLAN ID Example: 101
        ///  
        /// </summary>
        public int Vlan
        {
            get { return this.vlan ?? default(int); }
            set { this.vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this.vlan.HasValue;
        }

        /// <summary>
        /// Autonomous system (AS) number for Border Gateway Protocol (BGP) configuration Example: 65000
        ///  
        /// </summary>
        public int Asn
        {
            get { return this.asn ?? default(int); }
            set { this.asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this.asn.HasValue;
        }

        /// <summary>
        /// Authentication key for BGP configuration Example: asdf34example
        ///  
        /// </summary>
        public string AuthKey
        {
            get { return this.authKey; }
            set { this.authKey = value; }
        }

        // Check to see if AuthKey property is set
        internal bool IsSetAuthKey()
        {
            return this.authKey != null;
        }

        /// <summary>
        /// IP address assigned to the Amazon interface. Example: 192.168.1.1/30
        ///  
        /// </summary>
        public string AmazonAddress
        {
            get { return this.amazonAddress; }
            set { this.amazonAddress = value; }
        }

        // Check to see if AmazonAddress property is set
        internal bool IsSetAmazonAddress()
        {
            return this.amazonAddress != null;
        }

        /// <summary>
        /// IP address assigned to the customer interface. Example: 192.168.1.2/30
        ///  
        /// </summary>
        public string CustomerAddress
        {
            get { return this.customerAddress; }
            set { this.customerAddress = value; }
        }

        // Check to see if CustomerAddress property is set
        internal bool IsSetCustomerAddress()
        {
            return this.customerAddress != null;
        }

        /// <summary>
        /// A list of routes to be advertised to the AWS network in this region (public virtual interface) or your VPC (private virtual interface).
        ///  
        /// </summary>
        public List<RouteFilterPrefix> RouteFilterPrefixes
        {
            get { return this.routeFilterPrefixes; }
            set { this.routeFilterPrefixes = value; }
        }

        // Check to see if RouteFilterPrefixes property is set
        internal bool IsSetRouteFilterPrefixes()
        {
            return this.routeFilterPrefixes.Count > 0;
        }
    }
}
