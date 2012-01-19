﻿/*******************************************************************************
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
    /// The GetSubscriptionAttribtues action returns all of the properties of a subscription customers have created. Subscription
    /// properties returned might differ based on the authorization of the user.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class GetSubscriptionAttributesRequest
    {    
        private string subscriptionArnField;

        /// <summary>
        /// Gets and sets the SubscriptionArn property.
        /// The ARN of the subscription whose properties you want to get.
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
        /// <param name="subscriptionARN">The ARN of the subscription whose properties you want to get.</param>
        /// <returns>this instance</returns>
        public GetSubscriptionAttributesRequest WithSubscriptionArn(string subscriptionARN)
        {
            this.subscriptionArnField = subscriptionARN;
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
