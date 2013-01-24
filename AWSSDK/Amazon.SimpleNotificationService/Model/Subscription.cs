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
    /// The attributes of an SNS subscription.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class Subscription
    {    
        private string subscriptionArnField;
        private string ownerField;
        private string protocolField;
        private string endpointField;
        private string topicArnField;

        /// <summary>
        /// The subscription's ARN.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubscriptionArn")]
        public string SubscriptionArn
        {
            get { return this.subscriptionArnField; }
            set { this.subscriptionArnField = value; }
        }

        /// <summary>
        /// Sets the subscription's ARN.
        /// </summary>
        /// <param name="subscriptionArn">The subscription's ARN.</param>
        /// <returns>this instance</returns>
        public Subscription WithSubscriptionArn(string subscriptionArn)
        {
            this.subscriptionArnField = subscriptionArn;
            return this;
        }

        /// <summary>
        /// Checks if SubscriptionArn property is set
        /// </summary>
        /// <returns>true if SubscriptionArn property is set</returns>
        public bool IsSetSubscriptionArn()
        {
            return this.subscriptionArnField != null;
        }

        /// <summary>
        /// The subscription's owner.
        /// </summary>
        [XmlElementAttribute(ElementName = "Owner")]
        public string Owner
        {
            get { return this.ownerField; }
            set { this.ownerField = value; }
        }

        /// <summary>
        /// Sets the subscription's owner.
        /// </summary>
        /// <param name="owner">The subscription's owner.</param>
        /// <returns>this instance</returns>
        public Subscription WithOwner(string owner)
        {
            this.ownerField = owner;
            return this;
        }

        /// <summary>
        /// Checks if Owner property is set
        /// </summary>
        /// <returns>true if Owner property is set</returns>
        public bool IsSetOwner()
        {
            return this.ownerField != null;
        }

        /// <summary>
        /// The subscription's protocol.
        /// </summary>
        [XmlElementAttribute(ElementName = "Protocol")]
        public string Protocol
        {
            get { return this.protocolField; }
            set { this.protocolField = value; }
        }

        /// <summary>
        /// Sets the subscription's protocol.
        /// </summary>
        /// <param name="protocol">The subscription's protocol.</param>
        /// <returns>this instance</returns>
        public Subscription WithProtocol(string protocol)
        {
            this.protocolField = protocol;
            return this;
        }

        /// <summary>
        /// Checks if Protocol property is set
        /// </summary>
        /// <returns>true if Protocol property is set</returns>
        public bool IsSetProtocol()
        {
            return this.protocolField != null;
        }

        /// <summary>
        /// The subscription's endpoint (format depends on the protocol).
        /// </summary>
        [XmlElementAttribute(ElementName = "Endpoint")]
        public string Endpoint
        {
            get { return this.endpointField; }
            set { this.endpointField = value; }
        }

        /// <summary>
        /// Sets the subscription's endpoint (format depends on the protocol).
        /// </summary>
        /// <param name="endpoint">The subscription's endpoint.</param>
        /// <returns>this instance</returns>
        public Subscription WithEndpoint(string endpoint)
        {
            this.endpointField = endpoint;
            return this;
        }

        /// <summary>
        /// Checks if Endpoint property is set
        /// </summary>
        /// <returns>true if Endpoint property is set</returns>
        public bool IsSetEndpoint()
        {
            return this.endpointField != null;
        }

        /// <summary>
        /// The ARN of the subscription's topic.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the ARN of the subscription's topic.
        /// </summary>
        /// <param name="topicArn">The ARN of the subscription's topic.</param>
        /// <returns>this instance</returns>
        public Subscription WithTopicArn(string topicArn)
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

    }
}
