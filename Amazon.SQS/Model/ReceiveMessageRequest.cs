/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-10-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Retrieves one or more messages from the specified queue, including the message body and message ID of each message.
    /// Messages returned by this action stay in the queue until you delete them. However, once a message is returned to a
    /// ReceiveMessage request, it is not returned on subsequent ReceiveMessage requests for the duration of the
    /// VisibilityTimeout. If you do not specify a VisibilityTimeout in the request, the overall visibility timeout for the
    /// queue is used for the returned messages.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2011-10-01/", IsNullable = false)]
    public class ReceiveMessageRequest
    {    
        private string queueUrlField;
        private Decimal? maxNumberOfMessagesField;
        private Decimal? visibilityTimeoutField;
        private List<string> attributeNameField;

        /// <summary>
        /// Gets and sets the QueueUrl property.
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the QueueUrl property
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        public ReceiveMessageRequest WithQueueUrl(string queueUrl)
        {
            this.queueUrlField = queueUrl;
            return this;
        }

        /// <summary>
        /// Checks if QueueUrl property is set
        /// </summary>
        /// <returns>true if QueueUrl property is set</returns>
        public bool IsSetQueueUrl()
        {
            return this.queueUrlField != null;
        }

        /// <summary>
        /// Gets and sets the MaxNumberOfMessages property.
        /// Maximum number of messages to return. SQS never returns more messages than this value but might return fewer.
        /// Not necessarily all the messages in the queue are returned (for more information, see the preceding note about
        /// machine sampling). Values can be from 1 to 10. Default is 1.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxNumberOfMessages")]
        public Decimal MaxNumberOfMessages
        {
            get { return this.maxNumberOfMessagesField.GetValueOrDefault(); }
            set { this.maxNumberOfMessagesField = value; }
        }

        /// <summary>
        /// Sets the MaxNumberOfMessages property
        /// </summary>
        /// <param name="maxNumberOfMessages">Maximum number of messages to return. SQS never returns more messages than this value but might return fewer.
        /// Not necessarily all the messages in the queue are returned (for more information, see the preceding note about
        /// machine sampling). Values can be from 1 to 10. Default is 1.</param>
        /// <returns>this instance</returns>
        public ReceiveMessageRequest WithMaxNumberOfMessages(Decimal maxNumberOfMessages)
        {
            this.maxNumberOfMessagesField = maxNumberOfMessages;
            return this;
        }

        /// <summary>
        /// Checks if MaxNumberOfMessages property is set
        /// </summary>
        /// <returns>true if MaxNumberOfMessages property is set</returns>
        public bool IsSetMaxNumberOfMessages()
        {
            return this.maxNumberOfMessagesField.HasValue;
        }

        /// <summary>
        /// Gets and sets the VisibilityTimeout property.
        /// The duration (in seconds) that the received messages are hidden from subsequent retrieve requests after being retrieved
        /// by a ReceiveMessage request.
        /// </summary>
        [XmlElementAttribute(ElementName = "VisibilityTimeout")]
        public Decimal VisibilityTimeout
        {
            get { return this.visibilityTimeoutField.GetValueOrDefault(); }
            set { this.visibilityTimeoutField = value; }
        }

        /// <summary>
        /// Sets the VisibilityTimeout property
        /// </summary>
        /// <param name="visibilityTimeout">The duration (in seconds) that the received messages are hidden from subsequent retrieve requests after being retrieved
        /// by a ReceiveMessage request.</param>
        /// <returns>this instance</returns>
        public ReceiveMessageRequest WithVisibilityTimeout(Decimal visibilityTimeout)
        {
            this.visibilityTimeoutField = visibilityTimeout;
            return this;
        }

        /// <summary>
        /// Checks if VisibilityTimeout property is set
        /// </summary>
        /// <returns>true if VisibilityTimeout property is set</returns>
        public bool IsSetVisibilityTimeout()
        {
            return this.visibilityTimeoutField.HasValue;
        }

        /// <summary>
        /// Gets and sets the AttributeName property.
        /// The attribute you want to get. Valid values: All | SenderId | SentTimestamp | ApproximateReceiveCount |
        /// ApproximateFirstReceiveTimestamp
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeName")]
        public List<string> AttributeName
        {
            get
            {
                if (this.attributeNameField == null)
                {
                    this.attributeNameField = new List<string>();
                }
                return this.attributeNameField;
            }
            set { this.attributeNameField = value; }
        }

        /// <summary>
        /// Sets the AttributeName property
        /// </summary>
        /// <param name="list">The attribute you want to get. Valid values: All | SenderId | SentTimestamp | ApproximateReceiveCount |
        /// ApproximateFirstReceiveTimestamp</param>
        /// <returns>this instance</returns>
        public ReceiveMessageRequest WithAttributeName(params string[] list)
        {
            foreach (string item in list)
            {
                AttributeName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AttributeName property is set
        /// </summary>
        /// <returns>true if AttributeName property is set</returns>
        public bool IsSetAttributeName()
        {
            return (AttributeName.Count > 0);
        }

    }
}
