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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The data structure used by the Data Catalog to encrypt the password as part of <code>CreateConnection</code>
    /// or <code>UpdateConnection</code> and store it in the <code>ENCRYPTED_PASSWORD</code>
    /// field in the connection properties. You can enable catalog encryption or only password
    /// encryption.
    /// 
    ///  
    /// <para>
    /// When a <code>CreationConnection</code> request arrives containing a password, the
    /// Data Catalog first encrypts the password using your AWS KMS key. It then encrypts
    /// the whole connection object again if catalog encryption is also enabled.
    /// </para>
    ///  
    /// <para>
    /// This encryption requires that you set AWS KMS key permissions to enable or restrict
    /// access on the password key according to your security requirements. For example, you
    /// might want only admin users to have decrypt permission on the password key.
    /// </para>
    /// </summary>
    public partial class ConnectionPasswordEncryption
    {
        private string _awsKmsKeyId;
        private bool? _returnConnectionPasswordEncrypted;

        /// <summary>
        /// Gets and sets the property AwsKmsKeyId. 
        /// <para>
        /// An AWS KMS key that is used to encrypt the connection password. 
        /// </para>
        ///  
        /// <para>
        /// If connection password protection is enabled, the caller of <code>CreateConnection</code>
        /// and <code>UpdateConnection</code> needs at least <code>kms:Encrypt</code> permission
        /// on the specified AWS KMS key, to encrypt passwords before storing them in the Data
        /// Catalog. 
        /// </para>
        ///  
        /// <para>
        /// You can set the decrypt permission to enable or restrict access on the password key
        /// according to your security requirements.
        /// </para>
        /// </summary>
        public string AwsKmsKeyId
        {
            get { return this._awsKmsKeyId; }
            set { this._awsKmsKeyId = value; }
        }

        // Check to see if AwsKmsKeyId property is set
        internal bool IsSetAwsKmsKeyId()
        {
            return this._awsKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnConnectionPasswordEncrypted. 
        /// <para>
        /// When the <code>ReturnConnectionPasswordEncrypted</code> flag is set to "true", passwords
        /// remain encrypted in the responses of <code>GetConnection</code> and <code>GetConnections</code>.
        /// This encryption takes effect independently from catalog encryption. 
        /// </para>
        /// </summary>
        public bool ReturnConnectionPasswordEncrypted
        {
            get { return this._returnConnectionPasswordEncrypted.GetValueOrDefault(); }
            set { this._returnConnectionPasswordEncrypted = value; }
        }

        // Check to see if ReturnConnectionPasswordEncrypted property is set
        internal bool IsSetReturnConnectionPasswordEncrypted()
        {
            return this._returnConnectionPasswordEncrypted.HasValue; 
        }

    }
}