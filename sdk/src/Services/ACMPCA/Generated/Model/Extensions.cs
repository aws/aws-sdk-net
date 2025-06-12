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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
        private List<PolicyInformation> _certificatePolicies = AWSConfigs.InitializeCollections ? new List<PolicyInformation>() : null;
        private List<CustomExtension> _customExtensions = AWSConfigs.InitializeCollections ? new List<CustomExtension>() : null;
        private List<ExtendedKeyUsage> _extendedKeyUsage = AWSConfigs.InitializeCollections ? new List<ExtendedKeyUsage>() : null;
        private KeyUsage _keyUsage;
        private List<GeneralName> _subjectAlternativeNames = AWSConfigs.InitializeCollections ? new List<GeneralName>() : null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<PolicyInformation> CertificatePolicies
        {
            get { return this._certificatePolicies; }
            set { this._certificatePolicies = value; }
        }

        // Check to see if CertificatePolicies property is set
        internal bool IsSetCertificatePolicies()
        {
            return this._certificatePolicies != null && (this._certificatePolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomExtensions.  
        /// <para>
        /// Contains a sequence of one or more X.509 extensions, each of which consists of an
        /// object identifier (OID), a base64-encoded value, and the critical flag. For more information,
        /// see the <a href="https://oidref.com/2.5.29">Global OID reference database.</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public List<CustomExtension> CustomExtensions
        {
            get { return this._customExtensions; }
            set { this._customExtensions = value; }
        }

        // Check to see if CustomExtensions property is set
        internal bool IsSetCustomExtensions()
        {
            return this._customExtensions != null && (this._customExtensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsage. 
        /// <para>
        /// Specifies additional purposes for which the certified public key may be used other
        /// than basic purposes indicated in the <c>KeyUsage</c> extension.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<ExtendedKeyUsage> ExtendedKeyUsage
        {
            get { return this._extendedKeyUsage; }
            set { this._extendedKeyUsage = value; }
        }

        // Check to see if ExtendedKeyUsage property is set
        internal bool IsSetExtendedKeyUsage()
        {
            return this._extendedKeyUsage != null && (this._extendedKeyUsage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyUsage.
        /// </summary>
        public KeyUsage KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// The subject alternative name extension allows identities to be bound to the subject
        /// of the certificate. These identities may be included in addition to or in place of
        /// the identity in the subject field of the certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public List<GeneralName> SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null && (this._subjectAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}