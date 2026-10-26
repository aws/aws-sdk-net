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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// A time period bounded by an inclusive start date and an inclusive end date.
    /// </summary>
    public partial class Interval
    {
        /// <summary>
        /// Gets and sets the property EndDateInclusive. 
        /// <para>
        /// The end date of the interval. This date is included in the interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDateInclusive { get; set; }

        /// <summary>
        /// Checks to see if the EndDateInclusive property is set.
        /// </summary>
        internal bool IsSetEndDateInclusive() => this.EndDateInclusive.HasValue;

        /// <summary>
        /// Gets and sets the property StartDateInclusive. 
        /// <para>
        /// The start date of the interval. This date is included in the interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDateInclusive { get; set; }

        /// <summary>
        /// Checks to see if the StartDateInclusive property is set.
        /// </summary>
        internal bool IsSetStartDateInclusive() => this.StartDateInclusive.HasValue;
    }
}
