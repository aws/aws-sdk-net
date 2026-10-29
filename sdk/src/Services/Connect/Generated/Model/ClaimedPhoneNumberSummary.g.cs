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
    /// Information about a phone number that has been claimed to your Connect Customer instance
    /// or traffic distribution group.
    /// </summary>
    public partial class ClaimedPhoneNumberSummary
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance that phone numbers are claimed to.
        /// You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number. Phone numbers are formatted <c>[+] [country code] [subscriber number
        /// including area code]</c>.
        /// </para>
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the phone number.
        /// </para>
        /// </summary>
        public string PhoneNumberArn { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberArn property is set.
        /// </summary>
        internal bool IsSetPhoneNumberArn() => this.PhoneNumberArn != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberCountryCode. 
        /// <para>
        /// The ISO country code.
        /// </para>
        /// </summary>
        public PhoneNumberCountryCode PhoneNumberCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberCountryCode property is set.
        /// </summary>
        internal bool IsSetPhoneNumberCountryCode() => this.PhoneNumberCountryCode != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberDescription. 
        /// <para>
        /// The description of the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string PhoneNumberDescription { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberDescription property is set.
        /// </summary>
        internal bool IsSetPhoneNumberDescription() => this.PhoneNumberDescription != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// A unique identifier for the phone number.
        /// </para>
        /// </summary>
        public string PhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberId property is set.
        /// </summary>
        internal bool IsSetPhoneNumberId() => this.PhoneNumberId != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberStatus. 
        /// <para>
        /// The status of the phone number.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLAIMED</c> means the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>
        /// or <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>
        /// operation succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> means a <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>,
        /// <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>,
        /// or <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumberMetadata.html">UpdatePhoneNumberMetadata</a>
        /// operation is still in progress and has not yet completed. You can call <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribePhoneNumber.html">DescribePhoneNumber</a>
        /// at a later time to verify if the previous operation has completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> indicates that the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>
        /// or <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>
        /// operation has failed. It will include a message indicating the failure reason. A common
        /// reason for a failure may be that the <c>TargetArn</c> value you are claiming or updating
        /// a phone number to has reached its limit of total claimed numbers. If you received
        /// a <c>FAILED</c> status from a <c>ClaimPhoneNumber</c> API call, you have one day to
        /// retry claiming the phone number before the number is released back to the inventory
        /// for other customers to claim.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You will not be billed for the phone number during the 1-day period if number claiming
        /// fails. 
        /// </para>
        ///  </note>
        /// </summary>
        public PhoneNumberStatus PhoneNumberStatus { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberStatus property is set.
        /// </summary>
        internal bool IsSetPhoneNumberStatus() => this.PhoneNumberStatus != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberType. 
        /// <para>
        /// The type of phone number.
        /// </para>
        /// </summary>
        public PhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberType property is set.
        /// </summary>
        internal bool IsSetPhoneNumberType() => this.PhoneNumberType != null;

        /// <summary>
        /// Gets and sets the property SourcePhoneNumberArn. 
        /// <para>
        /// The claimed phone number ARN that was previously imported from the external service,
        /// such as Amazon Web Services End User Messaging. If it is from Amazon Web Services
        /// End User Messaging, it looks like the ARN of the phone number that was imported from
        /// Amazon Web Services End User Messaging.
        /// </para>
        /// </summary>
        public string SourcePhoneNumberArn { get; set; }

        /// <summary>
        /// Checks to see if the SourcePhoneNumberArn property is set.
        /// </summary>
        internal bool IsSetSourcePhoneNumberArn() => this.SourcePhoneNumberArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for Connect Customer instances or traffic distribution
        /// groups that phone number inbound traffic is routed through.
        /// </para>
        /// </summary>
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
