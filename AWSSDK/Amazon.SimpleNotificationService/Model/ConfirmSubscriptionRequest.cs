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
    /// Verifies an endpoint owner's intent to receive messages by validating the token
    /// sent to the endpoint by an earlier Subscribe action.
    /// If the token is valid, the action creates a new subscription and returns its
    /// Amazon Resource Name (ARN).
    /// </summary>
    /// <remarks>
    /// This call requires an AWS signature only when the AuthenticateOnUnsubscribe
    /// flag is set to "true".
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class ConfirmSubscriptionRequest : SNSRequest
    {    
        private string topicArnField;
        private string tokenField;
        private string authenticateOnUnsubscribeField;

        /// <summary>
        /// The ARN of the topic for which you wish to confirm a subscription.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the ARN of the topic for which you wish to confirm a subscription.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <returns>this instance</returns>
        public ConfirmSubscriptionRequest WithTopicArn(string topicArn)
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
        /// Short-lived token sent to an endpoint during the Subscribe action.
        /// </summary>
        [XmlElementAttribute(ElementName = "Token")]
        public string Token
        {
            get { return this.tokenField; }
            set { this.tokenField = value; }
        }

        /// <summary>
        /// Sets a short-lived token sent to an endpoint during the Subscribe action.
        /// </summary>
        /// <param name="token">Short-lived token sent to an endpoint during the Subscribe action.</param>
        /// <returns>this instance</returns>
        public ConfirmSubscriptionRequest WithToken(string token)
        {
            this.tokenField = token;
            return this;
        }

        /// <summary>
        /// Checks if Token property is set
        /// </summary>
        /// <returns>true if Token property is set</returns>
        public bool IsSetToken()
        {
            return this.tokenField != null;
        }

        /// <summary>
        /// Value that indicates that you want to disable unauthenticated unsubsciption of the subscription.
        /// If parameter is present in the request, the request has an AWS signature, and the value
        /// of this parameter is "true", only the topic owner and the subscription owner will be
        /// permitted to unsubscribe the endopint, and the Unsubscribe action will require AWS
        /// authentication.
        /// </summary>
        [XmlElementAttribute(ElementName = "AuthenticateOnUnsubscribe")]
        public string AuthenticateOnUnsubscribe
        {
            get { return this.authenticateOnUnsubscribeField; }
            set { this.authenticateOnUnsubscribeField = value; }
        }

        /// <summary>
        /// Sets the value that indicates that you want to disable unauthenticated unsubsciption of the subscription.
        /// </summary>
        /// <param name="authenticateOnUnsubscribe">
        /// Value that indicates that you want to disable unauthenticated unsubsciption of the subscription.
        /// </param>
        /// <returns>this instance</returns>
        public ConfirmSubscriptionRequest WithAuthenticateOnUnsubscribe(string authenticateOnUnsubscribe)
        {
            this.authenticateOnUnsubscribeField = authenticateOnUnsubscribe;
            return this;
        }

        /// <summary>
        /// Checks if AuthenticateOnUnsubscribe property is set
        /// </summary>
        /// <returns>true if AuthenticateOnUnsubscribe property is set</returns>
        public bool IsSetAuthenticateOnUnsubscribe()
        {
            return this.authenticateOnUnsubscribeField != null;
        }

    }
}
