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
    /// An interest group, theme, or label within a list. Lists can have multiple topics.
    /// </summary>
    public partial class Topic
    {
        /// <summary>
        /// Gets and sets the property DefaultSubscriptionStatus. 
        /// <para>
        /// The default subscription status to be applied to a contact if the contact has not
        /// noted their preference for subscribing to a topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionStatus DefaultSubscriptionStatus { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSubscriptionStatus property is set.
        /// </summary>
        internal bool IsSetDefaultSubscriptionStatus() => this.DefaultSubscriptionStatus != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the topic is about, which the contact will see.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the topic the contact will see.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

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
