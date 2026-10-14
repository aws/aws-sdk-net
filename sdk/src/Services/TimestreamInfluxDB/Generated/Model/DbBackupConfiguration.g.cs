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

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Specifies the configuration for an automated backup schedule.
    /// </summary>
    public partial class DbBackupConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomSchedule. 
        /// <para>
        /// A custom cron schedule expression for the backup. Required when type is CUSTOM_SCHEDULE.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 256)]
        public string CustomSchedule { get; set; }

        /// <summary>
        /// Checks to see if the CustomSchedule property is set.
        /// </summary>
        internal bool IsSetCustomSchedule() => this.CustomSchedule != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether this backup configuration is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionDays. 
        /// <para>
        /// The number of days to retain automated backups. Valid values are 1 to 365.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 365)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionDays property is set.
        /// </summary>
        internal bool IsSetRetentionDays() => this.RetentionDays.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of automated backup schedule. Valid values are HOURLY, DAILY, WEEKLY, MONTHLY,
        /// CUSTOM_SCHEDULE, and CONTINUOUS.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedDbBackupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
