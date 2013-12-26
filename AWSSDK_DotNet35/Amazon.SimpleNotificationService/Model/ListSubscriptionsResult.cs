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
    /// 
    /// </summary>
    public partial class ListSubscriptionsResult : AmazonWebServiceResponse
    {
        
        private List<Subscription> subscriptions = new List<Subscription>();
        private string nextToken;


        /// <summary>
        /// A list of subscriptions.
        ///  
        /// </summary>
        public List<Subscription> Subscriptions
        {
            get { return this.subscriptions; }
            set { this.subscriptions = value; }
        }

        // Check to see if Subscriptions property is set
        internal bool IsSetSubscriptions()
        {
            return this.subscriptions.Count > 0;
        }

        /// <summary>
        /// Token to pass along to the next <c>ListSubscriptions</c> request. This element is returned if there are more subscriptions to retrieve.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
