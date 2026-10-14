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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the CarrierLookup operation.
    /// </summary>
    public partial class CarrierLookupResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property Country. 
        /// <para>
        /// The name of the country or region for the phone number.
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property DialingCountryCode. 
        /// <para>
        /// The country or region numeric dialing code for the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public string DialingCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the DialingCountryCode property is set.
        /// </summary>
        internal bool IsSetDialingCountryCode() => this.DialingCountryCode != null;

        /// <summary>
        /// Gets and sets the property E164PhoneNumber. 
        /// <para>
        /// The phone number in E164 format, sanitized from the original input by removing any
        /// formatting characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string E164PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the E164PhoneNumber property is set.
        /// </summary>
        internal bool IsSetE164PhoneNumber() => this.E164PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character country or region code, in ISO 3166-1 alpha-2 format, for the phone
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the IsoCountryCode property is set.
        /// </summary>
        internal bool IsSetIsoCountryCode() => this.IsoCountryCode != null;

        /// <summary>
        /// Gets and sets the property MCC. 
        /// <para>
        /// The phone number's mobile country code, for mobile phone number types
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string MCC { get; set; }

        /// <summary>
        /// Checks to see if the MCC property is set.
        /// </summary>
        internal bool IsSetMCC() => this.MCC != null;

        /// <summary>
        /// Gets and sets the property MNC. 
        /// <para>
        /// The phone number's mobile network code, for mobile phone number types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 3)]
        public string MNC { get; set; }

        /// <summary>
        /// Checks to see if the MNC property is set.
        /// </summary>
        internal bool IsSetMNC() => this.MNC != null;

        /// <summary>
        /// Gets and sets the property OriginalPhoneNumber. 
        /// <para>
        /// The phone number exactly as you supplied it in the request. This field is returned
        /// only when you set <c>EnableCleansing</c> to <c>true</c>, the phone number was cleansed,
        /// and a normalized E.164 phone number was returned in the <c>E164PhoneNumber</c> field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string OriginalPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the OriginalPhoneNumber property is set.
        /// </summary>
        internal bool IsSetOriginalPhoneNumber() => this.OriginalPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberType. 
        /// <para>
        /// Describes the type of phone number. Valid values are: MOBILE, LANDLINE, VOIP, PREPAID,
        /// OTHER, and INVALID. Avoid sending SMS or voice messages to INVALID phone numbers,
        /// as these numbers are unlikely to belong to actual recipients.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberType property is set.
        /// </summary>
        internal bool IsSetPhoneNumberType() => this.PhoneNumberType != null;
    }
}
