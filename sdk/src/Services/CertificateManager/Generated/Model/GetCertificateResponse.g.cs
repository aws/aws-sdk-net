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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This is the response object from the GetCertificate operation.
    /// </summary>
    public partial class GetCertificateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The ACM-issued certificate corresponding to the ARN specified as input.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// Certificates forming the requested certificate's chain of trust. The chain consists
        /// of the certificate of the issuing CA and the intermediate certificates of any other
        /// subordinate CAs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2097152)]
        public string CertificateChain { get; set; }

        /// <summary>
        /// Checks to see if the CertificateChain property is set.
        /// </summary>
        internal bool IsSetCertificateChain() => this.CertificateChain != null;
    }
}
