/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Specifies the categorical, continuous, and integer hyperparameters, and their ranges
    /// of tunable values. The range of tunable values determines which values that a hyperparameter
    /// tuning job can choose for the specified hyperparameter. This object is part of the
    /// <a>HyperParameterTuningJobConfig</a> object.
    /// </summary>
    public partial class ParameterRanges
    {
        private List<CategoricalParameterRange> _categoricalParameterRanges = new List<CategoricalParameterRange>();
        private List<ContinuousParameterRange> _continuousParameterRanges = new List<ContinuousParameterRange>();
        private List<IntegerParameterRange> _integerParameterRanges = new List<IntegerParameterRange>();

        /// <summary>
        /// Gets and sets the property CategoricalParameterRanges. 
        /// <para>
        /// Specifies the tunable range for each categorical hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<CategoricalParameterRange> CategoricalParameterRanges
        {
            get { return this._categoricalParameterRanges; }
            set { this._categoricalParameterRanges = value; }
        }

        // Check to see if CategoricalParameterRanges property is set
        internal bool IsSetCategoricalParameterRanges()
        {
            return this._categoricalParameterRanges != null && this._categoricalParameterRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContinuousParameterRanges. 
        /// <para>
        /// Specifies the tunable range for each continuous hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<ContinuousParameterRange> ContinuousParameterRanges
        {
            get { return this._continuousParameterRanges; }
            set { this._continuousParameterRanges = value; }
        }

        // Check to see if ContinuousParameterRanges property is set
        internal bool IsSetContinuousParameterRanges()
        {
            return this._continuousParameterRanges != null && this._continuousParameterRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IntegerParameterRanges. 
        /// <para>
        /// Specifies the tunable range for each integer hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<IntegerParameterRange> IntegerParameterRanges
        {
            get { return this._integerParameterRanges; }
            set { this._integerParameterRanges = value; }
        }

        // Check to see if IntegerParameterRanges property is set
        internal bool IsSetIntegerParameterRanges()
        {
            return this._integerParameterRanges != null && this._integerParameterRanges.Count > 0; 
        }

    }
}