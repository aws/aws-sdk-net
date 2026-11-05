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
    /// Contains information about a memory resource.
    /// </summary>
    public partial class Memory
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the memory was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN of the KMS key used to encrypt the memory.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EventExpiryDuration. 
        /// <para>
        /// The number of days after which memory events will expire.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 365)]
        public int? EventExpiryDuration { get; set; }

        /// <summary>
        /// Checks to see if the EventExpiryDuration property is set.
        /// </summary>
        internal bool IsSetEventExpiryDuration() => this.EventExpiryDuration.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for failure if the memory is in a failed state.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IndexedKeys. 
        /// <para>
        /// The indexed metadata keys for this memory. Only indexed keys can be used in metadata
        /// filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<IndexedKey> IndexedKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<IndexedKey>() : null;

        /// <summary>
        /// Checks to see if the IndexedKeys property is set.
        /// </summary>
        internal bool IsSetIndexedKeys() => this.IndexedKeys != null && (this.IndexedKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedByResourceArn. 
        /// <para>
        /// ARN of the resource managing this memory (e.g. a harness). When set, strategy modifications
        /// and deletion are only allowed through the managing resource.
        /// </para>
        /// </summary>
        public string ManagedByResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedByResourceArn property is set.
        /// </summary>
        internal bool IsSetManagedByResourceArn() => this.ManagedByResourceArn != null;

        /// <summary>
        /// Gets and sets the property MemoryExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that provides permissions for the memory.
        /// </para>
        /// </summary>
        public string MemoryExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MemoryExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetMemoryExecutionRoleArn() => this.MemoryExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NamespaceKeys. 
        /// <para>
        /// The namespace variable key definitions for this memory. Namespace keys define custom
        /// variables used in <c>namespaceTemplates</c> with optional validation rules.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Strategies. 
        /// <para>
        /// The list of memory strategies associated with this memory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemoryStrategy> Strategies { get; set; } = AWSConfigs.InitializeCollections ? new List<MemoryStrategy>() : null;

        /// <summary>
        /// Checks to see if the Strategies property is set.
        /// </summary>
        internal bool IsSetStrategies() => this.Strategies != null && (this.Strategies.Count > 0 || !AWSConfigs.InitializeCollections);

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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the memory was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
