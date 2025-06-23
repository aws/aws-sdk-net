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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private CompactionMetrics _compactionMetrics;
        private CompactionStrategy _compactionStrategy;
        private DateTime? _endTimestamp;
        private string _error;
        private TableOptimizerEventType _eventType;
        private RunMetrics _metrics;
        private OrphanFileDeletionMetrics _orphanFileDeletionMetrics;
        private RetentionMetrics _retentionMetrics;
        private DateTime? _startTimestamp;

        /// <summary>
        /// Gets and sets the property CompactionMetrics. 
        /// <para>
        /// A <c>CompactionMetrics</c> object containing metrics for the optimizer run.
        /// </para>
        /// </summary>
        public CompactionMetrics CompactionMetrics
        {
            get { return this._compactionMetrics; }
            set { this._compactionMetrics = value; }
        }

        // Check to see if CompactionMetrics property is set
        internal bool IsSetCompactionMetrics()
        {
            return this._compactionMetrics != null;
        }

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
        public CompactionStrategy CompactionStrategy
        {
            get { return this._compactionStrategy; }
            set { this._compactionStrategy = value; }
        }

        // Check to see if CompactionStrategy property is set
        internal bool IsSetCompactionStrategy()
        {
            return this._compactionStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// Represents the epoch timestamp at which the compaction job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error that occured during the optimizer run.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// An event type representing the status of the table optimizer run.
        /// </para>
        /// </summary>
        public TableOptimizerEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

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
        public RunMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property OrphanFileDeletionMetrics. 
        /// <para>
        /// An <c>OrphanFileDeletionMetrics</c> object containing metrics for the optimizer run.
        /// </para>
        /// </summary>
        public OrphanFileDeletionMetrics OrphanFileDeletionMetrics
        {
            get { return this._orphanFileDeletionMetrics; }
            set { this._orphanFileDeletionMetrics = value; }
        }

        // Check to see if OrphanFileDeletionMetrics property is set
        internal bool IsSetOrphanFileDeletionMetrics()
        {
            return this._orphanFileDeletionMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionMetrics. 
        /// <para>
        /// A <c>RetentionMetrics</c> object containing metrics for the optimizer run.
        /// </para>
        /// </summary>
        public RetentionMetrics RetentionMetrics
        {
            get { return this._retentionMetrics; }
            set { this._retentionMetrics = value; }
        }

        // Check to see if RetentionMetrics property is set
        internal bool IsSetRetentionMetrics()
        {
            return this._retentionMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// Represents the epoch timestamp at which the compaction job was started within Lake
        /// Formation.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

    }
}