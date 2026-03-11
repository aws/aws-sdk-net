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
    /// The encryption configuration of your IAM Identity Center instance, including the key
    /// type, KMS key ARN, and current encryption status.
    /// </summary>
    public partial class EncryptionConfigurationDetails
    {
        private KmsKeyStatus _encryptionStatus;
        private string _encryptionStatusReason;
        private KmsKeyType _keyType;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property EncryptionStatus. 
        /// <para>
        /// The current status of encryption configuration.
        /// </para>
        /// </summary>
        public KmsKeyStatus EncryptionStatus
        {
            get { return this._encryptionStatus; }
            set { this._encryptionStatus = value; }
        }

        // Check to see if EncryptionStatus property is set
        internal bool IsSetEncryptionStatus()
        {
            return this._encryptionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionStatusReason. 
        /// <para>
        /// Provides additional context about the current encryption status. This field is particularly
        /// useful when the encryption status is UPDATE_FAILED. When encryption configuration
        /// update fails, this field contains information about the cause, which may include KMS
        /// key access issues, key not found errors, invalid key configuration, key in an invalid
        /// state, or a disabled key. 
        /// </para>
        /// </summary>
        public string EncryptionStatusReason
        {
            get { return this._encryptionStatusReason; }
            set { this._encryptionStatusReason = value; }
        }

        // Check to see if EncryptionStatusReason property is set
        internal bool IsSetEncryptionStatusReason()
        {
            return this._encryptionStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The type of KMS key used for encryption.
        /// </para>
        /// </summary>
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
        /// The ARN of the KMS key currently used to encrypt data in your IAM Identity Center
        /// instance. 
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