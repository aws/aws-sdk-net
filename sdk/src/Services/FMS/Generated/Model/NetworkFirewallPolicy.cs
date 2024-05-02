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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Configures the firewall policy deployment model of Network Firewall. For information
    /// about Network Firewall deployment models, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/architectures.html">Network
    /// Firewall example architectures with routing</a> in the <i>Network Firewall Developer
    /// Guide</i>.
    /// </summary>
    public partial class NetworkFirewallPolicy
    {
        private FirewallDeploymentModel _firewallDeploymentModel;

        /// <summary>
        /// Gets and sets the property FirewallDeploymentModel. 
        /// <para>
        /// Defines the deployment model to use for the firewall policy. To use a distributed
        /// model, set <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_PolicyOption.html">PolicyOption</a>
        /// to <c>NULL</c>.
        /// </para>
        /// </summary>
        public FirewallDeploymentModel FirewallDeploymentModel
        {
            get { return this._firewallDeploymentModel; }
            set { this._firewallDeploymentModel = value; }
        }

        // Check to see if FirewallDeploymentModel property is set
        internal bool IsSetFirewallDeploymentModel()
        {
            return this._firewallDeploymentModel != null;
        }

    }
}