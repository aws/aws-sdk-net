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
    /// Container for the parameters to the AssociateCrossAccountReplica operation. Links
    /// a primary secret in your account to a replica secret in a different Amazon Web Services
    /// account and starts replication to this replica. The replica secret must already exist
    /// in the other Amazon Web Services account. Create the replica with <a>CreateSecret</a>
    /// and set its <c>CrossAccountPrimaryARN</c> field set to this primary secret's ARN.
    /// When you call AssociateCrossAccountReplica, Secrets Manager calls AcceptCrossAccountReplication
    /// on the replica secret on your behalf. <para> The primary and replica secrets must
    /// be in the same Amazon Web Services Region and partition, and you must call this operation
    /// from the account that owns the primary secret. A primary secret can have at most one
    /// cross-account replica. This operation is idempotent, so you can call it again for
    /// the same replica to repair replication. If the association fails, Secrets Manager
    /// does not modify either the primary or replica secret. </para> <para> Secrets Manager
    /// generates a CloudTrail log entry when you call this action. Do not include sensitive
    /// information in request parameters because it might be logged. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>. </para> <para> <b>Required permissions:
    /// </b> <c>secretsmanager:AssociateCrossAccountReplica</c>, <c>secretsmanager:GetSecretValue</c>
    /// on the primary secret, and <c>secretsmanager:AcceptCrossAccountReplication</c> on
    /// the replica secret. You must also have <c>kms:Decrypt</c> permission for the Key Management
    /// Service (KMS) key that encrypts the primary secret, and <c>kms:Encrypt</c> permission
    /// for the Amazon Web Services KMS key that encrypts the replica secret. If you supply
    /// <c>ReplicationRoleARN</c>, you also need <c>iam:PassRole</c> for that role. For more
    /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. </para>
    /// </summary>
    public partial class AssociateCrossAccountReplicaRequest : AmazonSecretsManagerRequest
    {
        /// <summary>
        /// Gets and sets the property CrossAccountReplicaARN. 
        /// <para>
        /// The ARN of the replica secret in the other Amazon Web Services account. The replica
        /// secret must be in the same Region and partition as the primary secret. Additionally,
        /// the replica account owner must have created the replica secret as a cross-account
        /// replica of the primary secret. For more information see <a>CreateSecret</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CrossAccountReplicaARN { get; set; }

        /// <summary>
        /// Checks to see if the CrossAccountReplicaARN property is set.
        /// </summary>
        internal bool IsSetCrossAccountReplicaARN() => this.CrossAccountReplicaARN != null;

        /// <summary>
        /// Gets and sets the property ReplicaRestriction. 
        /// <para>
        /// Whether the replica account must belong to the same Amazon Web Services organization
        /// as the primary account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SameOrg</c>, which requires the replica account to be in the same organization
        /// as the primary account. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NoRestriction</c>, which allows the replica account to be in any organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReplicaRestrictionType ReplicaRestriction { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaRestriction property is set.
        /// </summary>
        internal bool IsSetReplicaRestriction() => this.ReplicaRestriction != null;

        /// <summary>
        /// Gets and sets the property ReplicationRoleARN. 
        /// <para>
        /// The ARN of an IAM role in the primary account that Secrets Manager assumes to perform
        /// replication. If you don't include this field, Secrets Manager replicates using the
        /// credentials of caller who updates the primary secret. For more information, see <a
        /// href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/cross-account-replicate-permissions.html">
        /// Cross-account replication permissions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ReplicationRoleARN { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationRoleARN property is set.
        /// </summary>
        internal bool IsSetReplicationRoleARN() => this.ReplicationRoleARN != null;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the primary secret in your account to replicate.
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
