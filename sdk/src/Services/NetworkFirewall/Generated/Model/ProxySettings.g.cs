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
    /// The proxy settings of a proxy mode firewall: the ports and protocols on which the
    /// firewall's proxy listens for traffic, and optionally your own domain name and certificate.
    /// </summary>
    public partial class ProxySettings
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate that the firewall's HTTPS proxy
        /// listener presents to clients. The certificate must be an Certificate Manager (ACM)
        /// certificate in the same account and Region as the firewall. Its subject alternative
        /// names must cover <c>DomainName</c>, either exactly or with a wildcard that matches
        /// exactly one label. For example, <c>*.example.com</c> covers <c>proxy.example.com</c>.
        /// If you don't specify this, Network Firewall uses a certificate that it manages for
        /// a domain name that it generates.
        /// </para>
        ///  
        /// <para>
        /// You manage and renew the certificate in ACM, and Network Firewall uses renewed certificates
        /// automatically. While the firewall uses the certificate, you can't delete it from ACM.
        /// Your clients must trust the certificate's certificate authority.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>CertificateArn</c>, you must also specify <c>DomainName</c>. You
        /// can set them only when you create the firewall. When you call <c>UpdateProxySettings</c>,
        /// specify the same values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that your clients use to reach the firewall's proxy. The name must
        /// have at least two labels and at most 253 characters. It can't contain a wildcard or
        /// use the <c>proxy-<i>id</i>.nfw.<i>region</i>.amazonaws.com</c> format, and the certificate
        /// in <c>CertificateArn</c> must cover it. If you don't specify this, Network Firewall
        /// generates a domain name.
        /// </para>
        ///  
        /// <para>
        /// Network Firewall creates the Route 53 private hosted zones that resolve this name
        /// to the firewall endpoints, so you don't need to configure DNS. A VPC can have only
        /// one private hosted zone with a given name. If a VPC that the firewall serves already
        /// has one with this name, Network Firewall can't set up the Availability Zones in that
        /// VPC.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>DomainName</c>, you must also specify <c>CertificateArn</c>. You
        /// can set them only when you create the firewall. When you call <c>UpdateProxySettings</c>,
        /// specify the same values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ListenerProperties. 
        /// <para>
        /// The listeners of the firewall's proxy. Specify at least one listener, and at most
        /// one HTTP listener and one HTTPS listener. Each listener needs a port from 1 to 65535,
        /// and the two listeners must use different ports.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify listeners when you create the firewall, the firewall listens
        /// for HTTP on port 3128 and HTTPS on port 8443.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ListenerProperty> ListenerProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<ListenerProperty>() : null;

        /// <summary>
        /// Checks to see if the ListenerProperties property is set.
        /// </summary>
        internal bool IsSetListenerProperties() => this.ListenerProperties != null && (this.ListenerProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
