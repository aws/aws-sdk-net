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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// A single recommended outreach window for one day, expressed in Coordinated Universal
    /// Time (UTC).
    /// </summary>
    public partial class BestOutreachWindow
    {
        /// <summary>
        /// Gets and sets the property Day. 
        /// <para>
        /// The day of the week that this outreach window applies to. Valid values are <c>MONDAY</c>,
        /// <c>TUESDAY</c>, <c>WEDNESDAY</c>, <c>THURSDAY</c>, <c>FRIDAY</c>, <c>SATURDAY</c>,
        /// and <c>SUNDAY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// Checks to see if the Day property is set.
        /// </summary>
        internal bool IsSetDay() => this.Day != null;

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// The exclusive end of the outreach window, in Coordinated Universal Time (UTC), in
        /// 24-hour <c>HH:mm</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string EndTimeUtc { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeUtc property is set.
        /// </summary>
        internal bool IsSetEndTimeUtc() => this.EndTimeUtc != null;

        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// The inclusive start of the outreach window, in Coordinated Universal Time (UTC), in
        /// 24-hour <c>HH:mm</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string StartTimeUtc { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeUtc property is set.
        /// </summary>
        internal bool IsSetStartTimeUtc() => this.StartTimeUtc != null;
    }
}
