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
    /// Identifies a model that you want to host and the resources chosen to deploy for hosting
    /// it. If you are deploying multiple models, tell SageMaker how to distribute traffic
    /// among the models by specifying variant weights. For more information on production
    /// variants, check <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-ab-testing.html">
    /// Production variants</a>.
    /// </summary>
    public partial class ProductionVariant
    {
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
        public ProductionVariantAcceleratorType AcceleratorType { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorType property is set.
        /// </summary>
        internal bool IsSetAcceleratorType() => this.AcceleratorType != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationConfig. 
        /// <para>
        /// Settings for the capacity reservation for the compute instances that SageMaker AI
        /// reserves for an endpoint. 
        /// </para>
        /// </summary>
        public ProductionVariantCapacityReservationConfig CapacityReservationConfig { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationConfig property is set.
        /// </summary>
        internal bool IsSetCapacityReservationConfig() => this.CapacityReservationConfig != null;

        /// <summary>
        /// Gets and sets the property ContainerStartupHealthCheckTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, for your inference container to pass health check by
        /// SageMaker Hosting. For more information about health check, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-algo-ping-requests">How
        /// Your Container Should Respond to Health Check (Ping) Requests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 3600)]
        public int? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ContainerStartupHealthCheckTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetContainerStartupHealthCheckTimeoutInSeconds() => this.ContainerStartupHealthCheckTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property CoreDumpConfig. 
        /// <para>
        /// Specifies configuration for a core dump from the model container when the process
        /// crashes.
        /// </para>
        /// </summary>
        public ProductionVariantCoreDumpConfig CoreDumpConfig { get; set; }

        /// <summary>
        /// Checks to see if the CoreDumpConfig property is set.
        /// </summary>
        internal bool IsSetCoreDumpConfig() => this.CoreDumpConfig != null;

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
        public bool? EnableSSMAccess { get; set; }

        /// <summary>
        /// Checks to see if the EnableSSMAccess property is set.
        /// </summary>
        internal bool IsSetEnableSSMAccess() => this.EnableSSMAccess.HasValue;

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
        ///  </li> </ul> </dd> <dt>al2023-ami-sagemaker-inference-gpu-4-1</dt> <dd> <ul> <li>
        /// 
        /// <para>
        /// Accelerator: GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA driver version: 580
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CUDA version: 13.0
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
        public ProductionVariantInferenceAmiVersion InferenceAmiVersion { get; set; }

        /// <summary>
        /// Checks to see if the InferenceAmiVersion property is set.
        /// </summary>
        internal bool IsSetInferenceAmiVersion() => this.InferenceAmiVersion != null;

        /// <summary>
        /// Gets and sets the property InitialInstanceCount. 
        /// <para>
        /// Number of instances to launch initially.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? InitialInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InitialInstanceCount property is set.
        /// </summary>
        internal bool IsSetInitialInstanceCount() => this.InitialInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InitialVariantWeight. 
        /// <para>
        /// Determines initial traffic distribution among all of the models that you specify in
        /// the endpoint configuration. The traffic to a production variant is determined by the
        /// ratio of the <c>VariantWeight</c> to the sum of all <c>VariantWeight</c> values across
        /// all ProductionVariants. If unspecified, it defaults to 1.0. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? InitialVariantWeight { get; set; }

        /// <summary>
        /// Checks to see if the InitialVariantWeight property is set.
        /// </summary>
        internal bool IsSetInitialVariantWeight() => this.InitialVariantWeight.HasValue;

        /// <summary>
        /// Gets and sets the property InstancePools. 
        /// <para>
        /// A list of instance pools for the production variant. Each instance pool specifies
        /// an instance type and its priority for provisioning. Use instance pools to configure
        /// heterogeneous endpoints that deploy models across multiple instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<InstancePool> InstancePools { get; set; } = AWSConfigs.InitializeCollections ? new List<InstancePool>() : null;

        /// <summary>
        /// Checks to see if the InstancePools property is set.
        /// </summary>
        internal bool IsSetInstancePools() => this.InstancePools != null && (this.InstancePools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type.
        /// </para>
        /// </summary>
        public ProductionVariantInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ManagedInstanceScaling. 
        /// <para>
        /// Settings that control the range in the number of instances that the endpoint provisions
        /// as it scales up or down to accommodate traffic. 
        /// </para>
        /// </summary>
        public ProductionVariantManagedInstanceScaling ManagedInstanceScaling { get; set; }

        /// <summary>
        /// Checks to see if the ManagedInstanceScaling property is set.
        /// </summary>
        internal bool IsSetManagedInstanceScaling() => this.ManagedInstanceScaling != null;

        /// <summary>
        /// Gets and sets the property ModelDataDownloadTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, to download and extract the model that you want to
        /// host from Amazon S3 to the individual inference instance associated with this production
        /// variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 3600)]
        public int? ModelDataDownloadTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataDownloadTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetModelDataDownloadTimeoutInSeconds() => this.ModelDataDownloadTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model that you want to host. This is the name that you specified when
        /// creating the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property RoutingConfig. 
        /// <para>
        /// Settings that control how the endpoint routes incoming traffic to the instances that
        /// the endpoint hosts.
        /// </para>
        /// </summary>
        public ProductionVariantRoutingConfig RoutingConfig { get; set; }

        /// <summary>
        /// Checks to see if the RoutingConfig property is set.
        /// </summary>
        internal bool IsSetRoutingConfig() => this.RoutingConfig != null;

        /// <summary>
        /// Gets and sets the property ServerlessConfig. 
        /// <para>
        /// The serverless configuration for an endpoint. Specifies a serverless endpoint configuration
        /// instead of an instance-based endpoint configuration.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessConfig ServerlessConfig { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessConfig property is set.
        /// </summary>
        internal bool IsSetServerlessConfig() => this.ServerlessConfig != null;

        /// <summary>
        /// Gets and sets the property VariantInstanceProvisionTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, for provisioning instances for the production variant.
        /// When SageMaker encounters an insufficient capacity error while provisioning instances,
        /// it retries with the next instance pool (if configured) or waits until the timeout
        /// expires. This timeout applies only to capacity provisioning and does not include the
        /// time for model download or container startup.
        /// </para>
        ///  
        /// <para>
        /// Valid values: 300 to 3600.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 300, Max = 3600)]
        public int? VariantInstanceProvisionTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the VariantInstanceProvisionTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetVariantInstanceProvisionTimeoutInSeconds() => this.VariantInstanceProvisionTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the production variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string VariantName { get; set; }

        /// <summary>
        /// Checks to see if the VariantName property is set.
        /// </summary>
        internal bool IsSetVariantName() => this.VariantName != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume attached to individual inference instance
        /// associated with the production variant. Currently only Amazon EBS gp2 storage volumes
        /// are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
