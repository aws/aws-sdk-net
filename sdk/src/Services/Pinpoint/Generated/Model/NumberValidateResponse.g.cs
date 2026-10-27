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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about a phone number.
    /// </summary>
    public partial class NumberValidateResponse
    {
        /// <summary>
        /// Gets and sets the property Carrier. 
        /// <para>
        /// The carrier or service provider that the phone number is currently registered with.
        /// In some countries and regions, this value may be the carrier or service provider that
        /// the phone number was originally registered with.
        /// </para>
        /// </summary>
        public string Carrier { get; set; }

        /// <summary>
        /// Checks to see if the Carrier property is set.
        /// </summary>
        internal bool IsSetCarrier() => this.Carrier != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The name of the city where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property CleansedPhoneNumberE164. 
        /// <para>
        /// The cleansed phone number, in E.164 format, for the location where the phone number
        /// was originally registered.
        /// </para>
        /// </summary>
        public string CleansedPhoneNumberE164 { get; set; }

        /// <summary>
        /// Checks to see if the CleansedPhoneNumberE164 property is set.
        /// </summary>
        internal bool IsSetCleansedPhoneNumberE164() => this.CleansedPhoneNumberE164 != null;

        /// <summary>
        /// Gets and sets the property CleansedPhoneNumberNational. 
        /// <para>
        /// The cleansed phone number, in the format for the location where the phone number was
        /// originally registered.
        /// </para>
        /// </summary>
        public string CleansedPhoneNumberNational { get; set; }

        /// <summary>
        /// Checks to see if the CleansedPhoneNumberNational property is set.
        /// </summary>
        internal bool IsSetCleansedPhoneNumberNational() => this.CleansedPhoneNumberNational != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The name of the country or region where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property CountryCodeIso2. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region where
        /// the phone number was originally registered.
        /// </para>
        /// </summary>
        public string CountryCodeIso2 { get; set; }

        /// <summary>
        /// Checks to see if the CountryCodeIso2 property is set.
        /// </summary>
        internal bool IsSetCountryCodeIso2() => this.CountryCodeIso2 != null;

        /// <summary>
        /// Gets and sets the property CountryCodeNumeric. 
        /// <para>
        /// The numeric code for the country or region where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string CountryCodeNumeric { get; set; }

        /// <summary>
        /// Checks to see if the CountryCodeNumeric property is set.
        /// </summary>
        internal bool IsSetCountryCodeNumeric() => this.CountryCodeNumeric != null;

        /// <summary>
        /// Gets and sets the property County. 
        /// <para>
        /// The name of the county where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Checks to see if the County property is set.
        /// </summary>
        internal bool IsSetCounty() => this.County != null;

        /// <summary>
        /// Gets and sets the property OriginalCountryCodeIso2. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, that was sent in the request
        /// body.
        /// </para>
        /// </summary>
        public string OriginalCountryCodeIso2 { get; set; }

        /// <summary>
        /// Checks to see if the OriginalCountryCodeIso2 property is set.
        /// </summary>
        internal bool IsSetOriginalCountryCodeIso2() => this.OriginalCountryCodeIso2 != null;

        /// <summary>
        /// Gets and sets the property OriginalPhoneNumber. 
        /// <para>
        /// The phone number that was sent in the request body.
        /// </para>
        /// </summary>
        public string OriginalPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the OriginalPhoneNumber property is set.
        /// </summary>
        internal bool IsSetOriginalPhoneNumber() => this.OriginalPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PhoneType. 
        /// <para>
        /// The description of the phone type. Valid values are: MOBILE, LANDLINE, VOIP, INVALID,
        /// PREPAID, and OTHER.
        /// </para>
        /// </summary>
        public string PhoneType { get; set; }

        /// <summary>
        /// Checks to see if the PhoneType property is set.
        /// </summary>
        internal bool IsSetPhoneType() => this.PhoneType != null;

        /// <summary>
        /// Gets and sets the property PhoneTypeCode. 
        /// <para>
        /// The phone type, represented by an integer. Valid values are: 0 (mobile), 1 (landline),
        /// 2 (VoIP), 3 (invalid), 4 (other), and 5 (prepaid).
        /// </para>
        /// </summary>
        public int? PhoneTypeCode { get; set; }

        /// <summary>
        /// Checks to see if the PhoneTypeCode property is set.
        /// </summary>
        internal bool IsSetPhoneTypeCode() => this.PhoneTypeCode.HasValue;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone for the location where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// The postal or ZIP code for the location where the phone number was originally registered.
        /// </para>
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Checks to see if the ZipCode property is set.
        /// </summary>
        internal bool IsSetZipCode() => this.ZipCode != null;
    }
}
