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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
        private string _backupArn;
        private string _backupId;
        private BackupState _backupState;
        private string _clusterId;
        private DateTime? _copyTimestamp;
        private DateTime? _createTimestamp;
        private DateTime? _deleteTimestamp;
        private string _hsmType;
        private ClusterMode _mode;
        private bool? _neverExpires;
        private string _sourceBackup;
        private string _sourceCluster;
        private string _sourceRegion;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BackupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup.
        /// </para>
        /// </summary>
        public string BackupArn
        {
            get { return this._backupArn; }
            set { this._backupArn = value; }
        }

        // Check to see if BackupArn property is set
        internal bool IsSetBackupArn()
        {
            return this._backupArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The identifier (ID) of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupState. 
        /// <para>
        /// The state of the backup.
        /// </para>
        /// </summary>
        public BackupState BackupState
        {
            get { return this._backupState; }
            set { this._backupState = value; }
        }

        // Check to see if BackupState property is set
        internal bool IsSetBackupState()
        {
            return this._backupState != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that was backed up.
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTimestamp. 
        /// <para>
        /// The date and time when the backup was copied from a source backup.
        /// </para>
        /// </summary>
        public DateTime? CopyTimestamp
        {
            get { return this._copyTimestamp; }
            set { this._copyTimestamp = value; }
        }

        // Check to see if CopyTimestamp property is set
        internal bool IsSetCopyTimestamp()
        {
            return this._copyTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when the backup was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp
        {
            get { return this._createTimestamp; }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteTimestamp. 
        /// <para>
        /// The date and time when the backup will be permanently deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteTimestamp
        {
            get { return this._deleteTimestamp; }
            set { this._deleteTimestamp = value; }
        }

        // Check to see if DeleteTimestamp property is set
        internal bool IsSetDeleteTimestamp()
        {
            return this._deleteTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HsmType. 
        /// <para>
        /// The HSM type used to create the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public string HsmType
        {
            get { return this._hsmType; }
            set { this._hsmType = value; }
        }

        // Check to see if HsmType property is set
        internal bool IsSetHsmType()
        {
            return this._hsmType != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the cluster that was backed up.
        /// </para>
        /// </summary>
        public ClusterMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property NeverExpires. 
        /// <para>
        /// Specifies whether the service should exempt a backup from the retention policy for
        /// the cluster. <c>True</c> exempts a backup from the retention policy. <c>False</c>
        /// means the service applies the backup retention policy defined at the cluster.
        /// </para>
        /// </summary>
        public bool? NeverExpires
        {
            get { return this._neverExpires; }
            set { this._neverExpires = value; }
        }

        // Check to see if NeverExpires property is set
        internal bool IsSetNeverExpires()
        {
            return this._neverExpires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceBackup. 
        /// <para>
        /// The identifier (ID) of the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceBackup
        {
            get { return this._sourceBackup; }
            set { this._sourceBackup = value; }
        }

        // Check to see if SourceBackup property is set
        internal bool IsSetSourceBackup()
        {
            return this._sourceBackup != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCluster. 
        /// <para>
        /// The identifier (ID) of the cluster containing the source backup from which the new
        /// backup was copied.
        /// </para>
        /// </summary>
        public string SourceCluster
        {
            get { return this._sourceCluster; }
            set { this._sourceCluster = value; }
        }

        // Check to see if SourceCluster property is set
        internal bool IsSetSourceCluster()
        {
            return this._sourceCluster != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The AWS Region that contains the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The list of tags for the backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}