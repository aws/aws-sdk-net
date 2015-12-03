/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomainName operation.
    /// Creates a new domain name.
    /// </summary>
    public partial class CreateDomainNameRequest : AmazonAPIGatewayRequest
    {
        private string _certificateBody;
        private string _certificateChain;
        private string _certificateName;
        private string _certificatePrivateKey;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// The body of the server certificate provided by your certificate authority.
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this._certificateBody; }
            set { this._certificateBody = value; }
        }

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this._certificateBody != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The intermediate certificates and optionally the root certificate, one after the other
        /// without any blank lines. If you include the root certificate, your certificate chain
        /// must start with intermediate certificates and end with the root certificate. Use the
        /// intermediate certificates that were provided by your certificate authority. Do not
        /// include any intermediaries that are not in the chain of trust path.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the certificate.
        /// </para>
        /// </summary>
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificatePrivateKey. 
        /// <para>
        /// Your certificate's private key.
        /// </para>
        /// </summary>
        public string CertificatePrivateKey
        {
            get { return this._certificatePrivateKey; }
            set { this._certificatePrivateKey = value; }
        }

        // Check to see if CertificatePrivateKey property is set
        internal bool IsSetCertificatePrivateKey()
        {
            return this._certificatePrivateKey != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the <a>DomainName</a> resource.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}