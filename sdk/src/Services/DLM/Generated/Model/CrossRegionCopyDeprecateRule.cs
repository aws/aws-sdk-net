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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
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
namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Custom AMI policies only]</b> Specifies an AMI deprecation rule for cross-Region
    /// AMI copies created by an AMI policy.
    /// </summary>
    public partial class CrossRegionCopyDeprecateRule
    {
        private int? _interval;
        private RetentionIntervalUnitValues _intervalUnit;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The period after which to deprecate the cross-Region AMI copies. The period must be
        /// less than or equal to the cross-Region AMI copy retention period, and it can't be
        /// greater than 10 years. This is equivalent to 120 months, 520 weeks, or 3650 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Interval
        {
            get { return this._interval; }
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
        /// The unit of time in which to measure the <b>Interval</b>. For example, to deprecate
        /// a cross-Region AMI copy after 3 months, specify <c>Interval=3</c> and <c>IntervalUnit=MONTHS</c>.
        /// </para>
        /// </summary>
        public RetentionIntervalUnitValues IntervalUnit
        {
            get { return this._intervalUnit; }
            set { this._intervalUnit = value; }
        }

        // Check to see if IntervalUnit property is set
        internal bool IsSetIntervalUnit()
        {
            return this._intervalUnit != null;
        }

    }
}