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
 *  API Version: 2010-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// The Unsubscribe action deletes a subscription. If the subscription requires authentication for
    /// deletion, only the owner of the subscription or the its topic's owner
    /// can unsubscribe, and an AWS signature is required. If the
    /// Unsubscribe call does not require authentication and the requester is not
    /// the subscription owner, a final cancellation message is delivered to the
    /// endpoint, so that the endpoint owner can easily resubscribe to the topic if
    /// the Unsubscribe request was unintended.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class UnsubscribeRequest
    {    
        private string subscriptionArnField;

        /// <summary>
        /// Gets and sets the SubscriptionArn property.
        /// The ARN of the subscription to be deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubscriptionArn")]
        public string SubscriptionArn
        {
            get { return this.subscriptionArnField; }
            set { this.subscriptionArnField = value; }
        }

        /// <summary>
        /// Sets the SubscriptionArn property
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to be deleted.</param>
        /// <returns>this instance</returns>
        public UnsubscribeRequest WithSubscriptionArn(string subscriptionArn)
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

    }
}
