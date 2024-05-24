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
    /// Container for the parameters to the UpdateSecretVersionStage operation.
    /// Modifies the staging labels attached to a version of a secret. Secrets Manager uses
    /// staging labels to track a version as it progresses through the secret rotation process.
    /// Each staging label can be attached to only one version at a time. To add a staging
    /// label to a version when it is already attached to another version, Secrets Manager
    /// first removes it from the other version first and then attaches it to this one. For
    /// more information about versions and staging labels, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/getting-started.html#term_version">Concepts:
    /// Version</a>. 
    /// 
    ///  
    /// <para>
    /// The staging labels that you specify in the <c>VersionStage</c> parameter are added
    /// to the existing list of staging labels for the version. 
    /// </para>
    ///  
    /// <para>
    /// You can move the <c>AWSCURRENT</c> staging label to this version by including it in
    /// this call.
    /// </para>
    ///  <note> 
    /// <para>
    /// Whenever you move <c>AWSCURRENT</c>, Secrets Manager automatically moves the label
    /// <c>AWSPREVIOUS</c> to the version that <c>AWSCURRENT</c> was removed from.
    /// </para>
    ///  </note> 
    /// <para>
    /// If this action results in the last label being removed from a version, then the version
    /// is considered to be 'deprecated' and can be deleted by Secrets Manager.
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
    ///  <b>Required permissions: </b> <c>secretsmanager:UpdateSecretVersionStage</c>. For
    /// more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class UpdateSecretVersionStageRequest : AmazonSecretsManagerRequest
    {
        private string _moveToVersionId;
        private string _removeFromVersionId;
        private string _secretId;
        private string _versionStage;

        /// <summary>
        /// Gets and sets the property MoveToVersionId. 
        /// <para>
        /// The ID of the version to add the staging label to. To remove a label from a version,
        /// then do not specify this parameter.
        /// </para>
        ///  
        /// <para>
        /// If the staging label is already attached to a different version of the secret, then
        /// you must also specify the <c>RemoveFromVersionId</c> parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string MoveToVersionId
        {
            get { return this._moveToVersionId; }
            set { this._moveToVersionId = value; }
        }

        // Check to see if MoveToVersionId property is set
        internal bool IsSetMoveToVersionId()
        {
            return this._moveToVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveFromVersionId. 
        /// <para>
        /// The ID of the version that the staging label is to be removed from. If the staging
        /// label you are trying to attach to one version is already attached to a different version,
        /// then you must include this parameter and specify the version that the label is to
        /// be removed from. If the label is attached and you either do not specify this parameter,
        /// or the version ID does not match, then the operation fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string RemoveFromVersionId
        {
            get { return this._removeFromVersionId; }
            set { this._removeFromVersionId = value; }
        }

        // Check to see if RemoveFromVersionId property is set
        internal bool IsSetRemoveFromVersionId()
        {
            return this._removeFromVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or the name of the secret with the version and staging labelsto modify.
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

        /// <summary>
        /// Gets and sets the property VersionStage. 
        /// <para>
        /// The staging label to add to this version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VersionStage
        {
            get { return this._versionStage; }
            set { this._versionStage = value; }
        }

        // Check to see if VersionStage property is set
        internal bool IsSetVersionStage()
        {
            return this._versionStage != null;
        }

    }
}