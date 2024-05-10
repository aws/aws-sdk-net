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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
        private SubscriptionStatus _defaultSubscriptionStatus;
        private string _description;
        private string _displayName;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property DefaultSubscriptionStatus. 
        /// <para>
        /// The default subscription status to be applied to a contact if the contact has not
        /// noted their preference for subscribing to a topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionStatus DefaultSubscriptionStatus
        {
            get { return this._defaultSubscriptionStatus; }
            set { this._defaultSubscriptionStatus = value; }
        }

        // Check to see if DefaultSubscriptionStatus property is set
        internal bool IsSetDefaultSubscriptionStatus()
        {
            return this._defaultSubscriptionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the topic is about, which the contact will see.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the topic the contact will see.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

    }
}