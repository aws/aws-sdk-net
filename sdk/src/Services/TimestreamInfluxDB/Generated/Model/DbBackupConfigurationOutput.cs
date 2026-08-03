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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Contains the configuration and status for an automated backup schedule.
    /// </summary>
    public partial class DbBackupConfigurationOutput
    {
        private string _customSchedule;
        private bool? _enabled;
        private DateTime? _nextAutomatedBackupTime;
        private int? _retentionDays;
        private AutomatedDbBackupType _type;

        /// <summary>
        /// Gets and sets the property CustomSchedule. 
        /// <para>
        /// The custom cron schedule expression for the backup, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=256)]
        public string CustomSchedule
        {
            get { return this._customSchedule; }
            set { this._customSchedule = value; }
        }

        // Check to see if CustomSchedule property is set
        internal bool IsSetCustomSchedule()
        {
            return this._customSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether this backup configuration is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextAutomatedBackupTime. 
        /// <para>
        /// The next scheduled time for an automated backup to be taken.
        /// </para>
        /// </summary>
        public DateTime? NextAutomatedBackupTime
        {
            get { return this._nextAutomatedBackupTime; }
            set { this._nextAutomatedBackupTime = value; }
        }

        // Check to see if NextAutomatedBackupTime property is set
        internal bool IsSetNextAutomatedBackupTime()
        {
            return this._nextAutomatedBackupTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionDays. 
        /// <para>
        /// The number of days automated backups are retained.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=365)]
        public int? RetentionDays
        {
            get { return this._retentionDays; }
            set { this._retentionDays = value; }
        }

        // Check to see if RetentionDays property is set
        internal bool IsSetRetentionDays()
        {
            return this._retentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of automated backup schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedDbBackupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}