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
    /// A status event that could not be processed by the service.
    /// </summary>
    public partial class UnprocessedStatusEvent
    {
        private UnprocessedStatusEventFailureReason _failedReason;
        private InstrumentationType _instrumentationType;
        private string _locationHash;
        private DynamicInstrumentationSignalType _signalType;
        private InstrumentationConfigurationStatus _status;
        private DateTime? _time;

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// The reason why this status event could not be processed, such as throttling or validation
        /// errors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UnprocessedStatusEventFailureReason FailedReason
        {
            get { return this._failedReason; }
            set { this._failedReason = value; }
        }

        // Check to see if FailedReason property is set
        internal bool IsSetFailedReason()
        {
            return this._failedReason != null;
        }

        /// <summary>
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// The type of instrumentation configuration for the unprocessed status event.
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
        /// Gets and sets the property LocationHash. 
        /// <para>
        /// The stable hash of the instrumentation location for the unprocessed event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=16)]
        public string LocationHash
        {
            get { return this._locationHash; }
            set { this._locationHash = value; }
        }

        // Check to see if LocationHash property is set
        internal bool IsSetLocationHash()
        {
            return this._locationHash != null;
        }

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// The telemetry signal type for the unprocessed status event.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status that failed to be processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The timestamp of the status event that failed to be processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time.HasValue; 
        }

    }
}