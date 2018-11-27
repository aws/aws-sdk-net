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
    /// Encrypts data on the server side with a new customer master key (CMK) without exposing
    /// the plaintext of the data on the client side. The data is first decrypted and then
    /// reencrypted. You can also use this operation to change the encryption context of a
    /// ciphertext. 
    /// 
    ///  
    /// <para>
    /// You can reencrypt data using CMKs in different AWS accounts.
    /// </para>
    ///  
    /// <para>
    /// Unlike other operations, <code>ReEncrypt</code> is authorized twice, once as <code>ReEncryptFrom</code>
    /// on the source CMK and once as <code>ReEncryptTo</code> on the destination CMK. We
    /// recommend that you include the <code>"kms:ReEncrypt*"</code> permission in your <a
    /// href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
    /// policies</a> to permit reencryption from or to the CMK. This permission is automatically
    /// included in the key policy when you create a CMK through the console, but you must
    /// include it manually when you create a CMK programmatically or when you set a key policy
    /// with the <a>PutKeyPolicy</a> operation.
    /// </para>
    ///  
    /// <para>
    /// The result of this operation varies with the key state of the CMK. For details, see
    /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
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
        /// Ciphertext of the data to reencrypt.
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
        /// Encryption context to use when the data is reencrypted.
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
        /// A unique identifier for the CMK that is used to reencrypt the data.
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with "alias/". To specify a CMK in a different
        /// AWS account, you must use the key ARN or alias ARN.
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
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>.
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