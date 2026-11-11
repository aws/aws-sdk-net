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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a local file certificate. The certificate must meet specific
    /// requirements and you must have proxy authorization enabled. For more information,
    /// see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/tls.html#virtual-node-tls-prerequisites">Transport
    /// Layer Security (TLS)</a>.
    /// </summary>
    public partial class ListenerTlsFileCertificate
    {
        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The certificate chain for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CertificateChain { get; set; }

        /// <summary>
        /// Checks to see if the CertificateChain property is set.
        /// </summary>
        internal bool IsSetCertificateChain() => this.CertificateChain != null;

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The private key for a certificate stored on the file system of the virtual node that
        /// the proxy is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKey property is set.
        /// </summary>
        internal bool IsSetPrivateKey() => this.PrivateKey != null;
    }
}
