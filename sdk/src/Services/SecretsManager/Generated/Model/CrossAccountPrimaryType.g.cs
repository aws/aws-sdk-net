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
    /// Contains information about the primary secret that a cross-account replica secret
    /// replicates from, including its ARN and replication status. This information is only
    /// available for cross-account replica secrets.
    /// </summary>
    public partial class CrossAccountPrimaryType
    {
        /// <summary>
        /// Gets and sets the property PrimarySecretARN. 
        /// <para>
        /// The ARN of the primary secret replicating into this replica secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PrimarySecretARN { get; set; }

        /// <summary>
        /// Checks to see if the PrimarySecretARN property is set.
        /// </summary>
        internal bool IsSetPrimarySecretARN() => this.PrimarySecretARN != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The status of replication from the primary secret to this replica. The status can
        /// be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InSync</c>: Replication to the replica secret is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: Replication to the replica secret was unable to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c>: Replication to the replica secret has started but is not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pending</c>: Replication has not yet started for the replica secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Detached</c>: Replication to the replica secret was stopped by the primary.
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
