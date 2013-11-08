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
    /// Container for the parameters to the Unsubscribe operation.
    /// <para>The <c>Unsubscribe</c> action deletes a subscription. If the subscription requires authentication for deletion, only the owner of the
    /// subscription or the topic's owner can unsubscribe, and an AWS signature is required. If the <c>Unsubscribe</c> call does not require
    /// authentication and the requester is not the subscription owner, a final cancellation message is delivered to the endpoint, so that the
    /// endpoint owner can easily resubscribe to the topic if the <c>Unsubscribe</c> request was unintended.</para>
    /// </summary>
    public partial class UnsubscribeRequest : AmazonWebServiceRequest
    {
        private string subscriptionArn;
        /// <summary>
        /// Default constructor for a new UnsubscribeRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public UnsubscribeRequest() {}
    
        /// <summary>
        /// Constructs a new UnsubscribeRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="subscriptionArn"> The ARN of the subscription to be deleted. </param>
        public UnsubscribeRequest(string subscriptionArn)
        {
            this.subscriptionArn = subscriptionArn;
        }
    

        /// <summary>
        /// The ARN of the subscription to be deleted.
        ///  
        /// </summary>
        public string SubscriptionArn
        {
            get { return this.subscriptionArn; }
            set { this.subscriptionArn = value; }
        }

        // Check to see if SubscriptionArn property is set
        internal bool IsSetSubscriptionArn()
        {
            return this.subscriptionArn != null;
        }

    }
}
    
