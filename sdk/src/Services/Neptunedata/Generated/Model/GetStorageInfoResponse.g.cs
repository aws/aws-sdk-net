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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the GetStorageInfo operation.
    /// </summary>
    public partial class GetStorageInfoResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DfeStatistics. 
        /// <para>
        /// Contains storage metrics for the Neptune DFE engine statistics, including size in
        /// bytes and entry count.
        /// </para>
        /// </summary>
        public StorageMetrics DfeStatistics { get; set; }

        /// <summary>
        /// Checks to see if the DfeStatistics property is set.
        /// </summary>
        internal bool IsSetDfeStatistics() => this.DfeStatistics != null;

        /// <summary>
        /// Gets and sets the property Dictionaries. 
        /// <para>
        /// Contains information about the dictionaries, including total dictionary storage and
        /// the portion used by blob entries. For additional details on the storage of the Neptune
        /// dictionary, see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/feature-overview-storage.html#feature-overview-storage-billing">Neptune
        /// Storage Billing</a>.
        /// </para>
        /// </summary>
        public DictionariesInfo Dictionaries { get; set; }

        /// <summary>
        /// Checks to see if the Dictionaries property is set.
        /// </summary>
        internal bool IsSetDictionaries() => this.Dictionaries != null;

        /// <summary>
        /// Gets and sets the property Internals. 
        /// <para>
        /// Contains storage metrics for Neptune system metadata, including size in bytes and
        /// entry count.
        /// </para>
        /// </summary>
        public StorageMetrics Internals { get; set; }

        /// <summary>
        /// Checks to see if the Internals property is set.
        /// </summary>
        internal bool IsSetInternals() => this.Internals != null;

        /// <summary>
        /// Gets and sets the property Quads. 
        /// <para>
        /// Contains information about the quad indexes, including counts and sizes for both RDF
        /// (SPARQL) and Property Graph (Gremlin/openCypher) data.
        /// </para>
        /// </summary>
        public QuadsIndexesInfo Quads { get; set; }

        /// <summary>
        /// Checks to see if the Quads property is set.
        /// </summary>
        internal bool IsSetQuads() => this.Quads != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Contains storage metrics for the Neptune schema, including size in bytes and entry
        /// count.
        /// </para>
        /// </summary>
        public StorageMetrics Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// Contains storage metrics for the Neptune change-log streams, including size in bytes
        /// and entry count.
        /// </para>
        /// </summary>
        public StorageMetrics Streams { get; set; }

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null;

        /// <summary>
        /// Gets and sets the property TotalStorageBytesUsed. 
        /// <para>
        /// The approximate total amount of storage used by the Neptune database instance, in
        /// bytes.
        /// </para>
        /// </summary>
        public long? TotalStorageBytesUsed { get; set; }

        /// <summary>
        /// Checks to see if the TotalStorageBytesUsed property is set.
        /// </summary>
        internal bool IsSetTotalStorageBytesUsed() => this.TotalStorageBytesUsed.HasValue;

        /// <summary>
        /// Gets and sets the property UndoLogs. 
        /// <para>
        /// Contains information about the undo logs. The <c>sizeInBytes</c> field represents
        /// the total size of the undo logs in bytes, and the <c>listSize</c> field represents
        /// the number of entries in the undo log list.
        /// </para>
        /// </summary>
        public UndoLogsMetrics UndoLogs { get; set; }

        /// <summary>
        /// Checks to see if the UndoLogs property is set.
        /// </summary>
        internal bool IsSetUndoLogs() => this.UndoLogs != null;
    }
}
