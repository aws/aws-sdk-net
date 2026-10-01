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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Additional specifications when the vehicle includes one or more trailers.
    /// </summary>
    public partial class IsolineTrailerOptions
    {
        /// <summary>
        /// Gets and sets the property AxleCount. 
        /// <para>
        /// The total number of axles across all trailers. Used for weight distribution calculations
        /// and road restrictions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public int? AxleCount { get; set; }

        /// <summary>
        /// Checks to see if the AxleCount property is set.
        /// </summary>
        internal bool IsSetAxleCount() => this.AxleCount.HasValue;

        /// <summary>
        /// Gets and sets the property TrailerCount. 
        /// <para>
        /// The number of trailers being pulled. Affects which roads can be used based on local
        /// regulations.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public int? TrailerCount { get; set; }

        /// <summary>
        /// Checks to see if the TrailerCount property is set.
        /// </summary>
        internal bool IsSetTrailerCount() => this.TrailerCount.HasValue;
    }
}
