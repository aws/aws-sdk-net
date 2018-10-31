/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecretVersionStage operation.
    /// Modifies the staging labels attached to a version of a secret. Staging labels are
    /// used to track a version as it progresses through the secret rotation process. You
    /// can attach a staging label to only one version of a secret at a time. If a staging
    /// label to be added is already attached to another version, then it is moved--removed
    /// from the other version first and then attached to this one. For more information about
    /// staging labels, see <a href="http://docs.aws.amazon.com/secretsmanager/latest/userguide/terms-concepts.html#term_staging-label">Staging
    /// Labels</a> in the <i>AWS Secrets Manager User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// The staging labels that you specify in the <code>VersionStage</code> parameter are
    /// added to the existing list of staging labels--they don't replace it.
    /// </para>
    ///  
    /// <para>
    /// You can move the <code>AWSCURRENT</code> staging label to this version by including
    /// it in this call.
    /// </para>
    ///  <note> 
    /// <para>
    /// Whenever you move <code>AWSCURRENT</code>, Secrets Manager automatically moves the
    /// label <code>AWSPREVIOUS</code> to the version that <code>AWSCURRENT</code> was removed
    /// from.
    /// </para>
    ///  </note> 
    /// <para>
    /// If this action results in the last label being removed from a version, then the version
    /// is considered to be 'deprecated' and can be deleted by Secrets Manager.
    /// </para>
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:UpdateSecretVersionStage
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To get the list of staging labels that are currently associated with a version of
    /// a secret, use <code> <a>DescribeSecret</a> </code> and examine the <code>SecretVersionsToStages</code>
    /// response value. 
    /// </para>
    ///  </li> </ul>
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
        /// (Optional) The secret version ID that you want to add the staging label to. If you
        /// want to remove a label from a version, then do not specify this parameter.
        /// </para>
        ///  
        /// <para>
        /// If the staging label is already attached to a different version of the secret, then
        /// you must also specify the <code>RemoveFromVersionId</code> parameter. 
        /// </para>
        /// </summary>
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
        /// Specifies the secret version ID of the version that the staging label is to be removed
        /// from. If the staging label you are trying to attach to one version is already attached
        /// to a different version, then you must include this parameter and specify the version
        /// that the label is to be removed from. If the label is attached and you either do not
        /// specify this parameter, or the version ID does not match, then the operation fails.
        /// </para>
        /// </summary>
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
        /// Specifies the secret with the version whose list of staging labels you want to modify.
        /// You can specify either the Amazon Resource Name (ARN) or the friendly name of the
        /// secret.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify an ARN, we generally recommend that you specify a complete ARN. You
        /// can specify a partial ARN too—for example, if you don’t include the final hyphen and
        /// six random characters that Secrets Manager adds at the end of the ARN when you created
        /// the secret. A partial ARN match can work as long as it uniquely matches only one secret.
        /// However, if your secret has a name that ends in a hyphen followed by six characters
        /// (before Secrets Manager adds the hyphen and six characters to the ARN) and you try
        /// to use that as a partial ARN, then those characters cause Secrets Manager to assume
        /// that you’re specifying a complete ARN. This confusion can cause unexpected results.
        /// To avoid this situation, we recommend that you don’t create secret names that end
        /// with a hyphen followed by six characters.
        /// </para>
        ///  </note>
        /// </summary>
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