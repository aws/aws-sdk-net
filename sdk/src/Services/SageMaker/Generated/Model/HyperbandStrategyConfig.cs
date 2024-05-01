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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for <c>Hyperband</c>, a multi-fidelity based hyperparameter tuning
    /// strategy. <c>Hyperband</c> uses the final and intermediate results of a training job
    /// to dynamically allocate resources to utilized hyperparameter configurations while
    /// automatically stopping under-performing configurations. This parameter should be provided
    /// only if <c>Hyperband</c> is selected as the <c>StrategyConfig</c> under the <c>HyperParameterTuningJobConfig</c>
    /// API.
    /// </summary>
    public partial class HyperbandStrategyConfig
    {
        private int? _maxResource;
        private int? _minResource;

        /// <summary>
        /// Gets and sets the property MaxResource. 
        /// <para>
        /// The maximum number of resources (such as epochs) that can be used by a training job
        /// launched by a hyperparameter tuning job. Once a job reaches the <c>MaxResource</c>
        /// value, it is stopped. If a value for <c>MaxResource</c> is not provided, and <c>Hyperband</c>
        /// is selected as the hyperparameter tuning strategy, <c>HyperbandTraining</c> attempts
        /// to infer <c>MaxResource</c> from the following keys (if present) in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html#sagemaker-Type-HyperParameterTrainingJobDefinition-StaticHyperParameters">StaticsHyperParameters</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>epochs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>numepochs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>n-epochs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>n_epochs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>num_epochs</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>HyperbandStrategyConfig</c> is unable to infer a value for <c>MaxResource</c>,
        /// it generates a validation error. The maximum value is 20,000 epochs. All metrics that
        /// correspond to an objective metric are used to derive <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-early-stopping.html">early
        /// stopping decisions</a>. For <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/distributed-training.html">distributed</a>
        /// training jobs, ensure that duplicate metrics are not printed in the logs across the
        /// individual nodes in a training job. If multiple nodes are publishing duplicate or
        /// incorrect metrics, training jobs may make an incorrect stopping decision and stop
        /// the job prematurely. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxResource
        {
            get { return this._maxResource; }
            set { this._maxResource = value; }
        }

        // Check to see if MaxResource property is set
        internal bool IsSetMaxResource()
        {
            return this._maxResource.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinResource. 
        /// <para>
        /// The minimum number of resources (such as epochs) that can be used by a training job
        /// launched by a hyperparameter tuning job. If the value for <c>MinResource</c> has not
        /// been reached, the training job is not stopped by <c>Hyperband</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MinResource
        {
            get { return this._minResource; }
            set { this._minResource = value; }
        }

        // Check to see if MinResource property is set
        internal bool IsSetMinResource()
        {
            return this._minResource.HasValue; 
        }

    }
}