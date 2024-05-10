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
        private DockerSettings _dockerSettings;
        private ExecutionRoleIdentityConfig _executionRoleIdentityConfig;
        private RStudioServerProDomainSettings _rStudioServerProDomainSettings;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// The configuration for attaching a SageMaker user profile name to the execution role
        /// as a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">sts:SourceIdentity
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
        /// </summary>
        [AWSProperty(Max=3)]
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

    }
}