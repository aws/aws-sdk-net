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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
    /// DISABLED.
    /// 
    ///  
    /// <para>
    /// If no status or time window is provided, the operation defaults to ACTIVE events from
    /// the last hour.
    /// </para>
    /// </summary>
    public partial class GetInstrumentationConfigurationStatusRequest : AmazonApplicationSignalsRequest
    {
        private DateTime? _endTime;
        private string _environment;
        private InstrumentationType _instrumentationType;
        private LocationIdentifier _locationIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private string _service;
        private DynamicInstrumentationSignalType _signalType;
        private DateTime? _startTime;
        private InstrumentationConfigurationStatus _status;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range to retrieve status events for. <c>StartTime</c> and <c>EndTime</c>
        /// must both be provided together or both be omitted. When both are omitted, the time
        /// range defaults to the last hour.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Environment name for the instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// Type of instrumentation configuration (BREAKPOINT or PROBE). Required to identify
        /// the configuration to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstrumentationType InstrumentationType
        {
            get { return this._instrumentationType; }
            set { this._instrumentationType = value; }
        }

        // Check to see if InstrumentationType property is set
        internal bool IsSetInstrumentationType()
        {
            return this._instrumentationType != null;
        }

        /// <summary>
        /// Gets and sets the property LocationIdentifier. 
        /// <para>
        /// Location identifier - either full code location or a pre-computed hash.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LocationIdentifier LocationIdentifier
        {
            get { return this._locationIdentifier; }
            set { this._locationIdentifier = value; }
        }

        // Check to see if LocationIdentifier property is set
        internal bool IsSetLocationIdentifier()
        {
            return this._locationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of status events to return in one call. The default is 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use the token returned by a previous call to retrieve the next page of status events.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Service name for the instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// Signal type for the instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DynamicInstrumentationSignalType SignalType
        {
            get { return this._signalType; }
            set { this._signalType = value; }
        }

        // Check to see if SignalType property is set
        internal bool IsSetSignalType()
        {
            return this._signalType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range to retrieve status events for. <c>StartTime</c> and <c>EndTime</c>
        /// must both be provided together or both be omitted. When both are omitted, the time
        /// range defaults to the last hour.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The single status to query for. If omitted, only <c>ACTIVE</c> status events are returned.
        /// </para>
        /// </summary>
        public InstrumentationConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}