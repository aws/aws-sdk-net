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
    /// A structure that represents a relative date filter.
    /// </summary>
    public partial class TopicRelativeDateFilter
    {
        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant used in a relative date filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public TopicSingularFilterConstant Constant { get; set; }

        /// <summary>
        /// Checks to see if the Constant property is set.
        /// </summary>
        internal bool IsSetConstant() => this.Constant != null;

        /// <summary>
        /// Gets and sets the property NullFilter. 
        /// <para>
        /// The <c>null</c> filter that is applied to the relative date filter.
        /// </para>
        /// </summary>
        public NullFilterType NullFilter { get; set; }

        /// <summary>
        /// Checks to see if the NullFilter property is set.
        /// </summary>
        internal bool IsSetNullFilter() => this.NullFilter != null;

        /// <summary>
        /// Gets and sets the property RelativeDateFilterFunction. 
        /// <para>
        /// The function to be used in a relative date filter to determine the range of dates
        /// to include in the results. Valid values for this structure are <c>BEFORE</c>, <c>AFTER</c>,
        /// and <c>BETWEEN</c>.
        /// </para>
        /// </summary>
        public TopicRelativeDateFilterFunction RelativeDateFilterFunction { get; set; }

        /// <summary>
        /// Checks to see if the RelativeDateFilterFunction property is set.
        /// </summary>
        internal bool IsSetRelativeDateFilterFunction() => this.RelativeDateFilterFunction != null;

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        public TopicTimeGranularity TimeGranularity { get; set; }

        /// <summary>
        /// Checks to see if the TimeGranularity property is set.
        /// </summary>
        internal bool IsSetTimeGranularity() => this.TimeGranularity != null;
    }
}
