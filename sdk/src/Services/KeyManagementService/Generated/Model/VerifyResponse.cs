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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the Verify operation.
    /// </summary>
    public partial class VerifyResponse : AmazonWebServiceResponse
    {
        private string _keyId;
        private bool? _signatureValid;
        private SigningAlgorithmSpec _signingAlgorithm;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The unique identifier for the asymmetric CMK that was used to verify the signature.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureValid. 
        /// <para>
        /// A Boolean value that indicates whether the signature was verified. A value of <code>True</code>
        /// indicates that the <code>Signature</code> was produced by signing the <code>Message</code>
        /// with the specified <code>KeyID</code> and <code>SigningAlgorithm.</code> If the signature
        /// is not verified, the <code>Verify</code> operation fails with a <code>KMSInvalidSignatureException</code>
        /// exception. 
        /// </para>
        /// </summary>
        public bool SignatureValid
        {
            get { return this._signatureValid.GetValueOrDefault(); }
            set { this._signatureValid = value; }
        }

        // Check to see if SignatureValid property is set
        internal bool IsSetSignatureValid()
        {
            return this._signatureValid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm that was used to verify the signature.
        /// </para>
        /// </summary>
        public SigningAlgorithmSpec SigningAlgorithm
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