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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Information about the data migration run, including start and stop time, latency,
    /// and migration progress.
    /// </summary>
    public partial class DataMigrationStatistics
    {
        private int? _cdcLatency;
        private long? _elapsedTimeMillis;
        private int? _fullLoadPercentage;
        private DateTime? _startTime;
        private DateTime? _stopTime;
        private int? _tablesErrored;
        private int? _tablesLoaded;
        private int? _tablesLoading;
        private int? _tablesQueued;

        /// <summary>
        /// Gets and sets the property CDCLatency. 
        /// <para>
        /// The current latency of the change data capture (CDC) operation.
        /// </para>
        /// </summary>
        public int? CDCLatency
        {
            get { return this._cdcLatency; }
            set { this._cdcLatency = value; }
        }

        // Check to see if CDCLatency property is set
        internal bool IsSetCDCLatency()
        {
            return this._cdcLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElapsedTimeMillis. 
        /// <para>
        /// The elapsed duration of the data migration run.
        /// </para>
        /// </summary>
        public long? ElapsedTimeMillis
        {
            get { return this._elapsedTimeMillis; }
            set { this._elapsedTimeMillis = value; }
        }

        // Check to see if ElapsedTimeMillis property is set
        internal bool IsSetElapsedTimeMillis()
        {
            return this._elapsedTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadPercentage. 
        /// <para>
        /// The data migration's progress in the full-load migration phase.
        /// </para>
        /// </summary>
        public int? FullLoadPercentage
        {
            get { return this._fullLoadPercentage; }
            set { this._fullLoadPercentage = value; }
        }

        // Check to see if FullLoadPercentage property is set
        internal bool IsSetFullLoadPercentage()
        {
            return this._fullLoadPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the migration started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The time when the migration stopped or failed.
        /// </para>
        /// </summary>
        public DateTime? StopTime
        {
            get { return this._stopTime; }
            set { this._stopTime = value; }
        }

        // Check to see if StopTime property is set
        internal bool IsSetStopTime()
        {
            return this._stopTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesErrored. 
        /// <para>
        /// The number of tables that DMS failed to process.
        /// </para>
        /// </summary>
        public int? TablesErrored
        {
            get { return this._tablesErrored; }
            set { this._tablesErrored = value; }
        }

        // Check to see if TablesErrored property is set
        internal bool IsSetTablesErrored()
        {
            return this._tablesErrored.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesLoaded. 
        /// <para>
        /// The number of tables loaded in the current data migration run.
        /// </para>
        /// </summary>
        public int? TablesLoaded
        {
            get { return this._tablesLoaded; }
            set { this._tablesLoaded = value; }
        }

        // Check to see if TablesLoaded property is set
        internal bool IsSetTablesLoaded()
        {
            return this._tablesLoaded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesLoading. 
        /// <para>
        /// The data migration's table loading progress.
        /// </para>
        /// </summary>
        public int? TablesLoading
        {
            get { return this._tablesLoading; }
            set { this._tablesLoading = value; }
        }

        // Check to see if TablesLoading property is set
        internal bool IsSetTablesLoading()
        {
            return this._tablesLoading.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesQueued. 
        /// <para>
        /// The number of tables that are waiting for processing.
        /// </para>
        /// </summary>
        public int? TablesQueued
        {
            get { return this._tablesQueued; }
            set { this._tablesQueued = value; }
        }

        // Check to see if TablesQueued property is set
        internal bool IsSetTablesQueued()
        {
            return this._tablesQueued.HasValue; 
        }

    }
}