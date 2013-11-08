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
    /// Container for the parameters to the Subscribe operation.
    /// <para>The <c>Subscribe</c> action prepares to subscribe an endpoint by sending the endpoint a confirmation message. To actually create a
    /// subscription, the endpoint owner must call the <c>ConfirmSubscription</c> action with the token from the confirmation message. Confirmation
    /// tokens are valid for three days.</para>
    /// </summary>
    public partial class SubscribeRequest : AmazonWebServiceRequest
    {
        private string topicArn;
        private string protocol;
        private string endpoint;
        /// <summary>
        /// Default constructor for a new SubscribeRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SubscribeRequest() {}
    
        /// <summary>
        /// Constructs a new SubscribeRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic you want to subscribe to. </param>
        /// <param name="protocol"> The protocol you want to use. Supported protocols include: <ul> <li><c>http</c> -- delivery of JSON-encoded message
        /// via HTTP POST</li> <li><c>https</c> -- delivery of JSON-encoded message via HTTPS POST</li> <li><c>email</c> -- delivery of message via
        /// SMTP</li> <li><c>email-json</c> -- delivery of JSON-encoded message via SMTP</li> <li><c>sms</c> -- delivery of message via SMS</li>
        /// <li><c>sqs</c> -- delivery of JSON-encoded message to an Amazon SQS queue</li> <li><c>application</c> -- delivery of JSON-encoded message to
        /// an EndpointArn for a mobile app and device.</li> </ul> </param>
        /// <param name="endpoint"> The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li>For the <c>http</c>
        /// protocol, the endpoint is an URL beginning with "http://"</li> <li>For the <c>https</c> protocol, the endpoint is a URL beginning with
        /// "https://"</li> <li>For the <c>email</c> protocol, the endpoint is an email address</li> <li>For the <c>email-json</c> protocol, the
        /// endpoint is an email address</li> <li>For the <c>sms</c> protocol, the endpoint is a phone number of an SMS-enabled device</li> <li>For the
        /// <c>sqs</c> protocol, the endpoint is the ARN of an Amazon SQS queue</li> <li>For the <c>application</c> protocol, the endpoint is the
        /// EndpointArn of a mobile app and device.</li> </ul> </param>
        public SubscribeRequest(string topicArn, string protocol, string endpoint)
        {
            this.topicArn = topicArn;
            this.protocol = protocol;
            this.endpoint = endpoint;
        }
    

        /// <summary>
        /// The ARN of the topic you want to subscribe to.
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
        /// The protocol you want to use. Supported protocols include: <ul> <li><c>http</c> -- delivery of JSON-encoded message via HTTP POST</li>
        /// <li><c>https</c> -- delivery of JSON-encoded message via HTTPS POST</li> <li><c>email</c> -- delivery of message via SMTP</li>
        /// <li><c>email-json</c> -- delivery of JSON-encoded message via SMTP</li> <li><c>sms</c> -- delivery of message via SMS</li> <li><c>sqs</c> --
        /// delivery of JSON-encoded message to an Amazon SQS queue</li> <li><c>application</c> -- delivery of JSON-encoded message to an EndpointArn
        /// for a mobile app and device.</li> </ul>
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;
        }

        /// <summary>
        /// The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li>For the <c>http</c> protocol, the endpoint is an
        /// URL beginning with "http://"</li> <li>For the <c>https</c> protocol, the endpoint is a URL beginning with "https://"</li> <li>For the
        /// <c>email</c> protocol, the endpoint is an email address</li> <li>For the <c>email-json</c> protocol, the endpoint is an email address</li>
        /// <li>For the <c>sms</c> protocol, the endpoint is a phone number of an SMS-enabled device</li> <li>For the <c>sqs</c> protocol, the endpoint
        /// is the ARN of an Amazon SQS queue</li> <li>For the <c>application</c> protocol, the endpoint is the EndpointArn of a mobile app and
        /// device.</li> </ul>
        ///  
        /// </summary>
        public string Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }

    }
}
    
