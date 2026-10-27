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
    /// Container for the parameters to the ImportCertificate operation. Uploads the specified
    /// certificate.
    /// </summary>
    public partial class ImportCertificateRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateIdentifier. 
        /// <para>
        /// A customer-assigned name for the certificate. Identifiers must begin with a letter
        /// and must contain only ASCII letters, digits, and hyphens. They can't end with a hyphen
        /// or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateIdentifier() => this.CertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The contents of a <c>.pem</c> file, which contains an X.509 certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CertificatePem { get; set; }

        /// <summary>
        /// Checks to see if the CertificatePem property is set.
        /// </summary>
        internal bool IsSetCertificatePem() => this.CertificatePem != null;

        /// <summary>
        /// Gets and sets the property CertificateWallet. 
        /// <para>
        /// The location of an imported Oracle Wallet certificate for use with SSL. Provide the
        /// name of a <c>.sso</c> file using the <c>fileb://</c> prefix. You can't provide the
        /// certificate inline.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>filebase64("${path.root}/rds-ca-2019-root.sso")</c> 
        /// </para>
        /// </summary>
        public MemoryStream CertificateWallet { get; set; }

        /// <summary>
        /// Checks to see if the CertificateWallet property is set.
        /// </summary>
        internal bool IsSetCertificateWallet() => this.CertificateWallet != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
