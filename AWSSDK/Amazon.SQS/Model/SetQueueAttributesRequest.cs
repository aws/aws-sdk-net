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
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.SQS.Util;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// <para>
    /// Sets the value of one or more queue attributes. Currently, you can set only one attribute per request. Valid attributes that
    /// can be set are [VisibilityTimeout, Policy, MaximumMessageSize,
    /// MessageRetentionPeriod, WaitTimeSeconds].
    /// </para>
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class SetQueueAttributesRequest : SQSRequest
    {    
        private string queueUrlField;
        private List<Attribute> attributeField;

        /// <summary>
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the URL associated with the Amazon SQS queue.
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        public SetQueueAttributesRequest WithQueueUrl(string queueUrl)
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
        /// Sets the name and value pair of an attribute associated with the queue.
        /// </summary>
        /// <param name="list">Name and value pair of an attribute associated with the queue.</param>
        /// <returns>this instance</returns>
        public SetQueueAttributesRequest WithAttribute(params Attribute[] list)
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


        /// <summary>
        /// Adds the attribute for setting the policy and returns back this for chaining operations.
        /// </summary>
        /// <param name="policy">The policy to set</param>
        /// <returns>This instances for chaining operations.</returns>
        public SetQueueAttributesRequest WithPolicy(string policy)
        {
            this.WithAttribute(new Attribute()
                        .WithName(SQSConstants.ATTRIBUTE_POLICY).WithValue(policy));
            return this;
        }

        /// <summary>
        /// Adds the attribute for setting the visibility timeout and returns back this for chaining operations.
        /// </summary>
        /// <param name="visibilityTimeout">The visibility timeout to set</param>
        /// <returns>This instances for chaining operations.</returns>
        public SetQueueAttributesRequest WithVisibilityTimeout(int visibilityTimeout)
        {
            this.WithAttribute(new Attribute()
                        .WithName(SQSConstants.ATTRIBUTE_VISIBILITY_TIMEOUT).WithValue(visibilityTimeout.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the attribute for setting the maximum message size and returns back this for chaining operations.
        /// </summary>
        /// <param name="maximumMessageSize">The maximum message size to set</param>
        /// <returns>This instances for chaining operations.</returns>
        public SetQueueAttributesRequest WithMaximumMessageSize(int maximumMessageSize)
        {
            this.WithAttribute(new Attribute()
                        .WithName(SQSConstants.ATTRIBUTE_MAXIMUM_MESSAGE_SIZE).WithValue(maximumMessageSize.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the attribute for setting the message retention period and returns back this for chaining operations.
        /// </summary>
        /// <param name="messageRetentionPeriod">The message retention period to set</param>
        /// <returns>This instances for chaining operations.</returns>
        public SetQueueAttributesRequest WithMessageRetentionPeriod(int messageRetentionPeriod)
        {
            this.WithAttribute(new Attribute()
                        .WithName(SQSConstants.ATTRIBUTE_MESSAGE_RETENTION_PERIOD).WithValue(messageRetentionPeriod.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the attribute for setting the delay in seconds and returns back this for chaining operations.
        /// </summary>
        /// <param name="delaySeconds">The delay in seconds to set</param>
        /// <returns>This instances for chaining operations.</returns>
        public SetQueueAttributesRequest WithDeplaySeconds(int delaySeconds)
        {
            this.WithAttribute(new Attribute()
                        .WithName(SQSConstants.ATTRIBUTE_DELAY_SECONDS).WithValue(delaySeconds.ToString()));
            return this;
        }
    }
}
