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
    /// A map of key-value pairs for all supported statistics. For issues with missing or
    /// unexpected values for this API, consult <a href="https://docs.aws.amazon.com/iot/latest/developerguide/fleet-indexing-troubleshooting.html">
    /// Fleet indexing troubleshooting guide</a>.
    /// </summary>
    public partial class Statistics
    {
        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The average of the aggregated field values.
        /// </para>
        /// </summary>
        public double? Average { get; set; }

        /// <summary>
        /// Checks to see if the Average property is set.
        /// </summary>
        internal bool IsSetAverage() => this.Average.HasValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The count of things that match the query string criteria and contain a valid aggregation
        /// field value.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum aggregated field value.
        /// </para>
        /// </summary>
        public double? Maximum { get; set; }

        /// <summary>
        /// Checks to see if the Maximum property is set.
        /// </summary>
        internal bool IsSetMaximum() => this.Maximum.HasValue;

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum aggregated field value.
        /// </para>
        /// </summary>
        public double? Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum.HasValue;

        /// <summary>
        /// Gets and sets the property StdDeviation. 
        /// <para>
        /// The standard deviation of the aggregated field values.
        /// </para>
        /// </summary>
        public double? StdDeviation { get; set; }

        /// <summary>
        /// Checks to see if the StdDeviation property is set.
        /// </summary>
        internal bool IsSetStdDeviation() => this.StdDeviation.HasValue;

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the aggregated field values.
        /// </para>
        /// </summary>
        public double? Sum { get; set; }

        /// <summary>
        /// Checks to see if the Sum property is set.
        /// </summary>
        internal bool IsSetSum() => this.Sum.HasValue;

        /// <summary>
        /// Gets and sets the property SumOfSquares. 
        /// <para>
        /// The sum of the squares of the aggregated field values.
        /// </para>
        /// </summary>
        public double? SumOfSquares { get; set; }

        /// <summary>
        /// Checks to see if the SumOfSquares property is set.
        /// </summary>
        internal bool IsSetSumOfSquares() => this.SumOfSquares.HasValue;

        /// <summary>
        /// Gets and sets the property Variance. 
        /// <para>
        /// The variance of the aggregated field values.
        /// </para>
        /// </summary>
        public double? Variance { get; set; }

        /// <summary>
        /// Checks to see if the Variance property is set.
        /// </summary>
        internal bool IsSetVariance() => this.Variance.HasValue;
    }
}
