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
    /// Container for the parameters to the ListAvailablePhoneNumbers operation. Retrieves
    /// a list of phone numbers that are available to request, based on the country, capabilities,
    /// and number type that you specify. You can optionally provide a number preference to
    /// return only numbers that match a specific digit pattern. <para> If no numbers match
    /// your search, this operation returns an empty list rather than an error. This operation
    /// currently supports only <c>TEN_DLC</c> number types in the <c>US</c>. </para>
    /// </summary>
    public partial class ListAvailablePhoneNumbersRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region in
        /// which to search for available phone numbers. This operation currently supports only
        /// <c>US</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the IsoCountryCode property is set.
        /// </summary>
        internal bool IsSetIsoCountryCode() => this.IsoCountryCode != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page. If you don't specify a value, the
        /// default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous request to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// The capabilities to filter by, such as SMS. Only phone numbers that support all of
        /// the specified capabilities are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public List<string> NumberCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NumberCapabilities property is set.
        /// </summary>
        internal bool IsSetNumberCapabilities() => this.NumberCapabilities != null && (this.NumberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberPreference. 
        /// <para>
        /// An optional selection preference used to return only phone numbers that match a specific
        /// digit pattern, such as numbers that start with, end with, or contain a particular
        /// sequence. You can specify at most one preference. Number preferences apply only to
        /// <c>TEN_DLC</c> numbers in the <c>US</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<NumberPreferenceItem> NumberPreference { get; set; } = AWSConfigs.InitializeCollections ? new List<NumberPreferenceItem>() : null;

        /// <summary>
        /// Checks to see if the NumberPreference property is set.
        /// </summary>
        internal bool IsSetNumberPreference() => this.NumberPreference != null && (this.NumberPreference.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberType. 
        /// <para>
        /// The type of phone number to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchableNumberType NumberType { get; set; }

        /// <summary>
        /// Checks to see if the NumberType property is set.
        /// </summary>
        internal bool IsSetNumberType() => this.NumberType != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;
    }
}
