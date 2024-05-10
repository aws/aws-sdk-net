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
    /// Container for the parameters to the MoveReplicationTask operation.
    /// Moves a replication task from its current replication instance to a different target
    /// replication instance using the specified parameters. The target replication instance
    /// must be created with the same or later DMS version as the current replication instance.
    /// </summary>
    public partial class MoveReplicationTaskRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _replicationTaskArn;
        private string _targetReplicationInstanceArn;

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task that you want to move.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TargetReplicationInstanceArn. 
        /// <para>
        /// The ARN of the replication instance where you want to move the task to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetReplicationInstanceArn
        {
            get { return this._targetReplicationInstanceArn; }
            set { this._targetReplicationInstanceArn = value; }
        }

        // Check to see if TargetReplicationInstanceArn property is set
        internal bool IsSetTargetReplicationInstanceArn()
        {
            return this._targetReplicationInstanceArn != null;
        }

    }
}