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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private AmazonQSettings _amazonQSettings;
        private DockerSettings _dockerSettings;
        private ExecutionRoleIdentityConfig _executionRoleIdentityConfig;
        private IPAddressType _ipAddressType;
        private RStudioServerProDomainSettings _rStudioServerProDomainSettings;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TrustedIdentityPropagationSettings _trustedIdentityPropagationSettings;
        private UnifiedStudioSettings _unifiedStudioSettings;

        /// <summary>
        /// Gets and sets the property AmazonQSettings. 
        /// <para>
        /// A collection of settings that configure the Amazon Q experience within the domain.
        /// The <c>AuthMode</c> that you use to create the domain must be <c>SSO</c>.
        /// </para>
        /// </summary>
        public AmazonQSettings AmazonQSettings
        {
            get { return this._amazonQSettings; }
            set { this._amazonQSettings = value; }
        }

        // Check to see if AmazonQSettings property is set
        internal bool IsSetAmazonQSettings()
        {
            return this._amazonQSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DockerSettings. 
        /// <para>
        /// A collection of settings that configure the domain's Docker interaction.
        /// </para>
        /// </summary>
        public DockerSettings DockerSettings
        {
            get { return this._dockerSettings; }
            set { this._dockerSettings = value; }
        }

        // Check to see if DockerSettings property is set
        internal bool IsSetDockerSettings()
        {
            return this._dockerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleIdentityConfig. 
        /// <para>
        /// The configuration for attaching a SageMaker AI user profile name to the execution
        /// role as a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">sts:SourceIdentity
        /// key</a>.
        /// </para>
        /// </summary>
        public ExecutionRoleIdentityConfig ExecutionRoleIdentityConfig
        {
            get { return this._executionRoleIdentityConfig; }
            set { this._executionRoleIdentityConfig = value; }
        }

        // Check to see if ExecutionRoleIdentityConfig property is set
        internal bool IsSetExecutionRoleIdentityConfig()
        {
            return this._executionRoleIdentityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the domain. Specify <c>ipv4</c> for IPv4-only connectivity
        /// or <c>dualstack</c> for both IPv4 and IPv6 connectivity. When you specify <c>dualstack</c>,
        /// the subnet must support IPv6 CIDR blocks. If not specified, defaults to <c>ipv4</c>.
        /// </para>
        /// </summary>
        public IPAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property RStudioServerProDomainSettings. 
        /// <para>
        /// A collection of settings that configure the <c>RStudioServerPro</c> Domain-level app.
        /// </para>
        /// </summary>
        public RStudioServerProDomainSettings RStudioServerProDomainSettings
        {
            get { return this._rStudioServerProDomainSettings; }
            set { this._rStudioServerProDomainSettings = value; }
        }

        // Check to see if RStudioServerProDomainSettings property is set
        internal bool IsSetRStudioServerProDomainSettings()
        {
            return this._rStudioServerProDomainSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security groups for the Amazon Virtual Private Cloud that the <c>Domain</c> uses
        /// for communication between Domain-level apps and user apps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrustedIdentityPropagationSettings. 
        /// <para>
        /// The Trusted Identity Propagation (TIP) settings for the SageMaker domain. These settings
        /// determine how user identities from IAM Identity Center are propagated through the
        /// domain to TIP enabled Amazon Web Services services.
        /// </para>
        /// </summary>
        public TrustedIdentityPropagationSettings TrustedIdentityPropagationSettings
        {
            get { return this._trustedIdentityPropagationSettings; }
            set { this._trustedIdentityPropagationSettings = value; }
        }

        // Check to see if TrustedIdentityPropagationSettings property is set
        internal bool IsSetTrustedIdentityPropagationSettings()
        {
            return this._trustedIdentityPropagationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property UnifiedStudioSettings. 
        /// <para>
        /// The settings that apply to an SageMaker AI domain when you use it in Amazon SageMaker
        /// Unified Studio.
        /// </para>
        /// </summary>
        public UnifiedStudioSettings UnifiedStudioSettings
        {
            get { return this._unifiedStudioSettings; }
            set { this._unifiedStudioSettings = value; }
        }

        // Check to see if UnifiedStudioSettings property is set
        internal bool IsSetUnifiedStudioSettings()
        {
            return this._unifiedStudioSettings != null;
        }

    }
}