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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the ListPhoneNumbers operation. Lists the phone numbers
    /// for the specified Amazon Chime SDK account, Amazon Chime SDK user, Amazon Chime SDK
    /// Voice Connector, or Amazon Chime SDK Voice Connector group.
    /// </summary>
    public partial class ListPhoneNumbersRequest : AmazonChimeSDKVoiceRequest
    {
        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The filter to limit the number of results.
        /// </para>
        /// </summary>
        public PhoneNumberAssociationName FilterName { get; set; }

        /// <summary>
        /// Checks to see if the FilterName property is set.
        /// </summary>
        internal bool IsSetFilterName() => this.FilterName != null;

        /// <summary>
        /// Gets and sets the property FilterValue. 
        /// <para>
        /// The filter value.
        /// </para>
        /// </summary>
        public string FilterValue { get; set; }

        /// <summary>
        /// Checks to see if the FilterValue property is set.
        /// </summary>
        internal bool IsSetFilterValue() => this.FilterValue != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to return the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The phone number product types.
        /// </para>
        /// </summary>
        public PhoneNumberProductType ProductType { get; set; }

        /// <summary>
        /// Checks to see if the ProductType property is set.
        /// </summary>
        internal bool IsSetProductType() => this.ProductType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your organization's phone numbers.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
