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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters that are required to generate or verify Visa PVV (PIN Verification Value).
    /// </summary>
    public partial class VisaPinVerificationValue
    {
        private string _encryptedPinBlock;
        private int? _pinVerificationKeyIndex;

        /// <summary>
        /// Gets and sets the property EncryptedPinBlock. 
        /// <para>
        /// The encrypted PIN block data to verify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=32)]
        public string EncryptedPinBlock
        {
            get { return this._encryptedPinBlock; }
            set { this._encryptedPinBlock = value; }
        }

        // Check to see if EncryptedPinBlock property is set
        internal bool IsSetEncryptedPinBlock()
        {
            return this._encryptedPinBlock != null;
        }

        /// <summary>
        /// Gets and sets the property PinVerificationKeyIndex. 
        /// <para>
        /// The value for PIN verification index. It is used in the Visa PIN algorithm to calculate
        /// the PVV (PIN Verification Value).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=9)]
        public int PinVerificationKeyIndex
        {
            get { return this._pinVerificationKeyIndex.GetValueOrDefault(); }
            set { this._pinVerificationKeyIndex = value; }
        }

        // Check to see if PinVerificationKeyIndex property is set
        internal bool IsSetPinVerificationKeyIndex()
        {
            return this._pinVerificationKeyIndex.HasValue; 
        }

    }
}