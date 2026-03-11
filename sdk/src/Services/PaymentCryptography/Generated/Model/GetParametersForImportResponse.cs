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
    /// This is the response object from the GetParametersForImport operation.
    /// </summary>
    public partial class GetParametersForImportResponse : AmazonWebServiceResponse
    {
        private string _importToken;
        private DateTime? _parametersValidUntilTimestamp;
        private KeyAlgorithm _wrappingKeyAlgorithm;
        private string _wrappingKeyCertificate;
        private string _wrappingKeyCertificateChain;

        /// <summary>
        /// Gets and sets the property ImportToken. 
        /// <para>
        /// The import token to initiate key import into Amazon Web Services Payment Cryptography.
        /// The import token expires after 30 days. You can use the same import token to import
        /// multiple keys to the same service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImportToken
        {
            get { return this._importToken; }
            set { this._importToken = value; }
        }

        // Check to see if ImportToken property is set
        internal bool IsSetImportToken()
        {
            return this._importToken != null;
        }

        /// <summary>
        /// Gets and sets the property ParametersValidUntilTimestamp. 
        /// <para>
        /// The validity period of the import token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ParametersValidUntilTimestamp
        {
            get { return this._parametersValidUntilTimestamp; }
            set { this._parametersValidUntilTimestamp = value; }
        }

        // Check to see if ParametersValidUntilTimestamp property is set
        internal bool IsSetParametersValidUntilTimestamp()
        {
            return this._parametersValidUntilTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyAlgorithm. 
        /// <para>
        /// The algorithm of the wrapping key for use within TR-34 WrappedKeyBlock or RSA WrappedKeyCryptogram.
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

        /// <summary>
        /// Gets and sets the property WrappingKeyCertificate. 
        /// <para>
        /// The wrapping key certificate in PEM format (base64 encoded) of the wrapping key for
        /// use within the TR-34 key block. The certificate expires in 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
        public string WrappingKeyCertificate
        {
            get { return this._wrappingKeyCertificate; }
            set { this._wrappingKeyCertificate = value; }
        }

        // Check to see if WrappingKeyCertificate property is set
        internal bool IsSetWrappingKeyCertificate()
        {
            return this._wrappingKeyCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyCertificateChain. 
        /// <para>
        /// The Amazon Web Services Payment Cryptography root certificate authority (CA) that
        /// signed the wrapping key certificate in PEM format (base64 encoded).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
        public string WrappingKeyCertificateChain
        {
            get { return this._wrappingKeyCertificateChain; }
            set { this._wrappingKeyCertificateChain = value; }
        }

        // Check to see if WrappingKeyCertificateChain property is set
        internal bool IsSetWrappingKeyCertificateChain()
        {
            return this._wrappingKeyCertificateChain != null;
        }

    }
}