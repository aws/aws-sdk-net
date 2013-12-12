/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Promotes a read replica DB instance to a standalone DB instance. </para>
    /// </summary>
    public partial class PromoteReadReplicaRequest : AmazonRDSRequest
    {
        private string dBInstanceIdentifier;
        private int? backupRetentionPeriod;
        private string preferredBackupWindow;


        /// <summary>
        /// The DB instance identifier. This value is stored as a lowercase string. Constraints: <ul> <li>Must be the identifier for an existing read
        /// replica DB instance</li> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li>
        /// <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul> Example: <copy>mydbinstance</copy>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;
        }

        /// <summary>
        /// The number of days to retain automated backups. Setting this parameter to a positive number enables backups. Setting this parameter to 0
        /// disables automated backups. Default: 1 Constraints: <ul> <li>Must be a value from 0 to 8</li> </ul>
        ///  
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this.backupRetentionPeriod ?? default(int); }
            set { this.backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this.backupRetentionPeriod.HasValue;
        }

        /// <summary>
        /// The daily time range during which automated backups are created if automated backups are enabled, using the <c>BackupRetentionPeriod</c>
        /// parameter. Default: A 30-minute window selected at random from an 8-hour block of time per region. See the Amazon RDS User Guide for the
        /// time blocks for each region from which the default backup windows are assigned. Constraints: Must be in the format <c>hh24:mi-hh24:mi</c>.
        /// Times should be Universal Time Coordinated (UTC). Must not conflict with the preferred maintenance window. Must be at least 30 minutes.
        ///  
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this.preferredBackupWindow; }
            set { this.preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this.preferredBackupWindow != null;
        }

    }
}
    
