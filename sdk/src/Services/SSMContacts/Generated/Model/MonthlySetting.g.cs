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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about on-call rotations that recur monthly.
    /// </summary>
    public partial class MonthlySetting
    {
        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month when monthly recurring on-call rotations begin.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 31)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Checks to see if the DayOfMonth property is set.
        /// </summary>
        internal bool IsSetDayOfMonth() => this.DayOfMonth.HasValue;

        /// <summary>
        /// Gets and sets the property HandOffTime. 
        /// <para>
        /// The time of day when a monthly recurring on-call shift rotation begins.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HandOffTime HandOffTime { get; set; }

        /// <summary>
        /// Checks to see if the HandOffTime property is set.
        /// </summary>
        internal bool IsSetHandOffTime() => this.HandOffTime != null;
    }
}
