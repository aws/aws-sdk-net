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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that specifies the KMS key type and KMS key ARN used to encrypt data
    /// in your IAM Identity Center instance.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private KmsKeyType _keyType;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The type of KMS key used for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KmsKeyType KeyType
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
        /// The ARN of the KMS key used to encrypt data. Required when KeyType is CUSTOMER_MANAGED_KEY.
        /// Cannot be specified when KeyType is AWS_OWNED_KMS_KEY.
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