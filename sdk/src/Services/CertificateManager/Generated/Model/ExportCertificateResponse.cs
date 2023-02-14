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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This is the response object from the ExportCertificate operation.
    /// </summary>
    public partial class ExportCertificateResponse : AmazonWebServiceResponse
    {
        private string _certificate;
        private string _certificateChain;
        private string _privateKey;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The base64 PEM-encoded certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The base64 PEM-encoded certificate chain. This does not include the certificate that
        /// you are exporting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2097152)]
        public string CertificateChain
        {
            get { return this._certificateChain; }
            set { this._certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this._certificateChain != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The encrypted private key associated with the public key in the certificate. The key
        /// is output in PKCS #8 format and is base64 PEM-encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=524288)]
        public string PrivateKey
        {
            get { return this._privateKey; }
            set { this._privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

    }
}