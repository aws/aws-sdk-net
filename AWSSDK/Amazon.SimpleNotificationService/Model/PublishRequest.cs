/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Sends a message to all of a topic's subscribed endpoints.
    /// </summary>
    /// <remarks>
    /// When a messageId is returned, the message has been saved and Amazon SNS will
    /// attempt to deliver it to the topic's subscribers shortly.
    /// The format of the outgoing message to each subscribed endpoint depends on the
    /// notification protocol selected.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class PublishRequest : SNSRequest
    {    
        private string topicArnField;
        private string messageField;
        private string messageStructureField;
        private string subjectField;

        /// <summary>
        /// The ARN of the topic you want to publish to.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the ARN of the topic you want to publish to.
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to.</param>
        /// <returns>this instance</returns>
        public PublishRequest WithTopicArn(string topicArn)
        {
            this.topicArnField = topicArn;
            return this;
        }

        /// <summary>
        /// Checks if TopicArn property is set
        /// </summary>
        /// <returns>true if TopicArn property is set</returns>
        public bool IsSetTopicArn()
        {
            return this.topicArnField != null;
        }

        /// <summary>
        /// The message you want to send to the topic.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Sets the message you want to send to the topic.
        /// </summary>
        /// <param name="message">The message you want to send to the topic.</param>
        /// <returns>this instance</returns>
        public PublishRequest WithMessage(string message)
        {
            this.messageField = message;
            return this;
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return this.messageField != null;
        }

        /// <summary>
        /// The structure of the message.
        /// Optional parameter. It can have only one valid value: "json".
        /// </summary>
        /// <remarks>
        /// <para>
        /// If this field is set to "json", the value of Message must be a syntactically valid JSON object.
        /// It must contain at least a top level JSON key of "default" with a value that is a string.
        /// For any other top level key that matches one of our transport protocols (e.g. "http"),
        /// the corresponding value (if it is a string) will be used for the message published for that protocol.
        /// </para>
        /// <para>
        /// Constraints: Keys in the JSON object that correspond to supported transport
        /// protocols must have simple JSON string values. The values will be parsed (unescaped)
        /// before they are used in outgoing messages. Typically, outbound notifications are JSON
        /// encoded (meaning, the characters will be reescaped for sending). JSON strings are 
        /// UTF-8. Values have a minimum length of 0 (the empty string, "", is allowed).
        /// Values have a maximum length bounded by the overall message size (so, including
        /// multiple protocols may limit message sizes). Non-string values will cause the key
        /// to be ignored. Keys that do not correspond to supported transport protocols will be
        /// ignored. Duplicate keys are not allowed. Failure to parse or validate any key or
        /// value in the message will cause the Publish call to return an error (no partial
        /// delivery).
        /// </para>
        /// </remarks>
        public string MessageStructure
        {
            get { return this.messageStructureField; }
            set { this.messageStructureField = value; }
        }

        /// <summary>
        /// Sets the structure of the message.
        /// Valid values: "json"
        /// </summary>
        /// <param name="messageStructure">The structure of the message.</param>
        /// <returns>this instance</returns>
        public PublishRequest WithMessageStructure(string messageStructure)
        {
            this.messageStructureField = messageStructure;
            return this;
        }

        /// <summary>
        /// Checks if MessageStructure property is set
        /// </summary>
        /// <returns>true if MessageStructure property is set</returns>
        public bool IsSetMessageStructure()
        {
            return this.messageStructureField != null;
        }

        /// <summary>
        /// Subject of the message.
        /// </summary>
        /// <remarks>
        /// Subject is optional parameter and used as the "Subject" line of when
        /// the message is delivered to e-mail endpoints.
        /// The subject will also be included, if present, in the standard JSON messages
        /// delivered to other endpoints.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Subject")]
        public string Subject
        {
            get { return this.subjectField; }
            set { this.subjectField = value; }
        }

        /// <summary>
        /// Sets the subject of the message.
        /// </summary>
        /// <param name="subject">Subject of the message.</param>
        /// <returns>this instance</returns>
        public PublishRequest WithSubject(string subject)
        {
            this.subjectField = subject;
            return this;
        }

        /// <summary>
        /// Checks if Subject property is set
        /// </summary>
        /// <returns>true if Subject property is set</returns>
        public bool IsSetSubject()
        {
            return this.subjectField != null;
        }

    }
}
