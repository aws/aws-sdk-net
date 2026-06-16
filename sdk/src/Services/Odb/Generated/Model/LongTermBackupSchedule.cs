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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private bool? _isDisabled;
        private RepeatCadence _repeatCadence;
        private int? _retentionPeriodInDays;
        private DateTime? _timeOfBackup;

        /// <summary>
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// Indicates whether the long-term backup schedule is disabled.
        /// </para>
        /// </summary>
        public bool? IsDisabled
        {
            get { return this._isDisabled; }
            set { this._isDisabled = value; }
        }

        // Check to see if IsDisabled property is set
        internal bool IsSetIsDisabled()
        {
            return this._isDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RepeatCadence. 
        /// <para>
        /// The cadence at which long-term backups are taken.
        /// </para>
        /// </summary>
        public RepeatCadence RepeatCadence
        {
            get { return this._repeatCadence; }
            set { this._repeatCadence = value; }
        }

        // Check to see if RepeatCadence property is set
        internal bool IsSetRepeatCadence()
        {
            return this._repeatCadence != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for long-term backups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=90, Max=3650)]
        public int? RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays; }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeOfBackup. 
        /// <para>
        /// The date and time at which the long-term backup is taken.
        /// </para>
        /// </summary>
        public DateTime? TimeOfBackup
        {
            get { return this._timeOfBackup; }
            set { this._timeOfBackup = value; }
        }

        // Check to see if TimeOfBackup property is set
        internal bool IsSetTimeOfBackup()
        {
            return this._timeOfBackup.HasValue; 
        }

    }
}