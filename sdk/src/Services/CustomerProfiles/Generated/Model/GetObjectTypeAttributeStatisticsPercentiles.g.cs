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
    /// Contains percentile statistics for object type attributes.
    /// </summary>
    public partial class GetObjectTypeAttributeStatisticsPercentiles
    {
        /// <summary>
        /// Gets and sets the property P25. 
        /// <para>
        /// The 25th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? P25 { get; set; }

        /// <summary>
        /// Checks to see if the P25 property is set.
        /// </summary>
        internal bool IsSetP25() => this.P25.HasValue;

        /// <summary>
        /// Gets and sets the property P5. 
        /// <para>
        /// The 5th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? P5 { get; set; }

        /// <summary>
        /// Checks to see if the P5 property is set.
        /// </summary>
        internal bool IsSetP5() => this.P5.HasValue;

        /// <summary>
        /// Gets and sets the property P50. 
        /// <para>
        /// The 50th percentile (median) value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? P50 { get; set; }

        /// <summary>
        /// Checks to see if the P50 property is set.
        /// </summary>
        internal bool IsSetP50() => this.P50.HasValue;

        /// <summary>
        /// Gets and sets the property P75. 
        /// <para>
        /// The 75th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? P75 { get; set; }

        /// <summary>
        /// Checks to see if the P75 property is set.
        /// </summary>
        internal bool IsSetP75() => this.P75.HasValue;

        /// <summary>
        /// Gets and sets the property P95. 
        /// <para>
        /// The 95th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? P95 { get; set; }

        /// <summary>
        /// Checks to see if the P95 property is set.
        /// </summary>
        internal bool IsSetP95() => this.P95.HasValue;
    }
}
