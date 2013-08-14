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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// <para>Response for GetTopicAttributes action.</para>
    /// </summary>
    public partial class GetTopicAttributesResult : AmazonWebServiceResponse
    {
        
        private Dictionary<string,string> attributes = new Dictionary<string,string>();

        /// <summary>
        /// A map of the topic's attributes. Attributes in this map include the following: <ul> <li><c>TopicArn</c> -- the topic's ARN</li>
        /// <li><c>Owner</c> -- the AWS account ID of the topic's owner</li> <li><c>Policy</c> -- the JSON serialization of the topic's access control
        /// policy</li> <li><c>DisplayName</c> -- the human-readable name used in the "From" field for notifications to email and email-json
        /// endpoints</li> <li><c>SubscriptionsPending</c> -- the number of subscriptions pending confirmation on this topic</li>
        /// <li><c>SubscriptionsConfirmed</c> -- the number of confirmed subscriptions on this topic</li> <li><c>SubscriptionsDeleted</c> -- the number
        /// of deleted subscriptions on this topic</li> <li><c>DeliveryPolicy</c> -- the JSON serialization of the topic's delivery policy</li>
        /// <li><c>EffectiveDeliveryPolicy</c> -- the JSON serialization of the effective delivery policy that takes into account system defaults</li>
        /// </ul>
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }
    }
}
