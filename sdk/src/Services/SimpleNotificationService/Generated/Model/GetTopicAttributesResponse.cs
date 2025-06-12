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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Response for GetTopicAttributes action.
    /// </summary>
    public partial class GetTopicAttributesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of the topic's attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DeliveryPolicy</c> – The JSON serialization of the topic's delivery policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DisplayName</c> – The human-readable name used in the <c>From</c> field for notifications
        /// to <c>email</c> and <c>email-json</c> endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EffectiveDeliveryPolicy</c> – The JSON serialization of the effective delivery
        /// policy, taking system defaults into account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Owner</c> – The Amazon Web Services account ID of the topic's owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Policy</c> – The JSON serialization of the topic's access control policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SignatureVersion</c> – The signature version corresponds to the hashing algorithm
        /// used while creating the signature of the notifications, subscription confirmations,
        /// or unsubscribe confirmation messages sent by Amazon SNS.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By default, <c>SignatureVersion</c> is set to <b>1</b>. The signature is a Base64-encoded
        /// <b>SHA1withRSA</b> signature.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you set <c>SignatureVersion</c> to <b>2</b>. Amazon SNS uses a Base64-encoded
        /// <b>SHA256withRSA</b> signature. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the API response does not include the <c>SignatureVersion</c> attribute, it means
        /// that the <c>SignatureVersion</c> for the topic has value <b>1</b>.
        /// </para>
        ///  </note> </li> </ul> </li> <li> 
        /// <para>
        ///  <c>SubscriptionsConfirmed</c> – The number of confirmed subscriptions for the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SubscriptionsDeleted</c> – The number of deleted subscriptions for the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SubscriptionsPending</c> – The number of subscriptions pending confirmation for
        /// the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TopicArn</c> – The topic's ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TracingConfig</c> – Tracing mode of an Amazon SNS topic. By default <c>TracingConfig</c>
        /// is set to <c>PassThrough</c>, and the topic passes through the tracing header it receives
        /// from an Amazon SNS publisher to its subscriptions. If set to <c>Active</c>, Amazon
        /// SNS will vend X-Ray segment data to topic owner account if the sampled flag in the
        /// tracing header is true. This is only supported on standard topics.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html">server-side-encryption</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KmsMasterKeyId</c> - The ID of an Amazon Web Services managed customer master
        /// key (CMK) for Amazon SNS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html#sse-key-terms">Key
        /// Terms</a>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a>
        /// in the <i>Key Management Service API Reference</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-fifo-topics.html">FIFO
        /// topics</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ArchivePolicy</c> – The policy that sets the retention period for messages stored
        /// in the message archive of an Amazon SNS FIFO topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BeginningArchiveTime</c> – The earliest starting point at which a message in the
        /// topic’s archive can be replayed from. This point in time is based on the configured
        /// message retention period set by the topic’s message archiving policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ContentBasedDeduplication</c> – Enables content-based deduplication for FIFO topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By default, <c>ContentBasedDeduplication</c> is set to <c>false</c>. If you create
        /// a FIFO topic and this attribute is <c>false</c>, you must specify a value for the
        /// <c>MessageDeduplicationId</c> parameter for the <a href="https://docs.aws.amazon.com/sns/latest/api/API_Publish.html">Publish</a>
        /// action. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you set <c>ContentBasedDeduplication</c> to <c>true</c>, Amazon SNS uses a SHA-256
        /// hash to generate the <c>MessageDeduplicationId</c> using the body of the message (but
        /// not the attributes of the message).
        /// </para>
        ///  
        /// <para>
        /// (Optional) To override the generated value, you can specify a value for the <c>MessageDeduplicationId</c>
        /// parameter for the <c>Publish</c> action.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>FifoTopic</c> – When this is set to <c>true</c>, a FIFO topic is created.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}