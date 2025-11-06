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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
        private string _carrier;
        private string _country;
        private string _dialingCountryCode;
        private string _e164PhoneNumber;
        private string _isoCountryCode;
        private string _mcc;
        private string _mnc;
        private PhoneNumberType _phoneNumberType;

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
        /// Gets and sets the property Country. 
        /// <para>
        /// The name of the country where the phone number was originally registered.
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
        /// Gets and sets the property DialingCountryCode. 
        /// <para>
        /// The numeric dialing code for the country or region where the phone number was originally
        /// registered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public string DialingCountryCode
        {
            get { return this._dialingCountryCode; }
            set { this._dialingCountryCode = value; }
        }

        // Check to see if DialingCountryCode property is set
        internal bool IsSetDialingCountryCode()
        {
            return this._dialingCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property E164PhoneNumber. 
        /// <para>
        /// The phone number in E164 format, sanitized from the original input by removing any
        /// formatting characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string E164PhoneNumber
        {
            get { return this._e164PhoneNumber; }
            set { this._e164PhoneNumber = value; }
        }

        // Check to see if E164PhoneNumber property is set
        internal bool IsSetE164PhoneNumber()
        {
            return this._e164PhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region where
        /// the phone number was originally registered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string IsoCountryCode
        {
            get { return this._isoCountryCode; }
            set { this._isoCountryCode = value; }
        }

        // Check to see if IsoCountryCode property is set
        internal bool IsSetIsoCountryCode()
        {
            return this._isoCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property MCC. 
        /// <para>
        /// The phone number's mobile country code, for mobile phone number types
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string MCC
        {
            get { return this._mcc; }
            set { this._mcc = value; }
        }

        // Check to see if MCC property is set
        internal bool IsSetMCC()
        {
            return this._mcc != null;
        }

        /// <summary>
        /// Gets and sets the property MNC. 
        /// <para>
        /// The phone number's mobile network code, for mobile phone number types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=3)]
        public string MNC
        {
            get { return this._mnc; }
            set { this._mnc = value; }
        }

        // Check to see if MNC property is set
        internal bool IsSetMNC()
        {
            return this._mnc != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberType. 
        /// <para>
        /// Describes the type of phone number. Valid values are: MOBILE, LANDLINE, OTHER, and
        /// INVALID. Avoid sending SMS or voice messages to INVALID phone numbers, as these numbers
        /// are unlikely to belong to actual recipients.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhoneNumberType PhoneNumberType
        {
            get { return this._phoneNumberType; }
            set { this._phoneNumberType = value; }
        }

        // Check to see if PhoneNumberType property is set
        internal bool IsSetPhoneNumberType()
        {
            return this._phoneNumberType != null;
        }

    }
}