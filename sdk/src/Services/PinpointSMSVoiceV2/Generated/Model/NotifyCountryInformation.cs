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
    /// The information for a country that supports notify messaging.
    /// </summary>
    public partial class NotifyCountryInformation
    {
        private string _countryName;
        private bool? _customerOwnedIdentityRequired;
        private string _isoCountryCode;
        private List<string> _supportedChannels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedTiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedUseCases = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CountryName. 
        /// <para>
        /// The name of the country.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CountryName
        {
            get { return this._countryName; }
            set { this._countryName = value; }
        }

        // Check to see if CountryName property is set
        internal bool IsSetCountryName()
        {
            return this._countryName != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIdentityRequired. 
        /// <para>
        /// Whether a customer-owned identity is required to send notify messages to this country.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? CustomerOwnedIdentityRequired
        {
            get { return this._customerOwnedIdentityRequired; }
            set { this._customerOwnedIdentityRequired = value; }
        }

        // Check to see if CustomerOwnedIdentityRequired property is set
        internal bool IsSetCustomerOwnedIdentityRequired()
        {
            return this._customerOwnedIdentityRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region.
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
        /// Gets and sets the property SupportedChannels. 
        /// <para>
        /// An array of supported channels for the country. Supported values include <c>SMS</c>
        /// and <c>VOICE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> SupportedChannels
        {
            get { return this._supportedChannels; }
            set { this._supportedChannels = value; }
        }

        // Check to see if SupportedChannels property is set
        internal bool IsSetSupportedChannels()
        {
            return this._supportedChannels != null && (this._supportedChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedTiers. 
        /// <para>
        /// An array of supported tiers for the country.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<string> SupportedTiers
        {
            get { return this._supportedTiers; }
            set { this._supportedTiers = value; }
        }

        // Check to see if SupportedTiers property is set
        internal bool IsSetSupportedTiers()
        {
            return this._supportedTiers != null && (this._supportedTiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedUseCases. 
        /// <para>
        /// An array of supported use cases for the country.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> SupportedUseCases
        {
            get { return this._supportedUseCases; }
            set { this._supportedUseCases = value; }
        }

        // Check to see if SupportedUseCases property is set
        internal bool IsSetSupportedUseCases()
        {
            return this._supportedUseCases != null && (this._supportedUseCases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}