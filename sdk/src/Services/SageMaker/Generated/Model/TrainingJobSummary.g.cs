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
    /// Provides summary information about a training job.
    /// </summary>
    public partial class TrainingJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the training job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        ///  Timestamp when the training job was last modified. 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SecondaryStatus. 
        /// <para>
        /// The secondary status of the training job.
        /// </para>
        /// </summary>
        public SecondaryStatus SecondaryStatus { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryStatus property is set.
        /// </summary>
        internal bool IsSetSecondaryStatus() => this.SecondaryStatus != null;

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// A timestamp that shows when the training job ended. This field is set only if the
        /// training job has one of the terminal statuses (<c>Completed</c>, <c>Failed</c>, or
        /// <c>Stopped</c>). 
        /// </para>
        /// </summary>
        public DateTime? TrainingEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingEndTime property is set.
        /// </summary>
        internal bool IsSetTrainingEndTime() => this.TrainingEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TrainingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobArn property is set.
        /// </summary>
        internal bool IsSetTrainingJobArn() => this.TrainingJobArn != null;

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job that you want a summary for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobName property is set.
        /// </summary>
        internal bool IsSetTrainingJobName() => this.TrainingJobName != null;

        /// <summary>
        /// Gets and sets the property TrainingJobStatus. 
        /// <para>
        /// The status of the training job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingJobStatus TrainingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobStatus property is set.
        /// </summary>
        internal bool IsSetTrainingJobStatus() => this.TrainingJobStatus != null;

        /// <summary>
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN); of the training plan associated with this training
        /// job.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
        /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 2048)]
        public string TrainingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanArn property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArn() => this.TrainingPlanArn != null;

        /// <summary>
        /// Gets and sets the property WarmPoolStatus. 
        /// <para>
        /// The status of the warm pool associated with the training job.
        /// </para>
        /// </summary>
        public WarmPoolStatus WarmPoolStatus { get; set; }

        /// <summary>
        /// Checks to see if the WarmPoolStatus property is set.
        /// </summary>
        internal bool IsSetWarmPoolStatus() => this.WarmPoolStatus != null;
    }
}
