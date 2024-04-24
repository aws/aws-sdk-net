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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Parameter information for IPEK generation during export.
    /// </summary>
    public partial class ExportDukptInitialKey
    {
        private string _keySerialNumber;

        /// <summary>
        /// Gets and sets the property KeySerialNumber. 
        /// <para>
        /// The KSN for IPEK generation using DUKPT. 
        /// </para>
        ///  
        /// <para>
        /// KSN must be padded before sending to Amazon Web Services Payment Cryptography. KSN
        /// hex length should be 20 for a TDES_2KEY key or 24 for an AES key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=24)]
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