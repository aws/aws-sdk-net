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

namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Custom AMI policies only]</b> Specifies an AMI deprecation rule for AMIs created
    /// by an AMI lifecycle policy.
    /// 
    ///  
    /// <para>
    /// For age-based schedules, you must specify <b>Interval</b> and <b>IntervalUnit</b>.
    /// For count-based schedules, you must specify <b>Count</b>.
    /// </para>
    /// </summary>
    public partial class DeprecateRule
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// If the schedule has a count-based retention rule, this parameter specifies the number
        /// of oldest AMIs to deprecate. The count must be less than or equal to the schedule's
        /// retention count, and it can't be greater than 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// If the schedule has an age-based retention rule, this parameter specifies the period
        /// after which to deprecate AMIs created by the schedule. The period must be less than
        /// or equal to the schedule's retention period, and it can't be greater than 10 years.
        /// This is equivalent to 120 months, 520 weeks, or 3650 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval.HasValue;

        /// <summary>
        /// Gets and sets the property IntervalUnit. 
        /// <para>
        /// The unit of time in which to measure the <b>Interval</b>.
        /// </para>
        /// </summary>
        public RetentionIntervalUnitValues IntervalUnit { get; set; }

        /// <summary>
        /// Checks to see if the IntervalUnit property is set.
        /// </summary>
        internal bool IsSetIntervalUnit() => this.IntervalUnit != null;
    }
}
