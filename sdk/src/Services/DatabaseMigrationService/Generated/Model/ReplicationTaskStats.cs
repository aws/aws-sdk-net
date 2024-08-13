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
    /// In response to a request by the <c>DescribeReplicationTasks</c> operation, this object
    /// provides a collection of statistics about a replication task.
    /// </summary>
    public partial class ReplicationTaskStats
    {
        private long? _elapsedTimeMillis;
        private DateTime? _freshStartDate;
        private DateTime? _fullLoadFinishDate;
        private int? _fullLoadProgressPercent;
        private DateTime? _fullLoadStartDate;
        private DateTime? _startDate;
        private DateTime? _stopDate;
        private int? _tablesErrored;
        private int? _tablesLoaded;
        private int? _tablesLoading;
        private int? _tablesQueued;

        /// <summary>
        /// Gets and sets the property ElapsedTimeMillis. 
        /// <para>
        /// The elapsed time of the task, in milliseconds.
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
        /// Gets and sets the property FreshStartDate. 
        /// <para>
        /// The date the replication task was started either with a fresh start or a target reload.
        /// </para>
        /// </summary>
        public DateTime? FreshStartDate
        {
            get { return this._freshStartDate; }
            set { this._freshStartDate = value; }
        }

        // Check to see if FreshStartDate property is set
        internal bool IsSetFreshStartDate()
        {
            return this._freshStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadFinishDate. 
        /// <para>
        /// The date the replication task full load was completed.
        /// </para>
        /// </summary>
        public DateTime? FullLoadFinishDate
        {
            get { return this._fullLoadFinishDate; }
            set { this._fullLoadFinishDate = value; }
        }

        // Check to see if FullLoadFinishDate property is set
        internal bool IsSetFullLoadFinishDate()
        {
            return this._fullLoadFinishDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadProgressPercent. 
        /// <para>
        /// The percent complete for the full load migration task.
        /// </para>
        /// </summary>
        public int? FullLoadProgressPercent
        {
            get { return this._fullLoadProgressPercent; }
            set { this._fullLoadProgressPercent = value; }
        }

        // Check to see if FullLoadProgressPercent property is set
        internal bool IsSetFullLoadProgressPercent()
        {
            return this._fullLoadProgressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FullLoadStartDate. 
        /// <para>
        /// The date the replication task full load was started.
        /// </para>
        /// </summary>
        public DateTime? FullLoadStartDate
        {
            get { return this._fullLoadStartDate; }
            set { this._fullLoadStartDate = value; }
        }

        // Check to see if FullLoadStartDate property is set
        internal bool IsSetFullLoadStartDate()
        {
            return this._fullLoadStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the replication task was started either with a fresh start or a resume. For
        /// more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html#DMS-StartReplicationTask-request-StartReplicationTaskType">StartReplicationTaskType</a>.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopDate. 
        /// <para>
        /// The date the replication task was stopped.
        /// </para>
        /// </summary>
        public DateTime? StopDate
        {
            get { return this._stopDate; }
            set { this._stopDate = value; }
        }

        // Check to see if StopDate property is set
        internal bool IsSetStopDate()
        {
            return this._stopDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TablesErrored. 
        /// <para>
        /// The number of errors that have occurred during this task.
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
        /// The number of tables loaded for this task.
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
        /// The number of tables currently loading for this task.
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
        /// The number of tables queued for this task.
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