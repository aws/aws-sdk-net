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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The job completion criteria.
    /// </summary>
    public partial class TuningJobCompletionCriteria
    {
        /// <summary>
        /// Gets and sets the property BestObjectiveNotImproving. 
        /// <para>
        /// A flag to stop your hyperparameter tuning job if model performance fails to improve
        /// as evaluated against an objective function.
        /// </para>
        /// </summary>
        public BestObjectiveNotImproving BestObjectiveNotImproving { get; set; }

        /// <summary>
        /// Checks to see if the BestObjectiveNotImproving property is set.
        /// </summary>
        internal bool IsSetBestObjectiveNotImproving() => this.BestObjectiveNotImproving != null;

        /// <summary>
        /// Gets and sets the property ConvergenceDetected. 
        /// <para>
        /// A flag to top your hyperparameter tuning job if automatic model tuning (AMT) has detected
        /// that your model has converged as evaluated against your objective function.
        /// </para>
        /// </summary>
        public ConvergenceDetected ConvergenceDetected { get; set; }

        /// <summary>
        /// Checks to see if the ConvergenceDetected property is set.
        /// </summary>
        internal bool IsSetConvergenceDetected() => this.ConvergenceDetected != null;

        /// <summary>
        /// Gets and sets the property TargetObjectiveMetricValue. 
        /// <para>
        /// The value of the objective metric.
        /// </para>
        /// </summary>
        public float? TargetObjectiveMetricValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetObjectiveMetricValue property is set.
        /// </summary>
        internal bool IsSetTargetObjectiveMetricValue() => this.TargetObjectiveMetricValue.HasValue;
    }
}
