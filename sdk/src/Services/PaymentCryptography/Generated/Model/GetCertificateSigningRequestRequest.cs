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
    /// Container for the parameters to the GetCertificateSigningRequest operation.
    /// Used to retrieve the public key for a keypair.
    /// </summary>
    public partial class GetCertificateSigningRequestRequest : AmazonPaymentCryptographyRequest
    {
        private CertificateSubjectType _certificateSubject;
        private string _keyIdentifier;
        private SigningAlgorithmType _signingAlgorithm;

        /// <summary>
        /// Gets and sets the property CertificateSubject. 
        /// <para>
        /// Certificate subject data
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateSubjectType CertificateSubject
        {
            get { return this._certificateSubject; }
            set { this._certificateSubject = value; }
        }

        // Check to see if CertificateSubject property is set
        internal bool IsSetCertificateSubject()
        {
            return this._certificateSubject != null;
        }

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// Asymmetric key used for generating the certificate signing request
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

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// Algorithm used to generate the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningAlgorithmType SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

    }
}