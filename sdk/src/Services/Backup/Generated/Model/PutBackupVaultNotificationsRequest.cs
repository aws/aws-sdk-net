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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the PutBackupVaultNotifications operation.
    /// Turns on notifications on a backup vault for the specified topic and events.
    /// </summary>
    public partial class PutBackupVaultNotificationsRequest : AmazonBackupRequest
    {
        private List<string> _backupVaultEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _backupVaultName;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property BackupVaultEvents. 
        /// <para>
        /// An array of events that indicate the status of jobs to back up resources to the backup
        /// vault.
        /// </para>
        ///  
        /// <para>
        /// For common use cases and code samples, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/sns-notifications.html">Using
        /// Amazon SNS to track Backup events</a>.
        /// </para>
        ///  
        /// <para>
        /// The following events are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BACKUP_JOB_STARTED</c> | <c>BACKUP_JOB_COMPLETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COPY_JOB_STARTED</c> | <c>COPY_JOB_SUCCESSFUL</c> | <c>COPY_JOB_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTORE_JOB_STARTED</c> | <c>RESTORE_JOB_COMPLETED</c> | <c>RECOVERY_POINT_MODIFIED</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3_BACKUP_OBJECT_FAILED</c> | <c>S3_RESTORE_OBJECT_FAILED</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The list below includes both supported events and deprecated events that are no longer
        /// in use (for reference). Deprecated events do not return statuses or notifications.
        /// Refer to the list above for the supported events.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
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
        /// Gets and sets the property SNSTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that specifies the topic for a backup vault’s events;
        /// for example, <c>arn:aws:sns:us-west-2:111122223333:MyVaultTopic</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SNSTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SNSTopicArn property is set
        internal bool IsSetSNSTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}