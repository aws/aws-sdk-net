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
    /// <para>Response for GetSubscriptionAttributes action.</para>
    /// </summary>
    public partial class GetSubscriptionAttributesResult : AmazonWebServiceResponse
    {
        
        private Dictionary<string,string> attributes = new Dictionary<string,string>();

        /// <summary>
        /// A map of the subscription's attributes. Attributes in this map include the following: <ul> <li><c>SubscriptionArn</c> -- the subscription's
        /// ARN</li> <li><c>TopicArn</c> -- the topic ARN that the subscription is associated with</li> <li><c>Owner</c> -- the AWS account ID of the
        /// subscription's owner</li> <li><c>ConfirmationWasAuthenticated</c> -- true if the subscription confirmation request was authenticated</li>
        /// <li><c>DeliveryPolicy</c> -- the JSON serialization of the subscription's delivery policy</li> <li><c>EffectiveDeliveryPolicy</c> -- the
        /// JSON serialization of the effective delivery policy that takes into account the topic delivery policy and account system defaults</li> </ul>
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
