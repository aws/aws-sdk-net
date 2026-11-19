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
    /// Container for the parameters to the StopReplicationToReplica operation. Removes the
    /// link between a replica secret and its primary secret, and stops replication to the
    /// replica. You call this operation from the replica account or Region. Depending on
    /// the type of replica, the behavior is: <ul> <li> <para> <b>Cross-Region replica</b>:
    /// promotes the replica to a standalone primary secret in the replica Region. </para>
    /// </li> <li> <para> <b>Cross-account replica</b>: promotes the replica in your account
    /// to a standalone secret and stops replication from its primary secret in the other
    /// account. Secrets Manager updates the primary secret's replication status to <c>Detached</c>
    /// for this replica. </para> </li> </ul> <para> To stop cross-account replication from
    /// the primary account instead, use <a>DisassociateCrossAccountReplica</a>. </para> <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters because it might be logged. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>. </para> <para> <b>Required permissions:
    /// </b> <c>secretsmanager:StopReplicationToReplica</c>. For cross-account replica secrets,
    /// you must also have <c>secretsmanager:DeleteResourcePolicy</c> permissions. For more
    /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. </para>
    /// </summary>
    public partial class StopReplicationToReplicaRequest : AmazonSecretsManagerRequest
    {
        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the replica secret.
        /// </para>
        ///  
        /// <para>
        /// For a cross-region replica, the replica ARN is the same as the original primary secret
        /// ARN except that the Region is changed to the replica Region. For a cross-account replica,
        /// this is the ARN or name of the replica secret in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretId property is set.
        /// </summary>
        internal bool IsSetSecretId() => this.SecretId != null;
    }
}
