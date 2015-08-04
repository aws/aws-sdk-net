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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the PromoteReadReplica operation.
    /// Promotes a Read Replica DB instance to a standalone DB instance. 
    /// 
    ///  <note> 
    /// <para>
    /// We recommend that you enable automated backups on your Read Replica before promoting
    /// the Read Replica. This ensures that no backup is taken during the promotion process.
    /// Once the instance is promoted to a primary instance, backups are taken based on your
    /// backup settings.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PromoteReadReplicaRequest : AmazonRDSRequest
    {
        private int? _backupRetentionPeriod;
        private string _dbInstanceIdentifier;
        private string _preferredBackupWindow;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        ///  The number of days to retain automated backups. Setting this parameter to a positive
        /// number enables backups. Setting this parameter to 0 disables automated backups. 
        /// </para>
        ///  
        /// <para>
        ///  Default: 1 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be a value from 0 to 8</li> </ul>
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod.GetValueOrDefault(); }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        ///  The DB instance identifier. This value is stored as a lowercase string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be the identifier for an existing Read Replica DB instance</li> <li>Must
        /// contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must
        /// be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul> 
        /// <para>
        /// Example: <copy>mydbinstance</copy>
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        ///  The daily time range during which automated backups are created if automated backups
        /// are enabled, using the <code>BackupRetentionPeriod</code> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  Default: A 30-minute window selected at random from an 8-hour block of time per region.
        /// To see the time blocks available, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/AdjustingTheMaintenanceWindow.html">
        /// Adjusting the Preferred Maintenance Window</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be in the format <code>hh24:mi-hh24:mi</code>.</li> <li>Times should
        /// be in Universal Coordinated Time (UTC).</li> <li>Must not conflict with the preferred
        /// maintenance window.</li> <li>Must be at least 30 minutes.</li> </ul>
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

    }
}