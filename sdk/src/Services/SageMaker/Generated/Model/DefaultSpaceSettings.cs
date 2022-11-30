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
    /// A collection of settings that apply to spaces created in the Domain.
    /// </summary>
    public partial class DefaultSpaceSettings
    {
        private string _executionRole;
        private JupyterServerAppSettings _jupyterServerAppSettings;
        private KernelGatewayAppSettings _kernelGatewayAppSettings;
        private List<string> _securityGroups = new List<string>();

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role for the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property JupyterServerAppSettings.
        /// </summary>
        public JupyterServerAppSettings JupyterServerAppSettings
        {
            get { return this._jupyterServerAppSettings; }
            set { this._jupyterServerAppSettings = value; }
        }

        // Check to see if JupyterServerAppSettings property is set
        internal bool IsSetJupyterServerAppSettings()
        {
            return this._jupyterServerAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KernelGatewayAppSettings.
        /// </summary>
        public KernelGatewayAppSettings KernelGatewayAppSettings
        {
            get { return this._kernelGatewayAppSettings; }
            set { this._kernelGatewayAppSettings = value; }
        }

        // Check to see if KernelGatewayAppSettings property is set
        internal bool IsSetKernelGatewayAppSettings()
        {
            return this._kernelGatewayAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups for the Amazon Virtual Private Cloud that the space uses for communication.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

    }
}