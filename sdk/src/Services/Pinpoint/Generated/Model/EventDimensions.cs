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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Event dimensions.
    /// </summary>
    public partial class EventDimensions
    {
        private Dictionary<string, AttributeDimension> _attributes = new Dictionary<string, AttributeDimension>();
        private SetDimension _eventType;
        private Dictionary<string, MetricDimension> _metrics = new Dictionary<string, MetricDimension>();

        /// <summary>
        /// Gets and sets the property Attributes. Custom attributes that your app reports to
        /// Amazon Pinpoint. You can use these attributes as selection criteria when you create
        /// an event filter.
        /// </summary>
        public Dictionary<string, AttributeDimension> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventType. The name of the event that causes the campaign
        /// to be sent. This can be a standard event type that Amazon Pinpoint generates, such
        /// as _session.start, or a custom event that's specific to your app.
        /// </summary>
        public SetDimension EventType
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
        /// Gets and sets the property Metrics. Custom metrics that your app reports to Amazon
        /// Pinpoint. You can use these attributes as selection criteria when you create an event
        /// filter.
        /// </summary>
        public Dictionary<string, MetricDimension> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

    }
}