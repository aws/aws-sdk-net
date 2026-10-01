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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the SearchAvailablePhoneNumbers operation. Searches
    /// for phone numbers that can be ordered. For US numbers, provide at least one of the
    /// following search filters: <c>AreaCode</c>, <c>City</c>, <c>State</c>, or <c>TollFreePrefix</c>.
    /// If you provide <c>City</c>, you must also provide <c>State</c>. Numbers outside the
    /// US only support the <c>PhoneNumberType</c> filter, which you must use.
    /// </summary>
    public partial class SearchAvailablePhoneNumbersRequest : AmazonChimeRequest
    {
        /// <summary>
        /// Gets and sets the property AreaCode. 
        /// <para>
        /// The area code used to filter results. Only applies to the US.
        /// </para>
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// Checks to see if the AreaCode property is set.
        /// </summary>
        internal bool IsSetAreaCode() => this.AreaCode != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city used to filter results. Only applies to the US.
        /// </para>
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country used to filter results. Defaults to the US Format: ISO 3166-1 alpha-2.
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberType. 
        /// <para>
        /// The phone number type used to filter results. Required for non-US numbers.
        /// </para>
        /// </summary>
        public PhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberType property is set.
        /// </summary>
        internal bool IsSetPhoneNumberType() => this.PhoneNumberType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state used to filter results. Required only if you provide <c>City</c>. Only applies
        /// to the US.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TollFreePrefix. 
        /// <para>
        /// The toll-free prefix that you use to filter results. Only applies to the US.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string TollFreePrefix { get; set; }

        /// <summary>
        /// Checks to see if the TollFreePrefix property is set.
        /// </summary>
        internal bool IsSetTollFreePrefix() => this.TollFreePrefix != null;
    }
}
