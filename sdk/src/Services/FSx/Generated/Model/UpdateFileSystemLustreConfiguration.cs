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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration object for Amazon FSx for Lustre file systems used in the <code>UpdateFileSystem</code>
    /// operation.
    /// </summary>
    public partial class UpdateFileSystemLustreConfiguration
    {
        private AutoImportPolicyType _autoImportPolicy;
        private int? _automaticBackupRetentionDays;
        private string _dailyAutomaticBackupStartTime;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AutoImportPolicy. 
        /// <para>
        /// Use this property to turn the Autoimport feature on and off. AutoImport enables your
        /// FSx for Lustre file system to automatically update its contents with changes that
        /// have been made to its linked Amazon S3 data repository. You can set the policy to
        /// have one the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> - (Default) Autoimport is turned off. Changes to your S3 repository
        /// will not be reflected on the FSx file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW</code> - Autoimport is turned on; only new files in the linked S3 repository
        /// will be imported to the FSx file system. Updates to existing files and deleted files
        /// will not be imported to the FSx file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_CHANGED</code> - Autoimport is turned on; new files and changes to existing
        /// files in the linked S3 repository will be imported to the FSx file system. Files deleted
        /// in S3 are not deleted in the FSx file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_CHANGED_DELETED</code> - Autoimport is turned on; new files, changes to
        /// existing files, and deleted files in the linked S3 repository will be imported to
        /// the FSx file system. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AutoImportPolicyType AutoImportPolicy
        {
            get { return this._autoImportPolicy; }
            set { this._autoImportPolicy = value; }
        }

        // Check to see if AutoImportPolicy property is set
        internal bool IsSetAutoImportPolicy()
        {
            return this._autoImportPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays.
        /// </summary>
        [AWSProperty(Min=0, Max=35)]
        public int AutomaticBackupRetentionDays
        {
            get { return this._automaticBackupRetentionDays.GetValueOrDefault(); }
            set { this._automaticBackupRetentionDays = value; }
        }

        // Check to see if AutomaticBackupRetentionDays property is set
        internal bool IsSetAutomaticBackupRetentionDays()
        {
            return this._automaticBackupRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime.
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
        public string DailyAutomaticBackupStartTime
        {
            get { return this._dailyAutomaticBackupStartTime; }
            set { this._dailyAutomaticBackupStartTime = value; }
        }

        // Check to see if DailyAutomaticBackupStartTime property is set
        internal bool IsSetDailyAutomaticBackupStartTime()
        {
            return this._dailyAutomaticBackupStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone. d is the weekday number, from 1 through 7, beginning with Monday and ending
        /// with Sunday.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}