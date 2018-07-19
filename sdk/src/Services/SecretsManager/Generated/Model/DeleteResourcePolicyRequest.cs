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
    /// Container for the parameters to the DeleteResourcePolicy operation.
    /// Deletes the resource-based permission policy that's attached to the secret.
    /// 
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
    /// secretsmanager:DeleteResourcePolicy
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To attach a resource policy to a secret, use <a>PutResourcePolicy</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve the current resource-based policy that's attached to a secret, use <a>GetResourcePolicy</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To list all of the currently available secrets, use <a>ListSecrets</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// Specifies the secret that you want to delete the attached resource-based policy for.
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

    }
}