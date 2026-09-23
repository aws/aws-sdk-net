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
    /// A status event that could not be processed by the service.
    /// </summary>
    public partial class UnprocessedStatusEvent
    {
        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// The reason why this status event could not be processed, such as throttling or validation
        /// errors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UnprocessedStatusEventFailureReason FailedReason { get; set; }

        /// <summary>
        /// Checks to see if the FailedReason property is set.
        /// </summary>
        internal bool IsSetFailedReason() => this.FailedReason != null;

        /// <summary>
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// The type of instrumentation configuration for the unprocessed status event.
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
        /// The stable hash of the instrumentation location for the unprocessed event.
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
        /// The telemetry signal type for the unprocessed status event.
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
        /// The status that failed to be processed.
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
        /// The timestamp of the status event that failed to be processed.
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
