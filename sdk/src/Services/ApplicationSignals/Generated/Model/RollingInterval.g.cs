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
    /// If the interval for this SLO is a rolling interval, this structure contains the interval
    /// specifications.
    /// </summary>
    public partial class RollingInterval
    {
        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Specifies the duration of each rolling interval. For example, if <c>Duration</c> is
        /// <c>7</c> and <c>DurationUnit</c> is <c>DAY</c>, each rolling interval is seven days.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property DurationUnit. 
        /// <para>
        /// Specifies the rolling interval unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DurationUnit DurationUnit { get; set; }

        /// <summary>
        /// Checks to see if the DurationUnit property is set.
        /// </summary>
        internal bool IsSetDurationUnit() => this.DurationUnit != null;
    }
}
