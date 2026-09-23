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
    /// The time period used to evaluate the SLO. It can be either a calendar interval or
    /// rolling interval.
    /// </summary>
    public partial class Interval
    {
        /// <summary>
        /// Gets and sets the property CalendarInterval. 
        /// <para>
        /// If the interval is a calendar interval, this structure contains the interval specifications.
        /// </para>
        /// </summary>
        public CalendarInterval CalendarInterval { get; set; }

        /// <summary>
        /// Checks to see if the CalendarInterval property is set.
        /// </summary>
        internal bool IsSetCalendarInterval() => this.CalendarInterval != null;

        /// <summary>
        /// Gets and sets the property RollingInterval. 
        /// <para>
        /// If the interval is a rolling interval, this structure contains the interval specifications.
        /// </para>
        /// </summary>
        public RollingInterval RollingInterval { get; set; }

        /// <summary>
        /// Checks to see if the RollingInterval property is set.
        /// </summary>
        internal bool IsSetRollingInterval() => this.RollingInterval != null;
    }
}
