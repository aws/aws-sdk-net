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
    /// The ListSubscriptionsByTopic action returns a list of the subscriptions to a specific topic. Each call returns
    /// a limited list of subscriptions. If there are more subscriptions, a NextToken is also returned. Use the NextToken
    /// parameter in a new ListSubscriptionsByTopic call to get further results.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class ListSubscriptionsByTopicRequest
    {    
        private string topicArnField;
        private string nextTokenField;

        /// <summary>
        /// Gets and sets the TopicArn property.
        /// The ARN of the topic for which you wish to find subscriptions.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the TopicArn property
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// <returns>this instance</returns>
        public ListSubscriptionsByTopicRequest WithTopicArn(string topicArn)
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
        /// Gets and sets the NextToken property.
        /// Token returned by the previous ListSubscriptionsByTopic request.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">Token returned by the previous ListSubscriptionsByTopic request.</param>
        /// <returns>this instance</returns>
        public ListSubscriptionsByTopicRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }

    }
}
