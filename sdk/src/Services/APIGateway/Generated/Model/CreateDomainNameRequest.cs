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
        private string _certificateArn;
        private string _certificateBody;
        private string _certificateChain;
        private string _certificateName;
        private string _certificatePrivateKey;
        private string _domainName;
        private EndpointConfiguration _endpointConfiguration;
        private string _regionalCertificateArn;
        private string _regionalCertificateName;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The reference to an AWS-managed certificate that will be used by edge-optimized endpoint
        /// for this domain name. AWS Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// [Deprecated] The body of the server certificate that will be used by edge-optimized
        /// endpoint for this domain name provided by your certificate authority.
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
        /// [Deprecated] The intermediate certificates and optionally the root certificate, one
        /// after the other without any blank lines, used by an edge-optimized endpoint for this
        /// domain name. If you include the root certificate, your certificate chain must start
        /// with intermediate certificates and end with the root certificate. Use the intermediate
        /// certificates that were provided by your certificate authority. Do not include any
        /// intermediaries that are not in the chain of trust path.
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
        /// The user-friendly name of the certificate that will be used by edge-optimized endpoint
        /// for this domain name.
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
        /// [Deprecated] Your edge-optimized endpoint's domain name certificate's private key.
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
        /// [Required] The name of the <a>DomainName</a> resource.
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

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration of this <a>DomainName</a> showing the endpoint types of
        /// the domain name. 
        /// </para>
        /// </summary>
        public EndpointConfiguration EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalCertificateArn. 
        /// <para>
        /// The reference to an AWS-managed certificate that will be used by regional endpoint
        /// for this domain name. AWS Certificate Manager is the only supported source.
        /// </para>
        /// </summary>
        public string RegionalCertificateArn
        {
            get { return this._regionalCertificateArn; }
            set { this._regionalCertificateArn = value; }
        }

        // Check to see if RegionalCertificateArn property is set
        internal bool IsSetRegionalCertificateArn()
        {
            return this._regionalCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalCertificateName. 
        /// <para>
        /// The user-friendly name of the certificate that will be used by regional endpoint for
        /// this domain name.
        /// </para>
        /// </summary>
        public string RegionalCertificateName
        {
            get { return this._regionalCertificateName; }
            set { this._regionalCertificateName = value; }
        }

        // Check to see if RegionalCertificateName property is set
        internal bool IsSetRegionalCertificateName()
        {
            return this._regionalCertificateName != null;
        }

    }
}