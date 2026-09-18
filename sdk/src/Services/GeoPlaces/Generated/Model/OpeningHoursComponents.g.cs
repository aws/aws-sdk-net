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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Components of the opening hours object.
    /// </summary>
    public partial class OpeningHoursComponents
    {
        /// <summary>
        /// Gets and sets the property OpenDuration. 
        /// <para>
        /// String which represents the duration of the opening period, such as <c>"PT12H00M"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string OpenDuration { get; set; }

        /// <summary>
        /// Checks to see if the OpenDuration property is set.
        /// </summary>
        internal bool IsSetOpenDuration() => this.OpenDuration != null;

        /// <summary>
        /// Gets and sets the property OpenTime. 
        /// <para>
        /// String which represents the opening hours, such as <c>"T070000"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 21)]
        public string OpenTime { get; set; }

        /// <summary>
        /// Checks to see if the OpenTime property is set.
        /// </summary>
        internal bool IsSetOpenTime() => this.OpenTime != null;

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// Days or periods when the provided opening hours are in affect. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>FREQ:DAILY;BYDAY:MO,TU,WE,TH,SU</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string Recurrence { get; set; }

        /// <summary>
        /// Checks to see if the Recurrence property is set.
        /// </summary>
        internal bool IsSetRecurrence() => this.Recurrence != null;
    }
}
