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
        /// <summary>
        /// Gets and sets the property CustomFileSystemConfigs. 
        /// <para>
        /// The settings for assigning a custom file system to a domain. Permitted users can access
        /// this file system in Amazon SageMaker AI Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<CustomFileSystemConfig> CustomFileSystemConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomFileSystemConfig>() : null;

        /// <summary>
        /// Checks to see if the CustomFileSystemConfigs property is set.
        /// </summary>
        internal bool IsSetCustomFileSystemConfigs() => this.CustomFileSystemConfigs != null && (this.CustomFileSystemConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomPosixUserConfig.
        /// </summary>
        public CustomPosixUserConfig CustomPosixUserConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomPosixUserConfig property is set.
        /// </summary>
        internal bool IsSetCustomPosixUserConfig() => this.CustomPosixUserConfig != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the execution role for the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property JupyterLabAppSettings.
        /// </summary>
        public JupyterLabAppSettings JupyterLabAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the JupyterLabAppSettings property is set.
        /// </summary>
        internal bool IsSetJupyterLabAppSettings() => this.JupyterLabAppSettings != null;

        /// <summary>
        /// Gets and sets the property JupyterServerAppSettings.
        /// </summary>
        public JupyterServerAppSettings JupyterServerAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the JupyterServerAppSettings property is set.
        /// </summary>
        internal bool IsSetJupyterServerAppSettings() => this.JupyterServerAppSettings != null;

        /// <summary>
        /// Gets and sets the property KernelGatewayAppSettings.
        /// </summary>
        public KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the KernelGatewayAppSettings property is set.
        /// </summary>
        internal bool IsSetKernelGatewayAppSettings() => this.KernelGatewayAppSettings != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security group IDs for the Amazon VPC that the space uses for communication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpaceStorageSettings.
        /// </summary>
        public DefaultSpaceStorageSettings SpaceStorageSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpaceStorageSettings property is set.
        /// </summary>
        internal bool IsSetSpaceStorageSettings() => this.SpaceStorageSettings != null;
    }
}
