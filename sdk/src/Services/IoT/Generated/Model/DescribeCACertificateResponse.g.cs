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
    /// This is the response object from the DescribeCACertificate operation.
    /// </summary>
    public partial class DescribeCACertificateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CertificateDescription. 
        /// <para>
        /// The CA certificate description.
        /// </para>
        /// </summary>
        public CACertificateDescription CertificateDescription { get; set; }

        /// <summary>
        /// Checks to see if the CertificateDescription property is set.
        /// </summary>
        internal bool IsSetCertificateDescription() => this.CertificateDescription != null;

        /// <summary>
        /// Gets and sets the property RegistrationConfig. 
        /// <para>
        /// Information about the registration configuration.
        /// </para>
        /// </summary>
        public RegistrationConfig RegistrationConfig { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationConfig property is set.
        /// </summary>
        internal bool IsSetRegistrationConfig() => this.RegistrationConfig != null;
    }
}
