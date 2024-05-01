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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about a phone number.
    /// </summary>
    public partial class NumberValidateResponse
    {
        private string _carrier;
        private string _city;
        private string _cleansedPhoneNumberE164;
        private string _cleansedPhoneNumberNational;
        private string _country;
        private string _countryCodeIso2;
        private string _countryCodeNumeric;
        private string _county;
        private string _originalCountryCodeIso2;
        private string _originalPhoneNumber;
        private string _phoneType;
        private int? _phoneTypeCode;
        private string _timezone;
        private string _zipCode;

        /// <summary>
        /// Gets and sets the property Carrier. 
        /// <para>
        /// The carrier or service provider that the phone number is currently registered with.
        /// In some countries and regions, this value may be the carrier or service provider that
        /// the phone number was originally registered with.
        /// </para>
        /// </summary>
        public string Carrier
        {
            get { return this._carrier; }
            set { this._carrier = value; }
        }

        // Check to see if Carrier property is set
        internal bool IsSetCarrier()
        {
            return this._carrier != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The name of the city where the phone number was originally registered.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CleansedPhoneNumberE164. 
        /// <para>
        /// The cleansed phone number, in E.164 format, for the location where the phone number
        /// was originally registered.
        /// </para>
        /// </summary>
        public string CleansedPhoneNumberE164
        {
            get { return this._cleansedPhoneNumberE164; }
            set { this._cleansedPhoneNumberE164 = value; }
        }

        // Check to see if CleansedPhoneNumberE164 property is set
        internal bool IsSetCleansedPhoneNumberE164()
        {
            return this._cleansedPhoneNumberE164 != null;
        }

        /// <summary>
        /// Gets and sets the property CleansedPhoneNumberNational. 
        /// <para>
        /// The cleansed phone number, in the format for the location where the phone number was
        /// originally registered.
        /// </para>
        /// </summary>
        public string CleansedPhoneNumberNational
        {
            get { return this._cleansedPhoneNumberNational; }
            set { this._cleansedPhoneNumberNational = value; }
        }

        // Check to see if CleansedPhoneNumberNational property is set
        internal bool IsSetCleansedPhoneNumberNational()
        {
            return this._cleansedPhoneNumberNational != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The name of the country or region where the phone number was originally registered.
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
        /// Gets and sets the property CountryCodeIso2. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region where
        /// the phone number was originally registered.
        /// </para>
        /// </summary>
        public string CountryCodeIso2
        {
            get { return this._countryCodeIso2; }
            set { this._countryCodeIso2 = value; }
        }

        // Check to see if CountryCodeIso2 property is set
        internal bool IsSetCountryCodeIso2()
        {
            return this._countryCodeIso2 != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCodeNumeric. 
        /// <para>
        /// The numeric code for the country or region where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string CountryCodeNumeric
        {
            get { return this._countryCodeNumeric; }
            set { this._countryCodeNumeric = value; }
        }

        // Check to see if CountryCodeNumeric property is set
        internal bool IsSetCountryCodeNumeric()
        {
            return this._countryCodeNumeric != null;
        }

        /// <summary>
        /// Gets and sets the property County. 
        /// <para>
        /// The name of the county where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string County
        {
            get { return this._county; }
            set { this._county = value; }
        }

        // Check to see if County property is set
        internal bool IsSetCounty()
        {
            return this._county != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalCountryCodeIso2. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, that was sent in the request
        /// body.
        /// </para>
        /// </summary>
        public string OriginalCountryCodeIso2
        {
            get { return this._originalCountryCodeIso2; }
            set { this._originalCountryCodeIso2 = value; }
        }

        // Check to see if OriginalCountryCodeIso2 property is set
        internal bool IsSetOriginalCountryCodeIso2()
        {
            return this._originalCountryCodeIso2 != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalPhoneNumber. 
        /// <para>
        /// The phone number that was sent in the request body.
        /// </para>
        /// </summary>
        public string OriginalPhoneNumber
        {
            get { return this._originalPhoneNumber; }
            set { this._originalPhoneNumber = value; }
        }

        // Check to see if OriginalPhoneNumber property is set
        internal bool IsSetOriginalPhoneNumber()
        {
            return this._originalPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneType. 
        /// <para>
        /// The description of the phone type. Valid values are: MOBILE, LANDLINE, VOIP,     
        ///             INVALID, PREPAID, and OTHER.
        /// </para>
        /// </summary>
        public string PhoneType
        {
            get { return this._phoneType; }
            set { this._phoneType = value; }
        }

        // Check to see if PhoneType property is set
        internal bool IsSetPhoneType()
        {
            return this._phoneType != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneTypeCode. 
        /// <para>
        /// The phone type, represented by an integer. Valid values are: 0 (mobile), 1 (landline),
        /// 2 (VoIP), 3 (invalid), 4 (other), and 5 (prepaid).
        /// </para>
        /// </summary>
        public int? PhoneTypeCode
        {
            get { return this._phoneTypeCode; }
            set { this._phoneTypeCode = value; }
        }

        // Check to see if PhoneTypeCode property is set
        internal bool IsSetPhoneTypeCode()
        {
            return this._phoneTypeCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone for the location where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// The postal or ZIP code for the location where the phone number was originally registered.
        /// </para>
        /// </summary>
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