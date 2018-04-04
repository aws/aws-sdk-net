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
    /// Container for the parameters to the CancelRotateSecret operation.
    /// Disables automatic scheduled rotation and cancels the rotation of a secret if one
    /// is currently in progress.
    /// 
    ///  
    /// <para>
    /// To re-enable scheduled rotation, call <a>RotateSecret</a> with <code>AutomaticallyRotateAfterDays</code>
    /// set to a value greater than 0. This will immediately rotate your secret and then enable
    /// the automatic schedule.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you cancel a rotation that is in progress, it can leave the <code>VersionStage</code>
    /// labels in an unexpected state. Depending on what step of the rotation was in progress,
    /// you might need to remove the staging label <code>AWSPENDING</code> from the partially
    /// created version, specified by the <code>SecretVersionId</code> response value. You
    /// should also evaluate the partially rotated new version to see if it should be deleted,
    /// which you can do by removing all staging labels from the new version's <code>VersionStage</code>
    /// field.
    /// </para>
    ///  </note> 
    /// <para>
    /// To successfully start a rotation, the staging label <code>AWSPENDING</code> must be
    /// in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Not be attached to any version at all
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Attached to the same version as the staging label <code>AWSCURRENT</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the staging label <code>AWSPENDING</code> is attached to a different version than
    /// the version with <code>AWSCURRENT</code> then the attempt to rotate fails.
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
    /// secretsmanager:CancelRotateSecret
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To configure rotation for a secret or to manually trigger a rotation, use <a>RotateSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get the rotation configuration details for a secret, use <a>DescribeSecret</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To list all of the currently available secrets, use <a>ListSecrets</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To list all of the versions currently associated with a secret, use <a>ListSecretVersionIds</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CancelRotateSecretRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// Specifies the secret for which you want to cancel a rotation request. You can specify
        /// either the Amazon Resource Name (ARN) or the friendly name of the secret.
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

    }
}