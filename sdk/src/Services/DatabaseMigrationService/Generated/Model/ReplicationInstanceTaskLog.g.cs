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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Contains metadata for a replication instance task log.
    /// </summary>
    public partial class ReplicationInstanceTaskLog
    {
        /// <summary>
        /// Gets and sets the property ReplicationInstanceTaskLogSize. 
        /// <para>
        /// The size, in bytes, of the replication task log.
        /// </para>
        /// </summary>
        public long? ReplicationInstanceTaskLogSize { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceTaskLogSize property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceTaskLogSize() => this.ReplicationInstanceTaskLogSize.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskArn() => this.ReplicationTaskArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskName. 
        /// <para>
        /// The name of the replication task.
        /// </para>
        /// </summary>
        public string ReplicationTaskName { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskName property is set.
        /// </summary>
        internal bool IsSetReplicationTaskName() => this.ReplicationTaskName != null;
    }
}
