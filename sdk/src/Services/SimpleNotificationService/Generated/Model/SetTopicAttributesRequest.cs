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
    /// Container for the parameters to the SetTopicAttributes operation.
    /// Allows a topic owner to set an attribute of the topic to a new value.
    /// 
    ///  <note> 
    /// <para>
    /// To remove the ability to change topic permissions, you must deny permissions to the
    /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetTopicAttributes</c> actions
    /// in your IAM policy.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SetTopicAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _attributeName;
        private string _attributeValue;
        private string _topicArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetTopicAttributesRequest() { }

        /// <summary>
        /// Instantiates SetTopicAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The ARN of the topic to modify.</param>
        /// <param name="attributeName">A map of attributes with their corresponding values. The following lists the names, descriptions, and values of the special request parameters that the <c>SetTopicAttributes</c> action uses: <ul> <li>  <c>DeliveryPolicy</c> – The policy that defines how Amazon SNS retries failed deliveries to HTTP/S endpoints. </li> <li>  <c>DisplayName</c> – The display name to use for a topic with SMS subscriptions. </li> <li>  <c>Policy</c> – The policy that defines who can access your topic. By default, only the topic owner can publish or subscribe to the topic. </li> <li>  <c>TracingConfig</c> – Tracing mode of an Amazon SNS topic. By default <c>TracingConfig</c> is set to <c>PassThrough</c>, and the topic passes through the tracing header it receives from an Amazon SNS publisher to its subscriptions. If set to <c>Active</c>, Amazon SNS will vend X-Ray segment data to topic owner account if the sampled flag in the tracing header is true. This is only supported on standard topics. </li> <li> HTTP <ul> <li>  <c>HTTPSuccessFeedbackRoleArn</c> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an HTTP endpoint.  </li> <li>  <c>HTTPSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an HTTP endpoint. </li> <li>  <c>HTTPFailureFeedbackRoleArn</c> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an HTTP endpoint. </li> </ul> </li> <li> Amazon Data Firehose <ul> <li>  <c>FirehoseSuccessFeedbackRoleArn</c> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an Amazon Data Firehose endpoint. </li> <li>  <c>FirehoseSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an Amazon Data Firehose endpoint. </li> <li>  <c>FirehoseFailureFeedbackRoleArn</c> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an Amazon Data Firehose endpoint.  </li> </ul> </li> <li> Lambda <ul> <li>  <c>LambdaSuccessFeedbackRoleArn</c> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an Lambda endpoint. </li> <li>  <c>LambdaSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an Lambda endpoint. </li> <li>  <c>LambdaFailureFeedbackRoleArn</c> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an Lambda endpoint.  </li> </ul> </li> <li> Platform application endpoint <ul> <li>  <c>ApplicationSuccessFeedbackRoleArn</c> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an platform application endpoint. </li> <li>  <c>ApplicationSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an platform application endpoint. </li> <li>  <c>ApplicationFailureFeedbackRoleArn</c> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an platform application endpoint. </li> </ul> <note> In addition to being able to configure topic attributes for message delivery status of notification messages sent to Amazon SNS application endpoints, you can also configure application attributes for the delivery status of push notification messages sent to push notification services. For example, For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-msg-status.html">Using Amazon SNS Application Attributes for Message Delivery Status</a>.  </note> </li> <li> Amazon SQS <ul> <li>  <c>SQSSuccessFeedbackRoleArn</c> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an Amazon SQS endpoint.  </li> <li>  <c>SQSSuccessFeedbackSampleRate</c> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an Amazon SQS endpoint.  </li> <li>  <c>SQSFailureFeedbackRoleArn</c> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an Amazon SQS endpoint.  </li> </ul> </li> </ul> <note> The &lt;ENDPOINT&gt;SuccessFeedbackRoleArn and &lt;ENDPOINT&gt;FailureFeedbackRoleArn attributes are used to give Amazon SNS write access to use CloudWatch Logs on your behalf. The &lt;ENDPOINT&gt;SuccessFeedbackSampleRate attribute is for specifying the sample rate percentage (0-100) of successfully delivered messages. After you configure the &lt;ENDPOINT&gt;FailureFeedbackRoleArn attribute, then all failed message deliveries generate CloudWatch Logs.  </note> The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <c>KmsMasterKeyId</c> – The ID of an Amazon Web Services managed customer master key (CMK) for Amazon SNS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html#sse-key-terms">Key Terms</a>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a> in the <i>Key Management Service API Reference</i>.  </li> <li>  <c>SignatureVersion</c> – The signature version corresponds to the hashing algorithm used while creating the signature of the notifications, subscription confirmations, or unsubscribe confirmation messages sent by Amazon SNS. By default, <c>SignatureVersion</c> is set to <c>1</c>. </li> </ul> The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-fifo-topics.html">FIFO topics</a>: <ul> <li>  <c>ArchivePolicy</c> – The policy that sets the retention period for messages stored in the message archive of an Amazon SNS FIFO topic. </li> <li>  <c>ContentBasedDeduplication</c> – Enables content-based deduplication for FIFO topics. <ul> <li> By default, <c>ContentBasedDeduplication</c> is set to <c>false</c>. If you create a FIFO topic and this attribute is <c>false</c>, you must specify a value for the <c>MessageDeduplicationId</c> parameter for the <a href="https://docs.aws.amazon.com/sns/latest/api/API_Publish.html">Publish</a> action.  </li> <li> When you set <c>ContentBasedDeduplication</c> to <c>true</c>, Amazon SNS uses a SHA-256 hash to generate the <c>MessageDeduplicationId</c> using the body of the message (but not the attributes of the message). (Optional) To override the generated value, you can specify a value for the <c>MessageDeduplicationId</c> parameter for the <c>Publish</c> action. </li> </ul> </li> </ul> <ul> <li>  <c>FifoThroughputScope</c> – Enables higher throughput for your FIFO topic by adjusting the scope of deduplication. This attribute has two possible values: <ul> <li>  <c>Topic</c> – The scope of message deduplication is across the entire topic. This is the default value and maintains existing behavior, with a maximum throughput of 3000 messages per second or 20MB per second, whichever comes first. </li> <li>  <c>MessageGroup</c> – The scope of deduplication is within each individual message group, which enables higher throughput per topic subject to regional quotas. For more information on quotas or to request an increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/sns.html">Amazon SNS service quotas</a> in the Amazon Web Services General Reference. </li> </ul> </li> </ul></param>
        /// <param name="attributeValue">The new value for the attribute.</param>
        public SetTopicAttributesRequest(string topicArn, string attributeName, string attributeValue)
        {
            _topicArn = topicArn;
            _attributeName = attributeName;
            _attributeValue = attributeValue;
        }

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// A map of attributes with their corresponding values.
        /// </para>
        ///  
        /// <para>
        /// The following lists the names, descriptions, and values of the special request parameters
        /// that the <c>SetTopicAttributes</c> action uses:
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
        /// status for an Amazon SNS topic that is subscribed to an platform application endpoint.
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
        /// The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html">server-side-encryption</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KmsMasterKeyId</c> – The ID of an Amazon Web Services managed customer master
        /// key (CMK) for Amazon SNS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html#sse-key-terms">Key
        /// Terms</a>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a>
        /// in the <i>Key Management Service API Reference</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SignatureVersion</c> – The signature version corresponds to the hashing algorithm
        /// used while creating the signature of the notifications, subscription confirmations,
        /// or unsubscribe confirmation messages sent by Amazon SNS. By default, <c>SignatureVersion</c>
        /// is set to <c>1</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-fifo-topics.html">FIFO
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
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The new value for the attribute.
        /// </para>
        /// </summary>
        public string AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the topic to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}