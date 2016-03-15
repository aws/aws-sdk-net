/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ReplicationTaskStats
    {
        private long? _elapsedTimeMillis;
        private int? _fullLoadProgressPercent;
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
        /// Gets and sets the property FullLoadProgressPercent. 
        /// <para>
        /// The percent complete for the full load migration task.
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
        /// Gets and sets the property TablesErrored. 
        /// <para>
        /// The number of errors that have occurred during this task.
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
        /// The number of tables loaded for this task.
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
        /// The number of tables currently loading for this task.
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
        /// The number of tables queued for this task.
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