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
    /// A batch transform job. For information about SageMaker batch transform, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">Use
    /// Batch Transform</a>.
    /// </summary>
    public partial class TransformJob
    {
        private string _autoMLJobArn;
        private BatchStrategy _batchStrategy;
        private DateTime? _creationTime;
        private BatchDataCaptureConfig _dataCaptureConfig;
        private DataProcessing _dataProcessing;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ExperimentConfig _experimentConfig;
        private string _failureReason;
        private string _labelingJobArn;
        private int? _maxConcurrentTransforms;
        private int? _maxPayloadInMB;
        private ModelClientConfig _modelClientConfig;
        private string _modelName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _transformEndTime;
        private TransformInput _transformInput;
        private string _transformJobArn;
        private string _transformJobName;
        private TransformJobStatus _transformJobStatus;
        private TransformOutput _transformOutput;
        private TransformResources _transformResources;
        private DateTime? _transformStartTime;

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AutoML job that created the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AutoMLJobArn
        {
            get { return this._autoMLJobArn; }
            set { this._autoMLJobArn = value; }
        }

        // Check to see if AutoMLJobArn property is set
        internal bool IsSetAutoMLJobArn()
        {
            return this._autoMLJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property BatchStrategy. 
        /// <para>
        /// Specifies the number of records to include in a mini-batch for an HTTP inference request.
        /// A record is a single unit of input data that inference can be made on. For example,
        /// a single line in a CSV file is a record.
        /// </para>
        /// </summary>
        public BatchStrategy BatchStrategy
        {
            get { return this._batchStrategy; }
            set { this._batchStrategy = value; }
        }

        // Check to see if BatchStrategy property is set
        internal bool IsSetBatchStrategy()
        {
            return this._batchStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the transform Job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataCaptureConfig.
        /// </summary>
        public BatchDataCaptureConfig DataCaptureConfig
        {
            get { return this._dataCaptureConfig; }
            set { this._dataCaptureConfig = value; }
        }

        // Check to see if DataCaptureConfig property is set
        internal bool IsSetDataCaptureConfig()
        {
            return this._dataCaptureConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DataProcessing.
        /// </summary>
        public DataProcessing DataProcessing
        {
            get { return this._dataProcessing; }
            set { this._dataProcessing = value; }
        }

        // Check to see if DataProcessing property is set
        internal bool IsSetDataProcessing()
        {
            return this._dataProcessing != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container. We support up to 16 key
        /// and values entries in the map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExperimentConfig.
        /// </summary>
        public ExperimentConfig ExperimentConfig
        {
            get { return this._experimentConfig; }
            set { this._experimentConfig = value; }
        }

        // Check to see if ExperimentConfig property is set
        internal bool IsSetExperimentConfig()
        {
            return this._experimentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the transform job failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the labeling job that created the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string LabelingJobArn
        {
            get { return this._labelingJobArn; }
            set { this._labelingJobArn = value; }
        }

        // Check to see if LabelingJobArn property is set
        internal bool IsSetLabelingJobArn()
        {
            return this._labelingJobArn != null;
        }

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
        [AWSProperty(Min=0)]
        public int? MaxConcurrentTransforms
        {
            get { return this._maxConcurrentTransforms; }
            set { this._maxConcurrentTransforms = value; }
        }

        // Check to see if MaxConcurrentTransforms property is set
        internal bool IsSetMaxConcurrentTransforms()
        {
            return this._maxConcurrentTransforms.HasValue; 
        }

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
        [AWSProperty(Min=0)]
        public int? MaxPayloadInMB
        {
            get { return this._maxPayloadInMB; }
            set { this._maxPayloadInMB = value; }
        }

        // Check to see if MaxPayloadInMB property is set
        internal bool IsSetMaxPayloadInMB()
        {
            return this._maxPayloadInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelClientConfig.
        /// </summary>
        public ModelClientConfig ModelClientConfig
        {
            get { return this._modelClientConfig; }
            set { this._modelClientConfig = value; }
        }

        // Check to see if ModelClientConfig property is set
        internal bool IsSetModelClientConfig()
        {
            return this._modelClientConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model associated with the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the transform job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransformEndTime. 
        /// <para>
        /// Indicates when the transform job has been completed, or has stopped or failed. You
        /// are billed for the time interval between this time and the value of <c>TransformStartTime</c>.
        /// </para>
        /// </summary>
        public DateTime? TransformEndTime
        {
            get { return this._transformEndTime; }
            set { this._transformEndTime = value; }
        }

        // Check to see if TransformEndTime property is set
        internal bool IsSetTransformEndTime()
        {
            return this._transformEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransformInput.
        /// </summary>
        public TransformInput TransformInput
        {
            get { return this._transformInput; }
            set { this._transformInput = value; }
        }

        // Check to see if TransformInput property is set
        internal bool IsSetTransformInput()
        {
            return this._transformInput != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TransformJobArn
        {
            get { return this._transformJobArn; }
            set { this._transformJobArn = value; }
        }

        // Check to see if TransformJobArn property is set
        internal bool IsSetTransformJobArn()
        {
            return this._transformJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string TransformJobName
        {
            get { return this._transformJobName; }
            set { this._transformJobName = value; }
        }

        // Check to see if TransformJobName property is set
        internal bool IsSetTransformJobName()
        {
            return this._transformJobName != null;
        }

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
        public TransformJobStatus TransformJobStatus
        {
            get { return this._transformJobStatus; }
            set { this._transformJobStatus = value; }
        }

        // Check to see if TransformJobStatus property is set
        internal bool IsSetTransformJobStatus()
        {
            return this._transformJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TransformOutput.
        /// </summary>
        public TransformOutput TransformOutput
        {
            get { return this._transformOutput; }
            set { this._transformOutput = value; }
        }

        // Check to see if TransformOutput property is set
        internal bool IsSetTransformOutput()
        {
            return this._transformOutput != null;
        }

        /// <summary>
        /// Gets and sets the property TransformResources.
        /// </summary>
        public TransformResources TransformResources
        {
            get { return this._transformResources; }
            set { this._transformResources = value; }
        }

        // Check to see if TransformResources property is set
        internal bool IsSetTransformResources()
        {
            return this._transformResources != null;
        }

        /// <summary>
        /// Gets and sets the property TransformStartTime. 
        /// <para>
        /// Indicates when the transform job starts on ML instances. You are billed for the time
        /// interval between this time and the value of <c>TransformEndTime</c>.
        /// </para>
        /// </summary>
        public DateTime? TransformStartTime
        {
            get { return this._transformStartTime; }
            set { this._transformStartTime = value; }
        }

        // Check to see if TransformStartTime property is set
        internal bool IsSetTransformStartTime()
        {
            return this._transformStartTime.HasValue; 
        }

    }
}