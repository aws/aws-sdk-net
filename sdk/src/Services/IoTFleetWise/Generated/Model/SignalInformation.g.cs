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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about a signal.
    /// </summary>
    public partial class SignalInformation
    {
        /// <summary>
        /// Gets and sets the property DataPartitionId. 
        /// <para>
        /// The ID of the data partition this signal is associated with.
        /// </para>
        ///  
        /// <para>
        /// The ID must match one of the IDs provided in <c>dataPartitions</c>. This is accomplished
        /// either by specifying a particular data partition ID or by using <c>default</c> for
        /// an established default partition. You can establish a default partition in the <c>DataPartition</c>
        /// data type.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you upload a signal as a condition for a campaign's data partition, the same signal
        /// must be included in <c>signalsToCollect</c>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
        /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
        /// FleetWise Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DataPartitionId { get; set; }

        /// <summary>
        /// Checks to see if the DataPartitionId property is set.
        /// </summary>
        internal bool IsSetDataPartitionId() => this.DataPartitionId != null;

        /// <summary>
        /// Gets and sets the property MaxSampleCount. 
        /// <para>
        /// The maximum number of samples to collect.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4294967295)]
        public long? MaxSampleCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxSampleCount property is set.
        /// </summary>
        internal bool IsSetMaxSampleCount() => this.MaxSampleCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumSamplingIntervalMs. 
        /// <para>
        /// The minimum duration of time (in milliseconds) between two triggering events to collect
        /// data.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a signal changes often, you might want to collect data at a slower rate.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4294967295)]
        public long? MinimumSamplingIntervalMs { get; set; }

        /// <summary>
        /// Checks to see if the MinimumSamplingIntervalMs property is set.
        /// </summary>
        internal bool IsSetMinimumSamplingIntervalMs() => this.MinimumSamplingIntervalMs.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
