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
    /// Container for the parameters to the UpdateMemory operation. Update an Amazon Bedrock
    /// AgentCore Memory resource memory.
    /// </summary>
    public partial class UpdateMemoryRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property AddIndexedKeys. 
        /// <para>
        /// Additional metadata keys to index. Previously indexed keys cannot be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<IndexedKey> AddIndexedKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<IndexedKey>() : null;

        /// <summary>
        /// Checks to see if the AddIndexedKeys property is set.
        /// </summary>
        internal bool IsSetAddIndexedKeys() => this.AddIndexedKeys != null && (this.AddIndexedKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client token is used for keeping track of idempotent requests. It can contain a
        /// session id which can be around 250 chars, combined with a unique Amazon Web Services
        /// identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the AgentCore Memory resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventExpiryDuration. 
        /// <para>
        /// The number of days after which memory events will expire, between 7 and 365 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 365)]
        public int? EventExpiryDuration { get; set; }

        /// <summary>
        /// Checks to see if the EventExpiryDuration property is set.
        /// </summary>
        internal bool IsSetEventExpiryDuration() => this.EventExpiryDuration.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that provides permissions for the AgentCore Memory resource.
        /// </para>
        /// </summary>
        public string MemoryExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MemoryExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetMemoryExecutionRoleArn() => this.MemoryExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The unique identifier of the memory to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property MemoryStrategies. 
        /// <para>
        /// The memory strategies to add, modify, or delete.
        /// </para>
        /// </summary>
        public ModifyMemoryStrategies MemoryStrategies { get; set; }

        /// <summary>
        /// Checks to see if the MemoryStrategies property is set.
        /// </summary>
        internal bool IsSetMemoryStrategies() => this.MemoryStrategies != null;

        /// <summary>
        /// Gets and sets the property NamespaceKeys. 
        /// <para>
        /// The namespace variable key definitions with validation rules for this memory. This
        /// value fully replaces the existing set — any key you omit is removed. Any referenced
        /// <c>namespaceKey</c> omission will throw ValidationException.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<NamespaceKeyEntry> NamespaceKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<NamespaceKeyEntry>() : null;

        /// <summary>
        /// Checks to see if the NamespaceKeys property is set.
        /// </summary>
        internal bool IsSetNamespaceKeys() => this.NamespaceKeys != null && (this.NamespaceKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StreamDeliveryResources. 
        /// <para>
        /// Configuration for streaming memory record data to external resources.
        /// </para>
        /// </summary>
        public StreamDeliveryResources StreamDeliveryResources { get; set; }

        /// <summary>
        /// Checks to see if the StreamDeliveryResources property is set.
        /// </summary>
        internal bool IsSetStreamDeliveryResources() => this.StreamDeliveryResources != null;
    }
}
