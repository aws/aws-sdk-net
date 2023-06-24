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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAvailablePhoneNumbers operation.
    /// Searches the provisioned phone numbers in an organization.
    /// </summary>
    public partial class SearchAvailablePhoneNumbersRequest : AmazonChimeSDKVoiceRequest
    {
        private string _areaCode;
        private string _city;
        private string _country;
        private int? _maxResults;
        private string _nextToken;
        private PhoneNumberType _phoneNumberType;
        private string _state;
        private string _tollFreePrefix;

        /// <summary>
        /// Gets and sets the property AreaCode. 
        /// <para>
        /// Confines a search to just the phone numbers associated with the specified area code.
        /// </para>
        /// </summary>
        public string AreaCode
        {
            get { return this._areaCode; }
            set { this._areaCode = value; }
        }

        // Check to see if AreaCode property is set
        internal bool IsSetAreaCode()
        {
            return this._areaCode != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// Confines a search to just the phone numbers associated with the specified city.
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
        /// Gets and sets the property Country. 
        /// <para>
        /// Confines a search to just the phone numbers associated with the specified country.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to return the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberType. 
        /// <para>
        /// Confines a search to just the phone numbers associated with the specified phone number
        /// type, either <b>local</b> or <b>toll-free</b>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Confines a search to just the phone numbers associated with the specified state.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TollFreePrefix. 
        /// <para>
        /// Confines a search to just the phone numbers associated with the specified toll-free
        /// prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string TollFreePrefix
        {
            get { return this._tollFreePrefix; }
            set { this._tollFreePrefix = value; }
        }

        // Check to see if TollFreePrefix property is set
        internal bool IsSetTollFreePrefix()
        {
            return this._tollFreePrefix != null;
        }

    }
}