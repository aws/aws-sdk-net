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
    /// Container for the parameters to the CreateTopic operation.
    /// Creates a topic to which notifications can be published. Users can create at most
    /// 100,000 standard topics (at most 1,000 FIFO topics). For more information, see <a
    /// href="https://docs.aws.amazon.com/sns/latest/dg/sns-create-topic.html">Creating an
    /// Amazon SNS topic</a> in the <i>Amazon SNS Developer Guide</i>. This action is idempotent,
    /// so if the requester already owns a topic with the specified name, that topic's ARN
    /// is returned without creating a new topic.
    /// </summary>
    public partial class CreateTopicRequest : AmazonSimpleNotificationServiceRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _dataProtectionPolicy;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateTopicRequest() { }

        /// <summary>
        /// Instantiates CreateTopicRequest with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the topic you want to create. Constraints: Topic names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 256 characters long. For a FIFO (first-in-first-out) topic, the name must end with the <c>.fifo</c> suffix. </param>
        public CreateTopicRequest(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of attributes with their corresponding values.
        /// </para>
        ///  
        /// <para>
        /// The following lists names, descriptions, and values of the special request parameters
        /// that the <c>CreateTopic</c> action uses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DeliveryPolicy</c> – The policy that defines how Amazon SNS retries failed deliveries
        /// to HTTP/S endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DisplayName</c> – The display name to use for a topic with SMS subscriptions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Policy</c> – The policy that defines who can access your topic. By default, only
        /// the topic owner can publish or subscribe to the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TracingConfig</c> – Tracing mode of an Amazon SNS topic. By default <c>TracingConfig</c>
        /// is set to <c>PassThrough</c>, and the topic passes through the tracing header it receives
        /// from an Amazon SNS publisher to its subscriptions. If set to <c>Active</c>, Amazon
        /// SNS will vend X-Ray segment data to topic owner account if the sampled flag in the
        /// tracing header is true. This is only supported on standard topics.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HTTPSuccessFeedbackRoleArn</c> – Indicates successful message delivery status
        /// for an Amazon SNS topic that is subscribed to an HTTP endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTPSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages
        /// to sample for an Amazon SNS topic that is subscribed to an HTTP endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTPFailureFeedbackRoleArn</c> – Indicates failed message delivery status for
        /// an Amazon SNS topic that is subscribed to an HTTP endpoint.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Amazon Data Firehose
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FirehoseSuccessFeedbackRoleArn</c> – Indicates successful message delivery status
        /// for an Amazon SNS topic that is subscribed to an Amazon Data Firehose endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FirehoseSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages
        /// to sample for an Amazon SNS topic that is subscribed to an Amazon Data Firehose endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FirehoseFailureFeedbackRoleArn</c> – Indicates failed message delivery status
        /// for an Amazon SNS topic that is subscribed to an Amazon Data Firehose endpoint. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Lambda
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LambdaSuccessFeedbackRoleArn</c> – Indicates successful message delivery status
        /// for an Amazon SNS topic that is subscribed to an Lambda endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LambdaSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages
        /// to sample for an Amazon SNS topic that is subscribed to an Lambda endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LambdaFailureFeedbackRoleArn</c> – Indicates failed message delivery status for
        /// an Amazon SNS topic that is subscribed to an Lambda endpoint. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Platform application endpoint
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ApplicationSuccessFeedbackRoleArn</c> – Indicates successful message delivery
        /// status for an Amazon SNS topic that is subscribed to a platform application endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApplicationSuccessFeedbackSampleRate</c> – Indicates percentage of successful
        /// messages to sample for an Amazon SNS topic that is subscribed to an platform application
        /// endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApplicationFailureFeedbackRoleArn</c> – Indicates failed message delivery status
        /// for an Amazon SNS topic that is subscribed to an platform application endpoint.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// In addition to being able to configure topic attributes for message delivery status
        /// of notification messages sent to Amazon SNS application endpoints, you can also configure
        /// application attributes for the delivery status of push notification messages sent
        /// to push notification services.
        /// </para>
        ///  
        /// <para>
        /// For example, For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-msg-status.html">Using
        /// Amazon SNS Application Attributes for Message Delivery Status</a>. 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Amazon SQS
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SQSSuccessFeedbackRoleArn</c> – Indicates successful message delivery status for
        /// an Amazon SNS topic that is subscribed to an Amazon SQS endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SQSSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages
        /// to sample for an Amazon SNS topic that is subscribed to an Amazon SQS endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SQSFailureFeedbackRoleArn</c> – Indicates failed message delivery status for an
        /// Amazon SNS topic that is subscribed to an Amazon SQS endpoint. 
        /// </para>
        ///  </li> </ul> </li> </ul> <note> 
        /// <para>
        /// The &lt;ENDPOINT&gt;SuccessFeedbackRoleArn and &lt;ENDPOINT&gt;FailureFeedbackRoleArn
        /// attributes are used to give Amazon SNS write access to use CloudWatch Logs on your
        /// behalf. The &lt;ENDPOINT&gt;SuccessFeedbackSampleRate attribute is for specifying
        /// the sample rate percentage (0-100) of successfully delivered messages. After you configure
        /// the &lt;ENDPOINT&gt;FailureFeedbackRoleArn attribute, then all failed message deliveries
        /// generate CloudWatch Logs. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html">server-side
        /// encryption</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KmsMasterKeyId</c> – The ID of an Amazon Web Services managed customer master
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
        ///  </li> </ul> </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>FifoThroughputScope</c> – Enables higher throughput for your FIFO topic by adjusting
        /// the scope of deduplication. This attribute has two possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Topic</c> – The scope of message deduplication is across the entire topic. This
        /// is the default value and maintains existing behavior, with a maximum throughput of
        /// 3000 messages per second or 20MB per second, whichever comes first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageGroup</c> – The scope of deduplication is within each individual message
        /// group, which enables higher throughput per topic subject to regional quotas. For more
        /// information on quotas or to request an increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/sns.html">Amazon
        /// SNS service quotas</a> in the Amazon Web Services General Reference.
        /// </para>
        ///  </li> </ul> </li> </ul>
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

        /// <summary>
        /// Gets and sets the property DataProtectionPolicy. 
        /// <para>
        /// The body of the policy document you want to use for this topic.
        /// </para>
        ///  
        /// <para>
        /// You can only add one policy per topic.
        /// </para>
        ///  
        /// <para>
        /// The policy must be in JSON string format.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Maximum length of 30,720.
        /// </para>
        /// </summary>
        public string DataProtectionPolicy
        {
            get { return this._dataProtectionPolicy; }
            set { this._dataProtectionPolicy = value; }
        }

        // Check to see if DataProtectionPolicy property is set
        internal bool IsSetDataProtectionPolicy()
        {
            return this._dataProtectionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the topic you want to create.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Topic names must be made up of only uppercase and lowercase ASCII letters,
        /// numbers, underscores, and hyphens, and must be between 1 and 256 characters long.
        /// </para>
        ///  
        /// <para>
        /// For a FIFO (first-in-first-out) topic, the name must end with the <c>.fifo</c> suffix.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags to add to a new topic.
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to tag a topic on creation, you must have the <c>sns:CreateTopic</c> and
        /// <c>sns:TagResource</c> permissions.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}