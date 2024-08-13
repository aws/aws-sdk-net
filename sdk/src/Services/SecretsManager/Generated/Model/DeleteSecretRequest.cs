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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
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
    /// Container for the parameters to the DeleteSecret operation.
    /// Deletes a secret and all of its versions. You can specify a recovery window during
    /// which you can restore the secret. The minimum recovery window is 7 days. The default
    /// recovery window is 30 days. Secrets Manager attaches a <c>DeletionDate</c> stamp to
    /// the secret that specifies the end of the recovery window. At the end of the recovery
    /// window, Secrets Manager deletes the secret permanently.
    /// 
    ///  
    /// <para>
    /// You can't delete a primary secret that is replicated to other Regions. You must first
    /// delete the replicas using <a>RemoveRegionsFromReplication</a>, and then delete the
    /// primary secret. When you delete a replica, it is deleted immediately.
    /// </para>
    ///  
    /// <para>
    /// You can't directly delete a version of a secret. Instead, you remove all staging labels
    /// from the version using <a>UpdateSecretVersionStage</a>. This marks the version as
    /// deprecated, and then Secrets Manager can automatically delete the version in the background.
    /// </para>
    ///  
    /// <para>
    /// To determine whether an application still uses a secret, you can create an Amazon
    /// CloudWatch alarm to alert you to any attempts to access a secret during the recovery
    /// window. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/monitoring_cloudwatch_deleted-secrets.html">
    /// Monitor secrets scheduled for deletion</a>.
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager performs the permanent secret deletion at the end of the waiting period
    /// as a background task with low priority. There is no guarantee of a specific time after
    /// the recovery window for the permanent delete to occur.
    /// </para>
    ///  
    /// <para>
    /// At any time before recovery window ends, you can use <a>RestoreSecret</a> to remove
    /// the <c>DeletionDate</c> and cancel the deletion of the secret.
    /// </para>
    ///  
    /// <para>
    /// When a secret is scheduled for deletion, you cannot retrieve the secret value. You
    /// must first cancel the deletion with <a>RestoreSecret</a> and then you can retrieve
    /// the secret.
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager generates a CloudTrail log entry when you call this action. Do not
    /// include sensitive information in request parameters because it might be logged. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>secretsmanager:DeleteSecret</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class DeleteSecretRequest : AmazonSecretsManagerRequest
    {
        private bool? _forceDeleteWithoutRecovery;
        private long? _recoveryWindowInDays;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ForceDeleteWithoutRecovery. 
        /// <para>
        /// Specifies whether to delete the secret without any recovery window. You can't use
        /// both this parameter and <c>RecoveryWindowInDays</c> in the same call. If you don't
        /// use either, then by default Secrets Manager uses a 30 day recovery window.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager performs the actual deletion with an asynchronous background process,
        /// so there might be a short delay before the secret is permanently deleted. If you delete
        /// a secret and then immediately create a secret with the same name, use appropriate
        /// back off and retry logic.
        /// </para>
        ///  
        /// <para>
        /// If you forcibly delete an already deleted or nonexistent secret, the operation does
        /// not return <c>ResourceNotFoundException</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use this parameter with caution. This parameter causes the operation to skip the normal
        /// recovery window before the permanent deletion that Secrets Manager would normally
        /// impose with the <c>RecoveryWindowInDays</c> parameter. If you delete a secret with
        /// the <c>ForceDeleteWithoutRecovery</c> parameter, then you have no opportunity to recover
        /// the secret. You lose the secret permanently.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? ForceDeleteWithoutRecovery
        {
            get { return this._forceDeleteWithoutRecovery; }
            set { this._forceDeleteWithoutRecovery = value; }
        }

        // Check to see if ForceDeleteWithoutRecovery property is set
        internal bool IsSetForceDeleteWithoutRecovery()
        {
            return this._forceDeleteWithoutRecovery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryWindowInDays. 
        /// <para>
        /// The number of days from 7 to 30 that Secrets Manager waits before permanently deleting
        /// the secret. You can't use both this parameter and <c>ForceDeleteWithoutRecovery</c>
        /// in the same call. If you don't use either, then by default Secrets Manager uses a
        /// 30 day recovery window.
        /// </para>
        /// </summary>
        public long? RecoveryWindowInDays
        {
            get { return this._recoveryWindowInDays; }
            set { this._recoveryWindowInDays = value; }
        }

        // Check to see if RecoveryWindowInDays property is set
        internal bool IsSetRecoveryWindowInDays()
        {
            return this._recoveryWindowInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret to delete.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// See <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/troubleshoot.html#ARN_secretnamehyphen">Finding
        /// a secret from a partial ARN</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

    }
}