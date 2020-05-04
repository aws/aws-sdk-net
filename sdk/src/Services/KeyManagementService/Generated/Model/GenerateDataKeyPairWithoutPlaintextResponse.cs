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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the GenerateDataKeyPairWithoutPlaintext operation.
    /// </summary>
    public partial class GenerateDataKeyPairWithoutPlaintextResponse : AmazonWebServiceResponse
    {
        private string _keyId;
        private DataKeyPairSpec _keyPairSpec;
        private MemoryStream _privateKeyCiphertextBlob;
        private MemoryStream _publicKey;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Specifies the CMK that encrypted the private key in the data key pair. You must specify
        /// a symmetric CMK. You cannot use an asymmetric CMK. To get the type of your CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with <code>"alias/"</code>.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPairSpec. 
        /// <para>
        /// The type of data key pair that was generated.
        /// </para>
        /// </summary>
        public DataKeyPairSpec KeyPairSpec
        {
            get { return this._keyPairSpec; }
            set { this._keyPairSpec = value; }
        }

        // Check to see if KeyPairSpec property is set
        internal bool IsSetKeyPairSpec()
        {
            return this._keyPairSpec != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKeyCiphertextBlob. 
        /// <para>
        /// The encrypted copy of the private key. When you use the HTTP API or the AWS CLI, the
        /// value is Base64-encoded. Otherwise, it is not Base64-encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
        public MemoryStream PrivateKeyCiphertextBlob
        {
            get { return this._privateKeyCiphertextBlob; }
            set { this._privateKeyCiphertextBlob = value; }
        }

        // Check to see if PrivateKeyCiphertextBlob property is set
        internal bool IsSetPrivateKeyCiphertextBlob()
        {
            return this._privateKeyCiphertextBlob != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key (in plaintext).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public MemoryStream PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

    }
}