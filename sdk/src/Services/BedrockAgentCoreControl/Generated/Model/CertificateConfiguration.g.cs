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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A reference to a private certificate authority (CA) certificate that the gateway uses
    /// to verify TLS connections to the target endpoint. Use this when the target presents
    /// a certificate issued by a private CA that is not trusted by default. Specify exactly
    /// one certificate source. The configuration is a reference only and never contains the
    /// certificate content.
    /// </summary>
    public partial class CertificateConfiguration
    {
        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The Amazon S3 location of the PEM-encoded private CA certificate.
        /// </para>
        /// </summary>
        public S3CertificateConfiguration S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property SecretsManager. 
        /// <para>
        /// The Amazon Web Services Secrets Manager location of the PEM-encoded private CA certificate.
        /// </para>
        /// </summary>
        public SecretsManagerCertificateConfiguration SecretsManager { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManager property is set.
        /// </summary>
        internal bool IsSetSecretsManager() => this.SecretsManager != null;
    }
}
