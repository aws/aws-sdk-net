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
    /// Container for the parameters to the ConfirmSubscription operation.
    /// <para>The <c>ConfirmSubscription</c> action verifies an endpoint owner's intent to receive messages by validating the token sent to the
    /// endpoint by an earlier <c>Subscribe</c> action. If the token is valid, the action creates a new subscription and returns its Amazon Resource
    /// Name (ARN). This call requires an AWS signature only when the <c>AuthenticateOnUnsubscribe</c> flag is set to "true".</para>
    /// </summary>
    public partial class ConfirmSubscriptionRequest : AmazonWebServiceRequest
    {
        private string topicArn;
        private string token;
        private string authenticateOnUnsubscribe;
        /// <summary>
        /// Default constructor for a new ConfirmSubscriptionRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public ConfirmSubscriptionRequest() {}
    
        /// <summary>
        /// Constructs a new ConfirmSubscriptionRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic for which you wish to confirm a subscription. </param>
        /// <param name="token"> Short-lived token sent to an endpoint during the <c>Subscribe</c> action. </param>
        public ConfirmSubscriptionRequest(string topicArn, string token)
        {
            this.topicArn = topicArn;
            this.token = token;
        }
    
        /// <summary>
        /// Constructs a new ConfirmSubscriptionRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic for which you wish to confirm a subscription. </param>
        /// <param name="token"> Short-lived token sent to an endpoint during the <c>Subscribe</c> action. </param>
        /// <param name="authenticateOnUnsubscribe"> Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter is
        /// <c>true</c> and the request has an AWS signature, then only the topic owner and the subscription owner can unsubscribe the endpoint. The
        /// unsubscribe action requires AWS authentication. </param>
        public ConfirmSubscriptionRequest(string topicArn, string token, string authenticateOnUnsubscribe)
        {
            this.topicArn = topicArn;
            this.token = token;
            this.authenticateOnUnsubscribe = authenticateOnUnsubscribe;
        }
    

        /// <summary>
        /// The ARN of the topic for which you wish to confirm a subscription.
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
        /// Short-lived token sent to an endpoint during the <c>Subscribe</c> action.
        ///  
        /// </summary>
        public string Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this.token != null;
        }

        /// <summary>
        /// Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter is <c>true</c> and the request has an AWS
        /// signature, then only the topic owner and the subscription owner can unsubscribe the endpoint. The unsubscribe action requires AWS
        /// authentication.
        ///  
        /// </summary>
        public string AuthenticateOnUnsubscribe
        {
            get { return this.authenticateOnUnsubscribe; }
            set { this.authenticateOnUnsubscribe = value; }
        }

        // Check to see if AuthenticateOnUnsubscribe property is set
        internal bool IsSetAuthenticateOnUnsubscribe()
        {
            return this.authenticateOnUnsubscribe != null;
        }

    }
}
    
