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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the PutBackupVaultNotifications operation. Turns on
    /// notifications on a backup vault for the specified topic and events.
    /// </summary>
    public partial class PutBackupVaultNotificationsRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property BackupVaultEvents. 
        /// <para>
        /// An array of events that indicate the status of jobs to back up resources to the backup
        /// vault. For the list of supported events, common use cases, and code samples, see <a
        /// href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-notifications.html">Notification
        /// options with Backup</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> BackupVaultEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BackupVaultEvents property is set.
        /// </summary>
        internal bool IsSetBackupVaultEvents() => this.BackupVaultEvents != null && (this.BackupVaultEvents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property SNSTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that specifies the topic for a backup vault’s events;
        /// for example, <c>arn:aws:sns:us-west-2:111122223333:MyVaultTopic</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SNSTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SNSTopicArn property is set.
        /// </summary>
        internal bool IsSetSNSTopicArn() => this.SNSTopicArn != null;
    }
}
