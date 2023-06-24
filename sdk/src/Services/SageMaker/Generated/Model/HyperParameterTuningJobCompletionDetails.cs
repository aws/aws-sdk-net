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
    /// A structure that contains runtime information about both current and completed hyperparameter
    /// tuning jobs.
    /// </summary>
    public partial class HyperParameterTuningJobCompletionDetails
    {
        private DateTime? _convergenceDetectedTime;
        private int? _numberOfTrainingJobsObjectiveNotImproving;

        /// <summary>
        /// Gets and sets the property ConvergenceDetectedTime. 
        /// <para>
        /// The time in timestamp format that AMT detected model convergence, as defined by a
        /// lack of significant improvement over time based on criteria developed over a wide
        /// range of diverse benchmarking tests.
        /// </para>
        /// </summary>
        public DateTime ConvergenceDetectedTime
        {
            get { return this._convergenceDetectedTime.GetValueOrDefault(); }
            set { this._convergenceDetectedTime = value; }
        }

        // Check to see if ConvergenceDetectedTime property is set
        internal bool IsSetConvergenceDetectedTime()
        {
            return this._convergenceDetectedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTrainingJobsObjectiveNotImproving. 
        /// <para>
        /// The number of training jobs launched by a tuning job that are not improving (1% or
        /// less) as measured by model performance evaluated against an objective function.
        /// </para>
        /// </summary>
        public int NumberOfTrainingJobsObjectiveNotImproving
        {
            get { return this._numberOfTrainingJobsObjectiveNotImproving.GetValueOrDefault(); }
            set { this._numberOfTrainingJobsObjectiveNotImproving = value; }
        }

        // Check to see if NumberOfTrainingJobsObjectiveNotImproving property is set
        internal bool IsSetNumberOfTrainingJobsObjectiveNotImproving()
        {
            return this._numberOfTrainingJobsObjectiveNotImproving.HasValue; 
        }

    }
}