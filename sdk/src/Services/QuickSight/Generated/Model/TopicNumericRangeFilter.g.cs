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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter that filters topics based on the value of a numeric field. The filter includes
    /// only topics whose numeric field value falls within the specified range.
    /// </summary>
    public partial class TopicNumericRangeFilter
    {
        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// An aggregation function that specifies how to calculate the value of a numeric field
        /// for a topic, Valid values for this structure are <c>NO_AGGREGATION</c>, <c>SUM</c>,
        /// <c>AVERAGE</c>, <c>COUNT</c>, <c>DISTINCT_COUNT</c>, <c>MAX</c>, <c>MEDIAN</c>, <c>MIN</c>,
        /// <c>STDEV</c>, <c>STDEVP</c>, <c>VAR</c>, and <c>VARP</c>.
        /// </para>
        /// </summary>
        public NamedFilterAggType Aggregation { get; set; }

        /// <summary>
        /// Checks to see if the Aggregation property is set.
        /// </summary>
        internal bool IsSetAggregation() => this.Aggregation != null;

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant used in a numeric range filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public TopicRangeFilterConstant Constant { get; set; }

        /// <summary>
        /// Checks to see if the Constant property is set.
        /// </summary>
        internal bool IsSetConstant() => this.Constant != null;

        /// <summary>
        /// Gets and sets the property Inclusive. 
        /// <para>
        /// A Boolean value that indicates whether the endpoints of the numeric range are included
        /// in the filter. If set to true, topics whose numeric field value is equal to the endpoint
        /// values will be included in the filter. If set to false, topics whose numeric field
        /// value is equal to the endpoint values will be excluded from the filter.
        /// </para>
        /// </summary>
        public bool? Inclusive { get; set; }

        /// <summary>
        /// Checks to see if the Inclusive property is set.
        /// </summary>
        internal bool IsSetInclusive() => this.Inclusive.HasValue;

        /// <summary>
        /// Gets and sets the property Inverse. 
        /// <para>
        /// A Boolean value that indicates if the filter is inverse.
        /// </para>
        /// </summary>
        public bool? Inverse { get; set; }

        /// <summary>
        /// Checks to see if the Inverse property is set.
        /// </summary>
        internal bool IsSetInverse() => this.Inverse.HasValue;

        /// <summary>
        /// Gets and sets the property NullFilter. 
        /// <para>
        /// The <c>null</c> filter that is applied to the numeric range filter.
        /// </para>
        /// </summary>
        public NullFilterType NullFilter { get; set; }

        /// <summary>
        /// Checks to see if the NullFilter property is set.
        /// </summary>
        internal bool IsSetNullFilter() => this.NullFilter != null;
    }
}
