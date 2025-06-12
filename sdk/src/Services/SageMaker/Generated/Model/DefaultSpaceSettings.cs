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
    /// The default settings for shared spaces that users create in the domain.
    /// 
    ///  
    /// <para>
    /// SageMaker applies these settings only to shared spaces. It doesn't apply them to private
    /// spaces.
    /// </para>
    /// </summary>
    public partial class DefaultSpaceSettings
    {
        private List<CustomFileSystemConfig> _customFileSystemConfigs = AWSConfigs.InitializeCollections ? new List<CustomFileSystemConfig>() : null;
        private CustomPosixUserConfig _customPosixUserConfig;
        private string _executionRole;
        private JupyterLabAppSettings _jupyterLabAppSettings;
        private JupyterServerAppSettings _jupyterServerAppSettings;
        private KernelGatewayAppSettings _kernelGatewayAppSettings;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DefaultSpaceStorageSettings _spaceStorageSettings;

        /// <summary>
        /// Gets and sets the property CustomFileSystemConfigs. 
        /// <para>
        /// The settings for assigning a custom file system to a domain. Permitted users can access
        /// this file system in Amazon SageMaker AI Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<CustomFileSystemConfig> CustomFileSystemConfigs
        {
            get { return this._customFileSystemConfigs; }
            set { this._customFileSystemConfigs = value; }
        }

        // Check to see if CustomFileSystemConfigs property is set
        internal bool IsSetCustomFileSystemConfigs()
        {
            return this._customFileSystemConfigs != null && (this._customFileSystemConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomPosixUserConfig.
        /// </summary>
        public CustomPosixUserConfig CustomPosixUserConfig
        {
            get { return this._customPosixUserConfig; }
            set { this._customPosixUserConfig = value; }
        }

        // Check to see if CustomPosixUserConfig property is set
        internal bool IsSetCustomPosixUserConfig()
        {
            return this._customPosixUserConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the execution role for the space.
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
        /// Gets and sets the property JupyterLabAppSettings.
        /// </summary>
        public JupyterLabAppSettings JupyterLabAppSettings
        {
            get { return this._jupyterLabAppSettings; }
            set { this._jupyterLabAppSettings = value; }
        }

        // Check to see if JupyterLabAppSettings property is set
        internal bool IsSetJupyterLabAppSettings()
        {
            return this._jupyterLabAppSettings != null;
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
        /// The security group IDs for the Amazon VPC that the space uses for communication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpaceStorageSettings.
        /// </summary>
        public DefaultSpaceStorageSettings SpaceStorageSettings
        {
            get { return this._spaceStorageSettings; }
            set { this._spaceStorageSettings = value; }
        }

        // Check to see if SpaceStorageSettings property is set
        internal bool IsSetSpaceStorageSettings()
        {
            return this._spaceStorageSettings != null;
        }

    }
}