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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings that apply to the <c>SageMaker Domain</c>. These settings
    /// are specified through the <c>CreateDomain</c> API call.
    /// </summary>
    public partial class DomainSettings
    {
        /// <summary>
        /// Gets and sets the property AmazonQSettings. 
        /// <para>
        /// A collection of settings that configure the Amazon Q experience within the domain.
        /// The <c>AuthMode</c> that you use to create the domain must be <c>SSO</c>.
        /// </para>
        /// </summary>
        public AmazonQSettings AmazonQSettings { get; set; }

        /// <summary>
        /// Checks to see if the AmazonQSettings property is set.
        /// </summary>
        internal bool IsSetAmazonQSettings() => this.AmazonQSettings != null;

        /// <summary>
        /// Gets and sets the property DockerSettings. 
        /// <para>
        /// A collection of settings that configure the domain's Docker interaction.
        /// </para>
        /// </summary>
        public DockerSettings DockerSettings { get; set; }

        /// <summary>
        /// Checks to see if the DockerSettings property is set.
        /// </summary>
        internal bool IsSetDockerSettings() => this.DockerSettings != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleIdentityConfig. 
        /// <para>
        /// The configuration for attaching a SageMaker AI user profile name to the execution
        /// role as a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">sts:SourceIdentity
        /// key</a>.
        /// </para>
        /// </summary>
        public ExecutionRoleIdentityConfig ExecutionRoleIdentityConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleIdentityConfig property is set.
        /// </summary>
        internal bool IsSetExecutionRoleIdentityConfig() => this.ExecutionRoleIdentityConfig != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the domain. Specify <c>ipv4</c> for IPv4-only connectivity
        /// or <c>dualstack</c> for both IPv4 and IPv6 connectivity. When you specify <c>dualstack</c>,
        /// the subnet must support IPv6 CIDR blocks. If not specified, defaults to <c>ipv4</c>.
        /// </para>
        /// </summary>
        public IPAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property RStudioServerProDomainSettings. 
        /// <para>
        /// A collection of settings that configure the <c>RStudioServerPro</c> Domain-level app.
        /// </para>
        /// </summary>
        public RStudioServerProDomainSettings RStudioServerProDomainSettings { get; set; }

        /// <summary>
        /// Checks to see if the RStudioServerProDomainSettings property is set.
        /// </summary>
        internal bool IsSetRStudioServerProDomainSettings() => this.RStudioServerProDomainSettings != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security groups for the Amazon Virtual Private Cloud that the <c>Domain</c> uses
        /// for communication between Domain-level apps and user apps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrustedIdentityPropagationSettings. 
        /// <para>
        /// The Trusted Identity Propagation (TIP) settings for the SageMaker domain. These settings
        /// determine how user identities from IAM Identity Center are propagated through the
        /// domain to TIP enabled Amazon Web Services services.
        /// </para>
        /// </summary>
        public TrustedIdentityPropagationSettings TrustedIdentityPropagationSettings { get; set; }

        /// <summary>
        /// Checks to see if the TrustedIdentityPropagationSettings property is set.
        /// </summary>
        internal bool IsSetTrustedIdentityPropagationSettings() => this.TrustedIdentityPropagationSettings != null;

        /// <summary>
        /// Gets and sets the property UnifiedStudioSettings. 
        /// <para>
        /// The settings that apply to an SageMaker AI domain when you use it in Amazon SageMaker
        /// Unified Studio.
        /// </para>
        /// </summary>
        public UnifiedStudioSettings UnifiedStudioSettings { get; set; }

        /// <summary>
        /// Checks to see if the UnifiedStudioSettings property is set.
        /// </summary>
        internal bool IsSetUnifiedStudioSettings() => this.UnifiedStudioSettings != null;
    }
}
