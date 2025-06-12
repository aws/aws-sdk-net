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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the dimensions for an event filter that determines when a campaign is sent
    /// or a journey activity is performed.
    /// </summary>
    public partial class EventDimensions
    {
        private Dictionary<string, AttributeDimension> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeDimension>() : null;
        private SetDimension _eventType;
        private Dictionary<string, MetricDimension> _metrics = AWSConfigs.InitializeCollections ? new Dictionary<string, MetricDimension>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more custom attributes that your application reports to Amazon Pinpoint. You
        /// can use these attributes as selection criteria when you create an event filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeDimension> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The name of the event that causes the campaign to be sent or the journey activity
        /// to be performed. This can be a standard event that Amazon Pinpoint generates, such
        /// as _email.delivered. For campaigns, this can also be a custom event that's specific
        /// to your application. For information about standard events, see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/event-streams.html">Streaming
        /// Amazon Pinpoint Events</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </para>
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more custom metrics that your application reports to Amazon Pinpoint. You can
        /// use these metrics as selection criteria when you create an event filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MetricDimension> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}