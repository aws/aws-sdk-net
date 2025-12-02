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
    /// Container for the parameters to the CreateMemory operation.
    /// Creates a new Amazon Bedrock AgentCore Memory resource.
    /// </summary>
    public partial class CreateMemoryRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _description;
        private string _encryptionKeyArn;
        private int? _eventExpiryDuration;
        private string _memoryExecutionRoleArn;
        private List<MemoryStrategyInput> _memoryStrategies = AWSConfigs.InitializeCollections ? new List<MemoryStrategyInput>() : null;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the memory data.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventExpiryDuration. 
        /// <para>
        /// The duration after which memory events expire. Specified as an ISO 8601 duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=365)]
        public int EventExpiryDuration
        {
            get { return this._eventExpiryDuration.GetValueOrDefault(); }
            set { this._eventExpiryDuration = value; }
        }

        // Check to see if EventExpiryDuration property is set
        internal bool IsSetEventExpiryDuration()
        {
            return this._eventExpiryDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the memory
        /// to access Amazon Web Services services.
        /// </para>
        /// </summary>
        public string MemoryExecutionRoleArn
        {
            get { return this._memoryExecutionRoleArn; }
            set { this._memoryExecutionRoleArn = value; }
        }

        // Check to see if MemoryExecutionRoleArn property is set
        internal bool IsSetMemoryExecutionRoleArn()
        {
            return this._memoryExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryStrategies. 
        /// <para>
        /// The memory strategies to use for this memory. Strategies define how information is
        /// extracted, processed, and consolidated.
        /// </para>
        /// </summary>
        public List<MemoryStrategyInput> MemoryStrategies
        {
            get { return this._memoryStrategies; }
            set { this._memoryStrategies = value; }
        }

        // Check to see if MemoryStrategies property is set
        internal bool IsSetMemoryStrategies()
        {
            return this._memoryStrategies != null && (this._memoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the memory. The name must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to an AgentCore Memory. Tags enable you to
        /// categorize your resources in different ways, for example, by purpose, owner, or environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}