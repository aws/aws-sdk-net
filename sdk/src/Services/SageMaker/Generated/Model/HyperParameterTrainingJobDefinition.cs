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
    /// Defines the training jobs launched by a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTrainingJobDefinition
    {
        private HyperParameterAlgorithmSpecification _algorithmSpecification;
        private bool? _enableNetworkIsolation;
        private List<Channel> _inputDataConfig = new List<Channel>();
        private OutputDataConfig _outputDataConfig;
        private ResourceConfig _resourceConfig;
        private string _roleArn;
        private Dictionary<string, string> _staticHyperParameters = new Dictionary<string, string>();
        private StoppingCondition _stoppingCondition;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// The <a>HyperParameterAlgorithmSpecification</a> object that specifies the algorithm
        /// to use for the training jobs that the tuning job launches.
        /// </para>
        /// </summary>
        public HyperParameterAlgorithmSpecification AlgorithmSpecification
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
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// Isolates the training container. No inbound or outbound network calls can be made,
        /// except for calls between peers within a training cluster for distributed training.
        /// If network isolation is used for training jobs that are configured to use a VPC, Amazon
        /// SageMaker downloads and uploads customer data and model artifacts through the specifed
        /// VPC, but the training container does not have network access.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Semantic Segmentation built-in algorithm does not support network isolation.
        /// </para>
        ///  </note>
        /// </summary>
        public bool EnableNetworkIsolation
        {
            get { return this._enableNetworkIsolation.GetValueOrDefault(); }
            set { this._enableNetworkIsolation = value; }
        }

        // Check to see if EnableNetworkIsolation property is set
        internal bool IsSetEnableNetworkIsolation()
        {
            return this._enableNetworkIsolation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of <a>Channel</a> objects that specify the input for the training jobs that
        /// the tuning job launches.
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
        /// Specifies the path to the Amazon S3 bucket where you store model artifacts from the
        /// training jobs that the tuning job launches.
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
        /// The resources, including the compute instances and storage volumes, to use for the
        /// training jobs that the tuning job launches.
        /// </para>
        ///  
        /// <para>
        /// Storage volumes store model artifacts and incremental states. Training algorithms
        /// might also use storage volumes for scratch space. If you want Amazon SageMaker to
        /// use the storage volume to store the training data, choose <code>File</code> as the
        /// <code>TrainingInputMode</code> in the algorithm specification. For distributed training
        /// algorithms, specify an instance count greater than 1.
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
        /// The Amazon Resource Name (ARN) of the IAM role associated with the training jobs that
        /// the tuning job launches.
        /// </para>
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
        /// Gets and sets the property StaticHyperParameters. 
        /// <para>
        /// Specifies the values of hyperparameters that do not change for the tuning job.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StaticHyperParameters
        {
            get { return this._staticHyperParameters; }
            set { this._staticHyperParameters = value; }
        }

        // Check to see if StaticHyperParameters property is set
        internal bool IsSetStaticHyperParameters()
        {
            return this._staticHyperParameters != null && this._staticHyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Sets a maximum duration for the training jobs that the tuning job launches. Use this
        /// parameter to limit model training costs. 
        /// </para>
        ///  
        /// <para>
        /// To stop a job, Amazon SageMaker sends the algorithm the <code>SIGTERM</code> signal.
        /// This delays job termination for 120 seconds. Algorithms might use this 120-second
        /// window to save the model artifacts.
        /// </para>
        ///  
        /// <para>
        /// When Amazon SageMaker terminates a job because the stopping condition has been met,
        /// training algorithms provided by Amazon SageMaker save the intermediate results of
        /// the job.
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The <a>VpcConfig</a> object that specifies the VPC that you want the training jobs
        /// that this hyperparameter tuning job launches to connect to. Control access to and
        /// from your training container by configuring the VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html">Protect Training
        /// Jobs by Using an Amazon Virtual Private Cloud</a>.
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