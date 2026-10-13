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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains details for a table optimizer run.
    /// </summary>
    public partial class TableOptimizerRun
    {
        /// <summary>
        /// Gets and sets the property CompactionMetrics. 
        /// <para>
        /// A <c>CompactionMetrics</c> object containing metrics for the optimizer run.
        /// </para>
        /// </summary>
        public CompactionMetrics CompactionMetrics { get; set; }

        /// <summary>
        /// Checks to see if the CompactionMetrics property is set.
        /// </summary>
        internal bool IsSetCompactionMetrics() => this.CompactionMetrics != null;

        /// <summary>
        /// Gets and sets the property CompactionStrategy. 
        /// <para>
        /// The strategy used for the compaction run. Indicates which algorithm was applied to
        /// determine how files were selected and combined during the compaction process. Valid
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>binpack</c>: Combines small files into larger files, typically targeting sizes
        /// over 100MB, while applying any pending deletes. This is the recommended compaction
        /// strategy for most use cases. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sort</c>: Organizes data based on specified columns which are sorted hierarchically
        /// during compaction, improving query performance for filtered operations. This strategy
        /// is recommended when your queries frequently filter on specific columns. To use this
        /// strategy, you must first define a sort order in your Iceberg table properties using
        /// the <c>sort_order</c> table property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>z-order</c>: Optimizes data organization by blending multiple attributes into
        /// a single scalar value that can be used for sorting, allowing efficient querying across
        /// multiple dimensions. This strategy is recommended when you need to query data across
        /// multiple dimensions simultaneously. To use this strategy, you must first define a
        /// sort order in your Iceberg table properties using the <c>sort_order</c> table property.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CompactionStrategy CompactionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the CompactionStrategy property is set.
        /// </summary>
        internal bool IsSetCompactionStrategy() => this.CompactionStrategy != null;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// Represents the epoch timestamp at which the compaction job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error that occured during the optimizer run.
        /// </para>
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// An event type representing the status of the table optimizer run.
        /// </para>
        /// </summary>
        public TableOptimizerEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A <c>RunMetrics</c> object containing metrics for the optimizer run.
        /// </para>
        ///  
        /// <para>
        /// This member is deprecated. See the individual metric members for compaction, retention,
        /// and orphan file deletion.
        /// </para>
        /// </summary>
        [Obsolete("Metrics has been replaced by optimizer type specific metrics such as IcebergCompactionMetrics")]
        public RunMetrics Metrics { get; set; }

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null;

        /// <summary>
        /// Gets and sets the property OrphanFileDeletionMetrics. 
        /// <para>
        /// An <c>OrphanFileDeletionMetrics</c> object containing metrics for the optimizer run.
        /// </para>
        /// </summary>
        public OrphanFileDeletionMetrics OrphanFileDeletionMetrics { get; set; }

        /// <summary>
        /// Checks to see if the OrphanFileDeletionMetrics property is set.
        /// </summary>
        internal bool IsSetOrphanFileDeletionMetrics() => this.OrphanFileDeletionMetrics != null;

        /// <summary>
        /// Gets and sets the property RetentionMetrics. 
        /// <para>
        /// A <c>RetentionMetrics</c> object containing metrics for the optimizer run.
        /// </para>
        /// </summary>
        public RetentionMetrics RetentionMetrics { get; set; }

        /// <summary>
        /// Checks to see if the RetentionMetrics property is set.
        /// </summary>
        internal bool IsSetRetentionMetrics() => this.RetentionMetrics != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// Represents the epoch timestamp at which the compaction job was started within Lake
        /// Formation.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;
    }
}
