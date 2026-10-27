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
    /// In response to a request by the <c>DescribeReplicationTasks</c> operation, this object
    /// provides a collection of statistics about a replication task.
    /// </summary>
    public partial class ReplicationTaskStats
    {
        /// <summary>
        /// Gets and sets the property ElapsedTimeMillis. 
        /// <para>
        /// The elapsed time of the task, in milliseconds.
        /// </para>
        /// </summary>
        public long? ElapsedTimeMillis { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeMillis property is set.
        /// </summary>
        internal bool IsSetElapsedTimeMillis() => this.ElapsedTimeMillis.HasValue;

        /// <summary>
        /// Gets and sets the property FreshStartDate. 
        /// <para>
        /// The date the replication task was started either with a fresh start or a target reload.
        /// </para>
        /// </summary>
        public DateTime? FreshStartDate { get; set; }

        /// <summary>
        /// Checks to see if the FreshStartDate property is set.
        /// </summary>
        internal bool IsSetFreshStartDate() => this.FreshStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadFinishDate. 
        /// <para>
        /// The date the replication task full load was completed.
        /// </para>
        /// </summary>
        public DateTime? FullLoadFinishDate { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadFinishDate property is set.
        /// </summary>
        internal bool IsSetFullLoadFinishDate() => this.FullLoadFinishDate.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadProgressPercent. 
        /// <para>
        /// The percent complete for the full load migration task.
        /// </para>
        /// </summary>
        public int? FullLoadProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadProgressPercent property is set.
        /// </summary>
        internal bool IsSetFullLoadProgressPercent() => this.FullLoadProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadStartDate. 
        /// <para>
        /// The date the replication task full load was started.
        /// </para>
        /// </summary>
        public DateTime? FullLoadStartDate { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadStartDate property is set.
        /// </summary>
        internal bool IsSetFullLoadStartDate() => this.FullLoadStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the replication task was started either with a fresh start or a resume. For
        /// more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html#DMS-StartReplicationTask-request-StartReplicationTaskType">StartReplicationTaskType</a>.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property StopDate. 
        /// <para>
        /// The date the replication task was stopped.
        /// </para>
        /// </summary>
        public DateTime? StopDate { get; set; }

        /// <summary>
        /// Checks to see if the StopDate property is set.
        /// </summary>
        internal bool IsSetStopDate() => this.StopDate.HasValue;

        /// <summary>
        /// Gets and sets the property TablesErrored. 
        /// <para>
        /// The number of errors that have occurred during this task.
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
        /// The number of tables loaded for this task.
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
        /// The number of tables currently loading for this task.
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
        /// The number of tables queued for this task.
        /// </para>
        /// </summary>
        public int? TablesQueued { get; set; }

        /// <summary>
        /// Checks to see if the TablesQueued property is set.
        /// </summary>
        internal bool IsSetTablesQueued() => this.TablesQueued.HasValue;
    }
}
