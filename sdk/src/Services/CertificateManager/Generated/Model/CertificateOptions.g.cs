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
    /// Structure that contains options for your certificate. You can use this structure to
    /// change the domain validation method or specify whether to export your certificate.
    /// 
    ///  
    /// <para>
    /// All public certificates are recorded in a certificate transparency log. For general
    /// information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-concepts.html#concept-transparency">Certificate
    /// Transparency Logging</a>.
    /// </para>
    ///  
    /// <para>
    /// You can export public ACM certificates to use with Amazon Web Services services as
    /// well as outside Amazon Web Services Cloud. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-exportable-certificates.html">Certificate
    /// Manager exportable public certificate</a>.
    /// </para>
    /// </summary>
    public partial class CertificateOptions
    {
        /// <summary>
        /// Gets and sets the property CertificateTransparencyLoggingPreference. 
        /// <para>
        /// This parameter has been deprecated. Certificate transparency logging opt-out is no
        /// longer available. All public certificates are recorded in a certificate transparency
        /// log.
        /// </para>
        /// </summary>
        [Obsolete("Certificate transparency logging opt-out is no longer available.")]
        public CertificateTransparencyLoggingPreference CertificateTransparencyLoggingPreference { get; set; }

        /// <summary>
        /// Checks to see if the CertificateTransparencyLoggingPreference property is set.
        /// </summary>
        internal bool IsSetCertificateTransparencyLoggingPreference() => this.CertificateTransparencyLoggingPreference != null;

        /// <summary>
        /// Gets and sets the property Export. 
        /// <para>
        /// You can opt in to allow the export of your certificates by specifying <c>ENABLED</c>.
        /// You cannot update the value of <c>Export</c> after the the certificate is created.
        /// </para>
        /// </summary>
        public CertificateExport Export { get; set; }

        /// <summary>
        /// Checks to see if the Export property is set.
        /// </summary>
        internal bool IsSetExport() => this.Export != null;

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// The domain validation method for the certificate. To migrate from email to DNS validation,
        /// specify <c>DNS</c>.
        /// </para>
        /// </summary>
        public ValidationMethod ValidationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMethod property is set.
        /// </summary>
        internal bool IsSetValidationMethod() => this.ValidationMethod != null;
    }
}
