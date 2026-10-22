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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// The SSL certificate that can be used to encrypt connections between the endpoints
    /// and the replication instance.
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
        /// Gets and sets the property CertificateCreationDate. 
        /// <para>
        /// The date that the certificate was created.
        /// </para>
        /// </summary>
        public DateTime? CertificateCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CertificateCreationDate property is set.
        /// </summary>
        internal bool IsSetCertificateCreationDate() => this.CertificateCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CertificateIdentifier. 
        /// <para>
        /// A customer-assigned name for the certificate. Identifiers must begin with a letter
        /// and must contain only ASCII letters, digits, and hyphens. They can't end with a hyphen
        /// or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        public string CertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateIdentifier() => this.CertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CertificateOwner. 
        /// <para>
        /// The owner of the certificate.
        /// </para>
        /// </summary>
        public string CertificateOwner { get; set; }

        /// <summary>
        /// Checks to see if the CertificateOwner property is set.
        /// </summary>
        internal bool IsSetCertificateOwner() => this.CertificateOwner != null;

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The contents of a <c>.pem</c> file, which contains an X.509 certificate.
        /// </para>
        /// </summary>
        public string CertificatePem { get; set; }

        /// <summary>
        /// Checks to see if the CertificatePem property is set.
        /// </summary>
        internal bool IsSetCertificatePem() => this.CertificatePem != null;

        /// <summary>
        /// Gets and sets the property CertificateWallet. 
        /// <para>
        /// The location of an imported Oracle Wallet certificate for use with SSL. Example: <c>filebase64("${path.root}/rds-ca-2019-root.sso")</c>
        /// 
        /// </para>
        /// </summary>
        public MemoryStream CertificateWallet { get; set; }

        /// <summary>
        /// Checks to see if the CertificateWallet property is set.
        /// </summary>
        internal bool IsSetCertificateWallet() => this.CertificateWallet != null;

        /// <summary>
        /// Gets and sets the property KeyLength. 
        /// <para>
        /// The key length of the cryptographic algorithm being used.
        /// </para>
        /// </summary>
        public int? KeyLength { get; set; }

        /// <summary>
        /// Checks to see if the KeyLength property is set.
        /// </summary>
        internal bool IsSetKeyLength() => this.KeyLength.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An KMS key identifier that is used to encrypt the certificate.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, then DMS uses your
        /// default encryption key.
        /// </para>
        ///  
        /// <para>
        /// KMS creates the default encryption key for your Amazon Web Services account. Your
        /// Amazon Web Services account has a different default encryption key for each Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm for the certificate.
        /// </para>
        /// </summary>
        public string SigningAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithm() => this.SigningAlgorithm != null;

        /// <summary>
        /// Gets and sets the property ValidFromDate. 
        /// <para>
        /// The beginning date that the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime? ValidFromDate { get; set; }

        /// <summary>
        /// Checks to see if the ValidFromDate property is set.
        /// </summary>
        internal bool IsSetValidFromDate() => this.ValidFromDate.HasValue;

        /// <summary>
        /// Gets and sets the property ValidToDate. 
        /// <para>
        /// The final date that the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime? ValidToDate { get; set; }

        /// <summary>
        /// Checks to see if the ValidToDate property is set.
        /// </summary>
        internal bool IsSetValidToDate() => this.ValidToDate.HasValue;
    }
}
