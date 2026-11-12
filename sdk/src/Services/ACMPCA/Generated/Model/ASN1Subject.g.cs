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
    /// Contains information about the certificate subject. The <c>Subject</c> field in the
    /// certificate identifies the entity that owns or controls the public key in the certificate.
    /// The entity can be a user, computer, device, or service. The <c>Subject </c>must contain
    /// an X.500 distinguished name (DN). A DN is a sequence of relative distinguished names
    /// (RDNs). The RDNs are separated by commas in the certificate.
    /// </summary>
    public partial class ASN1Subject
    {
        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// For CA and end-entity certificates in a private PKI, the common name (CN) can be any
        /// string within the length limit. 
        /// </para>
        ///  
        /// <para>
        /// Note: In publicly trusted certificates, the common name must be a fully qualified
        /// domain name (FQDN) associated with the certificate subject.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string CommonName { get; set; }

        /// <summary>
        /// Checks to see if the CommonName property is set.
        /// </summary>
        internal bool IsSetCommonName() => this.CommonName != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// Two-digit code that specifies the country in which the certificate subject located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property CustomAttributes.  
        /// <para>
        /// Contains a sequence of one or more X.500 relative distinguished names (RDNs), each
        /// of which consists of an object identifier (OID) and a value. For more information,
        /// see NIST’s definition of <a href="https://csrc.nist.gov/glossary/term/Object_Identifier">Object
        /// Identifier (OID)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Custom attributes cannot be used in combination with standard attributes.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public List<CustomAttribute> CustomAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomAttribute>() : null;

        /// <summary>
        /// Checks to see if the CustomAttributes property is set.
        /// </summary>
        internal bool IsSetCustomAttributes() => this.CustomAttributes != null && (this.CustomAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DistinguishedNameQualifier. 
        /// <para>
        /// Disambiguating information for the certificate subject.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string DistinguishedNameQualifier { get; set; }

        /// <summary>
        /// Checks to see if the DistinguishedNameQualifier property is set.
        /// </summary>
        internal bool IsSetDistinguishedNameQualifier() => this.DistinguishedNameQualifier != null;

        /// <summary>
        /// Gets and sets the property GenerationQualifier. 
        /// <para>
        /// Typically a qualifier appended to the name of an individual. Examples include Jr.
        /// for junior, Sr. for senior, and III for third.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public string GenerationQualifier { get; set; }

        /// <summary>
        /// Checks to see if the GenerationQualifier property is set.
        /// </summary>
        internal bool IsSetGenerationQualifier() => this.GenerationQualifier != null;

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// First name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string GivenName { get; set; }

        /// <summary>
        /// Checks to see if the GivenName property is set.
        /// </summary>
        internal bool IsSetGivenName() => this.GivenName != null;

        /// <summary>
        /// Gets and sets the property Initials. 
        /// <para>
        /// Concatenation that typically contains the first letter of the <b>GivenName</b>, the
        /// first letter of the middle name if one exists, and the first letter of the <b>Surname</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public string Initials { get; set; }

        /// <summary>
        /// Checks to see if the Initials property is set.
        /// </summary>
        internal bool IsSetInitials() => this.Initials != null;

        /// <summary>
        /// Gets and sets the property Locality. 
        /// <para>
        /// The locality (such as a city or town) in which the certificate subject is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Locality { get; set; }

        /// <summary>
        /// Checks to see if the Locality property is set.
        /// </summary>
        internal bool IsSetLocality() => this.Locality != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// Legal name of the organization with which the certificate subject is affiliated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnit. 
        /// <para>
        /// A subdivision or unit of the organization (such as sales or finance) with which the
        /// certificate subject is affiliated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string OrganizationalUnit { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnit property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnit() => this.OrganizationalUnit != null;

        /// <summary>
        /// Gets and sets the property Pseudonym. 
        /// <para>
        /// Typically a shortened version of a longer <b>GivenName</b>. For example, Jonathan
        /// is often shortened to John. Elizabeth is often shortened to Beth, Liz, or Eliza.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Pseudonym { get; set; }

        /// <summary>
        /// Checks to see if the Pseudonym property is set.
        /// </summary>
        internal bool IsSetPseudonym() => this.Pseudonym != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The certificate serial number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State in which the subject of the certificate is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// Family name. In the US and the UK, for example, the surname of an individual is ordered
        /// last. In Asian cultures the surname is typically ordered first.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public string Surname { get; set; }

        /// <summary>
        /// Checks to see if the Surname property is set.
        /// </summary>
        internal bool IsSetSurname() => this.Surname != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title such as Mr. or Ms., which is pre-pended to the name to refer formally to the
        /// certificate subject.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
