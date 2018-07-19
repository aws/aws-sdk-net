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
    /// Container for the parameters to the GetSecretValue operation.
    /// Retrieves the contents of the encrypted fields <code>SecretString</code> or <code>SecretBinary</code>
    /// from the specified version of a secret, whichever contains content.
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
    /// secretsmanager:GetSecretValue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// kms:Decrypt - required only if you use a customer-managed AWS KMS key to encrypt the
    /// secret. You do not need this permission to use the account's default AWS managed CMK
    /// for Secrets Manager.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create a new version of the secret with different encrypted information, use <a>PutSecretValue</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To retrieve the non-encrypted details for the secret, use <a>DescribeSecret</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetSecretValueRequest : AmazonSecretsManagerRequest
    {
        private string _secretId;
        private string _versionId;
        private string _versionStage;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// Specifies the secret containing the version that you want to retrieve. You can specify
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

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Specifies the unique identifier of the version of the secret that you want to retrieve.
        /// If you specify this parameter then don't specify <code>VersionStage</code>. If you
        /// don't specify either a <code>VersionStage</code> or <code>SecretVersionId</code> then
        /// the default is to perform the operation on the version with the <code>VersionStage</code>
        /// value of <code>AWSCURRENT</code>.
        /// </para>
        ///  
        /// <para>
        /// This value is typically a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value with 32 hexadecimal digits.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStage. 
        /// <para>
        /// Specifies the secret version that you want to retrieve by the staging label attached
        /// to the version.
        /// </para>
        ///  
        /// <para>
        /// Staging labels are used to keep track of different versions during the rotation process.
        /// If you use this parameter then don't specify <code>SecretVersionId</code>. If you
        /// don't specify either a <code>VersionStage</code> or <code>SecretVersionId</code>,
        /// then the default is to perform the operation on the version with the <code>VersionStage</code>
        /// value of <code>AWSCURRENT</code>.
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