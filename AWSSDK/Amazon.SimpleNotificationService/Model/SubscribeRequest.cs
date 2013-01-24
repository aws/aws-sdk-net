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
    /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
    /// </summary>
    /// <remarks>
    /// To actually create a subscription, the endpoint owner must call the ConfirmSubscription
    /// action with the token from the confirmation message. Confirmation tokens are valid for three days.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class SubscribeRequest : SNSRequest
    {    
        private string topicArnField;
        private string protocolField;
        private string endpointField;

        /// <summary>
        /// The ARN of topic you want to subscribe to.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the ARN of topic you want to subscribe to.
        /// </summary>
        /// <param name="topicArn">The ARN of topic you want to subscribe to.</param>
        /// <returns>this instance</returns>
        public SubscribeRequest WithTopicArn(string topicArn)
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
        /// The protocol you want to use.
        /// </summary>
        /// <remarks>
        /// Supported protocols include:
        /// <ul>
        /// <li>http -- delivery of JSON-encoded message via HTTP POST</li>
        /// <li>https -- delivery of JSON-encoded message via HTTPS POST</li>
        /// <li>email -- delivery of message via SMTP</li>
        /// <li>email-json -- delivery of JSON-encoded message via SMTP</li>
        /// <li>sms -- delivery of message via SMS</li>
        /// <li>sqs -- delivery of JSON-encoded message to an Amazon SQS queue</li>
        /// </ul>
        /// </remarks>
        [XmlElementAttribute(ElementName = "Protocol")]
        public string Protocol
        {
            get { return this.protocolField; }
            set { this.protocolField = value; }
        }

        /// <summary>
        /// Sets the protocol you want to use.
        /// </summary>
        /// <param name="protocol">The protocol you want to use.</param>
        /// <returns>this instance</returns>
        public SubscribeRequest WithProtocol(string protocol)
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
        /// The endpoint that you want to receive notifications.
        /// </summary>
        /// <remarks>
        /// Endpoints vary by protocol:
        /// <ul>
        /// <li>For the http protocol, the endpoint is an URL beginning with "http://"</li>
        /// <li>For the https protocol, the endpoint is a URL beginning with "https://"</li>
        /// <li>For the email protocol, the endpoint is an e-mail address</li>
        /// <li>For the email-json protocol, the endpoint is an e-mail address</li>
        /// <li>For the sms protocol, the endpoint is a phone number of an SMS-enabled device</li>
        /// <li>For the sqs protocol, the endpoint is the ARN of an Amazon SQS queue</li>
        /// </ul>
        /// </remarks>
        [XmlElementAttribute(ElementName = "Endpoint")]
        public string Endpoint
        {
            get { return this.endpointField; }
            set { this.endpointField = value; }
        }

        /// <summary>
        /// Sets the endpoint that you want to receive notifications.
        /// </summary>
        /// <param name="endpoint">The endpoint that you want to receive notifications.</param>
        /// <returns>this instance</returns>
        public SubscribeRequest WithEndpoint(string endpoint)
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

    }
}
