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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The proxy configuration for an Amazon Chime Voice Connector.
    /// </summary>
    public partial class Proxy
    {
        private int? _defaultSessionExpiryMinutes;
        private bool? _disabled;
        private string _fallBackPhoneNumber;
        private List<string> _phoneNumberCountries = new List<string>();

        /// <summary>
        /// Gets and sets the property DefaultSessionExpiryMinutes. 
        /// <para>
        /// The default number of minutes allowed for proxy sessions.
        /// </para>
        /// </summary>
        public int DefaultSessionExpiryMinutes
        {
            get { return this._defaultSessionExpiryMinutes.GetValueOrDefault(); }
            set { this._defaultSessionExpiryMinutes = value; }
        }

        // Check to see if DefaultSessionExpiryMinutes property is set
        internal bool IsSetDefaultSessionExpiryMinutes()
        {
            return this._defaultSessionExpiryMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When true, stops proxy sessions from being created on the specified Amazon Chime Voice
        /// Connector.
        /// </para>
        /// </summary>
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FallBackPhoneNumber. 
        /// <para>
        /// The phone number to route calls to after a proxy session expires.
        /// </para>
        /// </summary>
        public string FallBackPhoneNumber
        {
            get { return this._fallBackPhoneNumber; }
            set { this._fallBackPhoneNumber = value; }
        }

        // Check to see if FallBackPhoneNumber property is set
        internal bool IsSetFallBackPhoneNumber()
        {
            return this._fallBackPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberCountries. 
        /// <para>
        /// The countries for proxy phone numbers to be selected from.
        /// </para>
        /// </summary>
        public List<string> PhoneNumberCountries
        {
            get { return this._phoneNumberCountries; }
            set { this._phoneNumberCountries = value; }
        }

        // Check to see if PhoneNumberCountries property is set
        internal bool IsSetPhoneNumberCountries()
        {
            return this._phoneNumberCountries != null && this._phoneNumberCountries.Count > 0; 
        }

    }
}