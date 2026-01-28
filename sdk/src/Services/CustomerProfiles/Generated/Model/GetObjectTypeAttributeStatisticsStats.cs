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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private double? _average;
        private double? _maximum;
        private double? _minimum;
        private GetObjectTypeAttributeStatisticsPercentiles _percentiles;
        private double? _standardDeviation;

        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The arithmetic mean of the attribute values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum value found in the attribute dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The minimum value found in the attribute dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Percentiles. 
        /// <para>
        /// Percentile distribution statistics for the attribute values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GetObjectTypeAttributeStatisticsPercentiles Percentiles
        {
            get { return this._percentiles; }
            set { this._percentiles = value; }
        }

        // Check to see if Percentiles property is set
        internal bool IsSetPercentiles()
        {
            return this._percentiles != null;
        }

        /// <summary>
        /// Gets and sets the property StandardDeviation. 
        /// <para>
        /// The standard deviation of the attribute values, measuring their spread around the
        /// mean.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? StandardDeviation
        {
            get { return this._standardDeviation; }
            set { this._standardDeviation = value; }
        }

        // Check to see if StandardDeviation property is set
        internal bool IsSetStandardDeviation()
        {
            return this._standardDeviation.HasValue; 
        }

    }
}