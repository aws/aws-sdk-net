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
    /// Container for the parameters to the GetParametersForImport operation.
    /// Gets the import token and the wrapping key certificate in PEM format (base64 encoded)
    /// to initiate a TR-34 WrappedKeyBlock or a RSA WrappedKeyCryptogram import into Amazon
    /// Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// The wrapping key certificate wraps the key under import. The import token and wrapping
    /// key certificate must be in place and operational before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
    /// The import token expires in 30 days. You can use the same import token to import multiple
    /// keys into your service account.
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
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForExport.html">GetParametersForExport</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetParametersForImportRequest : AmazonPaymentCryptographyRequest
    {
        private KeyMaterialType _keyMaterialType;
        private KeyAlgorithm _wrappingKeyAlgorithm;

        /// <summary>
        /// Gets and sets the property KeyMaterialType. 
        /// <para>
        /// The method to use for key material import. Import token is only required for TR-34
        /// WrappedKeyBlock (<c>TR34_KEY_BLOCK</c>) and RSA WrappedKeyCryptogram (<c>KEY_CRYPTOGRAM</c>).
        /// </para>
        ///  
        /// <para>
        /// Import token is not required for TR-31, root public key cerificate or trusted public
        /// key certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyMaterialType KeyMaterialType
        {
            get { return this._keyMaterialType; }
            set { this._keyMaterialType = value; }
        }

        // Check to see if KeyMaterialType property is set
        internal bool IsSetKeyMaterialType()
        {
            return this._keyMaterialType != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyAlgorithm. 
        /// <para>
        /// The wrapping key algorithm to generate a wrapping key certificate. This certificate
        /// wraps the key under import.
        /// </para>
        ///  
        /// <para>
        /// At this time, <c>RSA_2048</c> is the allowed algorithm for TR-34 WrappedKeyBlock import.
        /// Additionally, <c>RSA_2048</c>, <c>RSA_3072</c>, <c>RSA_4096</c> are the allowed algorithms
        /// for RSA WrappedKeyCryptogram import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAlgorithm WrappingKeyAlgorithm
        {
            get { return this._wrappingKeyAlgorithm; }
            set { this._wrappingKeyAlgorithm = value; }
        }

        // Check to see if WrappingKeyAlgorithm property is set
        internal bool IsSetWrappingKeyAlgorithm()
        {
            return this._wrappingKeyAlgorithm != null;
        }

    }
}