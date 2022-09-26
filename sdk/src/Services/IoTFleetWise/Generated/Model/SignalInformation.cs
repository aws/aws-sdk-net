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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about a signal.
    /// </summary>
    public partial class SignalInformation
    {
        private long? _maxSampleCount;
        private long? _minimumSamplingIntervalMs;
        private string _name;

        /// <summary>
        /// Gets and sets the property MaxSampleCount. 
        /// <para>
        /// The maximum number of samples to collect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4294967295)]
        public long MaxSampleCount
        {
            get { return this._maxSampleCount.GetValueOrDefault(); }
            set { this._maxSampleCount = value; }
        }

        // Check to see if MaxSampleCount property is set
        internal bool IsSetMaxSampleCount()
        {
            return this._maxSampleCount.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=4294967295)]
        public long MinimumSamplingIntervalMs
        {
            get { return this._minimumSamplingIntervalMs.GetValueOrDefault(); }
            set { this._minimumSamplingIntervalMs = value; }
        }

        // Check to see if MinimumSamplingIntervalMs property is set
        internal bool IsSetMinimumSamplingIntervalMs()
        {
            return this._minimumSamplingIntervalMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}