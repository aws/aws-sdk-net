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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// A time range used to specify when the behavior of an insight or anomaly started.
    /// </summary>
    public partial class StartTimeRange
    {
        /// <summary>
        /// Gets and sets the property FromTime. 
        /// <para>
        ///  The start time of the time range. 
        /// </para>
        /// </summary>
        public DateTime? FromTime { get; set; }

        /// <summary>
        /// Checks to see if the FromTime property is set.
        /// </summary>
        internal bool IsSetFromTime() => this.FromTime.HasValue;

        /// <summary>
        /// Gets and sets the property ToTime. 
        /// <para>
        ///  The end time of the time range. 
        /// </para>
        /// </summary>
        public DateTime? ToTime { get; set; }

        /// <summary>
        /// Checks to see if the ToTime property is set.
        /// </summary>
        internal bool IsSetToTime() => this.ToTime.HasValue;
    }
}
