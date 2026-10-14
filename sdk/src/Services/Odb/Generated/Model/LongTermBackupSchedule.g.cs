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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The long-term backup schedule for an Autonomous Database.
    /// </summary>
    public partial class LongTermBackupSchedule
    {
        /// <summary>
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// Indicates whether the long-term backup schedule is disabled.
        /// </para>
        /// </summary>
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Checks to see if the IsDisabled property is set.
        /// </summary>
        internal bool IsSetIsDisabled() => this.IsDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property RepeatCadence. 
        /// <para>
        /// The cadence at which long-term backups are taken.
        /// </para>
        /// </summary>
        public RepeatCadence RepeatCadence { get; set; }

        /// <summary>
        /// Checks to see if the RepeatCadence property is set.
        /// </summary>
        internal bool IsSetRepeatCadence() => this.RepeatCadence != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for long-term backups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 90, Max = 3650)]
        public int? RetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetRetentionPeriodInDays() => this.RetentionPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property TimeOfBackup. 
        /// <para>
        /// The date and time at which the long-term backup is taken.
        /// </para>
        /// </summary>
        public DateTime? TimeOfBackup { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfBackup property is set.
        /// </summary>
        internal bool IsSetTimeOfBackup() => this.TimeOfBackup.HasValue;
    }
}
