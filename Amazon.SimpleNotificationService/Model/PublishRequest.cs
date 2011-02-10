/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The Publish action sends a message to all of a topic's subscribed endpoints. When a
    /// messageId is returned, the message has been saved and Amazon SNS will attempt to deliver it
    /// to the topic's subscribers shortly. The format of the outgoing message to each
    /// subscribed endpoint depends on the notification protocol selected.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class PublishRequest
    {    
        private string topicArnField;
        private string messageField;
        private string subjectField;

        /// <summary>
        /// Gets and sets the TopicArn property.
        /// The topic you want to publish to.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the TopicArn property
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
        /// Gets and sets the Message property.
        /// The message you want to send to the topic.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Sets the Message property
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
        /// Gets and sets the Subject property.
        /// Optional parameter to be used as the "Subject" line of when the message is
        /// delivered to e-mail endpoints. This field will also be included, if present,
        /// in the standard JSON messages delivered to other endpoints.
        /// </summary>
        [XmlElementAttribute(ElementName = "Subject")]
        public string Subject
        {
            get { return this.subjectField; }
            set { this.subjectField = value; }
        }

        /// <summary>
        /// Sets the Subject property
        /// </summary>
        /// <param name="subject">Optional parameter to be used as the "Subject" line of when the message is
        /// delivered to e-mail endpoints. This field will also be included, if present,
        /// in the standard JSON messages delivered to other endpoints.</param>
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
