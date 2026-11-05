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
    /// Container for the parameters to the ListPhoneNumbersV2 operation. Lists phone numbers
    /// claimed to your Connect Customer instance or traffic distribution group. If the provided
    /// <c>TargetArn</c> is a traffic distribution group, you can call this API in both Amazon
    /// Web Services Regions associated with traffic distribution group. <para> For more information
    /// about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
    /// Up Phone Numbers for Your Contact Center</a> in the <i>Connect Customer Administrator
    /// Guide</i>. </para> <note> <ul> <li> <para> When given an instance ARN, <c>ListPhoneNumbersV2</c>
    /// returns only the phone numbers claimed to the instance. </para> </li> <li> <para>
    /// When given a traffic distribution group ARN <c>ListPhoneNumbersV2</c> returns only
    /// the phone numbers claimed to the traffic distribution group. </para> </li> </ul> </note>
    /// </summary>
    public partial class ListPhoneNumbersV2Request : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance that phone numbers are claimed to.
        /// You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance. If both <c>TargetArn</c>
        /// and <c>InstanceId</c> are not provided, this API lists numbers claimed to all the
        /// Connect Customer instances belonging to your account in the same Amazon Web Services
        /// Region as the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
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
        [AWSProperty(Min = 1, Max = 100000)]
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
        /// Gets and sets the property PhoneNumberPrefix. 
        /// <para>
        /// The prefix of the phone number. If provided, it must contain <c>+</c> as part of the
        /// country code.
        /// </para>
        /// </summary>
        public string PhoneNumberPrefix { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberPrefix property is set.
        /// </summary>
        internal bool IsSetPhoneNumberPrefix() => this.PhoneNumberPrefix != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberTypes. 
        /// <para>
        /// The type of phone number.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for Connect Customer instances or traffic distribution
        /// groups that phone number inbound traffic is routed through. If both <c>TargetArn</c>
        /// and <c>InstanceId</c> input are not provided, this API lists numbers claimed to all
        /// the Connect Customer instances belonging to your account in the same Amazon Web Services
        /// Region as the request.
        /// </para>
        /// </summary>
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
