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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private string _agentRuntimeArn;
        private string _agentRuntimeId;
        private string _agentRuntimeName;
        private List<FilesystemConfiguration> _filesystemConfigurations = AWSConfigs.InitializeCollections ? new List<FilesystemConfiguration>() : null;
        private LifecycleConfiguration _lifecycleConfiguration;
        private NetworkConfiguration _networkConfiguration;

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The ARN of the underlying AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string AgentRuntimeArn
        {
            get { return this._agentRuntimeArn; }
            set { this._agentRuntimeArn = value; }
        }

        // Check to see if AgentRuntimeArn property is set
        internal bool IsSetAgentRuntimeArn()
        {
            return this._agentRuntimeArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The ID of the underlying AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeId
        {
            get { return this._agentRuntimeId; }
            set { this._agentRuntimeId = value; }
        }

        // Check to see if AgentRuntimeId property is set
        internal bool IsSetAgentRuntimeId()
        {
            return this._agentRuntimeId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeName. 
        /// <para>
        /// The name of the underlying AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeName
        {
            get { return this._agentRuntimeName; }
            set { this._agentRuntimeName = value; }
        }

        // Check to see if AgentRuntimeName property is set
        internal bool IsSetAgentRuntimeName()
        {
            return this._agentRuntimeName != null;
        }

        /// <summary>
        /// Gets and sets the property FilesystemConfigurations. 
        /// <para>
        /// The filesystem configurations for the runtime environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<FilesystemConfiguration> FilesystemConfigurations
        {
            get { return this._filesystemConfigurations; }
            set { this._filesystemConfigurations = value; }
        }

        // Check to see if FilesystemConfigurations property is set
        internal bool IsSetFilesystemConfigurations()
        {
            return this._filesystemConfigurations != null && (this._filesystemConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LifecycleConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecycleConfiguration LifecycleConfiguration
        {
            get { return this._lifecycleConfiguration; }
            set { this._lifecycleConfiguration = value; }
        }

        // Check to see if LifecycleConfiguration property is set
        internal bool IsSetLifecycleConfiguration()
        {
            return this._lifecycleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

    }
}