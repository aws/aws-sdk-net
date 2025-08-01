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
    /// Container for the parameters to the Publish operation.
    /// Sends a message to an Amazon SNS topic, a text message (SMS message) directly to a
    /// phone number, or a message to a mobile platform endpoint (when you specify the <c>TargetArn</c>).
    /// 
    ///  
    /// <para>
    /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
    /// that is subscribed to the topic. The format of the message depends on the notification
    /// protocol for each subscribed endpoint.
    /// </para>
    ///  
    /// <para>
    /// When a <c>messageId</c> is returned, the message is saved and Amazon SNS immediately
    /// delivers it to subscribers.
    /// </para>
    ///  
    /// <para>
    /// To use the <c>Publish</c> action for publishing a message to a mobile endpoint, such
    /// as an app on a Kindle device or mobile phone, you must specify the EndpointArn for
    /// the TargetArn parameter. The EndpointArn is returned when making a call with the <c>CreatePlatformEndpoint</c>
    /// action. 
    /// </para>
    ///  
    /// <para>
    /// For more information about formatting messages, see <a href="https://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
    /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
    /// </para>
    ///  <important> 
    /// <para>
    /// You can publish messages only to topics and endpoints in the same Amazon Web Services
    /// Region.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PublishRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _message;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;
        private string _messageDeduplicationId;
        private string _messageGroupId;
        private string _messageStructure;
        private string _phoneNumber;
        private string _subject;
        private string _targetArn;
        private string _topicArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PublishRequest() { }

        /// <summary>
        /// Instantiates PublishRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <c>TopicArn</c> parameter, you must specify a value for the <c>PhoneNumber</c> or <c>TargetArn</c> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <c>MessageStructure</c> parameter to <c>json</c> and use a JSON object for the <c>Message</c> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262,144 bytes, not 262,144 characters). </li> <li> For SMS, each message can contain up to 140 characters. This character limit depends on the encoding schema. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds this size limit, Amazon SNS sends the message as multiple messages, each fitting within the size limit. Messages aren't truncated mid-word but are cut off at whole-word boundaries. The total size limit for a single SMS <c>Publish</c> action is 1,600 characters. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <c>Publish</c> call to return an error (no partial delivery). </li> </ul></param>
        public PublishRequest(string topicArn, string message)
        {
            _topicArn = topicArn;
            _message = message;
        }

        /// <summary>
        /// Instantiates PublishRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <c>TopicArn</c> parameter, you must specify a value for the <c>PhoneNumber</c> or <c>TargetArn</c> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <c>MessageStructure</c> parameter to <c>json</c> and use a JSON object for the <c>Message</c> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262,144 bytes, not 262,144 characters). </li> <li> For SMS, each message can contain up to 140 characters. This character limit depends on the encoding schema. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds this size limit, Amazon SNS sends the message as multiple messages, each fitting within the size limit. Messages aren't truncated mid-word but are cut off at whole-word boundaries. The total size limit for a single SMS <c>Publish</c> action is 1,600 characters. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <c>Publish</c> call to return an error (no partial delivery). </li> </ul></param>
        /// <param name="subject">Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will also be included, if present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be UTF-8 text with no line breaks or control characters, and less than 100 characters long.</param>
        public PublishRequest(string topicArn, string message, string subject)
        {
            _topicArn = topicArn;
            _message = message;
            _subject = subject;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message you want to send.
        /// </para>
        ///  
        /// <para>
        /// If you are publishing to a topic and you want to send the same message to all transport
        /// protocols, include the text of the message as a String value. If you want to send
        /// different messages for each transport protocol, set the value of the <c>MessageStructure</c>
        /// parameter to <c>json</c> and use a JSON object for the <c>Message</c> parameter. 
        /// </para>
        ///   
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With the exception of SMS, messages must be UTF-8 encoded strings and at most 256
        /// KB in size (262,144 bytes, not 262,144 characters).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For SMS, each message can contain up to 140 characters. This character limit depends
        /// on the encoding schema. For example, an SMS message can contain 160 GSM characters,
        /// 140 ASCII characters, or 70 UCS-2 characters.
        /// </para>
        ///  
        /// <para>
        /// If you publish a message that exceeds this size limit, Amazon SNS sends the message
        /// as multiple messages, each fitting within the size limit. Messages aren't truncated
        /// mid-word but are cut off at whole-word boundaries.
        /// </para>
        ///  
        /// <para>
        /// The total size limit for a single SMS <c>Publish</c> action is 1,600 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// JSON-specific constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Keys in the JSON object that correspond to supported transport protocols must have
        /// simple JSON string values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The values will be parsed (unescaped) before they are used in outgoing messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Outbound notifications are JSON encoded (meaning that the characters will be reescaped
        /// for sending).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Values have a minimum length of 0 (the empty string, "", is allowed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Values have a maximum length bounded by the overall message size (so, including multiple
        /// protocols may limit message sizes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Non-string values will cause the key to be ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys that do not correspond to supported transport protocols are ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Duplicate keys are not allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failure to parse or validate any key or value in the message will cause the <c>Publish</c>
        /// call to return an error (no partial delivery).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// Message attributes for Publish action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MessageAttributeValue> MessageAttributes
        {
            get { return this._messageAttributes; }
            set { this._messageAttributes = value; }
        }

        // Check to see if MessageAttributes property is set
        internal bool IsSetMessageAttributes()
        {
            return this._messageAttributes != null && (this._messageAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageDeduplicationId. <ul> <li> 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) topics. The <c>MessageDeduplicationId</c>
        /// can contain up to 128 alphanumeric characters <c>(a-z, A-Z, 0-9)</c> and punctuation
        /// <c>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every message must have a unique <c>MessageDeduplicationId</c>, which is a token used
        /// for deduplication of sent messages within the 5 minute minimum deduplication interval.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scope of deduplication depends on the <c>FifoThroughputScope</c> attribute, when
        /// set to <c>Topic</c> the message deduplication scope is across the entire topic, when
        /// set to <c>MessageGroup</c> the message deduplication scope is within each individual
        /// message group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a message with a particular <c>MessageDeduplicationId</c> is sent successfully,
        /// subsequent messages within the deduplication scope and interval, with the same <c>MessageDeduplicationId</c>,
        /// are accepted successfully but aren't delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every message must have a unique <c>MessageDeduplicationId</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You may provide a <c>MessageDeduplicationId</c> explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you aren't able to provide a <c>MessageDeduplicationId</c> and you enable <c>ContentBasedDeduplication</c>
        /// for your topic, Amazon SNS uses a SHA-256 hash to generate the <c>MessageDeduplicationId</c>
        /// using the body of the message (but not the attributes of the message).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't provide a <c>MessageDeduplicationId</c> and the topic doesn't have <c>ContentBasedDeduplication</c>
        /// set, the action fails with an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the topic has a <c>ContentBasedDeduplication</c> set, your <c>MessageDeduplicationId</c>
        /// overrides the generated one. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// When <c>ContentBasedDeduplication</c> is in effect, messages with identical content
        /// sent within the deduplication scope and interval are treated as duplicates and only
        /// one copy of the message is delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send one message with <c>ContentBasedDeduplication</c> enabled, and then another
        /// message with a <c>MessageDeduplicationId</c> that is the same as the one generated
        /// for the first <c>MessageDeduplicationId</c>, the two messages are treated as duplicates,
        /// within the deduplication scope and interval, and only one copy of the message is delivered.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MessageDeduplicationId
        {
            get { return this._messageDeduplicationId; }
            set { this._messageDeduplicationId = value; }
        }

        // Check to see if MessageDeduplicationId property is set
        internal bool IsSetMessageDeduplicationId()
        {
            return this._messageDeduplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageGroupId. 
        /// <para>
        /// The <c>MessageGroupId</c> can contain up to 128 alphanumeric characters <c>(a-z, A-Z,
        /// 0-9)</c> and punctuation <c>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</c>.
        /// </para>
        ///  
        /// <para>
        ///  For FIFO topics: The <c>MessageGroupId</c> is a tag that specifies that a message
        /// belongs to a specific message group. Messages that belong to the same message group
        /// are processed in a FIFO manner (however, messages in different message groups might
        /// be processed out of order). Every message must include a <c>MessageGroupId</c>. 
        /// </para>
        ///  
        /// <para>
        ///  For standard topics: The <c>MessageGroupId</c> is optional and is forwarded only
        /// to Amazon SQS standard subscriptions to activate <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-fair-queues.html">fair
        /// queues</a>. The <c>MessageGroupId</c> is not used for, or sent to, any other endpoint
        /// types. When provided, the same validation rules apply as for FIFO topics. 
        /// </para>
        /// </summary>
        public string MessageGroupId
        {
            get { return this._messageGroupId; }
            set { this._messageGroupId = value; }
        }

        // Check to see if MessageGroupId property is set
        internal bool IsSetMessageGroupId()
        {
            return this._messageGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageStructure. 
        /// <para>
        /// Set <c>MessageStructure</c> to <c>json</c> if you want to send a different message
        /// for each protocol. For example, using one publish action, you can send a short message
        /// to your SMS subscribers and a longer message to your email subscribers. If you set
        /// <c>MessageStructure</c> to <c>json</c>, the value of the <c>Message</c> parameter
        /// must: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// be a syntactically valid JSON object; and
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// contain at least a top-level JSON key of "default" with a value that is a string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can define other top-level keys that define the message you want to send to a
        /// specific transport protocol (e.g., "http").
        /// </para>
        ///  
        /// <para>
        /// Valid value: <c>json</c> 
        /// </para>
        /// </summary>
        public string MessageStructure
        {
            get { return this._messageStructure; }
            set { this._messageStructure = value; }
        }

        // Check to see if MessageStructure property is set
        internal bool IsSetMessageStructure()
        {
            return this._messageStructure != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number to which you want to deliver an SMS message. Use E.164 format.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>PhoneNumber</c> parameter, you must specify
        /// a value for the <c>TargetArn</c> or <c>TopicArn</c> parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// Optional parameter to be used as the "Subject" line when the message is delivered
        /// to email endpoints. This field will also be included, if present, in the standard
        /// JSON messages delivered to other endpoints.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Subjects must be UTF-8 text with no line breaks or control characters,
        /// and less than 100 characters long.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// If you don't specify a value for the <c>TargetArn</c> parameter, you must specify
        /// a value for the <c>PhoneNumber</c> or <c>TopicArn</c> parameters.
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The topic you want to publish to.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>TopicArn</c> parameter, you must specify a
        /// value for the <c>PhoneNumber</c> or <c>TargetArn</c> parameters.
        /// </para>
        /// </summary>
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