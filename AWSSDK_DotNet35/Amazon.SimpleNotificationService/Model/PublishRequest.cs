/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>The <c>Publish</c> action sends a message to all of a topic's subscribed endpoints. When a <c>messageId</c> is returned, the message
    /// has been saved and Amazon SNS will attempt to deliver it to the topic's subscribers shortly. The format of the outgoing message to each
    /// subscribed endpoint depends on the notification protocol selected.</para> <para>To use the <c>Publish</c> action for sending a message to a
    /// mobile endpoint, such as an app on a Kindle device or mobile phone, you must specify the EndpointArn. The EndpointArn is returned when
    /// making a call with the <c>CreatePlatformEndpoint</c> action. The second example below shows a request and response for publishing to a
    /// mobile endpoint. </para>
    /// </summary>
    public partial class PublishRequest : AmazonWebServiceRequest
    {
        private string topicArn;
        private string targetArn;
        private string message;
        private string subject;
        private string messageStructure;
        /// <summary>
        /// Default constructor for a new PublishRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public PublishRequest() {}
    
        /// <summary>
        /// Constructs a new PublishRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The topic you want to publish to. </param>
        /// <param name="message"> The message you want to send to the topic. If you want to send the same message to all transport protocols, include
        /// the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the
        /// <c>MessageStructure</c> parameter to <c>json</c> and use a JSON object for the <c>Message</c> parameter. See the Examples section for the
        /// format of the JSON object. Constraints: Messages must be UTF-8 encoded strings at most 256 KB in size (262144 bytes, not 262144 characters).
        /// JSON-specific constraints: <ul> <li>Keys in the JSON object that correspond to supported transport protocols must have simple JSON string
        /// values. </li> <li>The values will be parsed (unescaped) before they are used in outgoing messages.</li> <li>Outbound notifications are JSON
        /// encoded (meaning that the characters will be reescaped for sending).</li> <li>Values have a minimum length of 0 (the empty string, "", is
        /// allowed).</li> <li>Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message
        /// sizes).</li> <li>Non-string values will cause the key to be ignored.</li> <li>Keys that do not correspond to supported transport protocols
        /// are ignored.</li> <li>Duplicate keys are not allowed.</li> <li>Failure to parse or validate any key or value in the message will cause the
        /// <c>Publish</c> call to return an error (no partial delivery).</li> </ul> </param>
        public PublishRequest(string topicArn, string message)
        {
            this.topicArn = topicArn;
            this.message = message;
        }
    
        /// <summary>
        /// Constructs a new PublishRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The topic you want to publish to. </param>
        /// <param name="message"> The message you want to send to the topic. If you want to send the same message to all transport protocols, include
        /// the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the
        /// <c>MessageStructure</c> parameter to <c>json</c> and use a JSON object for the <c>Message</c> parameter. See the Examples section for the
        /// format of the JSON object. Constraints: Messages must be UTF-8 encoded strings at most 256 KB in size (262144 bytes, not 262144 characters).
        /// JSON-specific constraints: <ul> <li>Keys in the JSON object that correspond to supported transport protocols must have simple JSON string
        /// values. </li> <li>The values will be parsed (unescaped) before they are used in outgoing messages.</li> <li>Outbound notifications are JSON
        /// encoded (meaning that the characters will be reescaped for sending).</li> <li>Values have a minimum length of 0 (the empty string, "", is
        /// allowed).</li> <li>Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message
        /// sizes).</li> <li>Non-string values will cause the key to be ignored.</li> <li>Keys that do not correspond to supported transport protocols
        /// are ignored.</li> <li>Duplicate keys are not allowed.</li> <li>Failure to parse or validate any key or value in the message will cause the
        /// <c>Publish</c> call to return an error (no partial delivery).</li> </ul> </param>
        /// <param name="subject"> Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will
        /// also be included, if present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that
        /// begins with a letter, number, or punctuation mark; must not include line breaks or control characters; and must be less than 100 characters
        /// long. </param>
        public PublishRequest(string topicArn, string message, string subject)
        {
            this.topicArn = topicArn;
            this.message = message;
            this.subject = subject;
        }
    

        /// <summary>
        /// The topic you want to publish to.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }

        /// <summary>
        /// Either TopicArn or EndpointArn, but not both.
        ///  
        /// </summary>
        public string TargetArn
        {
            get { return this.targetArn; }
            set { this.targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this.targetArn != null;
        }

        /// <summary>
        /// The message you want to send to the topic. If you want to send the same message to all transport protocols, include the text of the message
        /// as a String value. If you want to send different messages for each transport protocol, set the value of the <c>MessageStructure</c>
        /// parameter to <c>json</c> and use a JSON object for the <c>Message</c> parameter. See the Examples section for the format of the JSON object.
        /// Constraints: Messages must be UTF-8 encoded strings at most 256 KB in size (262144 bytes, not 262144 characters). JSON-specific constraints:
        /// <ul> <li>Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li>The values
        /// will be parsed (unescaped) before they are used in outgoing messages.</li> <li>Outbound notifications are JSON encoded (meaning that the
        /// characters will be reescaped for sending).</li> <li>Values have a minimum length of 0 (the empty string, "", is allowed).</li> <li>Values
        /// have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes).</li> <li>Non-string
        /// values will cause the key to be ignored.</li> <li>Keys that do not correspond to supported transport protocols are ignored.</li>
        /// <li>Duplicate keys are not allowed.</li> <li>Failure to parse or validate any key or value in the message will cause the <c>Publish</c> call
        /// to return an error (no partial delivery).</li> </ul>
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }

        /// <summary>
        /// Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will also be included, if
        /// present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that begins with a letter,
        /// number, or punctuation mark; must not include line breaks or control characters; and must be less than 100 characters long.
        ///  
        /// </summary>
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this.subject != null;
        }

        /// <summary>
        /// Set <c>MessageStructure</c> to <c>json</c> if you want to send a different message for each protocol. For example, using one publish action,
        /// you can send a short message to your SMS subscribers and a longer message to your email subscribers. If you set <c>MessageStructure</c> to
        /// <c>json</c>, the value of the <c>Message</c> parameter must: <ul> <li>be a syntactically valid JSON object; and</li> <li>contain at least a
        /// top-level JSON key of "default" with a value that is a string.</li> </ul> You can define other top-level keys that define the message you
        /// want to send to a specific transport protocol (e.g., "http"). For information about sending different messages for each protocol using the
        /// AWS Management Console, go to <a href="http://docs.aws.amazon.com/sns/latest/gsg/Publish.html#sns-message-formatting-by-protocol">Create
        /// Different Messages for Each Protocol</a> in the <i>Amazon Simple Notification Service Getting Started Guide</i>. Valid value: <c>json</c>
        ///  
        /// </summary>
        public string MessageStructure
        {
            get { return this.messageStructure; }
            set { this.messageStructure = value; }
        }

        // Check to see if MessageStructure property is set
        internal bool IsSetMessageStructure()
        {
            return this.messageStructure != null;
        }

    }
}
    
