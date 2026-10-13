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
    /// A batch transform job. For information about SageMaker batch transform, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">Use
    /// Batch Transform</a>.
    /// </summary>
    public partial class TransformJob
    {
        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AutoML job that created the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AutoMLJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobArn property is set.
        /// </summary>
        internal bool IsSetAutoMLJobArn() => this.AutoMLJobArn != null;

        /// <summary>
        /// Gets and sets the property BatchStrategy. 
        /// <para>
        /// Specifies the number of records to include in a mini-batch for an HTTP inference request.
        /// A record is a single unit of input data that inference can be made on. For example,
        /// a single line in a CSV file is a record.
        /// </para>
        /// </summary>
        public BatchStrategy BatchStrategy { get; set; }

        /// <summary>
        /// Checks to see if the BatchStrategy property is set.
        /// </summary>
        internal bool IsSetBatchStrategy() => this.BatchStrategy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the transform Job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataCaptureConfig.
        /// </summary>
        public BatchDataCaptureConfig DataCaptureConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataCaptureConfig property is set.
        /// </summary>
        internal bool IsSetDataCaptureConfig() => this.DataCaptureConfig != null;

        /// <summary>
        /// Gets and sets the property DataProcessing.
        /// </summary>
        public DataProcessing DataProcessing { get; set; }

        /// <summary>
        /// Checks to see if the DataProcessing property is set.
        /// </summary>
        internal bool IsSetDataProcessing() => this.DataProcessing != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container. We support up to 16 key
        /// and values entries in the map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExperimentConfig.
        /// </summary>
        public ExperimentConfig ExperimentConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentConfig property is set.
        /// </summary>
        internal bool IsSetExperimentConfig() => this.ExperimentConfig != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the transform job failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the labeling job that created the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string LabelingJobArn { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobArn property is set.
        /// </summary>
        internal bool IsSetLabelingJobArn() => this.LabelingJobArn != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrentTransforms. 
        /// <para>
        /// The maximum number of parallel requests that can be sent to each instance in a transform
        /// job. If <c>MaxConcurrentTransforms</c> is set to 0 or left unset, SageMaker checks
        /// the optional execution-parameters to determine the settings for your chosen algorithm.
        /// If the execution-parameters endpoint is not enabled, the default value is 1. For built-in
        /// algorithms, you don't need to set a value for <c>MaxConcurrentTransforms</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxConcurrentTransforms { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrentTransforms property is set.
        /// </summary>
        internal bool IsSetMaxConcurrentTransforms() => this.MaxConcurrentTransforms.HasValue;

        /// <summary>
        /// Gets and sets the property MaxPayloadInMB. 
        /// <para>
        /// The maximum allowed size of the payload, in MB. A payload is the data portion of a
        /// record (without metadata). The value in <c>MaxPayloadInMB</c> must be greater than,
        /// or equal to, the size of a single record. To estimate the size of a record in MB,
        /// divide the size of your dataset by the number of records. To ensure that the records
        /// fit within the maximum payload size, we recommend using a slightly larger value. The
        /// default value is 6 MB. For cases where the payload might be arbitrarily large and
        /// is transmitted using HTTP chunked encoding, set the value to 0. This feature works
        /// only in supported algorithms. Currently, SageMaker built-in algorithms do not support
        /// HTTP chunked encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxPayloadInMB { get; set; }

        /// <summary>
        /// Checks to see if the MaxPayloadInMB property is set.
        /// </summary>
        internal bool IsSetMaxPayloadInMB() => this.MaxPayloadInMB.HasValue;

        /// <summary>
        /// Gets and sets the property ModelClientConfig.
        /// </summary>
        public ModelClientConfig ModelClientConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelClientConfig property is set.
        /// </summary>
        internal bool IsSetModelClientConfig() => this.ModelClientConfig != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model associated with the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the transform job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransformEndTime. 
        /// <para>
        /// Indicates when the transform job has been completed, or has stopped or failed. You
        /// are billed for the time interval between this time and the value of <c>TransformStartTime</c>.
        /// </para>
        /// </summary>
        public DateTime? TransformEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TransformEndTime property is set.
        /// </summary>
        internal bool IsSetTransformEndTime() => this.TransformEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TransformInput.
        /// </summary>
        public TransformInput TransformInput { get; set; }

        /// <summary>
        /// Checks to see if the TransformInput property is set.
        /// </summary>
        internal bool IsSetTransformInput() => this.TransformInput != null;

        /// <summary>
        /// Gets and sets the property TransformJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TransformJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TransformJobArn property is set.
        /// </summary>
        internal bool IsSetTransformJobArn() => this.TransformJobArn != null;

        /// <summary>
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string TransformJobName { get; set; }

        /// <summary>
        /// Checks to see if the TransformJobName property is set.
        /// </summary>
        internal bool IsSetTransformJobName() => this.TransformJobName != null;

        /// <summary>
        /// Gets and sets the property TransformJobStatus. 
        /// <para>
        /// The status of the transform job.
        /// </para>
        ///  
        /// <para>
        /// Transform job statuses are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InProgress</c> - The job is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Completed</c> - The job has completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The transform job has failed. To see the reason for the failure,
        /// see the <c>FailureReason</c> field in the response to a <c>DescribeTransformJob</c>
        /// call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopping</c> - The transform job is stopping.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopped</c> - The transform job has stopped.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TransformJobStatus TransformJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the TransformJobStatus property is set.
        /// </summary>
        internal bool IsSetTransformJobStatus() => this.TransformJobStatus != null;

        /// <summary>
        /// Gets and sets the property TransformOutput.
        /// </summary>
        public TransformOutput TransformOutput { get; set; }

        /// <summary>
        /// Checks to see if the TransformOutput property is set.
        /// </summary>
        internal bool IsSetTransformOutput() => this.TransformOutput != null;

        /// <summary>
        /// Gets and sets the property TransformResources.
        /// </summary>
        public TransformResources TransformResources { get; set; }

        /// <summary>
        /// Checks to see if the TransformResources property is set.
        /// </summary>
        internal bool IsSetTransformResources() => this.TransformResources != null;

        /// <summary>
        /// Gets and sets the property TransformStartTime. 
        /// <para>
        /// Indicates when the transform job starts on ML instances. You are billed for the time
        /// interval between this time and the value of <c>TransformEndTime</c>.
        /// </para>
        /// </summary>
        public DateTime? TransformStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TransformStartTime property is set.
        /// </summary>
        internal bool IsSetTransformStartTime() => this.TransformStartTime.HasValue;
    }
}
