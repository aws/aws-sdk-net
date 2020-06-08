/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A wrapper type for the topic's Amazon Resource Name (ARN).
    /// </summary>
    public partial class AwsSnsTopicDetails
    {
        private string _kmsMasterKeyId;
        private string _owner;
        private List<AwsSnsTopicSubscription> _subscription = new List<AwsSnsTopicSubscription>();
        private string _topicName;

        /// <summary>
        /// Gets and sets the property KmsMasterKeyId. 
        /// <para>
        /// The ID of an AWS managed customer master key (CMK) for Amazon SNS or a custom CMK.
        /// </para>
        /// </summary>
        public string KmsMasterKeyId
        {
            get { return this._kmsMasterKeyId; }
            set { this._kmsMasterKeyId = value; }
        }

        // Check to see if KmsMasterKeyId property is set
        internal bool IsSetKmsMasterKeyId()
        {
            return this._kmsMasterKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The subscription's owner.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Subscription. 
        /// <para>
        /// Subscription is an embedded property that describes the subscription endpoints of
        /// an Amazon SNS topic.
        /// </para>
        /// </summary>
        public List<AwsSnsTopicSubscription> Subscription
        {
            get { return this._subscription; }
            set { this._subscription = value; }
        }

        // Check to see if Subscription property is set
        internal bool IsSetSubscription()
        {
            return this._subscription != null && this._subscription.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic.
        /// </para>
        /// </summary>
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