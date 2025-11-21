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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Defines a time range with inclusive start time and exclusive end time for filtering
    /// and analysis.
    /// </summary>
    public partial class TimePeriod
    {
        private DateTime? _endTimeExclusive;
        private DateTime? _startTimeInclusive;

        /// <summary>
        /// Gets and sets the property EndTimeExclusive. 
        /// <para>
        /// The end time of the period, exclusive. Events before this time are included.
        /// </para>
        /// </summary>
        public DateTime EndTimeExclusive
        {
            get { return this._endTimeExclusive.GetValueOrDefault(); }
            set { this._endTimeExclusive = value; }
        }

        // Check to see if EndTimeExclusive property is set
        internal bool IsSetEndTimeExclusive()
        {
            return this._endTimeExclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeInclusive. 
        /// <para>
        /// The start time of the period, inclusive. Events at or after this time are included.
        /// </para>
        /// </summary>
        public DateTime StartTimeInclusive
        {
            get { return this._startTimeInclusive.GetValueOrDefault(); }
            set { this._startTimeInclusive = value; }
        }

        // Check to see if StartTimeInclusive property is set
        internal bool IsSetStartTimeInclusive()
        {
            return this._startTimeInclusive.HasValue; 
        }

    }
}