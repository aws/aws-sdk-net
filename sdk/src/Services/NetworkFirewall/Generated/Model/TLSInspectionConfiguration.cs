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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The object that defines a TLS inspection configuration. This, along with <a>TLSInspectionConfigurationResponse</a>,
    /// define the TLS inspection configuration. You can retrieve all objects for a TLS inspection
    /// configuration by calling <a>DescribeTLSInspectionConfiguration</a>. 
    /// 
    ///  
    /// <para>
    /// Network Firewall uses a TLS inspection configuration to decrypt traffic. Network Firewall
    /// re-encrypts the traffic before sending it to its destination.
    /// </para>
    ///  
    /// <para>
    /// To use a TLS inspection configuration, you add it to a Network Firewall firewall policy,
    /// then you apply the firewall policy to a firewall. Network Firewall acts as a proxy
    /// service to decrypt and inspect inbound traffic. You can reference a TLS inspection
    /// configuration from more than one firewall policy, and you can use a firewall policy
    /// in more than one firewall. For more information about using TLS inspection configurations,
    /// see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection.html">Decrypting
    /// SSL/TLS traffic with TLS inspection configurations</a> in the <i>Network Firewall
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class TLSInspectionConfiguration
    {
        private List<ServerCertificateConfiguration> _serverCertificateConfigurations = new List<ServerCertificateConfiguration>();

        /// <summary>
        /// Gets and sets the property ServerCertificateConfigurations. 
        /// <para>
        /// Lists the server certificate configurations that are associated with the TLS configuration.
        /// </para>
        /// </summary>
        public List<ServerCertificateConfiguration> ServerCertificateConfigurations
        {
            get { return this._serverCertificateConfigurations; }
            set { this._serverCertificateConfigurations = value; }
        }

        // Check to see if ServerCertificateConfigurations property is set
        internal bool IsSetServerCertificateConfigurations()
        {
            return this._serverCertificateConfigurations != null && this._serverCertificateConfigurations.Count > 0; 
        }

    }
}