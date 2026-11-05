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

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// A range of dates and times that is used by the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EventFilter.html">EventFilter</a>
    /// and <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EntityFilter.html">EntityFilter</a>
    /// objects. If <c>from</c> is set and <c>to</c> is set: match items where the timestamp
    /// (<c>startTime</c>, <c>endTime</c>, or <c>lastUpdatedTime</c>) is between <c>from</c>
    /// and <c>to</c> inclusive. If <c>from</c> is set and <c>to</c> is not set: match items
    /// where the timestamp value is equal to or after <c>from</c>. If <c>from</c> is not
    /// set and <c>to</c> is set: match items where the timestamp value is equal to or before
    /// <c>to</c>.
    /// </summary>
    public partial class DateTimeRange
    {
        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The starting date and time of a time range.
        /// </para>
        /// </summary>
        public DateTime? From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From.HasValue;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The ending date and time of a time range.
        /// </para>
        /// </summary>
        public DateTime? To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To.HasValue;
    }
}
