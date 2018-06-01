/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the Publish operation.
    /// Sends a message to an Amazon SNS topic or sends a text message (SMS message) directly
    /// to a phone number. 
    /// 
    ///  
    /// <para>
    /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
    /// that is subscribed to the topic. The format of the message depends on the notification
    /// protocol for each subscribed endpoint.
    /// </para>
    ///  
    /// <para>
    /// When a <code>messageId</code> is returned, the message has been saved and Amazon SNS
    /// will attempt to deliver it shortly.
    /// </para>
    ///  
    /// <para>
    /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
    /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
    /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
    /// <code>CreatePlatformEndpoint</code> action. 
    /// </para>
    ///  
    /// <para>
    /// For more information about formatting messages, see <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
    /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
    /// </para>
    /// </summary>
    public partial class PublishRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _message;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = new Dictionary<string, MessageAttributeValue>();
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
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262144 bytes, not 262144 characters). </li> <li> For SMS, each message can contain up to 140 bytes, and the character limit depends on the encoding scheme. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds the size limit, Amazon SNS sends it as multiple messages, each fitting within the size limit. Messages are not cut off in the middle of a word but on whole-word boundaries. The total size limit for a single SMS publish action is 1600 bytes. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
        public PublishRequest(string topicArn, string message)
        {
            _topicArn = topicArn;
            _message = message;
        }

        /// <summary>
        /// Instantiates PublishRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262144 bytes, not 262144 characters). </li> <li> For SMS, each message can contain up to 140 bytes, and the character limit depends on the encoding scheme. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds the size limit, Amazon SNS sends it as multiple messages, each fitting within the size limit. Messages are not cut off in the middle of a word but on whole-word boundaries. The total size limit for a single SMS publish action is 1600 bytes. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
        /// <param name="subject">Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will also be included, if present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that begins with a letter, number, or punctuation mark; must not include line breaks or control characters; and must be less than 100 characters long.</param>
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
        /// different messages for each transport protocol, set the value of the <code>MessageStructure</code>
        /// parameter to <code>json</code> and use a JSON object for the <code>Message</code>
        /// parameter. 
        /// </para>
        ///   
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With the exception of SMS, messages must be UTF-8 encoded strings and at most 256
        /// KB in size (262144 bytes, not 262144 characters).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For SMS, each message can contain up to 140 bytes, and the character limit depends
        /// on the encoding scheme. For example, an SMS message can contain 160 GSM characters,
        /// 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds
        /// the size limit, Amazon SNS sends it as multiple messages, each fitting within the
        /// size limit. Messages are not cut off in the middle of a word but on whole-word boundaries.
        /// The total size limit for a single SMS publish action is 1600 bytes.
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
        /// Failure to parse or validate any key or value in the message will cause the <code>Publish</code>
        /// call to return an error (no partial delivery).
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// </summary>
        public Dictionary<string, MessageAttributeValue> MessageAttributes
        {
            get { return this._messageAttributes; }
            set { this._messageAttributes = value; }
        }

        // Check to see if MessageAttributes property is set
        internal bool IsSetMessageAttributes()
        {
            return this._messageAttributes != null && this._messageAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MessageStructure. 
        /// <para>
        /// Set <code>MessageStructure</code> to <code>json</code> if you want to send a different
        /// message for each protocol. For example, using one publish action, you can send a short
        /// message to your SMS subscribers and a longer message to your email subscribers. If
        /// you set <code>MessageStructure</code> to <code>json</code>, the value of the <code>Message</code>
        /// parameter must: 
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
        /// For information about sending different messages for each protocol using the AWS Management
        /// Console, go to <a href="http://docs.aws.amazon.com/sns/latest/gsg/Publish.html#sns-message-formatting-by-protocol">Create
        /// Different Messages for Each Protocol</a> in the <i>Amazon Simple Notification Service
        /// Getting Started Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Valid value: <code>json</code> 
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
        /// If you don't specify a value for the <code>PhoneNumber</code> parameter, you must
        /// specify a value for the <code>TargetArn</code> or <code>TopicArn</code> parameters.
        /// </para>
        /// </summary>
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
        /// Constraints: Subjects must be ASCII text that begins with a letter, number, or punctuation
        /// mark; must not include line breaks or control characters; and must be less than 100
        /// characters long.
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
        /// Either TopicArn or EndpointArn, but not both.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <code>TargetArn</code> parameter, you must specify
        /// a value for the <code>PhoneNumber</code> or <code>TopicArn</code> parameters.
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
        /// If you don't specify a value for the <code>TopicArn</code> parameter, you must specify
        /// a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.
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