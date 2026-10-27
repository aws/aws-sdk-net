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
    /// Contains X.509 certificate attributes extracted from the certificate.
    /// </summary>
    public partial class X509Attributes
    {
        /// <summary>
        /// Gets and sets the property ExtendedKeyUsages. 
        /// <para>
        /// Contains a list of Extended Key Usage X.509 v3 extension objects. Each object specifies
        /// a purpose for which the certificate public key can be used and consists of a name
        /// and an object identifier (OID). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExtendedKeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExtendedKeyUsages property is set.
        /// </summary>
        internal bool IsSetExtendedKeyUsages() => this.ExtendedKeyUsages != null && (this.ExtendedKeyUsages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The distinguished name of the certificate issuer.
        /// </para>
        /// </summary>
        public DistinguishedName Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The algorithm that was used to generate the public-private key pair.
        /// </para>
        /// </summary>
        public KeyAlgorithm KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyUsages. 
        /// <para>
        /// A list of Key Usage X.509 v3 extension objects. Each object is a string value that
        /// identifies the purpose of the public key contained in the certificate. Possible extension
        /// values include DIGITAL_SIGNATURE, KEY_ENCHIPHERMENT, NON_REPUDIATION, and more.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyUsages property is set.
        /// </summary>
        internal bool IsSetKeyUsages() => this.KeyUsages != null && (this.KeyUsages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The time after which the certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotAfter property is set.
        /// </summary>
        internal bool IsSetNotAfter() => this.NotAfter.HasValue;

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The time before which the certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotBefore property is set.
        /// </summary>
        internal bool IsSetNotBefore() => this.NotBefore.HasValue;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number assigned by the certificate authority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 59)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The distinguished name of the certificate subject.
        /// </para>
        /// </summary>
        public DistinguishedName Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// One or more domain names (subject alternative names) included in the certificate.
        /// This list contains the domain names that are bound to the public key that is contained
        /// in the certificate. The subject alternative names include the canonical domain name
        /// (CN) of the certificate and additional domain names that can be used to connect to
        /// the website. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GeneralName> SubjectAlternativeNames { get; set; } = AWSConfigs.InitializeCollections ? new List<GeneralName>() : null;

        /// <summary>
        /// Checks to see if the SubjectAlternativeNames property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeNames() => this.SubjectAlternativeNames != null && (this.SubjectAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
