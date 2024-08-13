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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAvailablePhoneNumbers operation.
    /// Searches for phone numbers that can be ordered. For US numbers, provide at least one
    /// of the following search filters: <c>AreaCode</c>, <c>City</c>, <c>State</c>, or <c>TollFreePrefix</c>.
    /// If you provide <c>City</c>, you must also provide <c>State</c>. Numbers outside the
    /// US only support the <c>PhoneNumberType</c> filter, which you must use.
    /// </summary>
    public partial class SearchAvailablePhoneNumbersRequest : AmazonChimeRequest
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
        /// The area code used to filter results. Only applies to the US.
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
        /// The city used to filter results. Only applies to the US.
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
        /// The country used to filter results. Defaults to the US Format: ISO 3166-1 alpha-2.
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
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The token used to retrieve the next page of results.
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
        /// The phone number type used to filter results. Required for non-US numbers.
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
        /// The state used to filter results. Required only if you provide <c>City</c>. Only applies
        /// to the US.
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
        /// The toll-free prefix that you use to filter results. Only applies to the US.
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