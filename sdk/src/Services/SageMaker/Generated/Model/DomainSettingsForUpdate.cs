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
    /// A collection of <c>Domain</c> configuration settings to update.
    /// </summary>
    public partial class DomainSettingsForUpdate
    {
        private DockerSettings _dockerSettings;
        private ExecutionRoleIdentityConfig _executionRoleIdentityConfig;
        private RStudioServerProDomainSettingsForUpdate _rStudioServerProDomainSettingsForUpdate;
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
        /// key</a>. This configuration can only be modified if there are no apps in the <c>InService</c>
        /// or <c>Pending</c> state.
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
        /// Gets and sets the property RStudioServerProDomainSettingsForUpdate. 
        /// <para>
        /// A collection of <c>RStudioServerPro</c> Domain-level app settings to update. A single
        /// <c>RStudioServerPro</c> application is created for a domain.
        /// </para>
        /// </summary>
        public RStudioServerProDomainSettingsForUpdate RStudioServerProDomainSettingsForUpdate
        {
            get { return this._rStudioServerProDomainSettingsForUpdate; }
            set { this._rStudioServerProDomainSettingsForUpdate = value; }
        }

        // Check to see if RStudioServerProDomainSettingsForUpdate property is set
        internal bool IsSetRStudioServerProDomainSettingsForUpdate()
        {
            return this._rStudioServerProDomainSettingsForUpdate != null;
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