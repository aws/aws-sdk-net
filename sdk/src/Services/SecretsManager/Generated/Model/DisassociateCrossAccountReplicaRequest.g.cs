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
    /// Container for the parameters to the DisassociateCrossAccountReplica operation. Removes
    /// the link between a primary secret in your account and a cross-account replica secret,
    /// and stops replication to the replica secret. Call this operation on the primary secret.
    /// This action removes the replica association created by <a>AssociateCrossAccountReplica</a>.
    /// <para> Disassociating the replica from the primary does not delete the replica secret
    /// or convert the replica secret to a standalone secret. The replica secret remains in
    /// the other account and its replication status changes to <c>Detached</c>. Secrets Manager
    /// no longer sends updates from the primary secret to the replica secret after disassociation.
    /// To convert a detached replica into a standalone secret, call <a>StopReplicationToReplica</a>
    /// on the replica secret. </para> <para> You must disassociate a cross-account replica
    /// before you call <a>DeleteSecret</a> for the primary secret. The <a>DeleteSecret</a>
    /// call fails if any replicas are still associated with the primary secret. </para> <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters because it might be logged. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>. </para> <para> <b>Required permissions:
    /// </b> <c>secretsmanager:DisassociateCrossAccountReplica</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. </para>
    /// </summary>
    public partial class DisassociateCrossAccountReplicaRequest : AmazonSecretsManagerRequest
    {
        /// <summary>
        /// Gets and sets the property CrossAccountReplicaARN. 
        /// <para>
        /// The ARN of the cross-account replica secret to unlink from the primary secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CrossAccountReplicaARN { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountReplicaARN property is set.
        /// </summary>
        internal bool IsSetCrossAccountReplicaARN() => this.CrossAccountReplicaARN != null;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the primary secret in your account.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot.html#ARN_secretnamehyphen">Finding
        /// a secret from a partial ARN</a>.
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
