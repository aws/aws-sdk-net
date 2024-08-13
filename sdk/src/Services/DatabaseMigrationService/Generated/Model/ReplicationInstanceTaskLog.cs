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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Contains metadata for a replication instance task log.
    /// </summary>
    public partial class ReplicationInstanceTaskLog
    {
        private long? _replicationInstanceTaskLogSize;
        private string _replicationTaskArn;
        private string _replicationTaskName;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceTaskLogSize. 
        /// <para>
        /// The size, in bytes, of the replication task log.
        /// </para>
        /// </summary>
        public long? ReplicationInstanceTaskLogSize
        {
            get { return this._replicationInstanceTaskLogSize; }
            set { this._replicationInstanceTaskLogSize = value; }
        }

        // Check to see if ReplicationInstanceTaskLogSize property is set
        internal bool IsSetReplicationInstanceTaskLogSize()
        {
            return this._replicationInstanceTaskLogSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task.
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
        /// Gets and sets the property ReplicationTaskName. 
        /// <para>
        /// The name of the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskName
        {
            get { return this._replicationTaskName; }
            set { this._replicationTaskName = value; }
        }

        // Check to see if ReplicationTaskName property is set
        internal bool IsSetReplicationTaskName()
        {
            return this._replicationTaskName != null;
        }

    }
}