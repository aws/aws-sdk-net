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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
        private CertificateValidity _certificateValidity;
        private EnrollmentFlagsV4 _enrollmentFlags;
        private ExtensionsV4 _extensions;
        private GeneralFlagsV4 _generalFlags;
        private HashAlgorithm _hashAlgorithm;
        private PrivateKeyAttributesV4 _privateKeyAttributes;
        private PrivateKeyFlagsV4 _privateKeyFlags;
        private SubjectNameFlagsV4 _subjectNameFlags;
        private List<string> _supersededTemplates = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CertificateValidity. 
        /// <para>
        /// Certificate validity describes the validity and renewal periods of a certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateValidity CertificateValidity
        {
            get { return this._certificateValidity; }
            set { this._certificateValidity = value; }
        }

        // Check to see if CertificateValidity property is set
        internal bool IsSetCertificateValidity()
        {
            return this._certificateValidity != null;
        }

        /// <summary>
        /// Gets and sets the property EnrollmentFlags. 
        /// <para>
        /// Enrollment flags describe the enrollment settings for certificates using the existing
        /// private key and deleting expired or revoked certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrollmentFlagsV4 EnrollmentFlags
        {
            get { return this._enrollmentFlags; }
            set { this._enrollmentFlags = value; }
        }

        // Check to see if EnrollmentFlags property is set
        internal bool IsSetEnrollmentFlags()
        {
            return this._enrollmentFlags != null;
        }

        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// Extensions describe the key usage extensions and application policies for a template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExtensionsV4 Extensions
        {
            get { return this._extensions; }
            set { this._extensions = value; }
        }

        // Check to see if Extensions property is set
        internal bool IsSetExtensions()
        {
            return this._extensions != null;
        }

        /// <summary>
        /// Gets and sets the property GeneralFlags. 
        /// <para>
        /// General flags describe whether the template is used for computers or users and if
        /// the template can be used with autoenrollment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeneralFlagsV4 GeneralFlags
        {
            get { return this._generalFlags; }
            set { this._generalFlags = value; }
        }

        // Check to see if GeneralFlags property is set
        internal bool IsSetGeneralFlags()
        {
            return this._generalFlags != null;
        }

        /// <summary>
        /// Gets and sets the property HashAlgorithm. 
        /// <para>
        /// Specifies the hash algorithm used to hash the private key. Hash algorithm can only
        /// be specified when using Key Storage Providers.
        /// </para>
        /// </summary>
        public HashAlgorithm HashAlgorithm
        {
            get { return this._hashAlgorithm; }
            set { this._hashAlgorithm = value; }
        }

        // Check to see if HashAlgorithm property is set
        internal bool IsSetHashAlgorithm()
        {
            return this._hashAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKeyAttributes. 
        /// <para>
        /// Private key attributes allow you to specify the minimal key length, key spec, key
        /// usage, and cryptographic providers for the private key of a certificate for v4 templates.
        /// V4 templates allow you to use either Key Storage Providers or Legacy Cryptographic
        /// Service Providers. You specify the cryptography provider category in private key flags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivateKeyAttributesV4 PrivateKeyAttributes
        {
            get { return this._privateKeyAttributes; }
            set { this._privateKeyAttributes = value; }
        }

        // Check to see if PrivateKeyAttributes property is set
        internal bool IsSetPrivateKeyAttributes()
        {
            return this._privateKeyAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKeyFlags. 
        /// <para>
        /// Private key flags for v4 templates specify the client compatibility, if the private
        /// key can be exported, if user input is required when using a private key, if an alternate
        /// signature algorithm should be used, and if certificates are renewed using the same
        /// private key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivateKeyFlagsV4 PrivateKeyFlags
        {
            get { return this._privateKeyFlags; }
            set { this._privateKeyFlags = value; }
        }

        // Check to see if PrivateKeyFlags property is set
        internal bool IsSetPrivateKeyFlags()
        {
            return this._privateKeyFlags != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectNameFlags. 
        /// <para>
        /// Subject name flags describe the subject name and subject alternate name that is included
        /// in a certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubjectNameFlagsV4 SubjectNameFlags
        {
            get { return this._subjectNameFlags; }
            set { this._subjectNameFlags = value; }
        }

        // Check to see if SubjectNameFlags property is set
        internal bool IsSetSubjectNameFlags()
        {
            return this._subjectNameFlags != null;
        }

        /// <summary>
        /// Gets and sets the property SupersededTemplates. 
        /// <para>
        /// List of templates in Active Directory that are superseded by this template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> SupersededTemplates
        {
            get { return this._supersededTemplates; }
            set { this._supersededTemplates = value; }
        }

        // Check to see if SupersededTemplates property is set
        internal bool IsSetSupersededTemplates()
        {
            return this._supersededTemplates != null && (this._supersededTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}