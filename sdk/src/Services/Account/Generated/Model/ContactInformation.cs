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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Account.Model
{
    /// <summary>
    /// Contains the details of the primary contact information associated with an Amazon
    /// Web Services account.
    /// </summary>
    public partial class ContactInformation
    {
        private string _addressLine1;
        private string _addressLine2;
        private string _addressLine3;
        private string _city;
        private string _companyName;
        private string _countryCode;
        private string _districtOrCounty;
        private string _fullName;
        private string _phoneNumber;
        private string _postalCode;
        private string _stateOrRegion;
        private string _websiteUrl;

        /// <summary>
        /// Gets and sets the property AddressLine1. 
        /// <para>
        /// The first line of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=60)]
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
        /// The second line of the primary contact address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=60)]
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
        /// Gets and sets the property AddressLine3. 
        /// <para>
        /// The third line of the primary contact address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=60)]
        public string AddressLine3
        {
            get { return this._addressLine3; }
            set { this._addressLine3 = value; }
        }

        // Check to see if AddressLine3 property is set
        internal bool IsSetAddressLine3()
        {
            return this._addressLine3 != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=50)]
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
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the company associated with the primary contact information, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        // Check to see if CompanyName property is set
        internal bool IsSetCompanyName()
        {
            return this._companyName != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The ISO-3166 two-letter country code for the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public string CountryCode
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
        /// Gets and sets the property DistrictOrCounty. 
        /// <para>
        /// The district or county of the primary contact address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string DistrictOrCounty
        {
            get { return this._districtOrCounty; }
            set { this._districtOrCounty = value; }
        }

        // Check to see if DistrictOrCounty property is set
        internal bool IsSetDistrictOrCounty()
        {
            return this._districtOrCounty != null;
        }

        /// <summary>
        /// Gets and sets the property FullName. 
        /// <para>
        /// The full name of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=50)]
        public string FullName
        {
            get { return this._fullName; }
            set { this._fullName = value; }
        }

        // Check to see if FullName property is set
        internal bool IsSetFullName()
        {
            return this._fullName != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number of the primary contact information. The number will be validated
        /// and, in some countries, checked for activation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=20)]
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
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=20)]
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }

        /// <summary>
        /// Gets and sets the property StateOrRegion. 
        /// <para>
        /// The state or region of the primary contact address. This field is required in selected
        /// countries.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string StateOrRegion
        {
            get { return this._stateOrRegion; }
            set { this._stateOrRegion = value; }
        }

        // Check to see if StateOrRegion property is set
        internal bool IsSetStateOrRegion()
        {
            return this._stateOrRegion != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The URL of the website associated with the primary contact information, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string WebsiteUrl
        {
            get { return this._websiteUrl; }
            set { this._websiteUrl = value; }
        }

        // Check to see if WebsiteUrl property is set
        internal bool IsSetWebsiteUrl()
        {
            return this._websiteUrl != null;
        }

    }
}