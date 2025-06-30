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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about an address.
    /// </summary>
    public partial class Address
    {
        private string _addressLine1;
        private string _addressLine2;
        private string _addressLine3;
        private string _city;
        private string _contactName;
        private string _contactPhoneNumber;
        private string _countryCode;
        private string _districtOrCounty;
        private string _municipality;
        private string _postalCode;
        private string _stateOrRegion;

        /// <summary>
        /// Gets and sets the property AddressLine1. 
        /// <para>
        /// The first line of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=180)]
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
        /// The second line of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
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
        /// The third line of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
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
        /// The city for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property ContactName. 
        /// <para>
        /// The name of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ContactName
        {
            get { return this._contactName; }
            set { this._contactName = value; }
        }

        // Check to see if ContactName property is set
        internal bool IsSetContactName()
        {
            return this._contactName != null;
        }

        /// <summary>
        /// Gets and sets the property ContactPhoneNumber. 
        /// <para>
        /// The phone number of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string ContactPhoneNumber
        {
            get { return this._contactPhoneNumber; }
            set { this._contactPhoneNumber = value; }
        }

        // Check to see if ContactPhoneNumber property is set
        internal bool IsSetContactPhoneNumber()
        {
            return this._contactPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The ISO-3166 two-letter country code for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
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
        /// The district or county for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
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
        /// Gets and sets the property Municipality. 
        /// <para>
        /// The municipality for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=180)]
        public string Municipality
        {
            get { return this._municipality; }
            set { this._municipality = value; }
        }

        // Check to see if Municipality property is set
        internal bool IsSetMunicipality()
        {
            return this._municipality != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
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
        /// The state for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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

    }
}