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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// The details of the address associated with the TRN information.
    /// </summary>
    public partial class Address
    {
        private string _addressLine1;
        private string _addressLine2;
        private string _addressLine3;
        private string _city;
        private string _countryCode;
        private string _districtOrCounty;
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
        /// The second line of the address, if applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
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
        ///  The third line of the address, if applicable. Currently, the Tax Settings API accepts
        /// the <c>addressLine3</c> parameter only for Saudi Arabia. When you specify a TRN in
        /// Saudi Arabia, you must enter the <c>addressLine3</c> and specify the building number
        /// for the address. For example, you might enter <c>1234</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
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
        /// The city that the address is in. 
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
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code for the country that the address is in. 
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
        /// The district or county the address is located. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For addresses in Brazil, this parameter uses the name of the neighborhood. When you
        /// set a TRN in Brazil, use <c>districtOrCounty</c> for the neighborhood name.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property PostalCode. 
        /// <para>
        ///  The postal code associated with the address. 
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
        /// The state, region, or province that the address is located. This field is only required
        /// for Canada, India, United Arab Emirates, Romania, and Brazil (CPF). It is optional
        /// for all other countries.
        /// </para>
        ///  
        /// <para>
        /// If this is required for tax settings, use the same name as shown on the <b>Tax Settings</b>
        /// page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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