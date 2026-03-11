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
    /// The parameter information of the outgoing wrapped key block.
    /// </summary>
    public partial class WrappedWorkingKey
    {
        private string _keyCheckValue;
        private string _wrappedKeyMaterial;
        private WrappedKeyMaterialFormat _wrappedKeyMaterialFormat;

        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the key contained within the outgoing TR31WrappedKeyBlock.
        /// </para>
        ///  
        /// <para>
        ///  The KCV is used to check if all parties holding a given key have the same key or
        /// to detect that a key has changed. For more information on KCV, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/terminology.html#terms.kcv">KCV</a>
        /// in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string KeyCheckValue
        {
            get { return this._keyCheckValue; }
            set { this._keyCheckValue = value; }
        }

        // Check to see if KeyCheckValue property is set
        internal bool IsSetKeyCheckValue()
        {
            return this._keyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterial. 
        /// <para>
        /// The wrapped key block of the outgoing transaction key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=32, Max=16384)]
        public string WrappedKeyMaterial
        {
            get { return this._wrappedKeyMaterial; }
            set { this._wrappedKeyMaterial = value; }
        }

        // Check to see if WrappedKeyMaterial property is set
        internal bool IsSetWrappedKeyMaterial()
        {
            return this._wrappedKeyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterialFormat. 
        /// <para>
        /// The key block format of the wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WrappedKeyMaterialFormat WrappedKeyMaterialFormat
        {
            get { return this._wrappedKeyMaterialFormat; }
            set { this._wrappedKeyMaterialFormat = value; }
        }

        // Check to see if WrappedKeyMaterialFormat property is set
        internal bool IsSetWrappedKeyMaterialFormat()
        {
            return this._wrappedKeyMaterialFormat != null;
        }

    }
}