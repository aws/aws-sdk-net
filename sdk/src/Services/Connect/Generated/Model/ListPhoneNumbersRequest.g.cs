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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the ListPhoneNumbers operation. Provides information
    /// about the phone numbers for the specified Connect Customer instance. <para> For more
    /// information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
    /// Up Phone Numbers for Your Contact Center</a> in the <i>Connect Customer Administrator
    /// Guide</i>. </para> <important> <ul> <li> <para> We recommend using <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
    /// to return phone number types. ListPhoneNumbers doesn't support number types <c>UIFN</c>,
    /// <c>SHARED</c>, <c>THIRD_PARTY_TF</c>, and <c>THIRD_PARTY_DID</c>. While it returns
    /// numbers of those types, it incorrectly lists them as <c>TOLL_FREE</c> or <c>DID</c>.
    /// </para> </li> <li> <para> The phone number <c>Arn</c> value that is returned from
    /// each of the items in the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbers.html#connect-ListPhoneNumbers-response-PhoneNumberSummaryList">PhoneNumberSummaryList</a>
    /// cannot be used to tag phone number resources. It will fail with a <c>ResourceNotFoundException</c>.
    /// Instead, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
    /// API. It returns the new phone number ARN that can be used to tag phone number resources.
    /// </para> </li> </ul> </important>
    /// </summary>
    public partial class ListPhoneNumbersRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page. The default MaxResult size is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberCountryCodes. 
        /// <para>
        /// The ISO country code.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> PhoneNumberCountryCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PhoneNumberCountryCodes property is set.
        /// </summary>
        internal bool IsSetPhoneNumberCountryCodes() => this.PhoneNumberCountryCodes != null && (this.PhoneNumberCountryCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PhoneNumberTypes. 
        /// <para>
        /// The type of phone number.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend using <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ListPhoneNumbersV2.html">ListPhoneNumbersV2</a>
        /// to return phone number types. While ListPhoneNumbers returns number types <c>UIFN</c>,
        /// <c>SHARED</c>, <c>THIRD_PARTY_TF</c>, and <c>THIRD_PARTY_DID</c>, it incorrectly lists
        /// them as <c>TOLL_FREE</c> or <c>DID</c>. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 6)]
        public List<string> PhoneNumberTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PhoneNumberTypes property is set.
        /// </summary>
        internal bool IsSetPhoneNumberTypes() => this.PhoneNumberTypes != null && (this.PhoneNumberTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
