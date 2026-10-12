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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The backup status information for the data store.
    /// </summary>
    public partial class DatastoreBackupStatus
    {
        /// <summary>
        /// Gets and sets the property BackupEnabledAt. The time backup was enabled on the data
        /// store.
        /// </summary>
        public DateTime? BackupEnabledAt { get; set; }

        /// <summary>
        /// Checks to see if the BackupEnabledAt property is set.
        /// </summary>
        internal bool IsSetBackupEnabledAt() => this.BackupEnabledAt.HasValue;

        /// <summary>
        /// Gets and sets the property Configuration. The backup configuration for the data store.
        /// </summary>
        public BackupConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property EarliestRestorePoint. The earliest point in time the data
        /// store can be restored to.
        /// </summary>
        public DateTime? EarliestRestorePoint { get; set; }

        /// <summary>
        /// Checks to see if the EarliestRestorePoint property is set.
        /// </summary>
        internal bool IsSetEarliestRestorePoint() => this.EarliestRestorePoint.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRestorePoint. The latest point in time the data store
        /// can be restored to.
        /// </summary>
        public DateTime? LatestRestorePoint { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestorePoint property is set.
        /// </summary>
        internal bool IsSetLatestRestorePoint() => this.LatestRestorePoint.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduledPermanentDeletionTime. The time the retained backup
        /// data is scheduled for permanent deletion.
        /// </summary>
        public DateTime? ScheduledPermanentDeletionTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledPermanentDeletionTime property is set.
        /// </summary>
        internal bool IsSetScheduledPermanentDeletionTime() => this.ScheduledPermanentDeletionTime.HasValue;
    }
}
