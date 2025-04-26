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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Used to configure a frequency-based vehicle signal fetch.
    /// </summary>
    public partial class TimeBasedSignalFetchConfig
    {
        private long? _executionFrequencyMs;

        /// <summary>
        /// Gets and sets the property ExecutionFrequencyMs. 
        /// <para>
        /// The frequency with which the signal fetch will be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=9223372036854775807)]
        public long? ExecutionFrequencyMs
        {
            get { return this._executionFrequencyMs; }
            set { this._executionFrequencyMs = value; }
        }

        // Check to see if ExecutionFrequencyMs property is set
        internal bool IsSetExecutionFrequencyMs()
        {
            return this._executionFrequencyMs.HasValue; 
        }

    }
}