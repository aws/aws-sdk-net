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
    /// The status of a single instrumentation configuration reported by an SDK instance.
    /// </summary>
    public partial class InstrumentationConfigurationStatusReport
    {
        /// <summary>
        /// Gets and sets the property ErrorCause. 
        /// <para>
        /// The error cause when the status is <c>ERROR</c>, such as the file or method not being
        /// found.
        /// </para>
        /// </summary>
        public InstrumentationErrorCause ErrorCause { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCause property is set.
        /// </summary>
        internal bool IsSetErrorCause() => this.ErrorCause != null;

        /// <summary>
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// The type of instrumentation configuration being reported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstrumentationType InstrumentationType { get; set; }

        /// <summary>
        /// Checks to see if the InstrumentationType property is set.
        /// </summary>
        internal bool IsSetInstrumentationType() => this.InstrumentationType != null;

        /// <summary>
        /// Gets and sets the property LocationHash. 
        /// <para>
        /// The stable hash of the instrumentation location that identifies the configuration
        /// being reported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 16)]
        public string LocationHash { get; set; }

        /// <summary>
        /// Checks to see if the LocationHash property is set.
        /// </summary>
        internal bool IsSetLocationHash() => this.LocationHash != null;

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// The telemetry signal type for this instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DynamicInstrumentationSignalType SignalType { get; set; }

        /// <summary>
        /// Checks to see if the SignalType property is set.
        /// </summary>
        internal bool IsSetSignalType() => this.SignalType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the instrumentation configuration: <c>READY</c>, <c>ERROR</c>, <c>ACTIVE</c>,
        /// or <c>DISABLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstrumentationConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The timestamp when the status event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;
    }
}
