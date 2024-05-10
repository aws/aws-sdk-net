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
    /// The weighted loss value for a quantile. This object is part of the <a>Metrics</a>
    /// object.
    /// </summary>
    public partial class WeightedQuantileLoss
    {
        private double? _lossValue;
        private double? _quantile;

        /// <summary>
        /// Gets and sets the property LossValue. 
        /// <para>
        /// The difference between the predicted value and the actual value over the quantile,
        /// weighted (normalized) by dividing by the sum over all quantiles.
        /// </para>
        /// </summary>
        public double? LossValue
        {
            get { return this._lossValue; }
            set { this._lossValue = value; }
        }

        // Check to see if LossValue property is set
        internal bool IsSetLossValue()
        {
            return this._lossValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Quantile. 
        /// <para>
        /// The quantile. Quantiles divide a probability distribution into regions of equal probability.
        /// For example, if the distribution was divided into 5 regions of equal probability,
        /// the quantiles would be 0.2, 0.4, 0.6, and 0.8.
        /// </para>
        /// </summary>
        public double? Quantile
        {
            get { return this._quantile; }
            set { this._quantile = value; }
        }

        // Check to see if Quantile property is set
        internal bool IsSetQuantile()
        {
            return this._quantile.HasValue; 
        }

    }
}