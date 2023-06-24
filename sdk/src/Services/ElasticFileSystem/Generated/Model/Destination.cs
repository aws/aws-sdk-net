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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Describes the destination file system in the replication configuration.
    /// </summary>
    public partial class Destination
    {
        private string _fileSystemId;
        private DateTime? _lastReplicatedTimestamp;
        private string _region;
        private ReplicationStatus _status;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the destination Amazon EFS file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property LastReplicatedTimestamp. 
        /// <para>
        /// The time when the most recent sync was successfully completed on the destination file
        /// system. Any changes to data on the source file system that occurred before this time
        /// have been successfully replicated to the destination file system. Any changes that
        /// occurred after this time might not be fully replicated.
        /// </para>
        /// </summary>
        public DateTime LastReplicatedTimestamp
        {
            get { return this._lastReplicatedTimestamp.GetValueOrDefault(); }
            set { this._lastReplicatedTimestamp = value; }
        }

        // Check to see if LastReplicatedTimestamp property is set
        internal bool IsSetLastReplicatedTimestamp()
        {
            return this._lastReplicatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which the destination file system is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the status of the destination Amazon EFS file system.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>Paused</code> state occurs as a result of opting out of the source or destination
        /// Region after the replication configuration was created. To resume replication for
        /// the file system, you need to again opt in to the Amazon Web Services Region. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html#rande-manage-enable">Managing
        /// Amazon Web Services Regions</a> in the <i>Amazon Web Services General Reference Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Error</code> state occurs when either the source or the destination file
        /// system (or both) is in a failed state and is unrecoverable. For more information,
        /// see <a href="https://docs.aws.amazon.com/efs/latest/ug/awsbackup.html#restoring-backup-efsmonitoring-replication-status.html">Monitoring
        /// replication status</a> in the <i>Amazon EFS User Guide</i>. You must delete the replication
        /// configuration, and then restore the most recent backup of the failed file system (either
        /// the source or the destination) to a new file system.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}