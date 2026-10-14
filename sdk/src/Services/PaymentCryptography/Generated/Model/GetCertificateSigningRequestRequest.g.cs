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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetCertificateSigningRequest operation. Creates
    /// a certificate signing request (CSR) from a key pair.
    /// </summary>
    public partial class GetCertificateSigningRequestRequest : AmazonPaymentCryptographyRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateSubject. 
        /// <para>
        /// The metadata used to create the CSR.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CertificateSubjectType CertificateSubject { get; set; }

        /// <summary>
        /// Checks to see if the CertificateSubject property is set.
        /// </summary>
        internal bool IsSetCertificateSubject() => this.CertificateSubject != null;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// Asymmetric key used for generating the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string KeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKeyIdentifier() => this.KeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The cryptographic algorithm used to sign your CSR.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SigningAlgorithmType SigningAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithm() => this.SigningAlgorithm != null;
    }
}
