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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the recovery point configuration used in the scan.
    /// </summary>
    public partial class ScanConfigurationRecoveryPoint
    {
        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the Amazon Web Services Backup vault that contains the recovery point
        /// for the scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property ContinuousScanDetails. 
        /// <para>
        /// The time range within the continuous backup in Amazon Web Services Backup that was
        /// scanned for a point-in-time recovery resource.
        /// </para>
        /// </summary>
        public ScanConfigurationContinuousScanDetails ContinuousScanDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContinuousScanDetails property is set.
        /// </summary>
        internal bool IsSetContinuousScanDetails() => this.ContinuousScanDetails != null;
    }
}
