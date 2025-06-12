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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// ContactDetail includes the following elements.
    /// </summary>
    public partial class ContactDetail
    {
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private ContactType _contactType;
        private CountryCode _countryCode;
        private string _email;
        private List<ExtraParam> _extraParams = AWSConfigs.InitializeCollections ? new List<ExtraParam>() : null;
        private string _fax;
        private string _firstName;
        private string _lastName;
        private string _organizationName;
        private string _phoneNumber;
        private string _state;
        private string _zipCode;

        /// <summary>
        /// Gets and sets the property AddressLine1. 
        /// <para>
        /// First line of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
        public string AddressLine1
        {
            get { return this._addressLine1; }
            set { this._addressLine1 = value; }
        }

        // Check to see if AddressLine1 property is set
        internal bool IsSetAddressLine1()
        {
            return this._addressLine1 != null;
        }

        /// <summary>
        /// Gets and sets the property AddressLine2. 
        /// <para>
        /// Second line of contact's address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
        public string AddressLine2
        {
            get { return this._addressLine2; }
            set { this._addressLine2 = value; }
        }

        // Check to see if AddressLine2 property is set
        internal bool IsSetAddressLine2()
        {
            return this._addressLine2 != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property ContactType. 
        /// <para>
        /// Indicates whether the contact is a person, company, association, or public organization.
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a value other than <c>PERSON</c>, you must also specify a value for
        /// <c>OrganizationName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For some TLDs, the privacy protection available depends on the value that you specify
        /// for <c>Contact Type</c>. For the privacy protection settings for your TLD, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For .es domains, the value of <c>ContactType</c> must be <c>PERSON</c> for all three
        /// contacts.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContactType ContactType
        {
            get { return this._contactType; }
            set { this._contactType = value; }
        }

        // Check to see if ContactType property is set
        internal bool IsSetContactType()
        {
            return this._contactType != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// Code for the country of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public CountryCode CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Email address of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=254)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraParams. 
        /// <para>
        /// A list of name-value pairs for parameters required by certain top-level domains.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExtraParam> ExtraParams
        {
            get { return this._extraParams; }
            set { this._extraParams = value; }
        }

        // Check to see if ExtraParams property is set
        internal bool IsSetExtraParams()
        {
            return this._extraParams != null && (this._extraParams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Fax. 
        /// <para>
        /// Fax number of the contact.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Phone number must be specified in the format "+[country dialing code].[number
        /// including any area code]". For example, a US phone number might appear as <c>"+1.1234567890"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=30)]
        public string Fax
        {
            get { return this._fax; }
            set { this._fax = value; }
        }

        // Check to see if Fax property is set
        internal bool IsSetFax()
        {
            return this._fax != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// First name of contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// Last name of contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// Name of the organization for contact types other than <c>PERSON</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
        public string OrganizationName
        {
            get { return this._organizationName; }
            set { this._organizationName = value; }
        }

        // Check to see if OrganizationName property is set
        internal bool IsSetOrganizationName()
        {
            return this._organizationName != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number of the contact.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Phone number must be specified in the format "+[country dialing code].[number
        /// including any area code&gt;]". For example, a US phone number might appear as <c>"+1.1234567890"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=30)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state or province of the contact's city.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
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
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// The zip or postal code of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=255)]
        public string ZipCode
        {
            get { return this._zipCode; }
            set { this._zipCode = value; }
        }

        // Check to see if ZipCode property is set
        internal bool IsSetZipCode()
        {
            return this._zipCode != null;
        }

    }
}