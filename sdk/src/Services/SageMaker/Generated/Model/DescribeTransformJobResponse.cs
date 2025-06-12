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
    /// This is the response object from the DescribeTransformJob operation.
    /// </summary>
    public partial class DescribeTransformJobResponse : AmazonWebServiceResponse
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
        /// The Amazon Resource Name (ARN) of the AutoML transform job.
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
        /// A <i>record</i> <i/> is a single unit of input data that inference can be made on.
        /// For example, a single line in a CSV file is a record. 
        /// </para>
        ///  
        /// <para>
        /// To enable the batch strategy, you must set <c>SplitType</c> to <c>Line</c>, <c>RecordIO</c>,
        /// or <c>TFRecord</c>.
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
        [AWSProperty(Required=true)]
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
        /// <para>
        /// Configuration to control how SageMaker captures inference data.
        /// </para>
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
        /// If the transform job failed, <c>FailureReason</c> describes why it failed. A transform
        /// job creates a log file, which includes error messages, and stores it as an Amazon
        /// S3 object. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/logging-cloudwatch.html">Log
        /// Amazon SageMaker Events with Amazon CloudWatch</a>.
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
        /// The Amazon Resource Name (ARN) of the Amazon SageMaker Ground Truth labeling job that
        /// created the transform or training job.
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
        /// The maximum number of parallel requests on each instance node that can be launched
        /// in a transform job. The default value is 1.
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
        /// The maximum payload size, in MB, used in the transform job.
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
        /// <para>
        /// The timeout and maximum number of retries for processing a transform job invocation.
        /// </para>
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
        /// The name of the model used in the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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
        /// <para>
        /// Describes the dataset to be transformed and the Amazon S3 location where it is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// The status of the transform job. If the transform job failed, the reason is returned
        /// in the <c>FailureReason</c> field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// <para>
        /// Identifies the Amazon S3 location where you want Amazon SageMaker to save the results
        /// from the transform job.
        /// </para>
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
        /// <para>
        /// Describes the resources, including ML instance types and ML instance count, to use
        /// for the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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