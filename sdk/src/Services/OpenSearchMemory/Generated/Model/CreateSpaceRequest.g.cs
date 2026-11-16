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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSpace operation. Creates a space. A space
    /// is an AWS resource that stores the events you send and the memories extracted from
    /// them, and defines the memory strategies that extract those memories. <para> The operation
    /// returns before provisioning finishes, with <c>status</c> <c>CREATING</c>. Call <c>GetSpace</c>
    /// until the status is <c>ACTIVE</c>, and then use the space. If provisioning fails,
    /// the status becomes <c>FAILED</c> and <c>statusReason</c> says why. </para>
    /// </summary>
    public partial class CreateSpaceRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that makes the request idempotent. A retry with
        /// the same token and the same parameters within 2 hours returns the space that the first
        /// request created, instead of creating another. Reusing the token with different parameters,
        /// or while the first request is still in progress, fails with <c>ConflictException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The AWS KMS key that encrypts the space's data. Omit it, or omit its <c>kmsKeyArn</c>,
        /// to use an AWS owned key. You can't change the key after you create the space.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property EventExpiryDays. 
        /// <para>
        /// How many days the space keeps each event, from 1 to 365. The default is 90.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 365)]
        public int? EventExpiryDays { get; set; }

        /// <summary>
        /// Checks to see if the EventExpiryDays property is set.
        /// </summary>
        internal bool IsSetEventExpiryDays() => this.EventExpiryDays.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractionModelId. 
        /// <para>
        /// The model that extracts and consolidates memories for every strategy in the space,
        /// as an Amazon Bedrock model ID without an inference-profile prefix: <c>anthropic.claude-opus-5-5</c>
        /// or <c>anthropic.claude-haiku-5-5</c>. Another value fails with <c>ValidationException</c>,
        /// and the message lists the supported IDs. Omit it to use the service default, which
        /// can change over time and isn't returned by <c>GetSpace</c>. Setting a value pins the
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ExtractionModelId { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionModelId property is set.
        /// </summary>
        internal bool IsSetExtractionModelId() => this.ExtractionModelId != null;

        /// <summary>
        /// Gets and sets the property MemoryExpiryDays. 
        /// <para>
        /// How many days the space keeps each memory, from 0 to 3650, counted from when the service
        /// writes the memory. Updating a memory with <c>UpdateMemory</c> doesn't restart the
        /// count. 0 means memories never expire. If you omit it, memories never expire.
        /// </para>
        ///  
        /// <para>
        /// Searches and lists leave out a memory past its expiry, and reading, updating, or deleting
        /// it returns <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3650)]
        public int? MemoryExpiryDays { get; set; }

        /// <summary>
        /// Checks to see if the MemoryExpiryDays property is set.
        /// </summary>
        internal bool IsSetMemoryExpiryDays() => this.MemoryExpiryDays.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryStrategies. 
        /// <para>
        /// The memory strategies that extract memories from the space's events: up to 10 strategies,
        /// each with a name that is unique within the space.
        /// </para>
        ///  
        /// <para>
        /// Optional. Omit it, or send an empty list, to create a space with no memory strategies.
        /// Such a space stores the conversation events you send it and returns them through <c>SearchEvents</c>
        /// and <c>ListEvents</c>, but extracts no memories and has none to search. You can add
        /// strategies later with <c>UpdateSpace</c>.
        /// </para>
        ///  
        /// <para>
        /// The serialized list can be at most 384 KiB.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<MemoryStrategy> MemoryStrategies { get; set; } = AWSConfigs.InitializeCollections ? new List<MemoryStrategy>() : null;

        /// <summary>
        /// Checks to see if the MemoryStrategies property is set.
        /// </summary>
        internal bool IsSetMemoryStrategies() => this.MemoryStrategies != null && (this.MemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the space, unique within your account in the Region. If another space already
        /// has the name, the request fails with <c>ConflictException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
