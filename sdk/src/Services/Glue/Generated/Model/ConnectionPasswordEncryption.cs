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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The data structure used by the Data Catalog to encrypt the password as part of <c>CreateConnection</c>
    /// or <c>UpdateConnection</c> and store it in the <c>ENCRYPTED_PASSWORD</c> field in
    /// the connection properties. You can enable catalog encryption or only password encryption.
    /// 
    ///  
    /// <para>
    /// When a <c>CreationConnection</c> request arrives containing a password, the Data Catalog
    /// first encrypts the password using your KMS key. It then encrypts the whole connection
    /// object again if catalog encryption is also enabled.
    /// </para>
    ///  
    /// <para>
    /// This encryption requires that you set KMS key permissions to enable or restrict access
    /// on the password key according to your security requirements. For example, you might
    /// want only administrators to have decrypt permission on the password key.
    /// </para>
    /// </summary>
    public partial class ConnectionPasswordEncryption
    {
        private string _awsKmsKeyId;
        private bool? _returnConnectionPasswordEncrypted;

        /// <summary>
        /// Gets and sets the property AwsKmsKeyId. 
        /// <para>
        /// An KMS key that is used to encrypt the connection password. 
        /// </para>
        ///  
        /// <para>
        /// If connection password protection is enabled, the caller of <c>CreateConnection</c>
        /// and <c>UpdateConnection</c> needs at least <c>kms:Encrypt</c> permission on the specified
        /// KMS key, to encrypt passwords before storing them in the Data Catalog. 
        /// </para>
        ///  
        /// <para>
        /// You can set the decrypt permission to enable or restrict access on the password key
        /// according to your security requirements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// When the <c>ReturnConnectionPasswordEncrypted</c> flag is set to "true", passwords
        /// remain encrypted in the responses of <c>GetConnection</c> and <c>GetConnections</c>.
        /// This encryption takes effect independently from catalog encryption. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ReturnConnectionPasswordEncrypted
        {
            get { return this._returnConnectionPasswordEncrypted; }
            set { this._returnConnectionPasswordEncrypted = value; }
        }

        // Check to see if ReturnConnectionPasswordEncrypted property is set
        internal bool IsSetReturnConnectionPasswordEncrypted()
        {
            return this._returnConnectionPasswordEncrypted.HasValue; 
        }

    }
}