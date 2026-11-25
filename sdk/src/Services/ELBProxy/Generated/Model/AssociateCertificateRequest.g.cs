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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateCertificate operation. Associates an
    /// ACM certificate with the specified Proxy.
    /// </summary>
    public partial class AssociateCertificateRequest : AmazonELBProxyRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateIdentifier. The Amazon Resource Name (ARN) of
        /// the ACM certificate.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string CertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateIdentifier() => this.CertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProxyIdentifier. The Amazon Resource Name (ARN) of the
        /// proxy.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProxyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProxyIdentifier property is set.
        /// </summary>
        internal bool IsSetProxyIdentifier() => this.ProxyIdentifier != null;
    }
}
