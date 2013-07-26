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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// <para>A wrapper type for the attributes of an SNS subscription.</para>
    /// </summary>
    public class Subscription
    {
        
        private string subscriptionArn;
        private string owner;
        private string protocol;
        private string endpoint;
        private string topicArn;
        /// <summary>
        /// Default constructor for a new Subscription object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public Subscription() {}
    

        /// <summary>
        /// The subscription's ARN.
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
        /// The subscription's owner.
        ///  
        /// </summary>
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }

        /// <summary>
        /// The subscription's protocol.
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;
        }

        /// <summary>
        /// The subscription's endpoint (format depends on the protocol).
        ///  
        /// </summary>
        public string Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }

        /// <summary>
        /// The ARN of the subscription's topic.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }
    }
}
