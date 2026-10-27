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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Information about the data migration run, including start and stop time, latency,
    /// and migration progress.
    /// </summary>
    public partial class DataMigrationStatistics
    {
        /// <summary>
        /// Gets and sets the property CDCLatency. 
        /// <para>
        /// The current latency of the change data capture (CDC) operation.
        /// </para>
        /// </summary>
        public int? CDCLatency { get; set; }

        /// <summary>
        /// Checks to see if the CDCLatency property is set.
        /// </summary>
        internal bool IsSetCDCLatency() => this.CDCLatency.HasValue;

        /// <summary>
        /// Gets and sets the property ElapsedTimeMillis. 
        /// <para>
        /// The elapsed duration of the data migration run.
        /// </para>
        /// </summary>
        public long? ElapsedTimeMillis { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeMillis property is set.
        /// </summary>
        internal bool IsSetElapsedTimeMillis() => this.ElapsedTimeMillis.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadPercentage. 
        /// <para>
        /// The data migration's progress in the full-load migration phase.
        /// </para>
        /// </summary>
        public int? FullLoadPercentage { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadPercentage property is set.
        /// </summary>
        internal bool IsSetFullLoadPercentage() => this.FullLoadPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the migration started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StopTime. 
        /// <para>
        /// The time when the migration stopped or failed.
        /// </para>
        /// </summary>
        public DateTime? StopTime { get; set; }

        /// <summary>
        /// Checks to see if the StopTime property is set.
        /// </summary>
        internal bool IsSetStopTime() => this.StopTime.HasValue;

        /// <summary>
        /// Gets and sets the property TablesErrored. 
        /// <para>
        /// The number of tables that DMS failed to process.
        /// </para>
        /// </summary>
        public int? TablesErrored { get; set; }

        /// <summary>
        /// Checks to see if the TablesErrored property is set.
        /// </summary>
        internal bool IsSetTablesErrored() => this.TablesErrored.HasValue;

        /// <summary>
        /// Gets and sets the property TablesLoaded. 
        /// <para>
        /// The number of tables loaded in the current data migration run.
        /// </para>
        /// </summary>
        public int? TablesLoaded { get; set; }

        /// <summary>
        /// Checks to see if the TablesLoaded property is set.
        /// </summary>
        internal bool IsSetTablesLoaded() => this.TablesLoaded.HasValue;

        /// <summary>
        /// Gets and sets the property TablesLoading. 
        /// <para>
        /// The data migration's table loading progress.
        /// </para>
        /// </summary>
        public int? TablesLoading { get; set; }

        /// <summary>
        /// Checks to see if the TablesLoading property is set.
        /// </summary>
        internal bool IsSetTablesLoading() => this.TablesLoading.HasValue;

        /// <summary>
        /// Gets and sets the property TablesQueued. 
        /// <para>
        /// The number of tables that are waiting for processing.
        /// </para>
        /// </summary>
        public int? TablesQueued { get; set; }

        /// <summary>
        /// Checks to see if the TablesQueued property is set.
        /// </summary>
        internal bool IsSetTablesQueued() => this.TablesQueued.HasValue;
    }
}
