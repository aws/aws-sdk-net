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
    /// Specifies the maximum number of training jobs and parallel training jobs that a hyperparameter
    /// tuning job can launch.
    /// </summary>
    public partial class ResourceLimits
    {
        /// <summary>
        /// Gets and sets the property MaxNumberOfTrainingJobs. 
        /// <para>
        /// The maximum number of training jobs that a hyperparameter tuning job can launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxNumberOfTrainingJobs { get; set; }

        /// <summary>
        /// Checks to see if the MaxNumberOfTrainingJobs property is set.
        /// </summary>
        internal bool IsSetMaxNumberOfTrainingJobs() => this.MaxNumberOfTrainingJobs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxParallelTrainingJobs. 
        /// <para>
        /// The maximum number of concurrent training jobs that a hyperparameter tuning job can
        /// launch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? MaxParallelTrainingJobs { get; set; }

        /// <summary>
        /// Checks to see if the MaxParallelTrainingJobs property is set.
        /// </summary>
        internal bool IsSetMaxParallelTrainingJobs() => this.MaxParallelTrainingJobs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRuntimeInSeconds. 
        /// <para>
        /// The maximum time in seconds that a hyperparameter tuning job can run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 120, Max = 15768000)]
        public int? MaxRuntimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxRuntimeInSeconds property is set.
        /// </summary>
        internal bool IsSetMaxRuntimeInSeconds() => this.MaxRuntimeInSeconds.HasValue;
    }
}
