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
    /// Parameter information for key material export from Amazon Web Services Payment Cryptography
    /// using TR-31 or TR-34 or RSA wrap and unwrap key exchange method.
    /// </summary>
    public partial class ExportKeyMaterial
    {
        private ExportDiffieHellmanTr31KeyBlock _diffieHellmanTr31KeyBlock;
        private ExportKeyCryptogram _keyCryptogram;
        private ExportTr31KeyBlock _tr31KeyBlock;
        private ExportTr34KeyBlock _tr34KeyBlock;

        /// <summary>
        /// Gets and sets the property DiffieHellmanTr31KeyBlock. 
        /// <para>
        /// Key derivation parameter information for key material export using asymmetric ECDH
        /// key exchange method.
        /// </para>
        /// </summary>
        public ExportDiffieHellmanTr31KeyBlock DiffieHellmanTr31KeyBlock
        {
            get { return this._diffieHellmanTr31KeyBlock; }
            set { this._diffieHellmanTr31KeyBlock = value; }
        }

        // Check to see if DiffieHellmanTr31KeyBlock property is set
        internal bool IsSetDiffieHellmanTr31KeyBlock()
        {
            return this._diffieHellmanTr31KeyBlock != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCryptogram. 
        /// <para>
        /// Parameter information for key material export using asymmetric RSA wrap and unwrap
        /// key exchange method
        /// </para>
        /// </summary>
        public ExportKeyCryptogram KeyCryptogram
        {
            get { return this._keyCryptogram; }
            set { this._keyCryptogram = value; }
        }

        // Check to see if KeyCryptogram property is set
        internal bool IsSetKeyCryptogram()
        {
            return this._keyCryptogram != null;
        }

        /// <summary>
        /// Gets and sets the property Tr31KeyBlock. 
        /// <para>
        /// Parameter information for key material export using symmetric TR-31 key exchange method.
        /// </para>
        /// </summary>
        public ExportTr31KeyBlock Tr31KeyBlock
        {
            get { return this._tr31KeyBlock; }
            set { this._tr31KeyBlock = value; }
        }

        // Check to see if Tr31KeyBlock property is set
        internal bool IsSetTr31KeyBlock()
        {
            return this._tr31KeyBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Tr34KeyBlock. 
        /// <para>
        /// Parameter information for key material export using the asymmetric TR-34 key exchange
        /// method.
        /// </para>
        /// </summary>
        public ExportTr34KeyBlock Tr34KeyBlock
        {
            get { return this._tr34KeyBlock; }
            set { this._tr34KeyBlock = value; }
        }

        // Check to see if Tr34KeyBlock property is set
        internal bool IsSetTr34KeyBlock()
        {
            return this._tr34KeyBlock != null;
        }

    }
}