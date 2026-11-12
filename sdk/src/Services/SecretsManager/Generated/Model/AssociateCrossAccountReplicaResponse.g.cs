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
    /// This is the response object from the AssociateCrossAccountReplica operation.
    /// </summary>
    public partial class AssociateCrossAccountReplicaResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the primary secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property CrossAccountReplicaARN. 
        /// <para>
        /// The ARN of the replica secret in the other account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CrossAccountReplicaARN { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountReplicaARN property is set.
        /// </summary>
        internal bool IsSetCrossAccountReplicaARN() => this.CrossAccountReplicaARN != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The status of replication to the replica secret. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InSync</c>, which indicates that replication to the replica completed successfully
        /// and the replica is up to date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>, which indicates that replication to the replica did not succeed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c>, which indicates that Secrets Manager is replicating to the replica.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pending</c>, which indicates that replication has not yet started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Detached</c>, which indicates that primary secret is no longer linked to the replica
        /// secret.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusType ReplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null;
    }
}
