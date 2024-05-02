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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the TestEventPattern operation.
    /// Tests whether the specified event pattern matches the provided event.
    /// 
    ///  
    /// <para>
    /// Most services in Amazon Web Services treat : or / as the same character in Amazon
    /// Resource Names (ARNs). However, EventBridge uses an exact match in event patterns
    /// and rules. Be sure to use the correct ARN characters when creating event patterns
    /// so that they match the ARN syntax in the event you want to match.
    /// </para>
    /// </summary>
    public partial class TestEventPatternRequest : AmazonCloudWatchEventsRequest
    {
        private string _event;
        private string _eventPattern;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The event, in JSON format, to test against the event pattern. The JSON must follow
        /// the format specified in <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/aws-events.html">Amazon
        /// Web Services Events</a>, and the following fields are mandatory:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>account</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>time</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resources</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>detail-type</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Event
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
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The event pattern. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html">Events
        /// and Event Patterns</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

    }
}