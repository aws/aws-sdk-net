/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// The contact's preference for being opted-in to or opted-out of a topic.
    /// </summary>
    public partial class TopicPreference
    {
        /// <summary>
        /// Gets and sets the property SubscriptionStatus. 
        /// <para>
        /// The contact's subscription status to a topic which is either <c>OPT_IN</c> or <c>OPT_OUT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionStatus SubscriptionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionStatus property is set.
        /// </summary>
        internal bool IsSetSubscriptionStatus() => this.SubscriptionStatus != null;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
