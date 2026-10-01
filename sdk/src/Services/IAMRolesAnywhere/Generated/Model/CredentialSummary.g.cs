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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// A record of a presented X509 credential from a temporary credential request.
    /// </summary>
    public partial class CredentialSummary
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the credential is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Indicates whether the temporary credential request was successful. 
        /// </para>
        /// </summary>
        public bool? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The fully qualified domain name of the issuing certificate for the presented end-entity
        /// certificate.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property SeenAt. 
        /// <para>
        /// The ISO-8601 time stamp of when the certificate was last used in a temporary credential
        /// request.
        /// </para>
        /// </summary>
        public DateTime? SeenAt { get; set; }

        /// <summary>
        /// Checks to see if the SeenAt property is set.
        /// </summary>
        internal bool IsSetSeenAt() => this.SeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the certificate.
        /// </para>
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property X509CertificateData. 
        /// <para>
        /// The PEM-encoded data of the certificate.
        /// </para>
        /// </summary>
        public string X509CertificateData { get; set; }

        /// <summary>
        /// Checks to see if the X509CertificateData property is set.
        /// </summary>
        internal bool IsSetX509CertificateData() => this.X509CertificateData != null;
    }
}
