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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Amazon Keyspaces encrypts and decrypts the table data at rest transparently and integrates
    /// with Key Management Service for storing and managing the encryption key. You can choose
    /// one of the following KMS keys (KMS keys):
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Amazon Web Services owned key - This is the default encryption type. The key is owned
    /// by Amazon Keyspaces (no additional charge). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Customer managed key - This key is stored in your account and is created, owned, and
    /// managed by you. You have full control over the customer managed key (KMS charges apply).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about encryption at rest in Amazon Keyspaces, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html">Encryption
    /// at rest</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about KMS, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html">KMS
    /// management service concepts</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class EncryptionSpecification
    {
        private string _kmsKeyIdentifier;
        private EncryptionType _type;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key, for example <code>kms_key_identifier:ARN</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5096)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The encryption option specified for the table. You can choose one of the following
        /// KMS keys (KMS keys):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>type:AWS_OWNED_KMS_KEY</code> - This key is owned by Amazon Keyspaces. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type:CUSTOMER_MANAGED_KMS_KEY</code> - This key is stored in your account and
        /// is created, owned, and managed by you. This option requires the <code>kms_key_identifier</code>
        /// of the KMS key in Amazon Resource Name (ARN) format as input. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <code>type:AWS_OWNED_KMS_KEY</code>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html">Encryption
        /// at rest</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}