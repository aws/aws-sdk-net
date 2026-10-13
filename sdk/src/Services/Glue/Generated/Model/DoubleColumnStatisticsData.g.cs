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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines column statistics supported for floating-point number data columns.
    /// </summary>
    public partial class DoubleColumnStatisticsData
    {
        /// <summary>
        /// Gets and sets the property MaximumValue. 
        /// <para>
        /// The highest value in the column.
        /// </para>
        /// </summary>
        public double? MaximumValue { get; set; }

        /// <summary>
        /// Checks to see if the MaximumValue property is set.
        /// </summary>
        internal bool IsSetMaximumValue() => this.MaximumValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumValue. 
        /// <para>
        /// The lowest value in the column.
        /// </para>
        /// </summary>
        public double? MinimumValue { get; set; }

        /// <summary>
        /// Checks to see if the MinimumValue property is set.
        /// </summary>
        internal bool IsSetMinimumValue() => this.MinimumValue.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfDistinctValues. 
        /// <para>
        /// The number of distinct values in a column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? NumberOfDistinctValues { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDistinctValues property is set.
        /// </summary>
        internal bool IsSetNumberOfDistinctValues() => this.NumberOfDistinctValues.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfNulls. 
        /// <para>
        /// The number of null values in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? NumberOfNulls { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNulls property is set.
        /// </summary>
        internal bool IsSetNumberOfNulls() => this.NumberOfNulls.HasValue;
    }
}
