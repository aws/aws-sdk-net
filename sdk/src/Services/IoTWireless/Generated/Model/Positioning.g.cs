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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The FPorts for the position information.
    /// </summary>
    public partial class Positioning
    {
        /// <summary>
        /// Gets and sets the property ClockSync.
        /// </summary>
        [AWSProperty(Min = 1, Max = 223)]
        public int? ClockSync { get; set; }

        /// <summary>
        /// Checks to see if the ClockSync property is set.
        /// </summary>
        internal bool IsSetClockSync() => this.ClockSync.HasValue;

        /// <summary>
        /// Gets and sets the property Gnss.
        /// </summary>
        [AWSProperty(Min = 1, Max = 223)]
        public int? Gnss { get; set; }

        /// <summary>
        /// Checks to see if the Gnss property is set.
        /// </summary>
        internal bool IsSetGnss() => this.Gnss.HasValue;

        /// <summary>
        /// Gets and sets the property Stream.
        /// </summary>
        [AWSProperty(Min = 1, Max = 223)]
        public int? Stream { get; set; }

        /// <summary>
        /// Checks to see if the Stream property is set.
        /// </summary>
        internal bool IsSetStream() => this.Stream.HasValue;
    }
}
