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
    /// The shared information used when deriving a key using ECDH.
    /// </summary>
    public partial class DiffieHellmanDerivationData
    {
        private string _sharedInformation;

        /// <summary>
        /// Gets and sets the property SharedInformation. 
        /// <para>
        /// A string containing information that binds the ECDH derived key to the two parties
        /// involved or to the context of the key.
        /// </para>
        ///  
        /// <para>
        /// It may include details like identities of the two parties deriving the key, context
        /// of the operation, session IDs, and optionally a nonce. It must not contain zero bytes.
        /// It is not recommended to reuse shared information for multiple ECDH key derivations,
        /// as it could result in derived key material being the same across different derivations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2048)]
        public string SharedInformation
        {
            get { return this._sharedInformation; }
            set { this._sharedInformation = value; }
        }

        // Check to see if SharedInformation property is set
        internal bool IsSetSharedInformation()
        {
            return this._sharedInformation != null;
        }

    }
}