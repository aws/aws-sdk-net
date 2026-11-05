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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A CA certificate for an Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
    /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
    /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
    /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Certificate
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificateIdentifier. 
        /// <para>
        /// The unique key that identifies a certificate.
        /// </para>
        /// </summary>
        public string CertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateIdentifier() => this.CertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CertificateType. 
        /// <para>
        /// The type of the certificate.
        /// </para>
        /// </summary>
        public string CertificateType { get; set; }

        /// <summary>
        /// Checks to see if the CertificateType property is set.
        /// </summary>
        internal bool IsSetCertificateType() => this.CertificateType != null;

        /// <summary>
        /// Gets and sets the property CustomerOverride. 
        /// <para>
        /// Indicates whether there is an override for the default certificate identifier.
        /// </para>
        /// </summary>
        public bool? CustomerOverride { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOverride property is set.
        /// </summary>
        internal bool IsSetCustomerOverride() => this.CustomerOverride.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerOverrideValidTill. 
        /// <para>
        /// If there is an override for the default certificate identifier, when the override
        /// expires.
        /// </para>
        /// </summary>
        public DateTime? CustomerOverrideValidTill { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOverrideValidTill property is set.
        /// </summary>
        internal bool IsSetCustomerOverrideValidTill() => this.CustomerOverrideValidTill.HasValue;

        /// <summary>
        /// Gets and sets the property Thumbprint. 
        /// <para>
        /// The thumbprint of the certificate.
        /// </para>
        /// </summary>
        public string Thumbprint { get; set; }

        /// <summary>
        /// Checks to see if the Thumbprint property is set.
        /// </summary>
        internal bool IsSetThumbprint() => this.Thumbprint != null;

        /// <summary>
        /// Gets and sets the property ValidFrom. 
        /// <para>
        /// The starting date from which the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Checks to see if the ValidFrom property is set.
        /// </summary>
        internal bool IsSetValidFrom() => this.ValidFrom.HasValue;

        /// <summary>
        /// Gets and sets the property ValidTill. 
        /// <para>
        /// The final date that the certificate continues to be valid.
        /// </para>
        /// </summary>
        public DateTime? ValidTill { get; set; }

        /// <summary>
        /// Checks to see if the ValidTill property is set.
        /// </summary>
        internal bool IsSetValidTill() => this.ValidTill.HasValue;
    }
}
