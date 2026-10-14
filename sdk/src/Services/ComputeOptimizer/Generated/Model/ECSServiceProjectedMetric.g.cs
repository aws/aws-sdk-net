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
    /// Describes the projected metrics of an Amazon ECS service recommendation option. 
    /// 
    ///  
    /// <para>
    /// To determine the performance difference between your current Amazon ECS service and
    /// the recommended option, compare the metric data of your service against its projected
    /// metric data.
    /// </para>
    /// </summary>
    public partial class ECSServiceProjectedMetric
    {
        /// <summary>
        /// Gets and sets the property LowerBoundValues. 
        /// <para>
        ///  The lower bound values for the projected metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> LowerBoundValues { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the LowerBoundValues property is set.
        /// </summary>
        internal bool IsSetLowerBoundValues() => this.LowerBoundValues != null && (this.LowerBoundValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the projected metric. 
        /// </para>
        ///  
        /// <para>
        /// The following metrics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Cpu</c> — The percentage of allocated compute units that are currently in use
        /// on the service tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Memory</c> — The percentage of memory that's currently in use on the service tasks.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ECSServiceMetricName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Timestamps. 
        /// <para>
        ///  The timestamps of the projected metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> Timestamps { get; set; } = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Checks to see if the Timestamps property is set.
        /// </summary>
        internal bool IsSetTimestamps() => this.Timestamps != null && (this.Timestamps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpperBoundValues. 
        /// <para>
        ///  The upper bound values for the projected metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> UpperBoundValues { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the UpperBoundValues property is set.
        /// </summary>
        internal bool IsSetUpperBoundValues() => this.UpperBoundValues != null && (this.UpperBoundValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
