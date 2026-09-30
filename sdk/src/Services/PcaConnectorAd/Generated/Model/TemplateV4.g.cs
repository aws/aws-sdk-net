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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// v4 template schema that can use either Legacy Cryptographic Providers or Key Storage
    /// Providers.
    /// </summary>
    public partial class TemplateV4
    {
        /// <summary>
        /// Gets and sets the property CertificateValidity. 
        /// <para>
        /// Certificate validity describes the validity and renewal periods of a certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CertificateValidity CertificateValidity { get; set; }

        /// <summary>
        /// Checks to see if the CertificateValidity property is set.
        /// </summary>
        internal bool IsSetCertificateValidity() => this.CertificateValidity != null;

        /// <summary>
        /// Gets and sets the property EnrollmentFlags. 
        /// <para>
        /// Enrollment flags describe the enrollment settings for certificates using the existing
        /// private key and deleting expired or revoked certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrollmentFlagsV4 EnrollmentFlags { get; set; }

        /// <summary>
        /// Checks to see if the EnrollmentFlags property is set.
        /// </summary>
        internal bool IsSetEnrollmentFlags() => this.EnrollmentFlags != null;

        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// Extensions describe the key usage extensions and application policies for a template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtensionsV4 Extensions { get; set; }

        /// <summary>
        /// Checks to see if the Extensions property is set.
        /// </summary>
        internal bool IsSetExtensions() => this.Extensions != null;

        /// <summary>
        /// Gets and sets the property GeneralFlags. 
        /// <para>
        /// General flags describe whether the template is used for computers or users and if
        /// the template can be used with autoenrollment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeneralFlagsV4 GeneralFlags { get; set; }

        /// <summary>
        /// Checks to see if the GeneralFlags property is set.
        /// </summary>
        internal bool IsSetGeneralFlags() => this.GeneralFlags != null;

        /// <summary>
        /// Gets and sets the property HashAlgorithm. 
        /// <para>
        /// Specifies the hash algorithm used to hash the private key. Hash algorithm can only
        /// be specified when using Key Storage Providers.
        /// </para>
        /// </summary>
        public HashAlgorithm HashAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the HashAlgorithm property is set.
        /// </summary>
        internal bool IsSetHashAlgorithm() => this.HashAlgorithm != null;

        /// <summary>
        /// Gets and sets the property PrivateKeyAttributes. 
        /// <para>
        /// Private key attributes allow you to specify the minimal key length, key spec, key
        /// usage, and cryptographic providers for the private key of a certificate for v4 templates.
        /// V4 templates allow you to use either Key Storage Providers or Legacy Cryptographic
        /// Service Providers. You specify the cryptography provider category in private key flags.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivateKeyAttributesV4 PrivateKeyAttributes { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKeyAttributes property is set.
        /// </summary>
        internal bool IsSetPrivateKeyAttributes() => this.PrivateKeyAttributes != null;

        /// <summary>
        /// Gets and sets the property PrivateKeyFlags. 
        /// <para>
        /// Private key flags for v4 templates specify the client compatibility, if the private
        /// key can be exported, if user input is required when using a private key, if an alternate
        /// signature algorithm should be used, and if certificates are renewed using the same
        /// private key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivateKeyFlagsV4 PrivateKeyFlags { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKeyFlags property is set.
        /// </summary>
        internal bool IsSetPrivateKeyFlags() => this.PrivateKeyFlags != null;

        /// <summary>
        /// Gets and sets the property SubjectNameFlags. 
        /// <para>
        /// Subject name flags describe the subject name and subject alternate name that is included
        /// in a certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubjectNameFlagsV4 SubjectNameFlags { get; set; }

        /// <summary>
        /// Checks to see if the SubjectNameFlags property is set.
        /// </summary>
        internal bool IsSetSubjectNameFlags() => this.SubjectNameFlags != null;

        /// <summary>
        /// Gets and sets the property SupersededTemplates. 
        /// <para>
        /// List of templates in Active Directory that are superseded by this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> SupersededTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupersededTemplates property is set.
        /// </summary>
        internal bool IsSetSupersededTemplates() => this.SupersededTemplates != null && (this.SupersededTemplates.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
