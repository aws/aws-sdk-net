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
    /// This is the response object from the GetParametersForExport operation.
    /// </summary>
    public partial class GetParametersForExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExportToken. 
        /// <para>
        /// The export token to initiate key export from Amazon Web Services Payment Cryptography.
        /// The export token expires after 30 days. You can use the same export token to export
        /// multiple keys from the same service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExportToken { get; set; }

        /// <summary>
        /// Checks to see if the ExportToken property is set.
        /// </summary>
        internal bool IsSetExportToken() => this.ExportToken != null;

        /// <summary>
        /// Gets and sets the property ParametersValidUntilTimestamp. 
        /// <para>
        /// The validity period of the export token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ParametersValidUntilTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ParametersValidUntilTimestamp property is set.
        /// </summary>
        internal bool IsSetParametersValidUntilTimestamp() => this.ParametersValidUntilTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SigningKeyAlgorithm. 
        /// <para>
        /// The algorithm of the signing key certificate for use in TR-34 key block generation.
        /// <c>RSA_2048</c> is the only signing key algorithm allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyAlgorithm SigningKeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningKeyAlgorithm() => this.SigningKeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property SigningKeyCertificate. 
        /// <para>
        /// The signing key certificate in PEM format (base64 encoded) of the public key for signature
        /// within the TR-34 key block. The certificate expires after 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32768)]
        public string SigningKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyCertificate property is set.
        /// </summary>
        internal bool IsSetSigningKeyCertificate() => this.SigningKeyCertificate != null;

        /// <summary>
        /// Gets and sets the property SigningKeyCertificateChain. 
        /// <para>
        /// The root certificate authority (CA) that signed the signing key certificate in PEM
        /// format (base64 encoded).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32768)]
        public string SigningKeyCertificateChain { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyCertificateChain property is set.
        /// </summary>
        internal bool IsSetSigningKeyCertificateChain() => this.SigningKeyCertificateChain != null;
    }
}
