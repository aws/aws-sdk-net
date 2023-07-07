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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This object provides a collection of statistics about a serverless replication.
    /// </summary>
    public partial class ReplicationStats
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
        /// The elapsed time of the replication, in milliseconds.
        /// </para>
        /// </summary>
        public long ElapsedTimeMillis
        {
            get { return this._elapsedTimeMillis.GetValueOrDefault(); }
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
        /// The date the replication was started either with a fresh start or a target reload.
        /// </para>
        /// </summary>
        public DateTime FreshStartDate
        {
            get { return this._freshStartDate.GetValueOrDefault(); }
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
        /// The date the replication full load was finished.
        /// </para>
        /// </summary>
        public DateTime FullLoadFinishDate
        {
            get { return this._fullLoadFinishDate.GetValueOrDefault(); }
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
        /// The percent complete for the full load serverless replication.
        /// </para>
        /// </summary>
        public int FullLoadProgressPercent
        {
            get { return this._fullLoadProgressPercent.GetValueOrDefault(); }
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
        /// The date the replication full load was started.
        /// </para>
        /// </summary>
        public DateTime FullLoadStartDate
        {
            get { return this._fullLoadStartDate.GetValueOrDefault(); }
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
        /// The date the replication is scheduled to start.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
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
        /// The date the replication was stopped.
        /// </para>
        /// </summary>
        public DateTime StopDate
        {
            get { return this._stopDate.GetValueOrDefault(); }
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
        /// The number of errors that have occured for this replication.
        /// </para>
        /// </summary>
        public int TablesErrored
        {
            get { return this._tablesErrored.GetValueOrDefault(); }
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
        /// The number of tables loaded for this replication.
        /// </para>
        /// </summary>
        public int TablesLoaded
        {
            get { return this._tablesLoaded.GetValueOrDefault(); }
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
        /// The number of tables currently loading for this replication.
        /// </para>
        /// </summary>
        public int TablesLoading
        {
            get { return this._tablesLoading.GetValueOrDefault(); }
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
        /// The number of tables queued for this replication.
        /// </para>
        /// </summary>
        public int TablesQueued
        {
            get { return this._tablesQueued.GetValueOrDefault(); }
            set { this._tablesQueued = value; }
        }

        // Check to see if TablesQueued property is set
        internal bool IsSetTablesQueued()
        {
            return this._tablesQueued.HasValue; 
        }

    }
}