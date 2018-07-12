/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies when to create snapshots of EBS volumes.
    /// </summary>
    public partial class CreateRule
    {
        private int? _interval;
        private IntervalUnitValues _intervalUnit;
        private List<string> _times = new List<string>();

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval. The supported values are 12 and 24.
        /// </para>
        /// </summary>
        public int Interval
        {
            get { return this._interval.GetValueOrDefault(); }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalUnit. 
        /// <para>
        /// The interval unit.
        /// </para>
        /// </summary>
        public IntervalUnitValues IntervalUnit
        {
            get { return this._intervalUnit; }
            set { this._intervalUnit = value; }
        }

        // Check to see if IntervalUnit property is set
        internal bool IsSetIntervalUnit()
        {
            return this._intervalUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Times. 
        /// <para>
        /// The time, in UTC, to start the operation.
        /// </para>
        ///  
        /// <para>
        /// The operation occurs within a one-hour window following the specified time.
        /// </para>
        /// </summary>
        public List<string> Times
        {
            get { return this._times; }
            set { this._times = value; }
        }

        // Check to see if Times property is set
        internal bool IsSetTimes()
        {
            return this._times != null && this._times.Count > 0; 
        }

    }
}