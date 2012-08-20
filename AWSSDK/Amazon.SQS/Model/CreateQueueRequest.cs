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

using Amazon.SQS.Util;

using Attribute = Amazon.SQS.Model.Attribute;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// The CreateQueue action creates a new queue, or returns the URL of an existing one.
    /// When you request CreateQueue, you provide a name for the queue. To successfully
    /// create a new queue, you must provide a name that is unique within the scope of
    /// your own queues. If you provide the name of an existing queue, a new queue isn't
    /// created and an error isn't returned. Instead, the request succeeds and the queue
    /// URL for the existing queue is returned. Exception: if you provide a value for
    /// DefaultVisibilityTimeout that is different from the value for the existing queue,
    /// you receive an error.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2011-10-01/", IsNullable = false)]
    public class CreateQueueRequest
    {    
        private string queueNameField;
        private List<Attribute> attributeField;

        /// <summary>
        /// Gets and sets the QueueName property.
        /// The name to use for the queue created. Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueName")]
        public string QueueName
        {
            get { return this.queueNameField; }
            set { this.queueNameField = value; }
        }

        /// <summary>
        /// Sets the QueueName property
        /// </summary>
        /// <param name="queueName">The name to use for the queue created. Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.</param>
        /// <returns>this instance</returns>
        public CreateQueueRequest WithQueueName(string queueName)
        {
            this.queueNameField = queueName;
            return this;
        }

        /// <summary>
        /// Checks if QueueName property is set
        /// </summary>
        /// <returns>true if QueueName property is set</returns>
        public bool IsSetQueueName()
        {
            return this.queueNameField != null;
        }

        /// <summary>
        /// Gets and sets the DefaultVisibilityTimeout property.
        /// The visibility timeout (in seconds) to use for this queue. Values can be 0 to 43200 (maximum 12 hours). Default is 30 seconds.
        /// </summary>
        [XmlElementAttribute(ElementName = "DefaultVisibilityTimeout")]
        public Decimal DefaultVisibilityTimeout
        {
            get 
            {
                return getAttributeValue<Decimal>(SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT);
            }
            set 
            {
                setAttributeValue(SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT, value);
            }
        }

        /// <summary>
        /// Sets the DefaultVisibilityTimeout property
        /// </summary>
        /// <param name="defaultVisibilityTimeout">The visibility timeout (in seconds) to use for this queue. Values can be 0 to 43200 (maximum 12 hours). Default is 30 seconds.</param>
        /// <returns>this instance</returns>
        public CreateQueueRequest WithDefaultVisibilityTimeout(Decimal defaultVisibilityTimeout)
        {
            this.DefaultVisibilityTimeout = defaultVisibilityTimeout;
            return this;
        }

        /// <summary>
        /// Checks if DefaultVisibilityTimeout property is set
        /// </summary>
        /// <returns>true if DefaultVisibilityTimeout property is set</returns>
        public bool IsSetDefaultVisibilityTimeout()
        {
            return AmazonSQSUtil.FindAttribute(this.Attribute, SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT) != null;
        }


        /// <summary>
        /// Gets and sets the DelaySeconds property.
        /// The default number of seconds for which the message has to be delayed.
        /// </summary>
        [XmlElementAttribute(ElementName = "DelaySeconds")]
        public int DelaySeconds
        {
            get
            {
                return getAttributeValue<int>(SQSConstants.ATTRIBUTE_DELAY_SECONDS);
            }
            set
            {
                setAttributeValue(SQSConstants.ATTRIBUTE_DELAY_SECONDS, value);
            }
        }

        /// <summary>
        /// Sets the DelaySeconds property
        /// </summary>
        /// <param name="delaySeconds">The default number of seconds for which the message has to be delayed.</param>
        /// <returns>this instance</returns>
        public CreateQueueRequest WithDelaySeconds(int delaySeconds)
        {
            this.DelaySeconds = delaySeconds;
            return this;
        }

        /// <summary>
        /// Checks if DelaySeconds property is set
        /// </summary>
        /// <returns>true if DelaySeconds property is set</returns>
        public bool IsSetDelaySeconds()
        {
            return AmazonSQSUtil.FindAttribute(this.Attribute, SQSConstants.ATTRIBUTE_DELAY_SECONDS) != null;
        }

        /// <summary>
        /// Gets and sets the Attribute property.
        /// Name and value pair of an attribute associated with the queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "Attribute")]
        public List<Attribute> Attribute
        {
            get
            {
                if (this.attributeField == null)
                {
                    this.attributeField = new List<Attribute>();
                }
                return this.attributeField;
            }
            set { this.attributeField = value; }
        }

        /// <summary>
        /// Sets the Attribute property
        /// </summary>
        /// <param name="list">Name and value pair of an attribute associated with the queue.</param>
        /// <returns>this instance</returns>
        public CreateQueueRequest WithAttribute(params Attribute[] list)
        {
            foreach (Attribute item in list)
            {
                Attribute.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attribute property is set
        /// </summary>
        /// <returns>true if Attribute property is set</returns>
        public bool IsSetAttribute()
        {
            return (Attribute.Count > 0);
        }

        private T getAttributeValue<T>(string name)
        {
            Attribute attr = AmazonSQSUtil.FindAttribute(this.Attribute, SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT);
            if (attr == null)
            {
                return default(T);
            }
            return (T)Convert.ChangeType(attr.Value, typeof(T));
        }

        private void setAttributeValue(string name, object value)
        {
            Attribute attr = AmazonSQSUtil.FindAttribute(this.Attribute, name);
            if (attr == null)
            {
                Attribute newAttr = new Attribute()
                    .WithName(name)
                    .WithValue(value.ToString());
                this.Attribute.Add(newAttr);
            }
            else
            {
                attr.Value = value.ToString();
            }
        }
    }
}
