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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The job completion criteria.
    /// </summary>
    public partial class TuningJobCompletionCriteria
    {
        private BestObjectiveNotImproving _bestObjectiveNotImproving;
        private ConvergenceDetected _convergenceDetected;
        private float? _targetObjectiveMetricValue;

        /// <summary>
        /// Gets and sets the property BestObjectiveNotImproving. 
        /// <para>
        /// A flag to stop your hyperparameter tuning job if model performance fails to improve
        /// as evaluated against an objective function.
        /// </para>
        /// </summary>
        public BestObjectiveNotImproving BestObjectiveNotImproving
        {
            get { return this._bestObjectiveNotImproving; }
            set { this._bestObjectiveNotImproving = value; }
        }

        // Check to see if BestObjectiveNotImproving property is set
        internal bool IsSetBestObjectiveNotImproving()
        {
            return this._bestObjectiveNotImproving != null;
        }

        /// <summary>
        /// Gets and sets the property ConvergenceDetected. 
        /// <para>
        /// A flag to top your hyperparameter tuning job if automatic model tuning (AMT) has detected
        /// that your model has converged as evaluated against your objective function.
        /// </para>
        /// </summary>
        public ConvergenceDetected ConvergenceDetected
        {
            get { return this._convergenceDetected; }
            set { this._convergenceDetected = value; }
        }

        // Check to see if ConvergenceDetected property is set
        internal bool IsSetConvergenceDetected()
        {
            return this._convergenceDetected != null;
        }

        /// <summary>
        /// Gets and sets the property TargetObjectiveMetricValue. 
        /// <para>
        /// The value of the objective metric.
        /// </para>
        /// </summary>
        public float TargetObjectiveMetricValue
        {
            get { return this._targetObjectiveMetricValue.GetValueOrDefault(); }
            set { this._targetObjectiveMetricValue = value; }
        }

        // Check to see if TargetObjectiveMetricValue property is set
        internal bool IsSetTargetObjectiveMetricValue()
        {
            return this._targetObjectiveMetricValue.HasValue; 
        }

    }
}