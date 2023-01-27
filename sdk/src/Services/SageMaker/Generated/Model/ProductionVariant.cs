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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Identifies a model that you want to host and the resources chosen to deploy for hosting
    /// it. If you are deploying multiple models, tell SageMaker how to distribute traffic
    /// among the models by specifying variant weights.
    /// </summary>
    public partial class ProductionVariant
    {
        private ProductionVariantAcceleratorType _acceleratorType;
        private int? _containerStartupHealthCheckTimeoutInSeconds;
        private ProductionVariantCoreDumpConfig _coreDumpConfig;
        private int? _initialInstanceCount;
        private float? _initialVariantWeight;
        private ProductionVariantInstanceType _instanceType;
        private int? _modelDataDownloadTimeoutInSeconds;
        private string _modelName;
        private ProductionVariantServerlessConfig _serverlessConfig;
        private string _variantName;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AcceleratorType. 
        /// <para>
        /// The size of the Elastic Inference (EI) instance to use for the production variant.
        /// EI instances provide on-demand GPU computing for inference. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ei.html">Using Elastic
        /// Inference in Amazon SageMaker</a>.
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
        /// Gets and sets the property ContainerStartupHealthCheckTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, for your inference container to pass health check by
        /// SageMaker Hosting. For more information about health check, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-inference-code.html#your-algorithms-inference-algo-ping-requests">How
        /// Your Container Should Respond to Health Check (Ping) Requests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int ContainerStartupHealthCheckTimeoutInSeconds
        {
            get { return this._containerStartupHealthCheckTimeoutInSeconds.GetValueOrDefault(); }
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
        /// Gets and sets the property InitialInstanceCount. 
        /// <para>
        /// Number of instances to launch initially.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int InitialInstanceCount
        {
            get { return this._initialInstanceCount.GetValueOrDefault(); }
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
        /// ratio of the <code>VariantWeight</code> to the sum of all <code>VariantWeight</code>
        /// values across all ProductionVariants. If unspecified, it defaults to 1.0. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public float InitialVariantWeight
        {
            get { return this._initialVariantWeight.GetValueOrDefault(); }
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
        /// Gets and sets the property ModelDataDownloadTimeoutInSeconds. 
        /// <para>
        /// The timeout value, in seconds, to download and extract the model that you want to
        /// host from Amazon S3 to the individual inference instance associated with this production
        /// variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=3600)]
        public int ModelDataDownloadTimeoutInSeconds
        {
            get { return this._modelDataDownloadTimeoutInSeconds.GetValueOrDefault(); }
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
        [AWSProperty(Required=true, Max=63)]
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
        [AWSProperty(Required=true, Max=63)]
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
        public int VolumeSizeInGB
        {
            get { return this._volumeSizeInGB.GetValueOrDefault(); }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}