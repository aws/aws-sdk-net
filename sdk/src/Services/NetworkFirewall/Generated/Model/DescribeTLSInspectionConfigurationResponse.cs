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
    /// This is the response object from the DescribeTLSInspectionConfiguration operation.
    /// </summary>
    public partial class DescribeTLSInspectionConfigurationResponse : AmazonWebServiceResponse
    {
        private TLSInspectionConfiguration _tlsInspectionConfiguration;
        private TLSInspectionConfigurationResponse _tlsInspectionConfigurationResponse;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfiguration. 
        /// <para>
        /// The object that defines a TLS inspection configuration. This, along with <a>TLSInspectionConfigurationResponse</a>,
        /// define the TLS inspection configuration. You can retrieve all objects for a TLS inspection
        /// configuration by calling <a>DescribeTLSInspectionConfiguration</a>. 
        /// </para>
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
        public TLSInspectionConfiguration TLSInspectionConfiguration
        {
            get { return this._tlsInspectionConfiguration; }
            set { this._tlsInspectionConfiguration = value; }
        }

        // Check to see if TLSInspectionConfiguration property is set
        internal bool IsSetTLSInspectionConfiguration()
        {
            return this._tlsInspectionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationResponse. 
        /// <para>
        /// The high-level properties of a TLS inspection configuration. This, along with the
        /// <a>TLSInspectionConfiguration</a>, define the TLS inspection configuration. You can
        /// retrieve all objects for a TLS inspection configuration by calling <a>DescribeTLSInspectionConfiguration</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TLSInspectionConfigurationResponse TLSInspectionConfigurationResponse
        {
            get { return this._tlsInspectionConfigurationResponse; }
            set { this._tlsInspectionConfigurationResponse = value; }
        }

        // Check to see if TLSInspectionConfigurationResponse property is set
        internal bool IsSetTLSInspectionConfigurationResponse()
        {
            return this._tlsInspectionConfigurationResponse != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the TLS inspection configuration. The token marks the state of the TLS
        /// inspection configuration resource at the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the TLS inspection configuration, you provide the token in your
        /// request. Network Firewall uses the token to ensure that the TLS inspection configuration
        /// hasn't changed since you last retrieved it. If it has changed, the operation fails
        /// with an <code>InvalidTokenException</code>. If this happens, retrieve the TLS inspection
        /// configuration again to get a current copy of it with a current token. Reapply your
        /// changes as needed, then try the operation again using the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}