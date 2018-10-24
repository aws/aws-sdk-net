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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The information for public switched telephone network (PSTN) conferencing.
    /// </summary>
    public partial class PSTNDialIn
    {
        private string _countryCode;
        private string _oneClickIdDelay;
        private string _oneClickPinDelay;
        private string _phoneNumber;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The zip code.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OneClickIdDelay. 
        /// <para>
        /// The delay duration before Alexa enters the conference ID with dual-tone multi-frequency
        /// (DTMF). Each number on the dial pad corresponds to a DTMF tone, which is how we send
        /// data over the telephone network.
        /// </para>
        /// </summary>
        public string OneClickIdDelay
        {
            get { return this._oneClickIdDelay; }
            set { this._oneClickIdDelay = value; }
        }

        // Check to see if OneClickIdDelay property is set
        internal bool IsSetOneClickIdDelay()
        {
            return this._oneClickIdDelay != null;
        }

        /// <summary>
        /// Gets and sets the property OneClickPinDelay. 
        /// <para>
        /// The delay duration before Alexa enters the conference pin with dual-tone multi-frequency
        /// (DTMF). Each number on the dial pad corresponds to a DTMF tone, which is how we send
        /// data over the telephone network.
        /// </para>
        /// </summary>
        public string OneClickPinDelay
        {
            get { return this._oneClickPinDelay; }
            set { this._oneClickPinDelay = value; }
        }

        // Check to see if OneClickPinDelay property is set
        internal bool IsSetOneClickPinDelay()
        {
            return this._oneClickPinDelay != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number to call to join the conference.
        /// </para>
        /// </summary>
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

    }
}