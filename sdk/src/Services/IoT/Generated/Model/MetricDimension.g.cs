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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The dimension of a metric.
    /// </summary>
    public partial class MetricDimension
    {
        /// <summary>
        /// Gets and sets the property DimensionName. 
        /// <para>
        /// A unique identifier for the dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DimensionName { get; set; }

        /// <summary>
        /// Checks to see if the DimensionName property is set.
        /// </summary>
        internal bool IsSetDimensionName() => this.DimensionName != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Defines how the <c>dimensionValues</c> of a dimension are interpreted. For example,
        /// for dimension type TOPIC_FILTER, the <c>IN</c> operator, a message will be counted
        /// only if its topic matches one of the topic filters. With <c>NOT_IN</c> operator, a
        /// message will be counted only if it doesn't match any of the topic filters. The operator
        /// is optional: if it's not provided (is <c>null</c>), it will be interpreted as <c>IN</c>.
        /// </para>
        /// </summary>
        public DimensionValueOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;
    }
}
