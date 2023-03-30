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
    /// Container for the parameters to the CreateTLSInspectionConfiguration operation.
    /// Creates an Network Firewall TLS inspection configuration. A TLS inspection configuration
    /// contains the Certificate Manager certificate references that Network Firewall uses
    /// to decrypt and re-encrypt inbound traffic.
    /// 
    ///  
    /// <para>
    /// After you create a TLS inspection configuration, you associate it with a firewall
    /// policy.
    /// </para>
    ///  
    /// <para>
    /// To update the settings for a TLS inspection configuration, use <a>UpdateTLSInspectionConfiguration</a>.
    /// </para>
    ///  
    /// <para>
    /// To manage a TLS inspection configuration's tags, use the standard Amazon Web Services
    /// resource tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
    /// </para>
    ///  
    /// <para>
    /// To retrieve information about TLS inspection configurations, use <a>ListTLSInspectionConfigurations</a>
    /// and <a>DescribeTLSInspectionConfiguration</a>.
    /// </para>
    ///  
    /// <para>
    ///  For more information about TLS inspection configurations, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection.html">Decrypting
    /// SSL/TLS traffic with TLS inspection configurations</a> in the <i>Network Firewall
    /// Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CreateTLSInspectionConfigurationRequest : AmazonNetworkFirewallRequest
    {
        private string _description;
        private EncryptionConfiguration _encryptionConfiguration;
        private List<Tag> _tags = new List<Tag>();
        private TLSInspectionConfiguration _tlsInspectionConfiguration;
        private string _tlsInspectionConfigurationName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the TLS inspection configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TLSInspectionConfigurationName. 
        /// <para>
        /// The descriptive name of the TLS inspection configuration. You can't change the name
        /// of a TLS inspection configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TLSInspectionConfigurationName
        {
            get { return this._tlsInspectionConfigurationName; }
            set { this._tlsInspectionConfigurationName = value; }
        }

        // Check to see if TLSInspectionConfigurationName property is set
        internal bool IsSetTLSInspectionConfigurationName()
        {
            return this._tlsInspectionConfigurationName != null;
        }

    }
}