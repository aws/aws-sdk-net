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
        /// (Optional) The secret version ID that you want to add the staging labels to.
        /// </para>
        ///  
        /// <para>
        /// If any of the staging labels are already attached to a different version of the secret,
        /// then they are removed from that version before adding them to this version.
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
        /// (Optional) Specifies the secret version ID of the version that the staging labels
        /// are to be removed from.
        /// </para>
        ///  
        /// <para>
        /// If you want to move a label to a new version, you do not have to explicitly remove
        /// it with this parameter. Adding a label using the <code>MoveToVersionId</code> parameter
        /// automatically removes it from the old version. However, if you do include both the
        /// "MoveTo" and "RemoveFrom" parameters, then the move is successful only if the staging
        /// labels are actually present on the "RemoveFrom" version. If a staging label was on
        /// a different version than "RemoveFrom", then the request fails.
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
        /// The list of staging labels to add to this version.
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