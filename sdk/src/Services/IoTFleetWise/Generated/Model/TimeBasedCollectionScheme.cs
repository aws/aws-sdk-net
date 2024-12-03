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
    /// Information about a collection scheme that uses a time period to decide how often
    /// to collect data.
    /// </summary>
    public partial class TimeBasedCollectionScheme
    {
        private long? _periodMs;

        /// <summary>
        /// Gets and sets the property PeriodMs. 
        /// <para>
        /// The time period (in milliseconds) to decide how often to collect data. For example,
        /// if the time period is <c>60000</c>, the Edge Agent software collects data once every
        /// minute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10000, Max=86400000)]
        public long? PeriodMs
        {
            get { return this._periodMs; }
            set { this._periodMs = value; }
        }

        // Check to see if PeriodMs property is set
        internal bool IsSetPeriodMs()
        {
            return this._periodMs.HasValue; 
        }

    }
}