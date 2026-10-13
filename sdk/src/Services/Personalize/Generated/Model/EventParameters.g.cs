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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes the parameters of events, which are used in solution creation.
    /// </summary>
    public partial class EventParameters
    {
        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The name of the event type to be considered for solution creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property EventValueThreshold. 
        /// <para>
        /// The threshold of the event type. Only events with a value greater or equal to this
        /// threshold will be considered for solution creation.
        /// </para>
        /// </summary>
        public double? EventValueThreshold { get; set; }

        /// <summary>
        /// Checks to see if the EventValueThreshold property is set.
        /// </summary>
        internal bool IsSetEventValueThreshold() => this.EventValueThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The weight of the event type. A higher weight means higher importance of the event
        /// type for the created solution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
