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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about a backup of an AWS CloudHSM cluster. All backup objects
    /// contain the <code>BackupId</code>, <code>BackupState</code>, <code>ClusterId</code>,
    /// and <code>CreateTimestamp</code> parameters. Backups that were copied into a destination
    /// region additionally contain the <code>CopyTimestamp</code>, <code>SourceBackup</code>,
    /// <code>SourceCluster</code>, and <code>SourceRegion</code> parameters. A backup that
    /// is pending deletion will include the <code>DeleteTimestamp</code> parameter.
    /// </summary>
    public partial class Backup
    {
        private string _backupId;
        private BackupState _backupState;
        private string _clusterId;
        private DateTime? _copyTimestamp;
        private DateTime? _createTimestamp;
        private DateTime? _deleteTimestamp;
        private bool? _neverExpires;
        private string _sourceBackup;
        private string _sourceCluster;
        private string _sourceRegion;
        private List<Tag> _tagList = new List<Tag>();

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
        public DateTime CopyTimestamp
        {
            get { return this._copyTimestamp.GetValueOrDefault(); }
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
        public DateTime CreateTimestamp
        {
            get { return this._createTimestamp.GetValueOrDefault(); }
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
        public DateTime DeleteTimestamp
        {
            get { return this._deleteTimestamp.GetValueOrDefault(); }
            set { this._deleteTimestamp = value; }
        }

        // Check to see if DeleteTimestamp property is set
        internal bool IsSetDeleteTimestamp()
        {
            return this._deleteTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NeverExpires. 
        /// <para>
        /// Specifies whether the service should exempt a backup from the retention policy for
        /// the cluster. <code>True</code> exempts a backup from the retention policy. <code>False</code>
        /// means the service applies the backup retention policy defined at the cluster.
        /// </para>
        /// </summary>
        public bool NeverExpires
        {
            get { return this._neverExpires.GetValueOrDefault(); }
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
            return this._tagList != null && this._tagList.Count > 0; 
        }

    }
}