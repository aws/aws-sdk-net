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
        private DataCompressionType _dataCompressionType;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AutoImportPolicy. 
        /// <para>
        ///  (Optional) When you create your file system, your existing S3 objects appear as file
        /// and directory listings. Use this property to choose how Amazon FSx keeps your file
        /// and directory listing up to date as you add or modify objects in your linked S3 bucket.
        /// <code>AutoImportPolicy</code> can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> - (Default) AutoImport is off. Amazon FSx only updates file and
        /// directory listings from the linked S3 bucket when the file system is created. FSx
        /// does not update the file and directory listing for any new or changed objects after
        /// choosing this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW</code> - AutoImport is on. Amazon FSx automatically imports directory listings
        /// of any new objects added to the linked S3 bucket that do not currently exist in the
        /// FSx file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_CHANGED</code> - AutoImport is on. Amazon FSx automatically imports file
        /// and directory listings of any new objects added to the S3 bucket and any existing
        /// objects that are changed in the S3 bucket after you choose this option. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/autoimport-data-repo.html">Automatically
        /// import updates from your S3 bucket</a>.
        /// </para>
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
        [AWSProperty(Min=0, Max=90)]
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
        /// Gets and sets the property DataCompressionType. 
        /// <para>
        /// Sets the data compression configuration for the file system. <code>DataCompressionType</code>
        /// can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> - Data compression is turned off for the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LZ4</code> - Data compression is turned on with the LZ4 algorithm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't use <code>DataCompressionType</code>, the file system retains its current
        /// data compression configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-compression.html">Lustre
        /// data compression</a>.
        /// </para>
        /// </summary>
        public DataCompressionType DataCompressionType
        {
            get { return this._dataCompressionType; }
            set { this._dataCompressionType = value; }
        }

        // Check to see if DataCompressionType property is set
        internal bool IsSetDataCompressionType()
        {
            return this._dataCompressionType != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// (Optional) The preferred start time to perform weekly maintenance, formatted d:HH:MM
        /// in the UTC time zone. d is the weekday number, from 1 through 7, beginning with Monday
        /// and ending with Sunday.
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