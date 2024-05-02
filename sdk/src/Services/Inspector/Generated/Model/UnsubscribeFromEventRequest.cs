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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the UnsubscribeFromEvent operation.
    /// Disables the process of sending Amazon Simple Notification Service (SNS) notifications
    /// about a specified event to a specified SNS topic.
    /// </summary>
    public partial class UnsubscribeFromEventRequest : AmazonInspectorRequest
    {
        private InspectorEvent _event;
        private string _resourceArn;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The event for which you want to stop receiving SNS notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InspectorEvent Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the assessment template that is used during the event for which you want
        /// to stop receiving SNS notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
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
        /// The ARN of the SNS topic to which SNS notifications are sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
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