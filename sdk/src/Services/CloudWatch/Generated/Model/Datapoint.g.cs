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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Encapsulates the statistical data that CloudWatch computes from metric data.
    /// </summary>
    public partial class Datapoint
    {
        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// The average of the metric values that correspond to the data point.
        /// </para>
        /// </summary>
        public double? Average { get; set; }

        /// <summary>
        /// Checks to see if the Average property is set.
        /// </summary>
        internal bool IsSetAverage() => this.Average.HasValue;

        /// <summary>
        /// Gets and sets the property ExtendedStatistics. 
        /// <para>
        /// The percentile statistic for the data point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> ExtendedStatistics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Checks to see if the ExtendedStatistics property is set.
        /// </summary>
        internal bool IsSetExtendedStatistics() => this.ExtendedStatistics != null && (this.ExtendedStatistics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum metric value for the data point.
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
        /// The minimum metric value for the data point.
        /// </para>
        /// </summary>
        public double? Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum.HasValue;

        /// <summary>
        /// Gets and sets the property SampleCount. 
        /// <para>
        /// The number of metric values that contributed to the aggregate value of this data point.
        /// </para>
        /// </summary>
        public double? SampleCount { get; set; }

        /// <summary>
        /// Checks to see if the SampleCount property is set.
        /// </summary>
        internal bool IsSetSampleCount() => this.SampleCount.HasValue;

        /// <summary>
        /// Gets and sets the property Sum. 
        /// <para>
        /// The sum of the metric values for the data point.
        /// </para>
        /// </summary>
        public double? Sum { get; set; }

        /// <summary>
        /// Checks to see if the Sum property is set.
        /// </summary>
        internal bool IsSetSum() => this.Sum.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time stamp used for the data point.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The standard unit for the data point.
        /// </para>
        /// </summary>
        public StandardUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
