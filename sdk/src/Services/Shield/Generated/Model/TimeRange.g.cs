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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// The time range.
    /// </summary>
    public partial class TimeRange
    {
        /// <summary>
        /// Gets and sets the property FromInclusive. 
        /// <para>
        /// The start time, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? FromInclusive { get; set; }

        /// <summary>
        /// Checks to see if the FromInclusive property is set.
        /// </summary>
        internal bool IsSetFromInclusive() => this.FromInclusive.HasValue;

        /// <summary>
        /// Gets and sets the property ToExclusive. 
        /// <para>
        /// The end time, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? ToExclusive { get; set; }

        /// <summary>
        /// Checks to see if the ToExclusive property is set.
        /// </summary>
        internal bool IsSetToExclusive() => this.ToExclusive.HasValue;
    }
}
