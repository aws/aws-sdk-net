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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutRawEvents operation. Publishes pre-shaped events
    /// to an event bus. <para> The total size of all event entries in a request must not
    /// exceed 1 MB (1,048,576 bytes), including the <c>Data</c> payload and the keys and
    /// values of <c>Metadata</c> for each entry. The limit applies to the request as a whole,
    /// not to individual entries. </para> <para> If you exceed the limit, the request fails
    /// with <c>InvalidInputException</c>, and the service doesn't publish any of the entries
    /// in the request. </para>
    /// </summary>
    public partial class PutRawEventsRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property DeduplicationConfiguration. 
        /// <para>
        /// Request-level deduplication settings, applied to every entry in the batch.
        /// </para>
        /// </summary>
        public DeduplicationConfiguration DeduplicationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeduplicationConfiguration property is set.
        /// </summary>
        internal bool IsSetDeduplicationConfiguration() => this.DeduplicationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// List of event entries to publish. Must contain at least one entry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<PutRawEventsRequestEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<PutRawEventsRequestEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventBusArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies an event bus.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;

        /// <summary>
        /// Gets and sets the property SchemaRegistryConfiguration. 
        /// <para>
        /// Schema-registry settings for encoding open-format (Avro/Protobuf) events. Required
        /// for open-format entries; ignored for JSON entries. The registry is read with the caller's
        /// credentials, so the caller needs read access to the registry it references.
        /// </para>
        /// </summary>
        public SchemaRegistryConfiguration SchemaRegistryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchemaRegistryConfiguration property is set.
        /// </summary>
        internal bool IsSetSchemaRegistryConfiguration() => this.SchemaRegistryConfiguration != null;
    }
}
