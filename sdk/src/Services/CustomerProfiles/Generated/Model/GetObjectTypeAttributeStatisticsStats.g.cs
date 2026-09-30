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
    /// Statistical measurements for object type attributes including basic statistics and
    /// percentiles.
    /// </summary>
    public partial class GetObjectTypeAttributeStatisticsStats
    {
        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The arithmetic mean of the attribute values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Average { get; set; }

        /// <summary>
        /// Checks to see if the Average property is set.
        /// </summary>
        internal bool IsSetAverage() => this.Average.HasValue;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum value found in the attribute dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Maximum { get; set; }

        /// <summary>
        /// Checks to see if the Maximum property is set.
        /// </summary>
        internal bool IsSetMaximum() => this.Maximum.HasValue;

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum value found in the attribute dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum.HasValue;

        /// <summary>
        /// Gets and sets the property Percentiles. 
        /// <para>
        /// Percentile distribution statistics for the attribute values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GetObjectTypeAttributeStatisticsPercentiles Percentiles { get; set; }

        /// <summary>
        /// Checks to see if the Percentiles property is set.
        /// </summary>
        internal bool IsSetPercentiles() => this.Percentiles != null;

        /// <summary>
        /// Gets and sets the property StandardDeviation. 
        /// <para>
        /// The standard deviation of the attribute values, measuring their spread around the
        /// mean.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? StandardDeviation { get; set; }

        /// <summary>
        /// Checks to see if the StandardDeviation property is set.
        /// </summary>
        internal bool IsSetStandardDeviation() => this.StandardDeviation.HasValue;
    }
}
