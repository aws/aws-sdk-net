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
    /// The backup configuration for the data store.
    /// </summary>
    public partial class BackupConfiguration
    {
        /// <summary>
        /// Gets and sets the property BackupTagsEnabled. Specifies whether tags are included
        /// in backups.
        /// </summary>
        public bool? BackupTagsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BackupTagsEnabled property is set.
        /// </summary>
        internal bool IsSetBackupTagsEnabled() => this.BackupTagsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property BackupType. The type of backup.
        /// </summary>
        public BackupType BackupType { get; set; }

        /// <summary>
        /// Checks to see if the BackupType property is set.
        /// </summary>
        internal bool IsSetBackupType() => this.BackupType != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. The number of days backup data is
        /// retained.
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public int? RetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetRetentionPeriodInDays() => this.RetentionPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property Status. The backup status of the data store.
        /// </summary>
        public BackupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
