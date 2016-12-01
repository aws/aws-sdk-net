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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServer operation.
    /// Updates settings for a server. 
    /// 
    ///  
    /// <para>
    ///  This operation is synchronous. 
    /// </para>
    /// </summary>
    public partial class UpdateServerRequest : AmazonOpsWorksCMRequest
    {
        private int? _backupRetentionCount;
        private bool? _disableAutomatedBackup;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property BackupRetentionCount. 
        /// <para>
        /// Sets the number of automated backups that you want to keep. 
        /// </para>
        /// </summary>
        public int BackupRetentionCount
        {
            get { return this._backupRetentionCount.GetValueOrDefault(); }
            set { this._backupRetentionCount = value; }
        }

        // Check to see if BackupRetentionCount property is set
        internal bool IsSetBackupRetentionCount()
        {
            return this._backupRetentionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisableAutomatedBackup. 
        /// <para>
        /// Setting DisableAutomatedBackup to <code>true</code> disables automated or scheduled
        /// backups. Automated backups are enabled by default. 
        /// </para>
        /// </summary>
        public bool DisableAutomatedBackup
        {
            get { return this._disableAutomatedBackup.GetValueOrDefault(); }
            set { this._disableAutomatedBackup = value; }
        }

        // Check to see if DisableAutomatedBackup property is set
        internal bool IsSetDisableAutomatedBackup()
        {
            return this._disableAutomatedBackup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow.
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow.
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server to update. 
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}