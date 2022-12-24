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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of <code>Domain</code> configuration settings to update.
    /// </summary>
    public partial class DomainSettingsForUpdate
    {
        private ExecutionRoleIdentityConfig _executionRoleIdentityConfig;
        private RStudioServerProDomainSettingsForUpdate _rStudioServerProDomainSettingsForUpdate;
        private List<string> _securityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ExecutionRoleIdentityConfig. 
        /// <para>
        /// The configuration for attaching a SageMaker user profile name to the execution role
        /// as a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">sts:SourceIdentity
        /// key</a>. This configuration can only be modified if there are no apps in the <code>InService</code>
        /// or <code>Pending</code> state.
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
        /// A collection of <code>RStudioServerPro</code> Domain-level app settings to update.
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
        /// The security groups for the Amazon Virtual Private Cloud that the <code>Domain</code>
        /// uses for communication between Domain-level apps and user apps.
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
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

    }
}