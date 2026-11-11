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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrustStore operation. Creates a trust store.
    /// </summary>
    public partial class CreateTrustStoreRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property CaCertificatesBundleSource. 
        /// <para>
        /// The CA certificates bundle source for the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CaCertificatesBundleSource CaCertificatesBundleSource { get; set; }

        /// <summary>
        /// Checks to see if the CaCertificatesBundleSource property is set.
        /// </summary>
        internal bool IsSetCaCertificatesBundleSource() => this.CaCertificatesBundleSource != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;

        /// <summary>
        /// Gets and sets the property UseClientCertificateOCSPEndpoint. 
        /// <para>
        /// A Boolean that determines whether to use the CA certificate's OCSP endpoint to check
        /// certificate revocation status.
        /// </para>
        /// </summary>
        public bool? UseClientCertificateOCSPEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UseClientCertificateOCSPEndpoint property is set.
        /// </summary>
        internal bool IsSetUseClientCertificateOCSPEndpoint() => this.UseClientCertificateOCSPEndpoint.HasValue;
    }
}
