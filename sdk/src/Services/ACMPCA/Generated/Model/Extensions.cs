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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains X.509 extension information for a certificate.
    /// </summary>
    public partial class Extensions
    {
        private List<PolicyInformation> _certificatePolicies = new List<PolicyInformation>();
        private List<ExtendedKeyUsage> _extendedKeyUsage = new List<ExtendedKeyUsage>();
        private KeyUsage _keyUsage;
        private List<GeneralName> _subjectAlternativeNames = new List<GeneralName>();

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
            return this._certificatePolicies != null && this._certificatePolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsage. 
        /// <para>
        /// Specifies additional purposes for which the certified public key may be used other
        /// than basic purposes indicated in the <code>KeyUsage</code> extension.
        /// </para>
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
            return this._extendedKeyUsage != null && this._extendedKeyUsage.Count > 0; 
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
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<GeneralName> SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null && this._subjectAlternativeNames.Count > 0; 
        }

    }
}