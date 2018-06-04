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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configures a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTuningJobConfig
    {
        private HyperParameterTuningJobObjective _hyperParameterTuningJobObjective;
        private ParameterRanges _parameterRanges;
        private ResourceLimits _resourceLimits;
        private HyperParameterTuningJobStrategyType _strategy;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobObjective. 
        /// <para>
        /// The object that specifies the objective metric for this tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobObjective HyperParameterTuningJobObjective
        {
            get { return this._hyperParameterTuningJobObjective; }
            set { this._hyperParameterTuningJobObjective = value; }
        }

        // Check to see if HyperParameterTuningJobObjective property is set
        internal bool IsSetHyperParameterTuningJobObjective()
        {
            return this._hyperParameterTuningJobObjective != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterRanges. 
        /// <para>
        /// The object that specifies the ranges of hyperparameters that this tuning job searches.
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

        /// <summary>
        /// Gets and sets the property ResourceLimits. 
        /// <para>
        /// The object that specifies the maximum number of training jobs and parallel training
        /// jobs for this tuning job.
        /// </para>
        /// </summary>
        public ResourceLimits ResourceLimits
        {
            get { return this._resourceLimits; }
            set { this._resourceLimits = value; }
        }

        // Check to see if ResourceLimits property is set
        internal bool IsSetResourceLimits()
        {
            return this._resourceLimits != null;
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// Specifies the search strategy for hyperparameters. Currently, the only valid value
        /// is <code>Bayesian</code>.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobStrategyType Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}