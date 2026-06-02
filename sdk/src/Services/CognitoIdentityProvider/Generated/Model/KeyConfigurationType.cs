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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Specifies the key configuration for a user pool. Contains settings for encryption
    /// keys used to secure user pool data.
    /// </summary>
    public partial class KeyConfigurationType
    {
        private EncryptionKeyType _keyType;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The type of encryption key used for the user pool.
        /// </para>
        ///  <dl> <dt>AWS_OWNED_KEY</dt> <dd> 
        /// <para>
        /// A key owned by Amazon Web Services in Key Management Service.
        /// </para>
        ///  </dd> <dt>CUSTOMER_MANAGED_KEY</dt> <dd> 
        /// <para>
        /// A key managed by the customer in Key Management Service. You must use a multi-region
        /// key to enable multi-region replication for a user pool.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public EncryptionKeyType KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used for encryption. If not specified,
        /// Amazon Web Services managed keys are used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}