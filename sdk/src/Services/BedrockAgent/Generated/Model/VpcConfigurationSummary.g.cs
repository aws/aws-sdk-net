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
    /// A summary of a VPC configuration returned by <c>ListVpcConfigurations</c>.
    /// </summary>
    public partial class VpcConfigurationSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the VPC configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the VPC configuration, if provided.
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
        /// The HTTP <c>Host</c> header value sent when invoking the resource, if configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string HostHeader { get; set; }

        /// <summary>
        /// Checks to see if the HostHeader property is set.
        /// </summary>
        internal bool IsSetHostHeader() => this.HostHeader != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the VPC configuration, if provided.
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
        /// The port on which the resource is reached.
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
        /// The protocol used to connect to the resource.
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
        /// Specifies how the resource target is resolved.
        /// </para>
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
        /// The private IPv4 address or DNS name of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ResourceTarget { get; set; }

        /// <summary>
        /// Checks to see if the ResourceTarget property is set.
        /// </summary>
        internal bool IsSetResourceTarget() => this.ResourceTarget != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle status of the VPC configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VpcConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional detail about the current status, such as the cause of a failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TlsServerName. 
        /// <para>
        /// The expected TLS server name that the service matches against the Subject Alternative
        /// Names on the resource's TLS certificate. Present when <c>protocol</c> is <c>HTTPS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string TlsServerName { get; set; }

        /// <summary>
        /// Checks to see if the TlsServerName property is set.
        /// </summary>
        internal bool IsSetTlsServerName() => this.TlsServerName != null;

        /// <summary>
        /// Gets and sets the property VpcConfigurationId. 
        /// <para>
        /// The unique identifier of the VPC configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string VpcConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfigurationId property is set.
        /// </summary>
        internal bool IsSetVpcConfigurationId() => this.VpcConfigurationId != null;

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
