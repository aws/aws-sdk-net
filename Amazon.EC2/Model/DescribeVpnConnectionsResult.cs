/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Vpn Connections Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeVpnConnectionsResult
    {
        private List<VpnConnection> vpnConnectionField;
        /// <summary>
        /// Gets and sets the VpnConnection property.
        /// List of vpn connections
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnection")]
        public List<VpnConnection> VpnConnection
        {
            get
            {
                if (this.vpnConnectionField == null)
                {
                    this.vpnConnectionField = new List<VpnConnection>();
                }
                return this.vpnConnectionField;
            }
            set { this.vpnConnectionField = value; }
        }

        /// <summary>
        /// Sets the VpnConnection property
        /// </summary>
        /// <param name="list">List of vpn connections</param>
        /// <returns>this instance</returns>
        public DescribeVpnConnectionsResult WithVpnConnection(params VpnConnection[] list)
        {
            foreach (VpnConnection item in list)
            {
                VpnConnection.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VpnConnection property is set
        /// </summary>
        /// <returns>true if VpnConnection property is set</returns>
        public bool IsSetVpnConnection()
        {
            return (VpnConnection.Count > 0);
        }

    }
}
