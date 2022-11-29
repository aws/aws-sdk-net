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
    /// Use this structure to allow <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
    /// operations</a> in the grant only when the operation request includes the specified
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">encryption
    /// context</a>. 
    /// 
    ///  
    /// <para>
    /// KMS applies the grant constraints only to cryptographic operations that support an
    /// encryption context, that is, all cryptographic operations with a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#symmetric-cmks">symmetric
    /// KMS key</a>. Grant constraints are not applied to operations that do not support an
    /// encryption context, such as cryptographic operations with asymmetric KMS keys and
    /// management operations, such as <a>DescribeKey</a> or <a>RetireGrant</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// In a cryptographic operation, the encryption context in the decryption operation must
    /// be an exact, case-sensitive match for the keys and values in the encryption context
    /// of the encryption operation. Only the order of the pairs can vary.
    /// </para>
    ///  
    /// <para>
    /// However, in a grant constraint, the key in each key-value pair is not case sensitive,
    /// but the value is case sensitive.
    /// </para>
    ///  
    /// <para>
    /// To avoid confusion, do not use multiple encryption context pairs that differ only
    /// by case. To require a fully case-sensitive encryption context, use the <code>kms:EncryptionContext:</code>
    /// and <code>kms:EncryptionContextKeys</code> conditions in an IAM or key policy. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/policy-conditions.html#conditions-kms-encryption-context">kms:EncryptionContext:</a>
    /// in the <i> <i>Key Management Service Developer Guide</i> </i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GrantConstraints
    {
        private Dictionary<string, string> _encryptionContextEquals = new Dictionary<string, string>();
        private Dictionary<string, string> _encryptionContextSubset = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property EncryptionContextEquals. 
        /// <para>
        /// A list of key-value pairs that must match the encryption context in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operation</a> request. The grant allows the operation only when the encryption context
        /// in the request is the same as the encryption context specified in this constraint.
        /// </para>
        /// </summary>
        public Dictionary<string, string> EncryptionContextEquals
        {
            get { return this._encryptionContextEquals; }
            set { this._encryptionContextEquals = value; }
        }

        // Check to see if EncryptionContextEquals property is set
        internal bool IsSetEncryptionContextEquals()
        {
            return this._encryptionContextEquals != null && this._encryptionContextEquals.Count > 0; 
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
        /// </summary>
        public Dictionary<string, string> EncryptionContextSubset
        {
            get { return this._encryptionContextSubset; }
            set { this._encryptionContextSubset = value; }
        }

        // Check to see if EncryptionContextSubset property is set
        internal bool IsSetEncryptionContextSubset()
        {
            return this._encryptionContextSubset != null && this._encryptionContextSubset.Count > 0; 
        }

    }
}