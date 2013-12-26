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
    /// Container for the parameters to the SetSubscriptionAttributes operation.
    /// <para>The <c>SetSubscriptionAttributes</c> action allows a subscription owner to set an attribute of the topic to a new value.</para>
    /// </summary>
    public partial class SetSubscriptionAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private string subscriptionArn;
        private string attributeName;
        private string attributeValue;


        /// <summary>
        /// The ARN of the subscription to modify.
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

        /// <summary>
        /// The name of the attribute you want to set. Only a subset of the subscriptions attributes are mutable. Valid values: <c>DeliveryPolicy</c> |
        /// <c>RawMessageDelivery</c>
        ///  
        /// </summary>
        public string AttributeName
        {
            get { return this.attributeName; }
            set { this.attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this.attributeName != null;
        }

        /// <summary>
        /// The new value for the attribute in JSON format.
        ///  
        /// </summary>
        public string AttributeValue
        {
            get { return this.attributeValue; }
            set { this.attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this.attributeValue != null;
        }

    }
}
    
