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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a timestamp with optional nanosecond granularity.
    /// </summary>
    public partial class TimeInNanos
    {
        private int? _offsetInNanos;
        private long? _timeInSeconds;

        /// <summary>
        /// Gets and sets the property OffsetInNanos. 
        /// <para>
        /// The nanosecond offset from <c>timeInSeconds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=999999999)]
        public int? OffsetInNanos
        {
            get { return this._offsetInNanos; }
            set { this._offsetInNanos = value; }
        }

        // Check to see if OffsetInNanos property is set
        internal bool IsSetOffsetInNanos()
        {
            return this._offsetInNanos.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeInSeconds. 
        /// <para>
        /// The timestamp date, in seconds, in the Unix epoch format. Fractional nanosecond data
        /// is provided by <c>offsetInNanos</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=9223372036854774)]
        public long? TimeInSeconds
        {
            get { return this._timeInSeconds; }
            set { this._timeInSeconds = value; }
        }

        // Check to see if TimeInSeconds property is set
        internal bool IsSetTimeInSeconds()
        {
            return this._timeInSeconds.HasValue; 
        }

    }
}