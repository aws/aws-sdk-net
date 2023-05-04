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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter that filters topics based on the value of a numeric field. The filter includes
    /// only topics whose numeric field value matches the specified value.
    /// </summary>
    public partial class TopicNumericEqualityFilter
    {
        private NamedFilterAggType _aggregation;
        private TopicSingularFilterConstant _constant;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// An aggregation function that specifies how to calculate the value of a numeric field
        /// for a topic. Valid values for this structure are <code>NO_AGGREGATION</code>, <code>SUM</code>,
        /// <code>AVERAGE</code>, <code>COUNT</code>, <code>DISTINCT_COUNT</code>, <code>MAX</code>,
        /// <code>MEDIAN</code>, <code>MIN</code>, <code>STDEV</code>, <code>STDEVP</code>, <code>VAR</code>,
        /// and <code>VARP</code>.
        /// </para>
        /// </summary>
        public NamedFilterAggType Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null;
        }

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant used in a numeric equality filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TopicSingularFilterConstant Constant
        {
            get { return this._constant; }
            set { this._constant = value; }
        }

        // Check to see if Constant property is set
        internal bool IsSetConstant()
        {
            return this._constant != null;
        }

    }
}