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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters that are required to perform encryption and decryption operations.
    /// </summary>
    public partial class EncryptionDecryptionAttributes
    {
        private AsymmetricEncryptionAttributes _asymmetric;
        private DukptEncryptionAttributes _dukpt;
        private EmvEncryptionAttributes _emv;
        private SymmetricEncryptionAttributes _symmetric;

        /// <summary>
        /// Gets and sets the property Asymmetric.
        /// </summary>
        public AsymmetricEncryptionAttributes Asymmetric
        {
            get { return this._asymmetric; }
            set { this._asymmetric = value; }
        }

        // Check to see if Asymmetric property is set
        internal bool IsSetAsymmetric()
        {
            return this._asymmetric != null;
        }

        /// <summary>
        /// Gets and sets the property Dukpt.
        /// </summary>
        public DukptEncryptionAttributes Dukpt
        {
            get { return this._dukpt; }
            set { this._dukpt = value; }
        }

        // Check to see if Dukpt property is set
        internal bool IsSetDukpt()
        {
            return this._dukpt != null;
        }

        /// <summary>
        /// Gets and sets the property Emv. 
        /// <para>
        /// Parameters for plaintext encryption using EMV keys.
        /// </para>
        /// </summary>
        public EmvEncryptionAttributes Emv
        {
            get { return this._emv; }
            set { this._emv = value; }
        }

        // Check to see if Emv property is set
        internal bool IsSetEmv()
        {
            return this._emv != null;
        }

        /// <summary>
        /// Gets and sets the property Symmetric. 
        /// <para>
        /// Parameters that are required to perform encryption and decryption using symmetric
        /// keys.
        /// </para>
        /// </summary>
        public SymmetricEncryptionAttributes Symmetric
        {
            get { return this._symmetric; }
            set { this._symmetric = value; }
        }

        // Check to see if Symmetric property is set
        internal bool IsSetSymmetric()
        {
            return this._symmetric != null;
        }

    }
}