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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The backup status information for the data store.
    /// </summary>
    public partial class DatastoreBackupStatus
    {
        private DateTime? _backupEnabledAt;
        private BackupConfiguration _configuration;
        private DateTime? _earliestRestorePoint;
        private DateTime? _latestRestorePoint;
        private DateTime? _scheduledPermanentDeletionTime;

        /// <summary>
        /// Gets and sets the property BackupEnabledAt. 
        /// <para>
        /// The time backup was enabled on the data store.
        /// </para>
        /// </summary>
        public DateTime? BackupEnabledAt
        {
            get { return this._backupEnabledAt; }
            set { this._backupEnabledAt = value; }
        }

        // Check to see if BackupEnabledAt property is set
        internal bool IsSetBackupEnabledAt()
        {
            return this._backupEnabledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The backup configuration for the data store.
        /// </para>
        /// </summary>
        public BackupConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property EarliestRestorePoint. 
        /// <para>
        /// The earliest point in time the data store can be restored to.
        /// </para>
        /// </summary>
        public DateTime? EarliestRestorePoint
        {
            get { return this._earliestRestorePoint; }
            set { this._earliestRestorePoint = value; }
        }

        // Check to see if EarliestRestorePoint property is set
        internal bool IsSetEarliestRestorePoint()
        {
            return this._earliestRestorePoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestRestorePoint. 
        /// <para>
        /// The latest point in time the data store can be restored to.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorePoint
        {
            get { return this._latestRestorePoint; }
            set { this._latestRestorePoint = value; }
        }

        // Check to see if LatestRestorePoint property is set
        internal bool IsSetLatestRestorePoint()
        {
            return this._latestRestorePoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledPermanentDeletionTime. 
        /// <para>
        /// The time the retained backup data is scheduled for permanent deletion.
        /// </para>
        /// </summary>
        public DateTime? ScheduledPermanentDeletionTime
        {
            get { return this._scheduledPermanentDeletionTime; }
            set { this._scheduledPermanentDeletionTime = value; }
        }

        // Check to see if ScheduledPermanentDeletionTime property is set
        internal bool IsSetScheduledPermanentDeletionTime()
        {
            return this._scheduledPermanentDeletionTime.HasValue; 
        }

    }
}