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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the PutEncryptionConfig operation.
    /// Updates the encryption configuration for X-Ray data.
    /// </summary>
    public partial class PutEncryptionConfigRequest : AmazonXRayRequest
    {
        private string _keyId;
        private EncryptionType _type;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// An Amazon Web Services KMS key in one of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Alias</b> - The name of the key. For example, <c>alias/MyKey</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Key ID</b> - The KMS key ID of the key. For example, <c>ae4aa6d49-a4d8-9df9-a475-4ff6d7898456</c>.
        /// Amazon Web Services X-Ray does not support asymmetric KMS keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ARN</b> - The full Amazon Resource Name of the key ID or alias. For example, <c>arn:aws:kms:us-east-2:123456789012:key/ae4aa6d49-a4d8-9df9-a475-4ff6d7898456</c>.
        /// Use this format to specify a key in a different account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Omit this key if you set <c>Type</c> to <c>NONE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of encryption. Set to <c>KMS</c> to use your own key for encryption. Set
        /// to <c>NONE</c> for default encryption.
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