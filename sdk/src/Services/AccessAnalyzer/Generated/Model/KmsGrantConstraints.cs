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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Use this structure to propose allowing <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
    /// operations</a> in the grant only when the operation request includes the specified
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">encryption
    /// context</a>. You can specify only one type of encryption context. An empty map is
    /// treated as not specified. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GrantConstraints.html">GrantConstraints</a>.
    /// </summary>
    public partial class KmsGrantConstraints
    {
        private Dictionary<string, string> _encryptionContextEquals = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _encryptionContextSubset = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property EncryptionContextEquals. 
        /// <para>
        /// A list of key-value pairs that must match the encryption context in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operation</a> request. The grant allows the operation only when the encryption context
        /// in the request is the same as the encryption context specified in this constraint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EncryptionContextEquals
        {
            get { return this._encryptionContextEquals; }
            set { this._encryptionContextEquals = value; }
        }

        // Check to see if EncryptionContextEquals property is set
        internal bool IsSetEncryptionContextEquals()
        {
            return this._encryptionContextEquals != null && (this._encryptionContextEquals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EncryptionContextSubset. 
        /// <para>
        /// A list of key-value pairs that must be included in the encryption context of the <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operation</a> request. The grant allows the cryptographic operation only when the
        /// encryption context in the request includes the key-value pairs specified in this constraint,
        /// although it can include additional key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EncryptionContextSubset
        {
            get { return this._encryptionContextSubset; }
            set { this._encryptionContextSubset = value; }
        }

        // Check to see if EncryptionContextSubset property is set
        internal bool IsSetEncryptionContextSubset()
        {
            return this._encryptionContextSubset != null && (this._encryptionContextSubset.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}