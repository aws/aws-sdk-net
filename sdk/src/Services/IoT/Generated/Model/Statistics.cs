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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private double? _average;
        private int? _count;
        private double? _maximum;
        private double? _minimum;
        private double? _stdDeviation;
        private double? _sum;
        private double? _sumOfSquares;
        private double? _variance;

        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The average of the aggregated field values.
        /// </para>
        /// </summary>
        public double? Average
        {
            get { return this._average; }
            set { this._average = value; }
        }

        // Check to see if Average property is set
        internal bool IsSetAverage()
        {
            return this._average.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The count of things that match the query string criteria and contain a valid aggregation
        /// field value.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum aggregated field value.
        /// </para>
        /// </summary>
        public double? Maximum
        {
            get { return this._maximum; }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum aggregated field value.
        /// </para>
        /// </summary>
        public double? Minimum
        {
            get { return this._minimum; }
            set { this._minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this._minimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StdDeviation. 
        /// <para>
        /// The standard deviation of the aggregated field values.
        /// </para>
        /// </summary>
        public double? StdDeviation
        {
            get { return this._stdDeviation; }
            set { this._stdDeviation = value; }
        }

        // Check to see if StdDeviation property is set
        internal bool IsSetStdDeviation()
        {
            return this._stdDeviation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the aggregated field values.
        /// </para>
        /// </summary>
        public double? Sum
        {
            get { return this._sum; }
            set { this._sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this._sum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SumOfSquares. 
        /// <para>
        /// The sum of the squares of the aggregated field values.
        /// </para>
        /// </summary>
        public double? SumOfSquares
        {
            get { return this._sumOfSquares; }
            set { this._sumOfSquares = value; }
        }

        // Check to see if SumOfSquares property is set
        internal bool IsSetSumOfSquares()
        {
            return this._sumOfSquares.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Variance. 
        /// <para>
        /// The variance of the aggregated field values.
        /// </para>
        /// </summary>
        public double? Variance
        {
            get { return this._variance; }
            set { this._variance = value; }
        }

        // Check to see if Variance property is set
        internal bool IsSetVariance()
        {
            return this._variance.HasValue; 
        }

    }
}