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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
        private string _commonName;
        private string _country;
        private List<CustomAttribute> _customAttributes = AWSConfigs.InitializeCollections ? new List<CustomAttribute>() : null;
        private string _distinguishedNameQualifier;
        private List<string> _domainComponents = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// The common name (CN) attribute.
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
        /// The country (C) attribute.
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
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// A list of custom attributes in the distinguished name. Each custom attribute contains
        /// an object identifier (OID) and its corresponding value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAttribute> CustomAttributes
        {
            get { return this._customAttributes; }
            set { this._customAttributes = value; }
        }

        // Check to see if CustomAttributes property is set
        internal bool IsSetCustomAttributes()
        {
            return this._customAttributes != null && (this._customAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DistinguishedNameQualifier. 
        /// <para>
        /// The distinguished name qualifier attribute.
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
        /// Gets and sets the property DomainComponents. 
        /// <para>
        /// The domain component attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DomainComponents
        {
            get { return this._domainComponents; }
            set { this._domainComponents = value; }
        }

        // Check to see if DomainComponents property is set
        internal bool IsSetDomainComponents()
        {
            return this._domainComponents != null && (this._domainComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GenerationQualifier. 
        /// <para>
        /// The generation qualifier attribute.
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
        /// The given name attribute.
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
        /// The initials attribute.
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
        /// The locality (L) attribute.
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
        /// The organization (O) attribute.
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
        /// The organizational unit (OU) attribute.
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
        /// The pseudonym attribute.
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
        /// The serial number attribute.
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
        /// The state or province (ST) attribute.
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
        /// The surname attribute.
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
        /// The title attribute.
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