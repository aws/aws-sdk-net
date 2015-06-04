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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ReEncrypt operation.
    /// Encrypts data on the server side with a new customer master key without exposing the
    /// plaintext of the data on the client side. The data is first decrypted and then encrypted.
    /// This operation can also be used to change the encryption context of a ciphertext.
    /// 
    /// 
    ///  
    /// <para>
    /// Unlike other actions, <code>ReEncrypt</code> is authorized twice - once as <code>ReEncryptFrom</code>
    /// on the source key and once as <code>ReEncryptTo</code> on the destination key. We
    /// therefore recommend that you include the <code>"action":"kms:ReEncrypt*"</code> statement
    /// in your key policies to permit re-encryption from or to the key. The statement is
    /// included automatically when you authorize use of the key through the console but must
    /// be included manually when you set a policy by using the <a>PutKeyPolicy</a> function.
    /// 
    /// </para>
    /// </summary>
    public partial class ReEncryptRequest : AmazonKeyManagementServiceRequest
    {
        private MemoryStream _ciphertextBlob;
        private Dictionary<string, string> _destinationEncryptionContext = new Dictionary<string, string>();
        private string _destinationKeyId;
        private List<string> _grantTokens = new List<string>();
        private Dictionary<string, string> _sourceEncryptionContext = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// Ciphertext of the data to re-encrypt.
        /// </para>
        /// </summary>
        public MemoryStream CiphertextBlob
        {
            get { return this._ciphertextBlob; }
            set { this._ciphertextBlob = value; }
        }

        // Check to see if CiphertextBlob property is set
        internal bool IsSetCiphertextBlob()
        {
            return this._ciphertextBlob != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEncryptionContext. 
        /// <para>
        /// Encryption context to be used when the data is re-encrypted.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DestinationEncryptionContext
        {
            get { return this._destinationEncryptionContext; }
            set { this._destinationEncryptionContext = value; }
        }

        // Check to see if DestinationEncryptionContext property is set
        internal bool IsSetDestinationEncryptionContext()
        {
            return this._destinationEncryptionContext != null && this._destinationEncryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DestinationKeyId. 
        /// <para>
        /// A unique identifier for the customer master key used to re-encrypt the data. This
        /// value can be a globally unique identifier, a fully specified ARN to either an alias
        /// or a key, or an alias name prefixed by "alias/". <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li>
        /// <li>Alias ARN Example - arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</li>
        /// <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> <li>Alias
        /// Name Example - alias/MyAliasName</li> </ul> 
        /// </para>
        /// </summary>
        public string DestinationKeyId
        {
            get { return this._destinationKeyId; }
            set { this._destinationKeyId = value; }
        }

        // Check to see if DestinationKeyId property is set
        internal bool IsSetDestinationKeyId()
        {
            return this._destinationKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a>. 
        /// </para>
        /// </summary>
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceEncryptionContext. 
        /// <para>
        /// Encryption context used to encrypt and decrypt the data specified in the <code>CiphertextBlob</code>
        /// parameter. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> SourceEncryptionContext
        {
            get { return this._sourceEncryptionContext; }
            set { this._sourceEncryptionContext = value; }
        }

        // Check to see if SourceEncryptionContext property is set
        internal bool IsSetSourceEncryptionContext()
        {
            return this._sourceEncryptionContext != null && this._sourceEncryptionContext.Count > 0; 
        }

    }
}