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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteKey operation.
    /// Deletes the key material and all metadata associated with Amazon Web Services Payment
    /// Cryptography key.
    /// 
    ///  
    /// <para>
    /// Key deletion is irreversible. After a key is deleted, you can't perform cryptographic
    /// operations using the key. For example, you can't decrypt data that was encrypted by
    /// a deleted Amazon Web Services Payment Cryptography key, and the data may become unrecoverable.
    /// Because key deletion is destructive, Amazon Web Services Payment Cryptography has
    /// a safety mechanism to prevent accidental deletion of a key. When you call this operation,
    /// Amazon Web Services Payment Cryptography disables the specified key but doesn't delete
    /// it until after a waiting period. The default waiting period is 7 days. To set a different
    /// waiting period, set <code>DeleteKeyInDays</code>. During the waiting period, the <code>KeyState</code>
    /// is <code>DELETE_PENDING</code>. After the key is deleted, the <code>KeyState</code>
    /// is <code>DELETE_COMPLETE</code>.
    /// </para>
    ///  
    /// <para>
    /// If you delete key material, you can use <a>ImportKey</a> to reimport the same key
    /// material into the Amazon Web Services Payment Cryptography key.
    /// </para>
    ///  
    /// <para>
    /// You should delete a key only when you are sure that you don't need to use it anymore
    /// and no other parties are utilizing this key. If you aren't sure, consider deactivating
    /// it instead by calling <a>StopKeyUsage</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>RestoreKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartKeyUsage</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopKeyUsage</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteKeyRequest : AmazonPaymentCryptographyRequest
    {
        private int? _deleteKeyInDays;
        private string _keyIdentifier;

        /// <summary>
        /// Gets and sets the property DeleteKeyInDays. 
        /// <para>
        /// The waiting period for key deletion. The default value is seven days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=180)]
        public int DeleteKeyInDays
        {
            get { return this._deleteKeyInDays.GetValueOrDefault(); }
            set { this._deleteKeyInDays = value; }
        }

        // Check to see if DeleteKeyInDays property is set
        internal bool IsSetDeleteKeyInDays()
        {
            return this._deleteKeyInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <code>KeyARN</code> of the key that is scheduled for deletion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string KeyIdentifier
        {
            get { return this._keyIdentifier; }
            set { this._keyIdentifier = value; }
        }

        // Check to see if KeyIdentifier property is set
        internal bool IsSetKeyIdentifier()
        {
            return this._keyIdentifier != null;
        }

    }
}