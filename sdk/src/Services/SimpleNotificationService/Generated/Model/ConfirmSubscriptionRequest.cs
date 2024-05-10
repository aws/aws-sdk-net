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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the ConfirmSubscription operation.
    /// Verifies an endpoint owner's intent to receive messages by validating the token sent
    /// to the endpoint by an earlier <c>Subscribe</c> action. If the token is valid, the
    /// action creates a new subscription and returns its Amazon Resource Name (ARN). This
    /// call requires an AWS signature only when the <c>AuthenticateOnUnsubscribe</c> flag
    /// is set to "true".
    /// </summary>
    public partial class ConfirmSubscriptionRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _authenticateOnUnsubscribe;
        private string _token;
        private string _topicArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ConfirmSubscriptionRequest() { }

        /// <summary>
        /// Instantiates ConfirmSubscriptionRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <c>Subscribe</c> action.</param>
        public ConfirmSubscriptionRequest(string topicArn, string token)
        {
            _topicArn = topicArn;
            _token = token;
        }

        /// <summary>
        /// Instantiates ConfirmSubscriptionRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <c>Subscribe</c> action.</param>
        /// <param name="authenticateOnUnsubscribe">Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter is <c>true</c> and the request has an Amazon Web Services signature, then only the topic owner and the subscription owner can unsubscribe the endpoint. The unsubscribe action requires Amazon Web Services authentication. </param>
        public ConfirmSubscriptionRequest(string topicArn, string token, string authenticateOnUnsubscribe)
        {
            _topicArn = topicArn;
            _token = token;
            _authenticateOnUnsubscribe = authenticateOnUnsubscribe;
        }

        /// <summary>
        /// Gets and sets the property AuthenticateOnUnsubscribe. 
        /// <para>
        /// Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter
        /// is <c>true</c> and the request has an Amazon Web Services signature, then only the
        /// topic owner and the subscription owner can unsubscribe the endpoint. The unsubscribe
        /// action requires Amazon Web Services authentication. 
        /// </para>
        /// </summary>
        public string AuthenticateOnUnsubscribe
        {
            get { return this._authenticateOnUnsubscribe; }
            set { this._authenticateOnUnsubscribe = value; }
        }

        // Check to see if AuthenticateOnUnsubscribe property is set
        internal bool IsSetAuthenticateOnUnsubscribe()
        {
            return this._authenticateOnUnsubscribe != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// Short-lived token sent to an endpoint during the <c>Subscribe</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the topic for which you wish to confirm a subscription.
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