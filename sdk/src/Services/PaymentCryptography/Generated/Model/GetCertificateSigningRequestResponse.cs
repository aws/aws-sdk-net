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
    /// This is the response object from the GetCertificateSigningRequest operation.
    /// </summary>
    public partial class GetCertificateSigningRequestResponse : AmazonWebServiceResponse
    {
        private string _certificateSigningRequest;

        /// <summary>
        /// Gets and sets the property CertificateSigningRequest. 
        /// <para>
        /// Certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=32768)]
        public string CertificateSigningRequest
        {
            get { return this._certificateSigningRequest; }
            set { this._certificateSigningRequest = value; }
        }

        // Check to see if CertificateSigningRequest property is set
        internal bool IsSetCertificateSigningRequest()
        {
            return this._certificateSigningRequest != null;
        }

    }
}