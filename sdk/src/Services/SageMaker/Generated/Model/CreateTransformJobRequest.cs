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
    /// Container for the parameters to the CreateTransformJob operation.
    /// Starts a transform job. A transform job uses a trained model to get inferences on
    /// a dataset and saves these results to an Amazon S3 location that you specify.
    /// 
    ///  
    /// <para>
    /// To perform batch transformations, you create a transform job and use the data that
    /// you have readily available.
    /// </para>
    ///  
    /// <para>
    /// In the request body, you provide the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>TransformJobName</c> - Identifies the transform job. The name must be unique within
    /// an Amazon Web Services Region in an Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ModelName</c> - Identifies the model to use. <c>ModelName</c> must be the name
    /// of an existing Amazon SageMaker model in the same Amazon Web Services Region and Amazon
    /// Web Services account. For information on creating a model, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModel.html">CreateModel</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TransformInput</c> - Describes the dataset to be transformed and the Amazon S3
    /// location where it is stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TransformOutput</c> - Identifies the Amazon S3 location where you want Amazon
    /// SageMaker to save the results from the transform job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TransformResources</c> - Identifies the ML compute instances and AMI image versions
    /// for the transform job.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about how batch transformation works, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">Batch
    /// Transform</a>.
    /// </para>
    /// </summary>
    public partial class CreateTransformJobRequest : AmazonSageMakerRequest
    {
        private BatchStrategy _batchStrategy;
        private BatchDataCaptureConfig _dataCaptureConfig;
        private DataProcessing _dataProcessing;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ExperimentConfig _experimentConfig;
        private int? _maxConcurrentTransforms;
        private int? _maxPayloadInMB;
        private ModelClientConfig _modelClientConfig;
        private string _modelName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TransformInput _transformInput;
        private string _transformJobName;
        private TransformOutput _transformOutput;
        private TransformResources _transformResources;

        /// <summary>
        /// Gets and sets the property BatchStrategy. 
        /// <para>
        /// Specifies the number of records to include in a mini-batch for an HTTP inference request.
        /// A <i>record</i> <i/> is a single unit of input data that inference can be made on.
        /// For example, a single line in a CSV file is a record. 
        /// </para>
        ///  
        /// <para>
        /// To enable the batch strategy, you must set the <c>SplitType</c> property to <c>Line</c>,
        /// <c>RecordIO</c>, or <c>TFRecord</c>.
        /// </para>
        ///  
        /// <para>
        /// To use only one record when making an HTTP invocation request to a container, set
        /// <c>BatchStrategy</c> to <c>SingleRecord</c> and <c>SplitType</c> to <c>Line</c>.
        /// </para>
        ///  
        /// <para>
        /// To fit as many records in a mini-batch as can fit within the <c>MaxPayloadInMB</c>
        /// limit, set <c>BatchStrategy</c> to <c>MultiRecord</c> and <c>SplitType</c> to <c>Line</c>.
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
        /// <para>
        /// The data structure used to specify the data to be used for inference in a batch transform
        /// job and to associate the data that is relevant to the prediction results in the output.
        /// The input filter provided allows you to exclude input data that is not needed for
        /// inference in a batch transform job. The output filter provided allows you to include
        /// input data relevant to interpreting the predictions in the output from the job. For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform-data-processing.html">Associate
        /// Prediction Results with their Corresponding Input Records</a>.
        /// </para>
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
        /// The environment variables to set in the Docker container. Don't include any sensitive
        /// data in your environment variables. We support up to 16 key and values entries in
        /// the map.
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
        /// Gets and sets the property MaxConcurrentTransforms. 
        /// <para>
        /// The maximum number of parallel requests that can be sent to each instance in a transform
        /// job. If <c>MaxConcurrentTransforms</c> is set to <c>0</c> or left unset, Amazon SageMaker
        /// checks the optional execution-parameters to determine the settings for your chosen
        /// algorithm. If the execution-parameters endpoint is not enabled, the default value
        /// is <c>1</c>. For more information on execution-parameters, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-batch-code.html#your-algorithms-batch-code-how-containe-serves-requests">How
        /// Containers Serve Requests</a>. For built-in algorithms, you don't need to set a value
        /// for <c>MaxConcurrentTransforms</c>.
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
        /// The maximum allowed size of the payload, in MB. A <i>payload</i> is the data portion
        /// of a record (without metadata). The value in <c>MaxPayloadInMB</c> must be greater
        /// than, or equal to, the size of a single record. To estimate the size of a record in
        /// MB, divide the size of your dataset by the number of records. To ensure that the records
        /// fit within the maximum payload size, we recommend using a slightly larger value. The
        /// default value is <c>6</c> MB. 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>MaxPayloadInMB</c> cannot be greater than 100 MB. If you specify the
        /// <c>MaxConcurrentTransforms</c> parameter, the value of <c>(MaxConcurrentTransforms
        /// * MaxPayloadInMB)</c> also cannot exceed 100 MB.
        /// </para>
        ///  
        /// <para>
        /// For cases where the payload might be arbitrarily large and is transmitted using HTTP
        /// chunked encoding, set the value to <c>0</c>. This feature works only in supported
        /// algorithms. Currently, Amazon SageMaker built-in algorithms do not support HTTP chunked
        /// encoding.
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
        /// Configures the timeout and maximum number of retries for processing a transform job
        /// invocation.
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
        /// The name of the model that you want to use for the transform job. <c>ModelName</c>
        /// must be the name of an existing Amazon SageMaker model within an Amazon Web Services
        /// Region in an Amazon Web Services account.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>.
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
        /// Gets and sets the property TransformInput. 
        /// <para>
        /// Describes the input source and the way the transform job consumes it.
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
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the transform job. The name must be unique within an Amazon Web Services
        /// Region in an Amazon Web Services account. 
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
        /// Gets and sets the property TransformOutput. 
        /// <para>
        /// Describes the results of the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}