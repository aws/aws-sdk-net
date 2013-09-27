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
    /// <para> Promotes a Read Replica DB Instance to a standalone DB Instance. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.PromoteReadReplica"/>
    public class PromoteReadReplicaRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;
        private int? backupRetentionPeriod;
        private string preferredBackupWindow;

        /// <summary>
        /// The DB Instance identifier. This value is stored as a lowercase string. Constraints: <ul> <li>Must be the identifier for an existing Read
        /// Replica DB Instance</li> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li>
        /// <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul> Example: <copy>mydbinstance</copy>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="dBInstanceIdentifier">The value to set for the DBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PromoteReadReplicaRequest WithDBInstanceIdentifier(string dBInstanceIdentifier)
        {
            this.dBInstanceIdentifier = dBInstanceIdentifier;
            return this;
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

        /// <summary>
        /// Sets the BackupRetentionPeriod property
        /// </summary>
        /// <param name="backupRetentionPeriod">The value to set for the BackupRetentionPeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PromoteReadReplicaRequest WithBackupRetentionPeriod(int backupRetentionPeriod)
        {
            this.backupRetentionPeriod = backupRetentionPeriod;
            return this;
        }
            

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this.backupRetentionPeriod.HasValue;
        }

        /// <summary>
        /// The daily time range during which automated backups are created if automated backups are enabled, using the <c>BackupRetentionPeriod</c>
        /// parameter. Default: A 30-minute window selected at random from an 8-hour block of time per region. The following list shows the time blocks
        /// for each region from which the default backup windows are assigned. <ul> <li><b>US-East (Northern Virginia) Region:</b> 03:00-11:00 UTC</li>
        /// <li><b>US-West (Northern California) Region:</b> 06:00-14:00 UTC</li> <li><b>EU (Ireland) Region:</b> 22:00-06:00 UTC</li> <li><b>Asia
        /// Pacific (Singapore) Region:</b> 14:00-22:00 UTC</li> <li><b>Asia Pacific (Tokyo) Region: </b> 17:00-03:00 UTC</li> </ul> Constraints: Must
        /// be in the format <c>hh24:mi-hh24:mi</c>. Times should be Universal Time Coordinated (UTC). Must not conflict with the preferred maintenance
        /// window. Must be at least 30 minutes.
        ///  
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this.preferredBackupWindow; }
            set { this.preferredBackupWindow = value; }
        }

        /// <summary>
        /// Sets the PreferredBackupWindow property
        /// </summary>
        /// <param name="preferredBackupWindow">The value to set for the PreferredBackupWindow property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PromoteReadReplicaRequest WithPreferredBackupWindow(string preferredBackupWindow)
        {
            this.preferredBackupWindow = preferredBackupWindow;
            return this;
        }
            

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this.preferredBackupWindow != null;
        }
    }
}
    
