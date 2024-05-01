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
    /// Container for the parameters to the GetPublicKeyCertificate operation.
    /// Gets the public key certificate of the asymmetric key pair that exists within Amazon
    /// Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// Unlike the private key of an asymmetric key, which never leaves Amazon Web Services
    /// Payment Cryptography unencrypted, callers with <c>GetPublicKeyCertificate</c> permission
    /// can download the public key certificate of the asymmetric key. You can share the public
    /// key certificate to allow others to encrypt messages and verify signatures outside
    /// of Amazon Web Services Payment Cryptography
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    /// </summary>
    public partial class GetPublicKeyCertificateRequest : AmazonPaymentCryptographyRequest
    {
        private string _keyIdentifier;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the asymmetric key pair.
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