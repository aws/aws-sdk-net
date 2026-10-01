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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Configuration parameters for events in the personalization system.
    /// </summary>
    public partial class EventParameters
    {
        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event being tracked (e.g., 'click', 'purchase', 'view').
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property EventValueThreshold. 
        /// <para>
        /// The minimum value threshold that an event must meet to be considered valid.
        /// </para>
        /// </summary>
        public double? EventValueThreshold { get; set; }

        /// <summary>
        /// Checks to see if the EventValueThreshold property is set.
        /// </summary>
        internal bool IsSetEventValueThreshold() => this.EventValueThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property EventWeight. 
        /// <para>
        /// The weight of the event type. A higher weight means higher importance of the event
        /// type for the created solution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? EventWeight { get; set; }

        /// <summary>
        /// Checks to see if the EventWeight property is set.
        /// </summary>
        internal bool IsSetEventWeight() => this.EventWeight.HasValue;
    }
}
