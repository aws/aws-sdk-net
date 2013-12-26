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
    /// Container for the parameters to the GetSubscriptionAttributes operation.
    /// <para>The <c>GetSubscriptionAttribtues</c> action returns all of the properties of a subscription.</para>
    /// </summary>
    public partial class GetSubscriptionAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private string subscriptionArn;


        /// <summary>
        /// The ARN of the subscription whose properties you want to get.
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
    
