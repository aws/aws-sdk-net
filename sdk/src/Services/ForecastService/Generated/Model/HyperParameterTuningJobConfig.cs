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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Configuration information for a hyperparameter tuning job. This object is specified
    /// in the <a>CreatePredictor</a> request.
    /// 
    ///  
    /// <para>
    /// A hyperparameter is a parameter that governs the model training process and is set
    /// before training starts. This is as opposed to a model parameter that is determined
    /// during training. The values of the hyperparameters have an effect on the chosen model
    /// parameters.
    /// </para>
    ///  
    /// <para>
    /// A hyperparameter tuning job is the process of choosing the optimum set of hyperparameter
    /// values that optimize a specified metric. This is accomplished by running many training
    /// jobs over a range of hyperparameter values. The optimum set of values is dependent
    /// on the algorithm, the training data, and the given metric objective.
    /// </para>
    /// </summary>
    public partial class HyperParameterTuningJobConfig
    {
        private ParameterRanges _parameterRanges;

        /// <summary>
        /// Gets and sets the property ParameterRanges. 
        /// <para>
        /// Specifies the ranges of valid values for the hyperparameters.
        /// </para>
        /// </summary>
        public ParameterRanges ParameterRanges
        {
            get { return this._parameterRanges; }
            set { this._parameterRanges = value; }
        }

        // Check to see if ParameterRanges property is set
        internal bool IsSetParameterRanges()
        {
            return this._parameterRanges != null;
        }

    }
}