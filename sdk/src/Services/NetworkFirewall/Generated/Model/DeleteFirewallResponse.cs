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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the DeleteFirewall operation.
    /// </summary>
    public partial class DeleteFirewallResponse : AmazonWebServiceResponse
    {
        private Firewall _firewall;
        private FirewallStatus _firewallStatus;

        /// <summary>
        /// Gets and sets the property Firewall.
        /// </summary>
        public Firewall Firewall
        {
            get { return this._firewall; }
            set { this._firewall = value; }
        }

        // Check to see if Firewall property is set
        internal bool IsSetFirewall()
        {
            return this._firewall != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallStatus.
        /// </summary>
        public FirewallStatus FirewallStatus
        {
            get { return this._firewallStatus; }
            set { this._firewallStatus = value; }
        }

        // Check to see if FirewallStatus property is set
        internal bool IsSetFirewallStatus()
        {
            return this._firewallStatus != null;
        }

    }
}