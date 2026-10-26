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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The AgentCore Runtime environment for a harness.
    /// </summary>
    public partial class HarnessAgentCoreRuntimeEnvironment
    {
        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The ARN of the underlying AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeArn property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeArn() => this.AgentRuntimeArn != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The ID of the underlying AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeId { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeId property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeId() => this.AgentRuntimeId != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeName. 
        /// <para>
        /// The name of the underlying AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeName { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeName property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeName() => this.AgentRuntimeName != null;

        /// <summary>
        /// Gets and sets the property FilesystemConfigurations. 
        /// <para>
        /// The filesystem configurations for the runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<FilesystemConfiguration> FilesystemConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<FilesystemConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FilesystemConfigurations property is set.
        /// </summary>
        internal bool IsSetFilesystemConfigurations() => this.FilesystemConfigurations != null && (this.FilesystemConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LifecycleConfiguration.
        /// </summary>
        [AWSProperty(Required = true)]
        public LifecycleConfiguration LifecycleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleConfiguration property is set.
        /// </summary>
        internal bool IsSetLifecycleConfiguration() => this.LifecycleConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration.
        /// </summary>
        [AWSProperty(Required = true)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;
    }
}
