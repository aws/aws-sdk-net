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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about a backup of an CloudHSM cluster. All backup objects contain
    /// the <c>BackupId</c>, <c>BackupState</c>, <c>ClusterId</c>, and <c>CreateTimestamp</c>
    /// parameters. Backups that were copied into a destination region additionally contain
    /// the <c>CopyTimestamp</c>, <c>SourceBackup</c>, <c>SourceCluster</c>, and <c>SourceRegion</c>
    /// parameters. A backup that is pending deletion will include the <c>DeleteTimestamp</c>
    /// parameter.
    /// </summary>
    public partial class Backup
    {
        /// <summary>
        /// Gets and sets the property BackupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup.
        /// </para>
        /// </summary>
        public string BackupArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupArn property is set.
        /// </summary>
        internal bool IsSetBackupArn() => this.BackupArn != null;

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The identifier (ID) of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupId { get; set; }

        /// <summary>
        /// Checks to see if the BackupId property is set.
        /// </summary>
        internal bool IsSetBackupId() => this.BackupId != null;

        /// <summary>
        /// Gets and sets the property BackupState. 
        /// <para>
        /// The state of the backup.
        /// </para>
        /// </summary>
        public BackupState BackupState { get; set; }

        /// <summary>
        /// Checks to see if the BackupState property is set.
        /// </summary>
        internal bool IsSetBackupState() => this.BackupState != null;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that was backed up.
        /// </para>
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property CopyTimestamp. 
        /// <para>
        /// The date and time when the backup was copied from a source backup.
        /// </para>
        /// </summary>
        public DateTime? CopyTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CopyTimestamp property is set.
        /// </summary>
        internal bool IsSetCopyTimestamp() => this.CopyTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when the backup was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteTimestamp. 
        /// <para>
        /// The date and time when the backup will be permanently deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTimestamp property is set.
        /// </summary>
        internal bool IsSetDeleteTimestamp() => this.DeleteTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The HSM type used to create the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string HsmType { get; set; }

        /// <summary>
        /// Checks to see if the HsmType property is set.
        /// </summary>
        internal bool IsSetHsmType() => this.HsmType != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the cluster that was backed up.
        /// </para>
        /// </summary>
        public ClusterMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NeverExpires. 
        /// <para>
        /// Specifies whether the service should exempt a backup from the retention policy for
        /// the cluster. <c>True</c> exempts a backup from the retention policy. <c>False</c>
        /// means the service applies the backup retention policy defined at the cluster.
        /// </para>
        /// </summary>
        public bool? NeverExpires { get; set; }

        /// <summary>
        /// Checks to see if the NeverExpires property is set.
        /// </summary>
        internal bool IsSetNeverExpires() => this.NeverExpires.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBackup. 
        /// <para>
        /// The identifier (ID) of the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceBackup { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackup property is set.
        /// </summary>
        internal bool IsSetSourceBackup() => this.SourceBackup != null;

        /// <summary>
        /// Gets and sets the property SourceCluster. 
        /// <para>
        /// The identifier (ID) of the cluster containing the source backup from which the new
        /// backup was copied.
        /// </para>
        /// </summary>
        public string SourceCluster { get; set; }

        /// <summary>
        /// Checks to see if the SourceCluster property is set.
        /// </summary>
        internal bool IsSetSourceCluster() => this.SourceCluster != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The AWS Region that contains the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags for the backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
