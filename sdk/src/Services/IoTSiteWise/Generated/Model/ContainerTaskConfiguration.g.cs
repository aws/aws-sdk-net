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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Configuration for a container task, including the container image, IAM role, and compute
    /// settings.
    /// </summary>
    public partial class ContainerTaskConfiguration
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to execute in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> Command { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null && (this.Command.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcrUri. 
        /// <para>
        /// The Amazon ECR image URI for the task container.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string EcrUri { get; set; }

        /// <summary>
        /// Checks to see if the EcrUri property is set.
        /// </summary>
        internal bool IsSetEcrUri() => this.EcrUri != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables passed to the container at runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 20)]
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EphemeralStorageConfiguration. 
        /// <para>
        /// Ephemeral storage configuration for the container task.
        /// </para>
        /// </summary>
        public EphemeralStorageConfiguration EphemeralStorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EphemeralStorageConfiguration property is set.
        /// </summary>
        internal bool IsSetEphemeralStorageConfiguration() => this.EphemeralStorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Mounts. 
        /// <para>
        /// Mounts attached to the container filesystem. Each mount exposes an external data source
        /// as a local directory inside the container. The service assigns each mount a container
        /// path based on the mount name. The container reads files through that path as if the
        /// data were on the local filesystem.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Mount> Mounts { get; set; } = AWSConfigs.InitializeCollections ? new List<Mount>() : null;

        /// <summary>
        /// Checks to see if the Mounts property is set.
        /// </summary>
        internal bool IsSetMounts() => this.Mounts != null && (this.Mounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessingType. 
        /// <para>
        /// The processing type for compute resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingType ProcessingType { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingType property is set.
        /// </summary>
        internal bool IsSetProcessingType() => this.ProcessingType != null;

        /// <summary>
        /// Gets and sets the property ProcessingUnit. 
        /// <para>
        /// The processing unit allocation that determines the vCPU, memory, and GPU resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingUnit ProcessingUnit { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingUnit property is set.
        /// </summary>
        internal bool IsSetProcessingUnit() => this.ProcessingUnit != null;

        /// <summary>
        /// Gets and sets the property TaskExecutionRole. 
        /// <para>
        /// The ARN of the IAM role that grants the containerized workload permissions to access
        /// AWS resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 20, Max = 2048)]
        public string TaskExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the TaskExecutionRole property is set.
        /// </summary>
        internal bool IsSetTaskExecutionRole() => this.TaskExecutionRole != null;

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The timeout in seconds for task execution. Default: 3600 (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 86400)]
        public long? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;
    }
}
