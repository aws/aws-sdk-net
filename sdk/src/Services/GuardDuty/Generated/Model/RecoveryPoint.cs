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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the recovery point configuration for scanning backup data
    /// from Amazon Web Services Backup.
    /// </summary>
    public partial class RecoveryPoint
    {
        private string _backupVaultName;
        private ContinuousScanDetails _continuousScanDetails;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the Amazon Web Services Backup vault that contains the name of the recovery
        /// point to be scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuousScanDetails. 
        /// <para>
        /// Contains information about the time range within the continuous backup in Amazon Web
        /// Services Backup to scan.
        /// </para>
        /// </summary>
        public ContinuousScanDetails ContinuousScanDetails
        {
            get { return this._continuousScanDetails; }
            set { this._continuousScanDetails = value; }
        }

        // Check to see if ContinuousScanDetails property is set
        internal bool IsSetContinuousScanDetails()
        {
            return this._continuousScanDetails != null;
        }

    }
}