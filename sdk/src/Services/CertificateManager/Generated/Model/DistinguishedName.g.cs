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
    /// Contains X.500 distinguished name information.
    /// </summary>
    public partial class DistinguishedName
    {
        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The common name (CN) attribute.
        /// </para>
        /// </summary>
        public string CommonName { get; set; }

        /// <summary>
        /// Checks to see if the CommonName property is set.
        /// </summary>
        internal bool IsSetCommonName() => this.CommonName != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country (C) attribute.
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// A list of custom attributes in the distinguished name. Each custom attribute contains
        /// an object identifier (OID) and its corresponding value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAttribute> CustomAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomAttribute>() : null;

        /// <summary>
        /// Checks to see if the CustomAttributes property is set.
        /// </summary>
        internal bool IsSetCustomAttributes() => this.CustomAttributes != null && (this.CustomAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DistinguishedNameQualifier. 
        /// <para>
        /// The distinguished name qualifier attribute.
        /// </para>
        /// </summary>
        public string DistinguishedNameQualifier { get; set; }

        /// <summary>
        /// Checks to see if the DistinguishedNameQualifier property is set.
        /// </summary>
        internal bool IsSetDistinguishedNameQualifier() => this.DistinguishedNameQualifier != null;

        /// <summary>
        /// Gets and sets the property DomainComponents. 
        /// <para>
        /// The domain component attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DomainComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DomainComponents property is set.
        /// </summary>
        internal bool IsSetDomainComponents() => this.DomainComponents != null && (this.DomainComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GenerationQualifier. 
        /// <para>
        /// The generation qualifier attribute.
        /// </para>
        /// </summary>
        public string GenerationQualifier { get; set; }

        /// <summary>
        /// Checks to see if the GenerationQualifier property is set.
        /// </summary>
        internal bool IsSetGenerationQualifier() => this.GenerationQualifier != null;

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The given name attribute.
        /// </para>
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// Checks to see if the GivenName property is set.
        /// </summary>
        internal bool IsSetGivenName() => this.GivenName != null;

        /// <summary>
        /// Gets and sets the property Initials. 
        /// <para>
        /// The initials attribute.
        /// </para>
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// Checks to see if the Initials property is set.
        /// </summary>
        internal bool IsSetInitials() => this.Initials != null;

        /// <summary>
        /// Gets and sets the property Locality. 
        /// <para>
        /// The locality (L) attribute.
        /// </para>
        /// </summary>
        public string Locality { get; set; }

        /// <summary>
        /// Checks to see if the Locality property is set.
        /// </summary>
        internal bool IsSetLocality() => this.Locality != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The organization (O) attribute.
        /// </para>
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnit. 
        /// <para>
        /// The organizational unit (OU) attribute.
        /// </para>
        /// </summary>
        public string OrganizationalUnit { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnit property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnit() => this.OrganizationalUnit != null;

        /// <summary>
        /// Gets and sets the property Pseudonym. 
        /// <para>
        /// The pseudonym attribute.
        /// </para>
        /// </summary>
        public string Pseudonym { get; set; }

        /// <summary>
        /// Checks to see if the Pseudonym property is set.
        /// </summary>
        internal bool IsSetPseudonym() => this.Pseudonym != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number attribute.
        /// </para>
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state or province (ST) attribute.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// The surname attribute.
        /// </para>
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Checks to see if the Surname property is set.
        /// </summary>
        internal bool IsSetSurname() => this.Surname != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title attribute.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
