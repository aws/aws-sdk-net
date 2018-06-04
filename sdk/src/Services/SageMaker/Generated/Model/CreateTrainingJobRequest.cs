/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrainingJob operation.
    /// Starts a model training job. After training completes, Amazon SageMaker saves the
    /// resulting model artifacts to an Amazon S3 location that you specify. 
    /// 
    ///  
    /// <para>
    /// If you choose to host your model using Amazon SageMaker hosting services, you can
    /// use the resulting model artifacts as part of the model. You can also use the artifacts
    /// in a deep learning service other than Amazon SageMaker, provided that you know how
    /// to use them for inferences. 
    /// </para>
    ///  
    /// <para>
    /// In the request body, you provide the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AlgorithmSpecification</code> - Identifies the training algorithm to use. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HyperParameters</code> - Specify these algorithm-specific parameters to influence
    /// the quality of the final model. For a list of hyperparameters for each training algorithm
    /// provided by Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>InputDataConfig</code> - Describes the training dataset and the Amazon S3 location
    /// where it is stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>OutputDataConfig</code> - Identifies the Amazon S3 location where you want
    /// Amazon SageMaker to save the results of model training. 
    /// </para>
    ///   </li> <li> 
    /// <para>
    ///  <code>ResourceConfig</code> - Identifies the resources, ML compute instances, and
    /// ML storage volumes to deploy for model training. In distributed training, you specify
    /// more than one instance. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RoleARN</code> - The Amazon Resource Number (ARN) that Amazon SageMaker assumes
    /// to perform tasks on your behalf during model training. You must grant this role the
    /// necessary permissions so that Amazon SageMaker can successfully complete model training.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StoppingCondition</code> - Sets a duration for training. Use this parameter
    /// to cap model training costs. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information about Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
    /// It Works</a>. 
    /// </para>
    /// </summary>
    public partial class CreateTrainingJobRequest : AmazonSageMakerRequest
    {
        private AlgorithmSpecification _algorithmSpecification;
        private Dictionary<string, string> _hyperParameters = new Dictionary<string, string>();
        private List<Channel> _inputDataConfig = new List<Channel>();
        private OutputDataConfig _outputDataConfig;
        private ResourceConfig _resourceConfig;
        private string _roleArn;
        private StoppingCondition _stoppingCondition;
        private List<Tag> _tags = new List<Tag>();
        private string _trainingJobName;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// The registry path of the Docker image that contains the training algorithm and algorithm-specific
        /// metadata, including the input mode. For more information about algorithms provided
        /// by Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// For information about providing your own algorithms, see <a>your-algorithms</a>. 
        /// </para>
        /// </summary>
        public AlgorithmSpecification AlgorithmSpecification
        {
            get { return this._algorithmSpecification; }
            set { this._algorithmSpecification = value; }
        }

        // Check to see if AlgorithmSpecification property is set
        internal bool IsSetAlgorithmSpecification()
        {
            return this._algorithmSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters that influence the quality of the model. You set hyperparameters
        /// before you start the learning process. For a list of hyperparameters for each training
        /// algorithm provided by Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of 100 hyperparameters. Each hyperparameter is a key-value
        /// pair. Each key and value is limited to 256 characters, as specified by the <code>Length
        /// Constraint</code>. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> HyperParameters
        {
            get { return this._hyperParameters; }
            set { this._hyperParameters = value; }
        }

        // Check to see if HyperParameters property is set
        internal bool IsSetHyperParameters()
        {
            return this._hyperParameters != null && this._hyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of <code>Channel</code> objects. Each channel is a named input source. <code>InputDataConfig</code>
        /// describes the input data and its location. 
        /// </para>
        ///  
        /// <para>
        /// Algorithms can accept input data from one or more channels. For example, an algorithm
        /// might have two channels of input data, <code>training_data</code> and <code>validation_data</code>.
        /// The configuration for each channel provides the S3 location where the input data is
        /// stored. It also provides information about the stored data: the MIME type, compression
        /// method, and whether the data is wrapped in RecordIO format. 
        /// </para>
        ///  
        /// <para>
        /// Depending on the input mode that the algorithm supports, Amazon SageMaker either copies
        /// input data files from an S3 bucket to a local directory in the Docker container, or
        /// makes it available as input streams. 
        /// </para>
        /// </summary>
        public List<Channel> InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null && this._inputDataConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies the path to the S3 bucket where you want to store model artifacts. Amazon
        /// SageMaker creates subfolders for the artifacts. 
        /// </para>
        /// </summary>
        public OutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The resources, including the ML compute instances and ML storage volumes, to use for
        /// model training. 
        /// </para>
        ///  
        /// <para>
        /// ML storage volumes store model artifacts and incremental states. Training algorithms
        /// might also use ML storage volumes for scratch space. If you want Amazon SageMaker
        /// to use the ML storage volume to store the training data, choose <code>File</code>
        /// as the <code>TrainingInputMode</code> in the algorithm specification. For distributed
        /// training algorithms, specify an instance count greater than 1.
        /// </para>
        /// </summary>
        public ResourceConfig ResourceConfig
        {
            get { return this._resourceConfig; }
            set { this._resourceConfig = value; }
        }

        // Check to see if ResourceConfig property is set
        internal bool IsSetResourceConfig()
        {
            return this._resourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to
        /// perform tasks on your behalf. 
        /// </para>
        ///  
        /// <para>
        /// During model training, Amazon SageMaker needs your permission to read input data from
        /// an S3 bucket, download a Docker image that contains training code, write model artifacts
        /// to an S3 bucket, write logs to Amazon CloudWatch Logs, and publish metrics to Amazon
        /// CloudWatch. You grant permissions for all of these tasks to an IAM role. For more
        /// information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">Amazon
        /// SageMaker Roles</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to pass this role to Amazon SageMaker, the caller of this API must have
        /// the <code>iam:PassRole</code> permission.
        /// </para>
        ///  </note>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Sets a duration for training. Use this parameter to cap model training costs. To stop
        /// a job, Amazon SageMaker sends the algorithm the <code>SIGTERM</code> signal, which
        /// delays job termination for 120 seconds. Algorithms might use this 120-second window
        /// to save the model artifacts. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon SageMaker terminates a job because the stopping condition has been met,
        /// training algorithms provided by Amazon SageMaker save the intermediate results of
        /// the job. This intermediate data is a valid model artifact. You can use it to create
        /// a model using the <code>CreateModel</code> API. 
        /// </para>
        /// </summary>
        public StoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job. The name must be unique within an AWS Region in an AWS
        /// account. It appears in the Amazon SageMaker console. 
        /// </para>
        /// </summary>
        public string TrainingJobName
        {
            get { return this._trainingJobName; }
            set { this._trainingJobName = value; }
        }

        // Check to see if TrainingJobName property is set
        internal bool IsSetTrainingJobName()
        {
            return this._trainingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A object that specifies the VPC that you want your training job to connect to. Control
        /// access to and from your training container by configuring the VPC. For more information,
        /// see <a>train-vpc</a> 
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}