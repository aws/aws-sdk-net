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
    /// Describes the container, as part of model definition.
    /// </summary>
    public partial class ContainerDefinition
    {
        private string _containerHostname;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private string _image;
        private ImageConfig _imageConfig;
        private string _inferenceSpecificationName;
        private ContainerMode _mode;
        private string _modelDataUrl;
        private string _modelPackageName;
        private MultiModelConfig _multiModelConfig;

        /// <summary>
        /// Gets and sets the property ContainerHostname. 
        /// <para>
        /// This parameter is ignored for models that contain only a <code>PrimaryContainer</code>.
        /// </para>
        ///  
        /// <para>
        /// When a <code>ContainerDefinition</code> is part of an inference pipeline, the value
        /// of the parameter uniquely identifies the container for the purposes of logging and
        /// metrics. For information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-pipeline-logs-metrics.html">Use
        /// Logs and Metrics to Monitor an Inference Pipeline</a>. If you don't specify a value
        /// for this parameter for a <code>ContainerDefinition</code> that is part of an inference
        /// pipeline, a unique name is automatically assigned based on the position of the <code>ContainerDefinition</code>
        /// in the pipeline. If you specify a value for the <code>ContainerHostName</code> for
        /// any <code>ContainerDefinition</code> that is part of an inference pipeline, you must
        /// specify a value for the <code>ContainerHostName</code> parameter of every <code>ContainerDefinition</code>
        /// in that pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string ContainerHostname
        {
            get { return this._containerHostname; }
            set { this._containerHostname = value; }
        }

        // Check to see if ContainerHostname property is set
        internal bool IsSetContainerHostname()
        {
            return this._containerHostname != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container. Each key and value in the
        /// <code>Environment</code> string to string map can have length of up to 1024. We support
        /// up to 16 entries in the map. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=16)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The path where inference code is stored. This can be either in Amazon EC2 Container
        /// Registry or in a Docker registry that is accessible from the same VPC that you configure
        /// for your endpoint. If you are using your own custom algorithm instead of an algorithm
        /// provided by SageMaker, the inference code must meet SageMaker requirements. SageMaker
        /// supports both <code>registry/repository[:tag]</code> and <code>registry/repository[@digest]</code>
        /// image path formats. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The model artifacts in an Amazon S3 bucket and the Docker image for inference container
        /// in Amazon EC2 Container Registry must be in the same region as the model or endpoint
        /// you are creating.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ImageConfig. 
        /// <para>
        /// Specifies whether the model container is in Amazon ECR or a private Docker registry
        /// accessible from your Amazon Virtual Private Cloud (VPC). For information about storing
        /// containers in a private Docker registry, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-containers-inference-private.html">Use
        /// a Private Docker Registry for Real-Time Inference Containers</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The model artifacts in an Amazon S3 bucket and the Docker image for inference container
        /// in Amazon EC2 Container Registry must be in the same region as the model or endpoint
        /// you are creating.
        /// </para>
        ///  </note>
        /// </summary>
        public ImageConfig ImageConfig
        {
            get { return this._imageConfig; }
            set { this._imageConfig = value; }
        }

        // Check to see if ImageConfig property is set
        internal bool IsSetImageConfig()
        {
            return this._imageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSpecificationName. 
        /// <para>
        /// The inference specification name in the model package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string InferenceSpecificationName
        {
            get { return this._inferenceSpecificationName; }
            set { this._inferenceSpecificationName = value; }
        }

        // Check to see if InferenceSpecificationName property is set
        internal bool IsSetInferenceSpecificationName()
        {
            return this._inferenceSpecificationName != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Whether the container hosts a single model or multiple models.
        /// </para>
        /// </summary>
        public ContainerMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The S3 path where the model artifacts, which result from model training, are stored.
        /// This path must point to a single gzip compressed tar archive (.tar.gz suffix). The
        /// S3 path is required for SageMaker built-in algorithms, but not if you use your own
        /// algorithms. For more information on built-in algorithms, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-algo-docker-registry-paths.html">Common
        /// Parameters</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The model artifacts must be in an S3 bucket that is in the same region as the model
        /// or endpoint you are creating.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you provide a value for this parameter, SageMaker uses Amazon Web Services Security
        /// Token Service to download model artifacts from the S3 path you provide. Amazon Web
        /// Services STS is activated in your Amazon Web Services account by default. If you previously
        /// deactivated Amazon Web Services STS for a region, you need to reactivate Amazon Web
        /// Services STS for that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
        /// <i>Amazon Web Services Identity and Access Management User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you use a built-in algorithm to create a model, SageMaker requires that you provide
        /// a S3 path to the model artifacts in <code>ModelDataUrl</code>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ModelDataUrl
        {
            get { return this._modelDataUrl; }
            set { this._modelDataUrl = value; }
        }

        // Check to see if ModelDataUrl property is set
        internal bool IsSetModelDataUrl()
        {
            return this._modelDataUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the model package to use to create the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=176)]
        public string ModelPackageName
        {
            get { return this._modelPackageName; }
            set { this._modelPackageName = value; }
        }

        // Check to see if ModelPackageName property is set
        internal bool IsSetModelPackageName()
        {
            return this._modelPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property MultiModelConfig. 
        /// <para>
        /// Specifies additional configuration for multi-model endpoints.
        /// </para>
        /// </summary>
        public MultiModelConfig MultiModelConfig
        {
            get { return this._multiModelConfig; }
            set { this._multiModelConfig = value; }
        }

        // Check to see if MultiModelConfig property is set
        internal bool IsSetMultiModelConfig()
        {
            return this._multiModelConfig != null;
        }

    }
}