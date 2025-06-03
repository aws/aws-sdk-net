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
    /// Identifies a model that you want to host and the resources chosen to deploy for hosting
    /// it. If you are deploying multiple models, tell SageMaker how to distribute traffic
    /// among the models by specifying variant weights. For more information on production
    /// variants, check <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-ab-testing.html">
    /// Production variants</a>.
    /// </summary>
    public partial class ProductionVariant
    {
        private ProductionVariantAcceleratorType _acceleratorType;
        private ProductionVariantCapacityReservationConfig _capacityReservationConfig;
        private int? _containerStartupHealthCheckTimeoutInSeconds;
        private ProductionVariantCoreDumpConfig _coreDumpConfig;
        private bool? _enableSSMAccess;
        private ProductionVariantInferenceAmiVersion _inferenceAmiVersion;
        private int? _initialInstanceCount;
        private float? _initialVariantWeight;
        private ProductionVariantInstanceType _instanceType;
        private ProductionVariantManagedInstanceScaling _managedInstanceScaling;
        private int? _modelDataDownloadTimeoutInSeconds;
        private string _modelName;
        private ProductionVariantRoutingConfig _routingConfig;
        private ProductionVariantServerlessConfig _serverlessConfig;
        private string _variantName;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AcceleratorType. 
        /// <para>
        /// This parameter is no longer supported. Elastic Inference (EI) is no longer available.
        /// </para>
        ///  
        /// <para>
        /// This parameter was used to specify the size of the EI instance to use for the production
        /// variant.
        /// </para>
        /// </summary>
        public ProductionVariantAcceleratorType AcceleratorType
        {
            get { return this._acceleratorType; }
            set { this._acceleratorType = value; }
        }

        // Check to see if AcceleratorType property is set
        internal bool IsSetAcceleratorType()
        {
            return this._acceleratorType != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationConfig. 
        /// <para>
        /// Settings for the capacity reservation for the compute instances that SageMaker AI
        /// reserves for an endpoint. 
        /// </para>
        /// </summary>
        public ProductionVariantCapacityReservationConfig CapacityReservationConfig
        {
            get { return this._capacityReservationConfig; }
            set { this._capacityReservationConfig = value; }
        }

        // Check to see if CapacityReservationConfig property is set
        internal bool IsSetCapacityReservationConfig()
        {
            return this._capacityReservationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerStartupHealthCheckTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, for your inference container to pass health check by
        /// SageMaker Hosting. For more information about health check, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-algo-ping-requests">How
        /// Your Container Should Respond to Health Check (Ping) Requests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int? ContainerStartupHealthCheckTimeoutInSeconds
        {
            get { return this._containerStartupHealthCheckTimeoutInSeconds; }
            set { this._containerStartupHealthCheckTimeoutInSeconds = value; }
        }

        // Check to see if ContainerStartupHealthCheckTimeoutInSeconds property is set
        internal bool IsSetContainerStartupHealthCheckTimeoutInSeconds()
        {
            return this._containerStartupHealthCheckTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CoreDumpConfig. 
        /// <para>
        /// Specifies configuration for a core dump from the model container when the process
        /// crashes.
        /// </para>
        /// </summary>
        public ProductionVariantCoreDumpConfig CoreDumpConfig
        {
            get { return this._coreDumpConfig; }
            set { this._coreDumpConfig = value; }
        }

        // Check to see if CoreDumpConfig property is set
        internal bool IsSetCoreDumpConfig()
        {
            return this._coreDumpConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EnableSSMAccess. 
        /// <para>
        ///  You can use this parameter to turn on native Amazon Web Services Systems Manager
        /// (SSM) access for a production variant behind an endpoint. By default, SSM access is
        /// disabled for all production variants behind an endpoint. You can turn on or turn off
        /// SSM access for a production variant behind an existing endpoint by creating a new
        /// endpoint configuration and calling <c>UpdateEndpoint</c>. 
        /// </para>
        /// </summary>
        public bool? EnableSSMAccess
        {
            get { return this._enableSSMAccess; }
            set { this._enableSSMAccess = value; }
        }

        // Check to see if EnableSSMAccess property is set
        internal bool IsSetEnableSSMAccess()
        {
            return this._enableSSMAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InferenceAmiVersion. 
        /// <para>
        /// Specifies an option from a collection of preconfigured Amazon Machine Image (AMI)
        /// images. Each image is configured by Amazon Web Services with a set of software and
        /// driver versions. Amazon Web Services optimizes these configurations for different
        /// machine learning workloads.
        /// </para>
        ///  
        /// <para>
        /// By selecting an AMI version, you can ensure that your inference environment is compatible
        /// with specific software requirements, such as CUDA driver versions, Linux kernel versions,
        /// or Amazon Web Services Neuron driver versions.
        /// </para>
        ///  
        /// <para>
        /// The AMI version names, and their configurations, are the following:
        /// </para>
        ///  <dl> <dt>al2-ami-sagemaker-inference-gpu-2</dt> <dd> <ul> <li> 
        /// <para>
        /// Accelerator: GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA driver version: 535
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CUDA version: 12.2
        /// </para>
        ///  </li> </ul> </dd> <dt>al2-ami-sagemaker-inference-gpu-2-1</dt> <dd> <ul> <li> 
        /// <para>
        /// Accelerator: GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA driver version: 535
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CUDA version: 12.2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA Container Toolkit with disabled CUDA-compat mounting
        /// </para>
        ///  </li> </ul> </dd> <dt>al2-ami-sagemaker-inference-gpu-3-1</dt> <dd> <ul> <li> 
        /// <para>
        /// Accelerator: GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA driver version: 550
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CUDA version: 12.4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA Container Toolkit with disabled CUDA-compat mounting
        /// </para>
        ///  </li> </ul> </dd> <dt>al2-ami-sagemaker-inference-neuron-2</dt> <dd> <ul> <li> 
        /// <para>
        /// Accelerator: Inferentia2 and Trainium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Neuron driver version: 2.19
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        public ProductionVariantInferenceAmiVersion InferenceAmiVersion
        {
            get { return this._inferenceAmiVersion; }
            set { this._inferenceAmiVersion = value; }
        }

        // Check to see if InferenceAmiVersion property is set
        internal bool IsSetInferenceAmiVersion()
        {
            return this._inferenceAmiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InitialInstanceCount. 
        /// <para>
        /// Number of instances to launch initially.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? InitialInstanceCount
        {
            get { return this._initialInstanceCount; }
            set { this._initialInstanceCount = value; }
        }

        // Check to see if InitialInstanceCount property is set
        internal bool IsSetInitialInstanceCount()
        {
            return this._initialInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitialVariantWeight. 
        /// <para>
        /// Determines initial traffic distribution among all of the models that you specify in
        /// the endpoint configuration. The traffic to a production variant is determined by the
        /// ratio of the <c>VariantWeight</c> to the sum of all <c>VariantWeight</c> values across
        /// all ProductionVariants. If unspecified, it defaults to 1.0. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public float? InitialVariantWeight
        {
            get { return this._initialVariantWeight; }
            set { this._initialVariantWeight = value; }
        }

        // Check to see if InitialVariantWeight property is set
        internal bool IsSetInitialVariantWeight()
        {
            return this._initialVariantWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type.
        /// </para>
        /// </summary>
        public ProductionVariantInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedInstanceScaling. 
        /// <para>
        /// Settings that control the range in the number of instances that the endpoint provisions
        /// as it scales up or down to accommodate traffic. 
        /// </para>
        /// </summary>
        public ProductionVariantManagedInstanceScaling ManagedInstanceScaling
        {
            get { return this._managedInstanceScaling; }
            set { this._managedInstanceScaling = value; }
        }

        // Check to see if ManagedInstanceScaling property is set
        internal bool IsSetManagedInstanceScaling()
        {
            return this._managedInstanceScaling != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDataDownloadTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, to download and extract the model that you want to
        /// host from Amazon S3 to the individual inference instance associated with this production
        /// variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int? ModelDataDownloadTimeoutInSeconds
        {
            get { return this._modelDataDownloadTimeoutInSeconds; }
            set { this._modelDataDownloadTimeoutInSeconds = value; }
        }

        // Check to see if ModelDataDownloadTimeoutInSeconds property is set
        internal bool IsSetModelDataDownloadTimeoutInSeconds()
        {
            return this._modelDataDownloadTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model that you want to host. This is the name that you specified when
        /// creating the model.
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
        /// Gets and sets the property RoutingConfig. 
        /// <para>
        /// Settings that control how the endpoint routes incoming traffic to the instances that
        /// the endpoint hosts.
        /// </para>
        /// </summary>
        public ProductionVariantRoutingConfig RoutingConfig
        {
            get { return this._routingConfig; }
            set { this._routingConfig = value; }
        }

        // Check to see if RoutingConfig property is set
        internal bool IsSetRoutingConfig()
        {
            return this._routingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessConfig. 
        /// <para>
        /// The serverless configuration for an endpoint. Specifies a serverless endpoint configuration
        /// instead of an instance-based endpoint configuration.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessConfig ServerlessConfig
        {
            get { return this._serverlessConfig; }
            set { this._serverlessConfig = value; }
        }

        // Check to see if ServerlessConfig property is set
        internal bool IsSetServerlessConfig()
        {
            return this._serverlessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the production variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string VariantName
        {
            get { return this._variantName; }
            set { this._variantName = value; }
        }

        // Check to see if VariantName property is set
        internal bool IsSetVariantName()
        {
            return this._variantName != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume attached to individual inference instance
        /// associated with the production variant. Currently only Amazon EBS gp2 storage volumes
        /// are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public int? VolumeSizeInGB
        {
            get { return this._volumeSizeInGB; }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}