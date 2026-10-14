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
    /// Provides summary information about a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTuningJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the tuning job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningEndTime. 
        /// <para>
        /// The date and time that the tuning job ended.
        /// </para>
        /// </summary>
        public DateTime? HyperParameterTuningEndTime { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningEndTime property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningEndTime() => this.HyperParameterTuningEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string HyperParameterTuningJobArn { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobArn property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobArn() => this.HyperParameterTuningJobArn != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobName. 
        /// <para>
        /// The name of the tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string HyperParameterTuningJobName { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobName property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobName() => this.HyperParameterTuningJobName != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobStatus. 
        /// <para>
        /// The status of the tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HyperParameterTuningJobStatus HyperParameterTuningJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobStatus property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobStatus() => this.HyperParameterTuningJobStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the tuning job was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectiveStatusCounters. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ObjectiveStatusCounters.html">ObjectiveStatusCounters</a>
        /// object that specifies the numbers of training jobs, categorized by objective metric
        /// status, that this tuning job launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectiveStatusCounters ObjectiveStatusCounters { get; set; }

        /// <summary>
        /// Checks to see if the ObjectiveStatusCounters property is set.
        /// </summary>
        internal bool IsSetObjectiveStatusCounters() => this.ObjectiveStatusCounters != null;

        /// <summary>
        /// Gets and sets the property ResourceLimits. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ResourceLimits.html">ResourceLimits</a>
        /// object that specifies the maximum number of training jobs and parallel training jobs
        /// allowed for this tuning job.
        /// </para>
        /// </summary>
        public ResourceLimits ResourceLimits { get; set; }

        /// <summary>
        /// Checks to see if the ResourceLimits property is set.
        /// </summary>
        internal bool IsSetResourceLimits() => this.ResourceLimits != null;

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// Specifies the search strategy hyperparameter tuning uses to choose which hyperparameters
        /// to evaluate at each iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HyperParameterTuningJobStrategyType Strategy { get; set; }

        /// <summary>
        /// Checks to see if the Strategy property is set.
        /// </summary>
        internal bool IsSetStrategy() => this.Strategy != null;

        /// <summary>
        /// Gets and sets the property TrainingJobStatusCounters. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingJobStatusCounters.html">TrainingJobStatusCounters</a>
        /// object that specifies the numbers of training jobs, categorized by status, that this
        /// tuning job launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingJobStatusCounters TrainingJobStatusCounters { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobStatusCounters property is set.
        /// </summary>
        internal bool IsSetTrainingJobStatusCounters() => this.TrainingJobStatusCounters != null;
    }
}
