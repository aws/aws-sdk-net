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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <c>MarkerRecorded</c> event.
    /// </summary>
    public partial class MarkerRecordedEventAttributes
    {
        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskCompleted</c> event corresponding to the decision task
        /// that resulted in the <c>RecordMarker</c> decision that requested this marker. This
        /// information can be useful for diagnosing problems by tracing back the chain of events
        /// leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? DecisionTaskCompletedEventId { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskCompletedEventId property is set.
        /// </summary>
        internal bool IsSetDecisionTaskCompletedEventId() => this.DecisionTaskCompletedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The details of the marker.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property MarkerName. 
        /// <para>
        /// The name of the marker.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MarkerName { get; set; }

        /// <summary>
        /// Checks to see if the MarkerName property is set.
        /// </summary>
        internal bool IsSetMarkerName() => this.MarkerName != null;
    }
}
