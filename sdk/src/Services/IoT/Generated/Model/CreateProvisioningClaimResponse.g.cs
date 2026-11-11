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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the CreateProvisioningClaim operation.
    /// </summary>
    public partial class CreateProvisioningClaimResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The provisioning claim certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string CertificatePem { get; set; }

        /// <summary>
        /// Checks to see if the CertificatePem property is set.
        /// </summary>
        internal bool IsSetCertificatePem() => this.CertificatePem != null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The provisioning claim expiration time.
        /// </para>
        /// </summary>
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        /// The provisioning claim key pair.
        /// </para>
        /// </summary>
        public KeyPair KeyPair { get; set; }

        /// <summary>
        /// Checks to see if the KeyPair property is set.
        /// </summary>
        internal bool IsSetKeyPair() => this.KeyPair != null;
    }
}
