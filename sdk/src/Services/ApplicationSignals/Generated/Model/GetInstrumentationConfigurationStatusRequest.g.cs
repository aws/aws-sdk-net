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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the GetInstrumentationConfigurationStatus operation.
    /// Retrieves the status history for a single instrumentation configuration during a specified
    /// time range. The response lists when the configuration was ACTIVE, READY, ERROR, or
    /// DISABLED. <para> If no status or time window is provided, the operation defaults to
    /// ACTIVE events from the last hour. </para>
    /// </summary>
    public partial class GetInstrumentationConfigurationStatusRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range to retrieve status events for. <c>StartTime</c> and <c>EndTime</c>
        /// must both be provided together or both be omitted. When both are omitted, the time
        /// range defaults to the last hour.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Environment. Environment name for the instrumentation configuration.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property InstrumentationType. Type of instrumentation configuration
        /// (BREAKPOINT or PROBE). Required to identify the configuration to retrieve.
        /// </summary>
        [AWSProperty(Required = true)]
        public InstrumentationType InstrumentationType { get; set; }

        /// <summary>
        /// Checks to see if the InstrumentationType property is set.
        /// </summary>
        internal bool IsSetInstrumentationType() => this.InstrumentationType != null;

        /// <summary>
        /// Gets and sets the property LocationIdentifier. Location identifier - either full code
        /// location or a pre-computed hash.
        /// </summary>
        [AWSProperty(Required = true)]
        public LocationIdentifier LocationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the LocationIdentifier property is set.
        /// </summary>
        internal bool IsSetLocationIdentifier() => this.LocationIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of status events to return in one call. The default is 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by a previous call to retrieve the next page of status events.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Service. Service name for the instrumentation configuration.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property SignalType. Signal type for the instrumentation configuration.
        /// </summary>
        [AWSProperty(Required = true)]
        public DynamicInstrumentationSignalType SignalType { get; set; }

        /// <summary>
        /// Checks to see if the SignalType property is set.
        /// </summary>
        internal bool IsSetSignalType() => this.SignalType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range to retrieve status events for. <c>StartTime</c> and <c>EndTime</c>
        /// must both be provided together or both be omitted. When both are omitted, the time
        /// range defaults to the last hour.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The single status to query for. If omitted, only <c>ACTIVE</c> status events are returned.
        /// </para>
        /// </summary>
        public InstrumentationConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
