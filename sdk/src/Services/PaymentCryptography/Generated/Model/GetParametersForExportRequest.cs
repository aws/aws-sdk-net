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
    /// Container for the parameters to the GetParametersForExport operation.
    /// Gets the export token and the signing key certificate to initiate a TR-34 key export
    /// from Amazon Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// The signing key certificate signs the wrapped key under export within the TR-34 key
    /// payload. The export token and signing key certificate must be in place and operational
    /// before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>.
    /// The export token expires in 30 days. You can use the same export token to export multiple
    /// keys from your service account.
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
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetParametersForExportRequest : AmazonPaymentCryptographyRequest
    {
        private KeyMaterialType _keyMaterialType;
        private KeyAlgorithm _signingKeyAlgorithm;

        /// <summary>
        /// Gets and sets the property KeyMaterialType. 
        /// <para>
        /// The key block format type (for example, TR-34 or TR-31) to use during key material
        /// export. Export token is only required for a TR-34 key export, <c>TR34_KEY_BLOCK</c>.
        /// Export token is not required for TR-31 key export.
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
        /// Gets and sets the property SigningKeyAlgorithm. 
        /// <para>
        /// The signing key algorithm to generate a signing key certificate. This certificate
        /// signs the wrapped key under export within the TR-34 key block. <c>RSA_2048</c> is
        /// the only signing key algorithm allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAlgorithm SigningKeyAlgorithm
        {
            get { return this._signingKeyAlgorithm; }
            set { this._signingKeyAlgorithm = value; }
        }

        // Check to see if SigningKeyAlgorithm property is set
        internal bool IsSetSigningKeyAlgorithm()
        {
            return this._signingKeyAlgorithm != null;
        }

    }
}