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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the performance risk ratings for a given resource type.
    /// 
    ///  
    /// <para>
    /// Resources with a <c>high</c> or <c>medium</c> rating are at risk of not meeting the
    /// performance needs of their workloads, while resources with a <c>low</c> rating are
    /// performing well in their workloads.
    /// </para>
    /// </summary>
    public partial class CurrentPerformanceRiskRatings
    {
        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// A count of the applicable resource types with a high performance risk rating.
        /// </para>
        /// </summary>
        public long? High { get; set; }

        /// <summary>
        /// Checks to see if the High property is set.
        /// </summary>
        internal bool IsSetHigh() => this.High.HasValue;

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// A count of the applicable resource types with a low performance risk rating.
        /// </para>
        /// </summary>
        public long? Low { get; set; }

        /// <summary>
        /// Checks to see if the Low property is set.
        /// </summary>
        internal bool IsSetLow() => this.Low.HasValue;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// A count of the applicable resource types with a medium performance risk rating.
        /// </para>
        /// </summary>
        public long? Medium { get; set; }

        /// <summary>
        /// Checks to see if the Medium property is set.
        /// </summary>
        internal bool IsSetMedium() => this.Medium.HasValue;

        /// <summary>
        /// Gets and sets the property VeryLow. 
        /// <para>
        /// A count of the applicable resource types with a very low performance risk rating.
        /// </para>
        /// </summary>
        public long? VeryLow { get; set; }

        /// <summary>
        /// Checks to see if the VeryLow property is set.
        /// </summary>
        internal bool IsSetVeryLow() => this.VeryLow.HasValue;
    }
}
