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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides detailed error metrics to evaluate the performance of a predictor. This
    /// object is part of the <a>Metrics</a> object.
    /// </summary>
    public partial class ErrorMetric
    {
        /// <summary>
        /// Gets and sets the property ForecastType. 
        /// <para>
        ///  The Forecast type used to compute WAPE, MAPE, MASE, and RMSE. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 4)]
        public string ForecastType { get; set; }

        /// <summary>
        /// Checks to see if the ForecastType property is set.
        /// </summary>
        internal bool IsSetForecastType() => this.ForecastType != null;

        /// <summary>
        /// Gets and sets the property MAPE. 
        /// <para>
        /// The Mean Absolute Percentage Error (MAPE)
        /// </para>
        /// </summary>
        public double? MAPE { get; set; }

        /// <summary>
        /// Checks to see if the MAPE property is set.
        /// </summary>
        internal bool IsSetMAPE() => this.MAPE.HasValue;

        /// <summary>
        /// Gets and sets the property MASE. 
        /// <para>
        /// The Mean Absolute Scaled Error (MASE)
        /// </para>
        /// </summary>
        public double? MASE { get; set; }

        /// <summary>
        /// Checks to see if the MASE property is set.
        /// </summary>
        internal bool IsSetMASE() => this.MASE.HasValue;

        /// <summary>
        /// Gets and sets the property RMSE. 
        /// <para>
        ///  The root-mean-square error (RMSE). 
        /// </para>
        /// </summary>
        public double? RMSE { get; set; }

        /// <summary>
        /// Checks to see if the RMSE property is set.
        /// </summary>
        internal bool IsSetRMSE() => this.RMSE.HasValue;

        /// <summary>
        /// Gets and sets the property WAPE. 
        /// <para>
        ///  The weighted absolute percentage error (WAPE). 
        /// </para>
        /// </summary>
        public double? WAPE { get; set; }

        /// <summary>
        /// Checks to see if the WAPE property is set.
        /// </summary>
        internal bool IsSetWAPE() => this.WAPE.HasValue;
    }
}
