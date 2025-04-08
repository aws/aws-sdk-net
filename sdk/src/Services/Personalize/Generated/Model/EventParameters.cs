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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
        private string _eventType;
        private double? _eventValueThreshold;
        private double? _weight;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The name of the event type to be considered for solution creation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property EventValueThreshold. 
        /// <para>
        /// The threshold of the event type. Only events with a value greater or equal to this
        /// threshold will be considered for solution creation.
        /// </para>
        /// </summary>
        public double? EventValueThreshold
        {
            get { return this._eventValueThreshold; }
            set { this._eventValueThreshold = value; }
        }

        // Check to see if EventValueThreshold property is set
        internal bool IsSetEventValueThreshold()
        {
            return this._eventValueThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The weight of the event type. A higher weight means higher importance of the event
        /// type for the created solution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}