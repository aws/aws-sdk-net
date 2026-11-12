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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Information about a cross-account replica secret. This information is only available
    /// for cross-account primary secrets.
    /// </summary>
    public partial class CrossAccountReplicaEntry
    {
        /// <summary>
        /// Gets and sets the property ReplicaSecretARN. 
        /// <para>
        /// The ARN of the replica secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ReplicaSecretARN { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaSecretARN property is set.
        /// </summary>
        internal bool IsSetReplicaSecretARN() => this.ReplicaSecretARN != null;

        /// <summary>
        /// Gets and sets the property ReplicationRoleARN. 
        /// <para>
        /// The ARN of the IAM role that Secrets Manager assumes to replicate to this replica,
        /// if one was specified when the replica was associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ReplicationRoleARN { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationRoleARN property is set.
        /// </summary>
        internal bool IsSetReplicationRoleARN() => this.ReplicationRoleARN != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The status of replication from this primary secret. The status can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InSync</c>: Replication from the primary secret is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: Replication from the primary secret was unable to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c>: Replication from the primary secret has started but is not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Detached</c>: Replication from the primary secret was stopped by the replica.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusType ReplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that describes the replication status, if Secrets Manager has more information
        /// to provide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
