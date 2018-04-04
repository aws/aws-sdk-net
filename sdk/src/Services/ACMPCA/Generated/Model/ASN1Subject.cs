/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains information about the certificate subject. The certificate can be one issued
    /// by your private certificate authority (CA) or it can be your private CA certificate.
    /// The <b>Subject</b> field in the certificate identifies the entity that owns or controls
    /// the public key in the certificate. The entity can be a user, computer, device, or
    /// service. The <b>Subject</b> must contain an X.500 distinguished name (DN). A DN is
    /// a sequence of relative distinguished names (RDNs). The RDNs are separated by commas
    /// in the certificate. The DN must be unique for each for each entity, but your private
    /// CA can issue more than one certificate with the same DN to the same entity.
    /// </summary>
    public partial class ASN1Subject
    {
        private string _commonName;
        private string _country;
        private string _distinguishedNameQualifier;
        private string _generationQualifier;
        private string _givenName;
        private string _initials;
        private string _locality;
        private string _organization;
        private string _organizationalUnit;
        private string _pseudonym;
        private string _serialNumber;
        private string _state;
        private string _surname;
        private string _title;

        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// Fully qualified domain name (FQDN) associated with the certificate subject.
        /// </para>
        /// </summary>
        public string CommonName
        {
            get { return this._commonName; }
            set { this._commonName = value; }
        }

        // Check to see if CommonName property is set
        internal bool IsSetCommonName()
        {
            return this._commonName != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// Two digit code that specifies the country in which the certificate subject located.
        /// </para>
        /// </summary>
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property DistinguishedNameQualifier. 
        /// <para>
        /// Disambiguating information for the certificate subject.
        /// </para>
        /// </summary>
        public string DistinguishedNameQualifier
        {
            get { return this._distinguishedNameQualifier; }
            set { this._distinguishedNameQualifier = value; }
        }

        // Check to see if DistinguishedNameQualifier property is set
        internal bool IsSetDistinguishedNameQualifier()
        {
            return this._distinguishedNameQualifier != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationQualifier. 
        /// <para>
        /// Typically a qualifier appended to the name of an individual. Examples include Jr.
        /// for junior, Sr. for senior, and III for third.
        /// </para>
        /// </summary>
        public string GenerationQualifier
        {
            get { return this._generationQualifier; }
            set { this._generationQualifier = value; }
        }

        // Check to see if GenerationQualifier property is set
        internal bool IsSetGenerationQualifier()
        {
            return this._generationQualifier != null;
        }

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// First name.
        /// </para>
        /// </summary>
        public string GivenName
        {
            get { return this._givenName; }
            set { this._givenName = value; }
        }

        // Check to see if GivenName property is set
        internal bool IsSetGivenName()
        {
            return this._givenName != null;
        }

        /// <summary>
        /// Gets and sets the property Initials. 
        /// <para>
        /// Concatenation that typically contains the first letter of the <b>GivenName</b>, the
        /// first letter of the middle name if one exists, and the first letter of the <b>SurName</b>.
        /// </para>
        /// </summary>
        public string Initials
        {
            get { return this._initials; }
            set { this._initials = value; }
        }

        // Check to see if Initials property is set
        internal bool IsSetInitials()
        {
            return this._initials != null;
        }

        /// <summary>
        /// Gets and sets the property Locality. 
        /// <para>
        /// The locality (such as a city or town) in which the certificate subject is located.
        /// </para>
        /// </summary>
        public string Locality
        {
            get { return this._locality; }
            set { this._locality = value; }
        }

        // Check to see if Locality property is set
        internal bool IsSetLocality()
        {
            return this._locality != null;
        }

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// Legal name of the organization with which the certificate subject is affiliated. 
        /// </para>
        /// </summary>
        public string Organization
        {
            get { return this._organization; }
            set { this._organization = value; }
        }

        // Check to see if Organization property is set
        internal bool IsSetOrganization()
        {
            return this._organization != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnit. 
        /// <para>
        /// A subdivision or unit of the organization (such as sales or finance) with which the
        /// certificate subject is affiliated.
        /// </para>
        /// </summary>
        public string OrganizationalUnit
        {
            get { return this._organizationalUnit; }
            set { this._organizationalUnit = value; }
        }

        // Check to see if OrganizationalUnit property is set
        internal bool IsSetOrganizationalUnit()
        {
            return this._organizationalUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Pseudonym. 
        /// <para>
        /// Typically a shortened version of a longer <b>GivenName</b>. For example, Jonathan
        /// is often shortened to John. Elizabeth is often shortened to Beth, Liz, or Eliza.
        /// </para>
        /// </summary>
        public string Pseudonym
        {
            get { return this._pseudonym; }
            set { this._pseudonym = value; }
        }

        // Check to see if Pseudonym property is set
        internal bool IsSetPseudonym()
        {
            return this._pseudonym != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The certificate serial number.
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State in which the subject of the certificate is located.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// Family name. In the US and the UK for example, the surname of an individual is ordered
        /// last. In Asian cultures the surname is typically ordered first.
        /// </para>
        /// </summary>
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }

        // Check to see if Surname property is set
        internal bool IsSetSurname()
        {
            return this._surname != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title such as Mr. or Ms. which is pre-pended to the name to refer formally to the
        /// certificate subject.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}