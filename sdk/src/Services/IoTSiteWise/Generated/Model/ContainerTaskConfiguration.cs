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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ecrUri;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ProcessingType _processingType;
        private ProcessingUnit _processingUnit;
        private string _taskExecutionRole;
        private long? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to execute in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EcrUri. 
        /// <para>
        /// The Amazon ECR image URI for the task container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string EcrUri
        {
            get { return this._ecrUri; }
            set { this._ecrUri = value; }
        }

        // Check to see if EcrUri property is set
        internal bool IsSetEcrUri()
        {
            return this._ecrUri != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables passed to the container at runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProcessingType. 
        /// <para>
        /// The processing type for compute resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingType ProcessingType
        {
            get { return this._processingType; }
            set { this._processingType = value; }
        }

        // Check to see if ProcessingType property is set
        internal bool IsSetProcessingType()
        {
            return this._processingType != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingUnit. 
        /// <para>
        /// The processing unit allocation that determines the vCPU, memory, and GPU resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingUnit ProcessingUnit
        {
            get { return this._processingUnit; }
            set { this._processingUnit = value; }
        }

        // Check to see if ProcessingUnit property is set
        internal bool IsSetProcessingUnit()
        {
            return this._processingUnit != null;
        }

        /// <summary>
        /// Gets and sets the property TaskExecutionRole. 
        /// <para>
        /// The ARN of the IAM role that grants the containerized workload permissions to access
        /// AWS resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=20, Max=2048)]
        public string TaskExecutionRole
        {
            get { return this._taskExecutionRole; }
            set { this._taskExecutionRole = value; }
        }

        // Check to see if TaskExecutionRole property is set
        internal bool IsSetTaskExecutionRole()
        {
            return this._taskExecutionRole != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The timeout in seconds for task execution. Default: 3600 (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public long? TimeoutSeconds
        {
            get { return this._timeoutSeconds; }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

    }
}