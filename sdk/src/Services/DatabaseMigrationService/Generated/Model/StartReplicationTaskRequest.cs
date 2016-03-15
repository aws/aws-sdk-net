/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartReplicationTask operation.
    /// Starts the replication task.
    /// 
    ///  <note/>
    /// </summary>
    public partial class StartReplicationTaskRequest : AmazonDatabaseMigrationServiceRequest
    {
        private DateTime? _cdcStartTime;
        private string _replicationTaskArn;
        private StartReplicationTaskTypeValue _startReplicationTaskType;

        /// <summary>
        /// Gets and sets the property CdcStartTime. 
        /// <para>
        /// The start time for the Change Data Capture (CDC) operation.
        /// </para>
        /// </summary>
        public DateTime CdcStartTime
        {
            get { return this._cdcStartTime.GetValueOrDefault(); }
            set { this._cdcStartTime = value; }
        }

        // Check to see if CdcStartTime property is set
        internal bool IsSetCdcStartTime()
        {
            return this._cdcStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the replication task to be started.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartReplicationTaskType. 
        /// <para>
        /// The type of replication task.
        /// </para>
        /// </summary>
        public StartReplicationTaskTypeValue StartReplicationTaskType
        {
            get { return this._startReplicationTaskType; }
            set { this._startReplicationTaskType = value; }
        }

        // Check to see if StartReplicationTaskType property is set
        internal bool IsSetStartReplicationTaskType()
        {
            return this._startReplicationTaskType != null;
        }

    }
}