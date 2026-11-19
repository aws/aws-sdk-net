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
    /// Container for the parameters to the UpdateSpace operation. Updates a space's memory
    /// strategies, retention settings, or extraction model. Supply only the fields to change.
    /// Omitted fields keep their current values. <para> If the request changes the set of
    /// strategies, a strategy's configuration, a retention setting, or the extraction model,
    /// the space moves to <c>UPDATING</c>. When the change is complete, the space returns
    /// to <c>ACTIVE</c>, or moves to <c>FAILED</c> if the change can't be applied. While
    /// the space is <c>UPDATING</c>, <c>GetSpace</c> returns the previous configuration.
    /// A request that only changes strategy descriptions or repeats the values the space
    /// has stored is applied immediately and doesn't change the status. Sending a retention
    /// value that the space never set also moves the space to <c>UPDATING</c>, even one that
    /// matches the behavior without it, such as 90 for <c>eventExpiryDays</c> or 0 for <c>memoryExpiryDays</c>.
    /// A space that is <c>CREATING</c>, <c>UPDATING</c>, or <c>DELETING</c> can't be updated:
    /// the request fails with <c>ConflictException</c>. </para>
    /// </summary>
    public partial class UpdateSpaceRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property EventExpiryDays. 
        /// <para>
        /// How many days the space keeps each event, from 1 to 365. Omit it to leave the current
        /// value unchanged. Events already stored keep the expiry they were written with.
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
        /// The model that extracts and consolidates memories for every strategy in the space:
        /// <c>anthropic.claude-opus-5-5</c> or <c>anthropic.claude-haiku-5-5</c>. Omit it to
        /// leave the current value unchanged. Once set, it can't be cleared back to the service
        /// default.
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
        /// How many days the space keeps each memory, from 0 to 3650. 0 means memories never
        /// expire. Omit it to leave the current value unchanged. You can't clear the setting.
        /// To make memories written from then on never expire, send 0. <c>GetSpace</c> then returns
        /// 0.
        /// </para>
        ///  
        /// <para>
        /// A change applies to memories written after it. Memories already stored keep the expiry
        /// they were written with. A memory the service rewrites later, such as a summary it
        /// keeps up to date, takes the setting in force at that rewrite. A change moves the space
        /// to <c>UPDATING</c>. Sending the value that the space has stored doesn't.
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
        /// The complete new list of memory strategies. The service removes strategies that aren't
        /// in the list from the space. Removing a strategy stops extraction for it but doesn't
        /// delete its memories: they're kept, until they expire if the space sets <c>memoryExpiryDays</c>,
        /// and they're available again if you later add a strategy with the same <c>type</c>
        /// and <c>name</c>. To delete them, use <c>DeleteMemory</c> before you remove the strategy,
        /// or delete the space.
        /// </para>
        ///  
        /// <para>
        /// To keep a strategy, include it with the same <c>type</c> and <c>name</c> that <c>GetSpace</c>
        /// returns. For a kept strategy, any <c>configuration</c> member you omit keeps its current
        /// value. It doesn't return to the default, and you can't clear a member once it's set.
        /// Omit this field to leave the strategies unchanged. The list must name at least one
        /// strategy. You can't remove every strategy from a space with <c>UpdateSpace</c>.
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
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;
    }
}
