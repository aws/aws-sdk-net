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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The Transaction Fraud Insights (TFI) model training metric details.
    /// </summary>
    public partial class TFITrainingMetricsValue
    {
        private List<TFIMetricDataPoint> _metricDataPoints = AWSConfigs.InitializeCollections ? new List<TFIMetricDataPoint>() : null;
        private TFIModelPerformance _modelPerformance;

        /// <summary>
        /// Gets and sets the property MetricDataPoints. 
        /// <para>
        ///  The model's performance metrics data points. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TFIMetricDataPoint> MetricDataPoints
        {
            get { return this._metricDataPoints; }
            set { this._metricDataPoints = value; }
        }

        // Check to see if MetricDataPoints property is set
        internal bool IsSetMetricDataPoints()
        {
            return this._metricDataPoints != null && (this._metricDataPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelPerformance. 
        /// <para>
        ///  The model performance score. 
        /// </para>
        /// </summary>
        public TFIModelPerformance ModelPerformance
        {
            get { return this._modelPerformance; }
            set { this._modelPerformance = value; }
        }

        // Check to see if ModelPerformance property is set
        internal bool IsSetModelPerformance()
        {
            return this._modelPerformance != null;
        }

    }
}