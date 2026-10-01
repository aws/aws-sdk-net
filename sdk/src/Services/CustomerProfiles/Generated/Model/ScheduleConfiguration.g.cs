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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Configuration for scheduled segment membership event notifications.
    /// </summary>
    public partial class ScheduleConfiguration
    {
        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval between scheduled executions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 24)]
        public int? Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the interval. The following are valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>HOURLY</b>: The interval is measured in hours. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScheduleConfigurationUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
