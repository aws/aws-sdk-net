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
    /// Container for the parameters to the ImportPhoneNumber operation. Imports a claimed
    /// phone number from an external service, such as Amazon Web Services End User Messaging,
    /// into an Connect Customer instance. You can call this API only in the same Amazon Web
    /// Services Region where the Connect Customer instance was created. <important> <para>
    /// Call the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribePhoneNumber.html">DescribePhoneNumber</a>
    /// API to verify the status of a previous <c>ImportPhoneNumber</c> operation. </para>
    /// </important> <para> If you plan to claim or import numbers and then release numbers
    /// frequently, contact us for a service quota exception. Otherwise, it is possible you
    /// will be blocked from claiming and releasing any more numbers until up to 180 days
    /// past the oldest number released has expired. </para> <para> By default you can claim
    /// or import and then release up to 200% of your maximum number of active phone numbers.
    /// If you claim or import and then release phone numbers using the UI or API during a
    /// rolling 180 day cycle that exceeds 200% of your phone number service level quota,
    /// you will be blocked from claiming or importing any more numbers until 180 days past
    /// the oldest number released has expired. </para> <para> For example, if you already
    /// have 99 claimed or imported numbers and a service level quota of 99 phone numbers,
    /// and in any 180 day period you release 99, claim 99, and then release 99, you will
    /// have exceeded the 200% limit. At that point you are blocked from claiming any more
    /// numbers until you open an Amazon Web Services Support ticket. </para>
    /// </summary>
    public partial class ImportPhoneNumberRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Gets and sets the property SourcePhoneNumberArn. 
        /// <para>
        /// The claimed phone number ARN being imported from the external service, such as Amazon
        /// Web Services End User Messaging. If it is from Amazon Web Services End User Messaging,
        /// it looks like the ARN of the phone number to import from Amazon Web Services End User
        /// Messaging.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
    }
}
