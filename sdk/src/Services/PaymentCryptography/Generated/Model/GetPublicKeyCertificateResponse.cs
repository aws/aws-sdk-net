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
    /// This is the response object from the GetPublicKeyCertificate operation.
    /// </summary>
    public partial class GetPublicKeyCertificateResponse : AmazonWebServiceResponse
    {
        private string _keyCertificate;
        private string _keyCertificateChain;

        /// <summary>
        /// Gets and sets the property KeyCertificate. 
        /// <para>
        /// The public key component of the asymmetric key pair in a certificate PEM format (base64
        /// encoded). It is signed by the root certificate authority (CA). The certificate expires
        /// in 90 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=32768)]
        public string KeyCertificate
        {
            get { return this._keyCertificate; }
            set { this._keyCertificate = value; }
        }

        // Check to see if KeyCertificate property is set
        internal bool IsSetKeyCertificate()
        {
            return this._keyCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCertificateChain. 
        /// <para>
        /// The root certificate authority (CA) that signed the public key certificate in PEM
        /// format (base64 encoded) of the asymmetric key pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=32768)]
        public string KeyCertificateChain
        {
            get { return this._keyCertificateChain; }
            set { this._keyCertificateChain = value; }
        }

        // Check to see if KeyCertificateChain property is set
        internal bool IsSetKeyCertificateChain()
        {
            return this._keyCertificateChain != null;
        }

    }
}