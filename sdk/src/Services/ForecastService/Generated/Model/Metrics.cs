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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides metrics that are used to evaluate the performance of a predictor. This object
    /// is part of the <a>WindowSummary</a> object.
    /// </summary>
    public partial class Metrics
    {
        private double? _averageWeightedQuantileLoss;
        private List<ErrorMetric> _errorMetrics = AWSConfigs.InitializeCollections ? new List<ErrorMetric>() : null;
        private double? _rmse;
        private List<WeightedQuantileLoss> _weightedQuantileLosses = AWSConfigs.InitializeCollections ? new List<WeightedQuantileLoss>() : null;

        /// <summary>
        /// Gets and sets the property AverageWeightedQuantileLoss. 
        /// <para>
        /// The average value of all weighted quantile losses.
        /// </para>
        /// </summary>
        public double? AverageWeightedQuantileLoss
        {
            get { return this._averageWeightedQuantileLoss; }
            set { this._averageWeightedQuantileLoss = value; }
        }

        // Check to see if AverageWeightedQuantileLoss property is set
        internal bool IsSetAverageWeightedQuantileLoss()
        {
            return this._averageWeightedQuantileLoss.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMetrics. 
        /// <para>
        ///  Provides detailed error metrics for each forecast type. Metrics include root-mean
        /// square-error (RMSE), mean absolute percentage error (MAPE), mean absolute scaled error
        /// (MASE), and weighted average percentage error (WAPE). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorMetric> ErrorMetrics
        {
            get { return this._errorMetrics; }
            set { this._errorMetrics = value; }
        }

        // Check to see if ErrorMetrics property is set
        internal bool IsSetErrorMetrics()
        {
            return this._errorMetrics != null && (this._errorMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RMSE. 
        /// <para>
        /// The root-mean-square error (RMSE).
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated, please refer to ErrorMetrics for both RMSE and WAPE")]
        public double? RMSE
        {
            get { return this._rmse; }
            set { this._rmse = value; }
        }

        // Check to see if RMSE property is set
        internal bool IsSetRMSE()
        {
            return this._rmse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeightedQuantileLosses. 
        /// <para>
        /// An array of weighted quantile losses. Quantiles divide a probability distribution
        /// into regions of equal probability. The distribution in this case is the loss function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WeightedQuantileLoss> WeightedQuantileLosses
        {
            get { return this._weightedQuantileLosses; }
            set { this._weightedQuantileLosses = value; }
        }

        // Check to see if WeightedQuantileLosses property is set
        internal bool IsSetWeightedQuantileLosses()
        {
            return this._weightedQuantileLosses != null && (this._weightedQuantileLosses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}