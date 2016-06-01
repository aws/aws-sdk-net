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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used as a response element in the <a>ListEventSubscriptions</a>
    /// action.
    /// </summary>
    public partial class Subscription
    {
        private List<EventSubscription> _eventSubscriptions = new List<EventSubscription>();
        private string _resourceArn;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property EventSubscriptions. 
        /// <para>
        /// The list of existing event subscriptions.
        /// </para>
        /// </summary>
        public List<EventSubscription> EventSubscriptions
        {
            get { return this._eventSubscriptions; }
            set { this._eventSubscriptions = value; }
        }

        // Check to see if EventSubscriptions property is set
        internal bool IsSetEventSubscriptions()
        {
            return this._eventSubscriptions != null && this._eventSubscriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the assessment template that is used during the event for which the SNS
        /// notification is sent.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the Amazon Simple Notification Service (SNS) topic to which the SNS notifications
        /// are sent.
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}