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
    /// Container for the parameters to the UpdateMemory operation.
    /// Update an Amazon Bedrock AgentCore Memory resource memory.
    /// </summary>
    public partial class UpdateMemoryRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _description;
        private int? _eventExpiryDuration;
        private string _memoryExecutionRoleArn;
        private string _memoryId;
        private ModifyMemoryStrategies _memoryStrategies;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client token is used for keeping track of idempotent requests. It can contain a
        /// session id which can be around 250 chars, combined with a unique AWS identifier.
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
        /// The updated description of the AgentCore Memory resource.
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
        /// Gets and sets the property EventExpiryDuration. 
        /// <para>
        /// The number of days after which memory events will expire, between 7 and 365 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=365)]
        public int? EventExpiryDuration
        {
            get { return this._eventExpiryDuration; }
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
        /// The ARN of the IAM role that provides permissions for the AgentCore Memory resource.
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
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The unique identifier of the memory to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12)]
        public string MemoryId
        {
            get { return this._memoryId; }
            set { this._memoryId = value; }
        }

        // Check to see if MemoryId property is set
        internal bool IsSetMemoryId()
        {
            return this._memoryId != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryStrategies. 
        /// <para>
        /// The memory strategies to add, modify, or delete.
        /// </para>
        /// </summary>
        public ModifyMemoryStrategies MemoryStrategies
        {
            get { return this._memoryStrategies; }
            set { this._memoryStrategies = value; }
        }

        // Check to see if MemoryStrategies property is set
        internal bool IsSetMemoryStrategies()
        {
            return this._memoryStrategies != null;
        }

    }
}