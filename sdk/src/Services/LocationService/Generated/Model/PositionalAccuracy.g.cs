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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Defines the level of certainty of the position.
    /// </summary>
    public partial class PositionalAccuracy
    {
        /// <summary>
        /// Gets and sets the property Horizontal. 
        /// <para>
        /// Estimated maximum distance, in meters, between the measured position and the true
        /// position of a device, along the Earth's surface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 10000000)]
        public double? Horizontal { get; set; }

        /// <summary>
        /// Checks to see if the Horizontal property is set.
        /// </summary>
        internal bool IsSetHorizontal() => this.Horizontal.HasValue;
    }
}
