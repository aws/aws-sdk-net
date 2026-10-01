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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Configurations related to the TLS certificate for the security configuration.
    /// </summary>
    public partial class TLSCertificateConfiguration
    {
        /// <summary>
        /// Gets and sets the property CertificateProviderType. 
        /// <para>
        /// The TLS certificate type. Acceptable values: <c>PEM</c> or <c>Custom</c>.
        /// </para>
        /// </summary>
        public CertificateProviderType CertificateProviderType { get; set; }

        /// <summary>
        /// Checks to see if the CertificateProviderType property is set.
        /// </summary>
        internal bool IsSetCertificateProviderType() => this.CertificateProviderType != null;

        /// <summary>
        /// Gets and sets the property PrivateCertificateSecretArn. 
        /// <para>
        /// Secrets Manager ARN that contains the private TLS certificate contents, used for communication
        /// between the user job and the system job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 2048)]
        public string PrivateCertificateSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the PrivateCertificateSecretArn property is set.
        /// </summary>
        internal bool IsSetPrivateCertificateSecretArn() => this.PrivateCertificateSecretArn != null;

        /// <summary>
        /// Gets and sets the property PublicCertificateSecretArn. 
        /// <para>
        /// Secrets Manager ARN that contains the public TLS certificate contents, used for communication
        /// between the user job and the system job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 2048)]
        public string PublicCertificateSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the PublicCertificateSecretArn property is set.
        /// </summary>
        internal bool IsSetPublicCertificateSecretArn() => this.PublicCertificateSecretArn != null;
    }
}
