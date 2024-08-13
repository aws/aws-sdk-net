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
    /// Provides detailed error metrics to evaluate the performance of a predictor. This
    /// object is part of the <a>Metrics</a> object.
    /// </summary>
    public partial class ErrorMetric
    {
        private string _forecastType;
        private double? _mape;
        private double? _mase;
        private double? _rmse;
        private double? _wape;

        /// <summary>
        /// Gets and sets the property ForecastType. 
        /// <para>
        ///  The Forecast type used to compute WAPE, MAPE, MASE, and RMSE. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=4)]
        public string ForecastType
        {
            get { return this._forecastType; }
            set { this._forecastType = value; }
        }

        // Check to see if ForecastType property is set
        internal bool IsSetForecastType()
        {
            return this._forecastType != null;
        }

        /// <summary>
        /// Gets and sets the property MAPE. 
        /// <para>
        /// The Mean Absolute Percentage Error (MAPE)
        /// </para>
        /// </summary>
        public double? MAPE
        {
            get { return this._mape; }
            set { this._mape = value; }
        }

        // Check to see if MAPE property is set
        internal bool IsSetMAPE()
        {
            return this._mape.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MASE. 
        /// <para>
        /// The Mean Absolute Scaled Error (MASE)
        /// </para>
        /// </summary>
        public double? MASE
        {
            get { return this._mase; }
            set { this._mase = value; }
        }

        // Check to see if MASE property is set
        internal bool IsSetMASE()
        {
            return this._mase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RMSE. 
        /// <para>
        ///  The root-mean-square error (RMSE). 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property WAPE. 
        /// <para>
        ///  The weighted absolute percentage error (WAPE). 
        /// </para>
        /// </summary>
        public double? WAPE
        {
            get { return this._wape; }
            set { this._wape = value; }
        }

        // Check to see if WAPE property is set
        internal bool IsSetWAPE()
        {
            return this._wape.HasValue; 
        }

    }
}