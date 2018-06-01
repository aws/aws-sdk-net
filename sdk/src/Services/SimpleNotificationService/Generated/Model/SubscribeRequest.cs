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
    /// Container for the parameters to the Subscribe operation.
    /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
    /// To actually create a subscription, the endpoint owner must call the <code>ConfirmSubscription</code>
    /// action with the token from the confirmation message. Confirmation tokens are valid
    /// for three days.
    /// 
    ///  
    /// <para>
    /// This action is throttled at 100 transactions per second (TPS).
    /// </para>
    /// </summary>
    public partial class SubscribeRequest : AmazonSimpleNotificationServiceRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _endpoint;
        private string _protocol;
        private bool? _returnSubscriptionArn;
        private string _topicArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SubscribeRequest() { }

        /// <summary>
        /// Instantiates SubscribeRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to subscribe to.</param>
        /// <param name="protocol">The protocol you want to use. Supported protocols include: <ul> <li>  <code>http</code> -- delivery of JSON-encoded message via HTTP POST </li> <li>  <code>https</code> -- delivery of JSON-encoded message via HTTPS POST </li> <li>  <code>email</code> -- delivery of message via SMTP </li> <li>  <code>email-json</code> -- delivery of JSON-encoded message via SMTP </li> <li>  <code>sms</code> -- delivery of message via SMS </li> <li>  <code>sqs</code> -- delivery of JSON-encoded message to an Amazon SQS queue </li> <li>  <code>application</code> -- delivery of JSON-encoded message to an EndpointArn for a mobile app and device. </li> <li>  <code>lambda</code> -- delivery of JSON-encoded message to an AWS Lambda function. </li> </ul></param>
        /// <param name="endpoint">The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li> For the <code>http</code> protocol, the endpoint is an URL beginning with "http://" </li> <li> For the <code>https</code> protocol, the endpoint is a URL beginning with "https://" </li> <li> For the <code>email</code> protocol, the endpoint is an email address </li> <li> For the <code>email-json</code> protocol, the endpoint is an email address </li> <li> For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled device </li> <li> For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue </li> <li> For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile app and device. </li> <li> For the <code>lambda</code> protocol, the endpoint is the ARN of an AWS Lambda function. </li> </ul></param>
        public SubscribeRequest(string topicArn, string protocol, string endpoint)
        {
            _topicArn = topicArn;
            _protocol = protocol;
            _endpoint = endpoint;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Assigns attributes to the subscription as a map of key-value pairs. You can assign
        /// any attribute that is supported by the <code>SetSubscriptionAttributes</code> action.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint that you want to receive notifications. Endpoints vary by protocol:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <code>http</code> protocol, the endpoint is an URL beginning with "http://"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>https</code> protocol, the endpoint is a URL beginning with "https://"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>email</code> protocol, the endpoint is an email address
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>email-json</code> protocol, the endpoint is an email address
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled
        /// device
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile
        /// app and device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>lambda</code> protocol, the endpoint is the ARN of an AWS Lambda function.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol you want to use. Supported protocols include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>http</code> -- delivery of JSON-encoded message via HTTP POST
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>https</code> -- delivery of JSON-encoded message via HTTPS POST
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>email</code> -- delivery of message via SMTP
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>email-json</code> -- delivery of JSON-encoded message via SMTP
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sms</code> -- delivery of message via SMS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqs</code> -- delivery of JSON-encoded message to an Amazon SQS queue
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>application</code> -- delivery of JSON-encoded message to an EndpointArn for
        /// a mobile app and device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>lambda</code> -- delivery of JSON-encoded message to an AWS Lambda function.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnSubscriptionArn. 
        /// <para>
        /// Sets whether the response from the <code>Subscribe</code> request includes the subscription
        /// ARN, even if the subscription is not yet confirmed.
        /// </para>
        ///  
        /// <para>
        /// If you set this parameter to <code>false</code>, the response includes the ARN for
        /// confirmed subscriptions, but it includes an ARN value of "pending subscription" for
        /// subscriptions that are not yet confirmed. A subscription becomes confirmed when the
        /// subscriber calls the <code>ConfirmSubscription</code> action with a confirmation token.
        /// </para>
        ///  
        /// <para>
        /// If you set this parameter to <code>true</code>, the response includes the ARN in all
        /// cases, even if the subscription is not yet confirmed.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool ReturnSubscriptionArn
        {
            get { return this._returnSubscriptionArn.GetValueOrDefault(); }
            set { this._returnSubscriptionArn = value; }
        }

        // Check to see if ReturnSubscriptionArn property is set
        internal bool IsSetReturnSubscriptionArn()
        {
            return this._returnSubscriptionArn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the topic you want to subscribe to.
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