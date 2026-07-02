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
    /// The status of a single instrumentation configuration reported by an SDK instance.
    /// </summary>
    public partial class InstrumentationConfigurationStatusReport
    {
        private InstrumentationErrorCause _errorCause;
        private InstrumentationType _instrumentationType;
        private string _locationHash;
        private DynamicInstrumentationSignalType _signalType;
        private InstrumentationConfigurationStatus _status;
        private DateTime? _time;

        /// <summary>
        /// Gets and sets the property ErrorCause. 
        /// <para>
        /// The error cause when the status is <c>ERROR</c>, such as the file or method not being
        /// found.
        /// </para>
        /// </summary>
        public InstrumentationErrorCause ErrorCause
        {
            get { return this._errorCause; }
            set { this._errorCause = value; }
        }

        // Check to see if ErrorCause property is set
        internal bool IsSetErrorCause()
        {
            return this._errorCause != null;
        }

        /// <summary>
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// The type of instrumentation configuration being reported.
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
        /// The stable hash of the instrumentation location that identifies the configuration
        /// being reported.
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
        /// The telemetry signal type for this instrumentation configuration.
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
        /// The status of the instrumentation configuration: <c>READY</c>, <c>ERROR</c>, <c>ACTIVE</c>,
        /// or <c>DISABLED</c>.
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
        /// The timestamp when the status event occurred.
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