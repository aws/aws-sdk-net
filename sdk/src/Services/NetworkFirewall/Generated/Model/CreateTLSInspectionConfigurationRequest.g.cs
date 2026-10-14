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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateTLSInspectionConfiguration operation. Creates
    /// an Network Firewall TLS inspection configuration. Network Firewall uses TLS inspection
    /// configurations to decrypt your firewall's inbound and outbound SSL/TLS traffic. After
    /// decryption, Network Firewall inspects the traffic according to your firewall policy's
    /// stateful rules, and then re-encrypts it before sending it to its destination. You
    /// can enable inspection of your firewall's inbound traffic, outbound traffic, or both.
    /// To use TLS inspection with your firewall, you must first import or provision certificates
    /// using ACM, create a TLS inspection configuration, add that configuration to a new
    /// firewall policy, and then associate that policy with your firewall. <para> To update
    /// the settings for a TLS inspection configuration, use <a>UpdateTLSInspectionConfiguration</a>.
    /// </para> <para> To manage a TLS inspection configuration's tags, use the standard Amazon
    /// Web Services resource tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>,
    /// and <a>UntagResource</a>. </para> <para> To retrieve information about TLS inspection
    /// configurations, use <a>ListTLSInspectionConfigurations</a> and <a>DescribeTLSInspectionConfiguration</a>.
    /// </para> <para> For more information about TLS inspection configurations, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection.html">Inspecting
    /// SSL/TLS traffic with TLS inspection configurations</a> in the <i>Network Firewall
    /// Developer Guide</i>. </para>
    /// </summary>
    public partial class CreateTLSInspectionConfigurationRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the TLS inspection configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

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
        /// To use a TLS inspection configuration, you add it to a new Network Firewall firewall
        /// policy, then you apply the firewall policy to a firewall. Network Firewall acts as
        /// a proxy service to decrypt and inspect the traffic traveling through your firewalls.
        /// You can reference a TLS inspection configuration from more than one firewall policy,
        /// and you can use a firewall policy in more than one firewall. For more information
        /// about using TLS inspection configurations, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection.html">Inspecting
        /// SSL/TLS traffic with TLS inspection configurations</a> in the <i>Network Firewall
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TLSInspectionConfiguration TLSInspectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfiguration property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfiguration() => this.TLSInspectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationName. 
        /// <para>
        /// The descriptive name of the TLS inspection configuration. You can't change the name
        /// of a TLS inspection configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TLSInspectionConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationName property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationName() => this.TLSInspectionConfigurationName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
