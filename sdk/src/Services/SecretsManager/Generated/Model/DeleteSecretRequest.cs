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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSecret operation.
    /// Deletes an entire secret and all of its versions. You can optionally include a recovery
    /// window during which you can restore the secret. If you don't specify a recovery window
    /// value, the operation defaults to 30 days. Secrets Manager attaches a <code>DeletionDate</code>
    /// stamp to the secret that specifies the end of the recovery window. At the end of the
    /// recovery window, Secrets Manager deletes the secret permanently.
    /// 
    ///  
    /// <para>
    /// At any time before recovery window ends, you can use <a>RestoreSecret</a> to remove
    /// the <code>DeletionDate</code> and cancel the deletion of the secret.
    /// </para>
    ///  
    /// <para>
    /// You cannot access the encrypted secret information in any secret that is scheduled
    /// for deletion. If you need to access that information, you must cancel the deletion
    /// with <a>RestoreSecret</a> and then retrieve the information.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// There is no explicit operation to delete a version of a secret. Instead, remove all
    /// staging labels from the <code>VersionStage</code> field of a version. That marks the
    /// version as deprecated and allows Secrets Manager to delete it as needed. Versions
    /// that do not have any staging labels do not show up in <a>ListSecretVersionIds</a>
    /// unless you specify <code>IncludeDeprecated</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The permanent secret deletion at the end of the waiting period is performed as a background
    /// task with low priority. There is no guarantee of a specific time after the recovery
    /// window for the actual delete operation to occur.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// secretsmanager:DeleteSecret
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create a secret, use <a>CreateSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To cancel deletion of a version of a secret before the recovery window has expired,
    /// use <a>RestoreSecret</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteSecretRequest : AmazonSecretsManagerRequest
    {
        private bool? _forceDeleteWithoutRecovery;
        private long? _recoveryWindowInDays;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ForceDeleteWithoutRecovery. 
        /// <para>
        /// (Optional) Specifies that the secret is to be deleted without any recovery window.
        /// You can't use both this parameter and the <code>RecoveryWindowInDays</code> parameter
        /// in the same API call.
        /// </para>
        ///  
        /// <para>
        /// An asynchronous background process performs the actual deletion, so there can be a
        /// short delay before the operation completes. If you write code to delete and then immediately
        /// recreate a secret with the same name, ensure that your code includes appropriate back
        /// off and retry logic.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use this parameter with caution. This parameter causes the operation to skip the normal
        /// waiting period before the permanent deletion that AWS would normally impose with the
        /// <code>RecoveryWindowInDays</code> parameter. If you delete a secret with the <code>ForceDeleteWithouRecovery</code>
        /// parameter, then you have no opportunity to recover the secret. It is permanently lost.
        /// </para>
        ///  </important>
        /// </summary>
        public bool ForceDeleteWithoutRecovery
        {
            get { return this._forceDeleteWithoutRecovery.GetValueOrDefault(); }
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
        /// (Optional) Specifies the number of days that Secrets Manager waits before it can delete
        /// the secret. You can't use both this parameter and the <code>ForceDeleteWithoutRecovery</code>
        /// parameter in the same API call.
        /// </para>
        ///  
        /// <para>
        /// This value can range from 7 to 30 days. The default value is 30.
        /// </para>
        /// </summary>
        public long RecoveryWindowInDays
        {
            get { return this._recoveryWindowInDays.GetValueOrDefault(); }
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
        /// Specifies the secret that you want to delete. You can specify either the Amazon Resource
        /// Name (ARN) or the friendly name of the secret.
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
        /// To avoid this situation, we recommend that you don’t create secret names ending with
        /// a hyphen followed by six characters.
        /// </para>
        ///  
        /// <para>
        /// If you specify an incomplete ARN without the random suffix, and instead provide the
        /// 'friendly name', you <i>must</i> not include the random suffix. If you do include
        /// the random suffix added by Secrets Manager, you receive either a <i>ResourceNotFoundException</i>
        /// or an <i>AccessDeniedException</i> error, depending on your permissions.
        /// </para>
        ///  </note>
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