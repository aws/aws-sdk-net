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
    /// Parameters that are used for Derived Unique Key Per Transaction (DUKPT) derivation
    /// algorithm.
    /// </summary>
    public partial class DukptAttributes
    {
        private DukptDerivationType _dukptDerivationType;
        private string _keySerialNumber;

        /// <summary>
        /// Gets and sets the property DukptDerivationType. 
        /// <para>
        /// The key type derived using DUKPT from a Base Derivation Key (BDK) and Key Serial Number
        /// (KSN). This must be less than or equal to the strength of the BDK. For example, you
        /// can't use <c>AES_128</c> as a derivation type for a BDK of <c>AES_128</c> or <c>TDES_2KEY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DukptDerivationType DukptDerivationType
        {
            get { return this._dukptDerivationType; }
            set { this._dukptDerivationType = value; }
        }

        // Check to see if DukptDerivationType property is set
        internal bool IsSetDukptDerivationType()
        {
            return this._dukptDerivationType != null;
        }

        /// <summary>
        /// Gets and sets the property KeySerialNumber. 
        /// <para>
        /// The unique identifier known as Key Serial Number (KSN) that comes from an encrypting
        /// device using DUKPT encryption method. The KSN is derived from the encrypting device
        /// unique identifier and an internal transaction counter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=24)]
        public string KeySerialNumber
        {
            get { return this._keySerialNumber; }
            set { this._keySerialNumber = value; }
        }

        // Check to see if KeySerialNumber property is set
        internal bool IsSetKeySerialNumber()
        {
            return this._keySerialNumber != null;
        }

    }
}