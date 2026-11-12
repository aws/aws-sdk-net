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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains X.509 extension information for a certificate.
    /// </summary>
    public partial class Extensions
    {
        /// <summary>
        /// Gets and sets the property CertificatePolicies. 
        /// <para>
        /// Contains a sequence of one or more policy information terms, each of which consists
        /// of an object identifier (OID) and optional qualifiers. For more information, see NIST's
        /// definition of <a href="https://csrc.nist.gov/glossary/term/Object_Identifier">Object
        /// Identifier (OID)</a>.
        /// </para>
        ///  
        /// <para>
        /// In an end-entity certificate, these terms indicate the policy under which the certificate
        /// was issued and the purposes for which it may be used. In a CA certificate, these terms
        /// limit the set of policies for certification paths that include this certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<PolicyInformation> CertificatePolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyInformation>() : null;

        /// <summary>
        /// Checks to see if the CertificatePolicies property is set.
        /// </summary>
        internal bool IsSetCertificatePolicies() => this.CertificatePolicies != null && (this.CertificatePolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomExtensions.  
        /// <para>
        /// Contains a sequence of one or more X.509 extensions, each of which consists of an
        /// object identifier (OID), a base64-encoded value, and the critical flag. For more information,
        /// see the <a href="https://oidref.com/2.5.29">Global OID reference database.</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public List<CustomExtension> CustomExtensions { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomExtension>() : null;

        /// <summary>
        /// Checks to see if the CustomExtensions property is set.
        /// </summary>
        internal bool IsSetCustomExtensions() => this.CustomExtensions != null && (this.CustomExtensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsage. 
        /// <para>
        /// Specifies additional purposes for which the certified public key may be used other
        /// than basic purposes indicated in the <c>KeyUsage</c> extension.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<ExtendedKeyUsage> ExtendedKeyUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<ExtendedKeyUsage>() : null;

        /// <summary>
        /// Checks to see if the ExtendedKeyUsage property is set.
        /// </summary>
        internal bool IsSetExtendedKeyUsage() => this.ExtendedKeyUsage != null && (this.ExtendedKeyUsage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyUsage.
        /// </summary>
        public KeyUsage KeyUsage { get; set; }

        /// <summary>
        /// Checks to see if the KeyUsage property is set.
        /// </summary>
        internal bool IsSetKeyUsage() => this.KeyUsage != null;

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// The subject alternative name extension allows identities to be bound to the subject
        /// of the certificate. These identities may be included in addition to or in place of
        /// the identity in the subject field of the certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public List<GeneralName> SubjectAlternativeNames { get; set; } = AWSConfigs.InitializeCollections ? new List<GeneralName>() : null;

        /// <summary>
        /// Checks to see if the SubjectAlternativeNames property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeNames() => this.SubjectAlternativeNames != null && (this.SubjectAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
