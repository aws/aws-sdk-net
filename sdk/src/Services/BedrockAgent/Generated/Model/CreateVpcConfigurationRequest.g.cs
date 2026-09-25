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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcConfiguration operation. Creates a VPC
    /// configuration that lets a knowledge base connect to a resource in your private VPC.
    /// This operation is asynchronous: it returns a <c>vpcConfigurationId</c> with status
    /// <c>CREATING</c>. Poll <c>GetVpcConfiguration</c> until the status becomes <c>CREATED</c>
    /// or <c>CREATE_FAILED</c>.
    /// </summary>
    public partial class CreateVpcConfigurationRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the service ignores the request
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the VPC configuration. If you don't specify a description,
        /// the VPC configuration has no description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HostHeader. 
        /// <para>
        /// An optional HTTP <c>Host</c> header value to send when invoking the resource. Set
        /// this only if your resource (or an upstream router or ingress) routes by the <c>Host</c>
        /// header and that host differs from the target. This setting is independent of <c>tlsServerName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string HostHeader { get; set; }

        /// <summary>
        /// Checks to see if the HostHeader property is set.
        /// </summary>
        internal bool IsSetHostHeader() => this.HostHeader != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to associate this VPC configuration with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional human-readable name for the VPC configuration. If you don't specify a
        /// name, the VPC configuration has no name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which to reach the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used to connect to the resource. Specify <c>HTTP</c> for plaintext or
        /// <c>HTTPS</c> for TLS. When you specify <c>HTTPS</c>, you must also provide <c>tlsServerName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VpcProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ResolutionMode. 
        /// <para>
        /// Controls how a domain-name <c>resourceTarget</c> is resolved. This applies only when
        /// the target is a domain name; it has no effect for IP-address targets, which have no
        /// name to resolve. In all cases the resolved address must be reachable from inside your
        /// VPC. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_VPC</c> (default, recommended) – The target domain name is resolved privately,
        /// using the DNS resolvers of the VPC, such as private Route 53 hosted zones or on-premises
        /// DNS reachable from the VPC. Use this for targets that are private to your VPC, such
        /// as internal load balancers, private hosted-zone names, or on-premises hosts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC</c> – The target domain name is resolved against public DNS resolvers.
        /// Select this only when the target's domain name must be resolved through public DNS
        /// and the resulting address is still reachable from the VPC, an uncommon split-horizon
        /// configuration. If you are unsure, use <c>IN_VPC</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public VpcResolutionMode ResolutionMode { get; set; }

        /// <summary>
        /// Checks to see if the ResolutionMode property is set.
        /// </summary>
        internal bool IsSetResolutionMode() => this.ResolutionMode != null;

        /// <summary>
        /// Gets and sets the property ResourceTarget. 
        /// <para>
        /// The private IPv4 address or DNS name of the resource you want the knowledge base to
        /// reach. The target must be privately reachable from inside your VPC, such as an internal
        /// load balancer or a private IP. The following are not supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Internet-facing endpoints
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Loopback addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Link-local addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Wildcard addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multicast addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IPv6 literals
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ResourceTarget { get; set; }

        /// <summary>
        /// Checks to see if the ResourceTarget property is set.
        /// </summary>
        internal bool IsSetResourceTarget() => this.ResourceTarget != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The subnets, in the VPC identified by <c>vpcId</c>, that the knowledge base uses to
        /// connect to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TlsServerName. 
        /// <para>
        /// The expected TLS server name. The service matches this value against the Subject Alternative
        /// Names on your resource's TLS certificate during invocation. This field is required
        /// when <c>protocol</c> is <c>HTTPS</c>. Set it to a hostname on your certificate, such
        /// as <c>app.internal.example.com</c>. You can use a single leftmost wildcard, such as
        /// <c>*.example.com</c>. The value must be a hostname without a port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string TlsServerName { get; set; }

        /// <summary>
        /// Checks to see if the TlsServerName property is set.
        /// </summary>
        internal bool IsSetTlsServerName() => this.TlsServerName != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the knowledge base connects through to reach the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
