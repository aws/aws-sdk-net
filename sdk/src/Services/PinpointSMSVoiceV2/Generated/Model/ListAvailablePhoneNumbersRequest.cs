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
    /// Container for the parameters to the ListAvailablePhoneNumbers operation.
    /// Search available phone numbers from aggregator inventory, optionally filtered by pattern.
    /// If NumberPreference is omitted, returns unfiltered available numbers. Returns empty
    /// list (not an exception) when no numbers match. ResourceNotFoundException is thrown
    /// only for invalid RegistrationId (campaign not found).
    /// </summary>
    public partial class ListAvailablePhoneNumbersRequest : AmazonPinpointSMSVoiceV2Request
    {
        private string _isoCountryCode;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _numberCapabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<NumberPreferenceItem> _numberPreference = AWSConfigs.InitializeCollections ? new List<NumberPreferenceItem>() : null;
        private SearchableNumberType _numberType;
        private string _registrationId;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region in
        /// which to search for available phone numbers. This operation currently supports only
        /// <c>US</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page. If you don't specify a value, the
        /// default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// The token returned from a previous request to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// The capabilities to filter by, such as SMS. Only phone numbers that support all of
        /// the specified capabilities are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> NumberCapabilities
        {
            get { return this._numberCapabilities; }
            set { this._numberCapabilities = value; }
        }

        // Check to see if NumberCapabilities property is set
        internal bool IsSetNumberCapabilities()
        {
            return this._numberCapabilities != null && (this._numberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberPreference. 
        /// <para>
        /// Optional. If omitted, returns unfiltered available numbers. Max 1 element for List
        /// API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<NumberPreferenceItem> NumberPreference
        {
            get { return this._numberPreference; }
            set { this._numberPreference = value; }
        }

        // Check to see if NumberPreference property is set
        internal bool IsSetNumberPreference()
        {
            return this._numberPreference != null && (this._numberPreference.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberType. 
        /// <para>
        /// The type of phone number to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchableNumberType NumberType
        {
            get { return this._numberType; }
            set { this._numberType = value; }
        }

        // Check to see if NumberType property is set
        internal bool IsSetNumberType()
        {
            return this._numberType != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The registration associated with the request. A registration is required for regulated
        /// number types. You can specify either:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The unique identifier of the registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

    }
}