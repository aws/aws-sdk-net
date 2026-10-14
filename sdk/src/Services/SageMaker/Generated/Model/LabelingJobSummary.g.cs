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
    /// Provides summary information about a labeling job.
    /// </summary>
    public partial class LabelingJobSummary
    {
        /// <summary>
        /// Gets and sets the property AnnotationConsolidationLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function used to consolidate the annotations
        /// from individual workers into a label for a data object. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-annotation-consolidation.html">Annotation
        /// Consolidation</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AnnotationConsolidationLambdaArn { get; set; }

        /// <summary>
        /// Checks to see if the AnnotationConsolidationLambdaArn property is set.
        /// </summary>
        internal bool IsSetAnnotationConsolidationLambdaArn() => this.AnnotationConsolidationLambdaArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the job was created (timestamp).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the <c>LabelingJobStatus</c> field is <c>Failed</c>, this field contains a description
        /// of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input configuration for the labeling job.
        /// </para>
        /// </summary>
        public LabelingJobInputConfig InputConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputConfig property is set.
        /// </summary>
        internal bool IsSetInputConfig() => this.InputConfig != null;

        /// <summary>
        /// Gets and sets the property LabelCounters. 
        /// <para>
        /// Counts showing the progress of the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LabelCounters LabelCounters { get; set; }

        /// <summary>
        /// Checks to see if the LabelCounters property is set.
        /// </summary>
        internal bool IsSetLabelCounters() => this.LabelCounters != null;

        /// <summary>
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the labeling job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LabelingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobArn property is set.
        /// </summary>
        internal bool IsSetLabelingJobArn() => this.LabelingJobArn != null;

        /// <summary>
        /// Gets and sets the property LabelingJobName. 
        /// <para>
        /// The name of the labeling job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string LabelingJobName { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobName property is set.
        /// </summary>
        internal bool IsSetLabelingJobName() => this.LabelingJobName != null;

        /// <summary>
        /// Gets and sets the property LabelingJobOutput. 
        /// <para>
        /// The location of the output produced by the labeling job.
        /// </para>
        /// </summary>
        public LabelingJobOutput LabelingJobOutput { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobOutput property is set.
        /// </summary>
        internal bool IsSetLabelingJobOutput() => this.LabelingJobOutput != null;

        /// <summary>
        /// Gets and sets the property LabelingJobStatus. 
        /// <para>
        /// The current status of the labeling job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LabelingJobStatus LabelingJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobStatus property is set.
        /// </summary>
        internal bool IsSetLabelingJobStatus() => this.LabelingJobStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the job was last modified (timestamp).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property PreHumanTaskLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Lambda function. The function is run before each
        /// data object is sent to a worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PreHumanTaskLambdaArn { get; set; }

        /// <summary>
        /// Checks to see if the PreHumanTaskLambdaArn property is set.
        /// </summary>
        internal bool IsSetPreHumanTaskLambdaArn() => this.PreHumanTaskLambdaArn != null;

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the work team assigned to the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string WorkteamArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkteamArn property is set.
        /// </summary>
        internal bool IsSetWorkteamArn() => this.WorkteamArn != null;
    }
}
