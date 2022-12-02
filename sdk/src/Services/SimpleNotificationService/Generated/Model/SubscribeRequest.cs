/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the Subscribe operation.
    /// Subscribes an endpoint to an Amazon SNS topic. If the endpoint type is HTTP/S or email,
    /// or if the endpoint and the topic are not in the same Amazon Web Services account,
    /// the endpoint owner must run the <code>ConfirmSubscription</code> action to confirm
    /// the subscription.
    /// 
    ///  
    /// <para>
    /// You call the <code>ConfirmSubscription</code> action with the token from the subscription
    /// response. Confirmation tokens are valid for three days.
    /// </para>
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
        /// <param name="protocol">The protocol that you want to use. Supported protocols include: <ul> <li>  <code>http</code> – delivery of JSON-encoded message via HTTP POST </li> <li>  <code>https</code> – delivery of JSON-encoded message via HTTPS POST </li> <li>  <code>email</code> – delivery of message via SMTP </li> <li>  <code>email-json</code> – delivery of JSON-encoded message via SMTP </li> <li>  <code>sms</code> – delivery of message via SMS </li> <li>  <code>sqs</code> – delivery of JSON-encoded message to an Amazon SQS queue </li> <li>  <code>application</code> – delivery of JSON-encoded message to an EndpointArn for a mobile app and device </li> <li>  <code>lambda</code> – delivery of JSON-encoded message to an Lambda function </li> <li>  <code>firehose</code> – delivery of JSON-encoded message to an Amazon Kinesis Data Firehose delivery stream. </li> </ul></param>
        /// <param name="endpoint">The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li> For the <code>http</code> protocol, the (public) endpoint is a URL beginning with <code>http://</code>. </li> <li> For the <code>https</code> protocol, the (public) endpoint is a URL beginning with <code>https://</code>. </li> <li> For the <code>email</code> protocol, the endpoint is an email address. </li> <li> For the <code>email-json</code> protocol, the endpoint is an email address. </li> <li> For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled device. </li> <li> For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue. </li> <li> For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile app and device. </li> <li> For the <code>lambda</code> protocol, the endpoint is the ARN of an Lambda function. </li> <li> For the <code>firehose</code> protocol, the endpoint is the ARN of an Amazon Kinesis Data Firehose delivery stream. </li> </ul></param>
        public SubscribeRequest(string topicArn, string protocol, string endpoint)
        {
            _topicArn = topicArn;
            _protocol = protocol;
            _endpoint = endpoint;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of attributes with their corresponding values.
        /// </para>
        ///  
        /// <para>
        /// The following lists the names, descriptions, and values of the special request parameters
        /// that the <code>Subscribe</code> action uses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DeliveryPolicy</code> – The policy that defines how Amazon SNS retries failed
        /// deliveries to HTTP/S endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FilterPolicy</code> – The simple JSON object that lets your subscriber receive
        /// only a subset of messages, rather than receiving every message published to the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FilterPolicyScope</code> – This attribute lets you choose the filtering scope
        /// by using one of the following string value types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MessageAttributes</code> (default) – The filter is applied on the message attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageBody</code> – The filter is applied on the message body.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RawMessageDelivery</code> – When set to <code>true</code>, enables raw message
        /// delivery to Amazon SQS or HTTP/S endpoints. This eliminates the need for the endpoints
        /// to process JSON formatting, which is otherwise created for Amazon SNS metadata.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedrivePolicy</code> – When specified, sends undeliverable messages to the
        /// specified Amazon SQS dead-letter queue. Messages that can't be delivered due to client
        /// errors (for example, when the subscribed endpoint is unreachable) or server errors
        /// (for example, when the service that powers the subscribed endpoint becomes unavailable)
        /// are held in the dead-letter queue for further analysis or reprocessing.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute applies only to Amazon Kinesis Data Firehose delivery stream
        /// subscriptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SubscriptionRoleArn</code> – The ARN of the IAM role that has the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Permission to write to the Kinesis Data Firehose delivery stream
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SNS listed as a trusted entity
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Specifying a valid ARN for this attribute is required for Kinesis Data Firehose delivery
        /// stream subscriptions. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-firehose-as-subscriber.html">Fanout
        /// to Kinesis Data Firehose delivery streams</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
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
        /// For the <code>http</code> protocol, the (public) endpoint is a URL beginning with
        /// <code>http://</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>https</code> protocol, the (public) endpoint is a URL beginning with
        /// <code>https://</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>email</code> protocol, the endpoint is an email address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>email-json</code> protocol, the endpoint is an email address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled
        /// device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile
        /// app and device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>lambda</code> protocol, the endpoint is the ARN of an Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>firehose</code> protocol, the endpoint is the ARN of an Amazon Kinesis
        /// Data Firehose delivery stream.
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
        /// The protocol that you want to use. Supported protocols include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>http</code> – delivery of JSON-encoded message via HTTP POST
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>https</code> – delivery of JSON-encoded message via HTTPS POST
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>email</code> – delivery of message via SMTP
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>email-json</code> – delivery of JSON-encoded message via SMTP
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sms</code> – delivery of message via SMS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqs</code> – delivery of JSON-encoded message to an Amazon SQS queue
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>application</code> – delivery of JSON-encoded message to an EndpointArn for
        /// a mobile app and device
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>lambda</code> – delivery of JSON-encoded message to an Lambda function
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>firehose</code> – delivery of JSON-encoded message to an Amazon Kinesis Data
        /// Firehose delivery stream.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// If you set this parameter to <code>true</code>, the response includes the ARN in all
        /// cases, even if the subscription is not yet confirmed. In addition to the ARN for confirmed
        /// subscriptions, the response also includes the <code>pending subscription</code> ARN
        /// value for subscriptions that aren't yet confirmed. A subscription becomes confirmed
        /// when the subscriber calls the <code>ConfirmSubscription</code> action with a confirmation
        /// token.
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
        [AWSProperty(Required=true)]
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