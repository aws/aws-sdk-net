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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the Amazon SNS event notifications for the specified backup
    /// vault.
    /// </summary>
    public partial class AwsBackupBackupVaultNotificationsDetails
    {
        private List<string> _backupVaultEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property BackupVaultEvents. 
        /// <para>
        /// An array of events that indicate the status of jobs to back up resources to the backup
        /// vault. The following events are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BACKUP_JOB_STARTED | BACKUP_JOB_COMPLETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COPY_JOB_STARTED | COPY_JOB_SUCCESSFUL | COPY_JOB_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTORE_JOB_STARTED | RESTORE_JOB_COMPLETED | RECOVERY_POINT_MODIFIED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BACKUP_OBJECT_FAILED | S3_RESTORE_OBJECT_FAILED</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BackupVaultEvents
        {
            get { return this._backupVaultEvents; }
            set { this._backupVaultEvents = value; }
        }

        // Check to see if BackupVaultEvents property is set
        internal bool IsSetBackupVaultEvents()
        {
            return this._backupVaultEvents != null && (this._backupVaultEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the Amazon SNS topic for a
        /// backup vault's events. 
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}