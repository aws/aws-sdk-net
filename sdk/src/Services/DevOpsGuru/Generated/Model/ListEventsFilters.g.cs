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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Filters you can use to specify which events are returned when <c>ListEvents</c> is
    /// called.
    /// </summary>
    public partial class ListEventsFilters
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The source, <c>AWS_CLOUD_TRAIL</c> or <c>AWS_CODE_DEPLOY</c>, of the events you want
        /// returned. 
        /// </para>
        /// </summary>
        public EventDataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property EventClass. 
        /// <para>
        ///  The class of the events you want to filter for, such as an infrastructure change,
        /// a deployment, or a schema change. 
        /// </para>
        /// </summary>
        public EventClass EventClass { get; set; }

        /// <summary>
        /// Checks to see if the EventClass property is set.
        /// </summary>
        internal bool IsSetEventClass() => this.EventClass != null;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        ///  The Amazon Web Services source that emitted the events you want to filter for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 50)]
        public string EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

        /// <summary>
        /// Gets and sets the property EventTimeRange. 
        /// <para>
        ///  A time range during which you want the filtered events to have occurred. 
        /// </para>
        /// </summary>
        public EventTimeRange EventTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the EventTimeRange property is set.
        /// </summary>
        internal bool IsSetEventTimeRange() => this.EventTimeRange != null;

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        ///  An ID of an insight that is related to the events you want to filter for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InsightId { get; set; }

        /// <summary>
        /// Checks to see if the InsightId property is set.
        /// </summary>
        internal bool IsSetInsightId() => this.InsightId != null;

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCollection property is set.
        /// </summary>
        internal bool IsSetResourceCollection() => this.ResourceCollection != null;
    }
}
