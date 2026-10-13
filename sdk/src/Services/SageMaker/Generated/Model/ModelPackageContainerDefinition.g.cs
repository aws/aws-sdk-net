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
    /// Describes the Docker container for the model package.
    /// </summary>
    public partial class ModelPackageContainerDefinition
    {
        /// <summary>
        /// Gets and sets the property AdditionalModelDataSources. 
        /// <para>
        /// Data sources that are available to your model in addition to the one that you specify
        /// for <c>ModelDataSource</c> when you use the <c>CreateModelPackage</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<AdditionalModelDataSource> AdditionalModelDataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalModelDataSource>() : null;

        /// <summary>
        /// Checks to see if the AdditionalModelDataSources property is set.
        /// </summary>
        internal bool IsSetAdditionalModelDataSources() => this.AdditionalModelDataSources != null && (this.AdditionalModelDataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalS3DataSource. 
        /// <para>
        /// The additional data source that is used during inference in the Docker container for
        /// your model package.
        /// </para>
        /// </summary>
        public AdditionalS3DataSource AdditionalS3DataSource { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalS3DataSource property is set.
        /// </summary>
        internal bool IsSetAdditionalS3DataSource() => this.AdditionalS3DataSource != null;

        /// <summary>
        /// Gets and sets the property BaseModel. 
        /// <para>
        ///  Identifies the foundation model that was used as the starting point for model customization.
        /// 
        /// </para>
        /// </summary>
        public BaseModel BaseModel { get; set; }

        /// <summary>
        /// Checks to see if the BaseModel property is set.
        /// </summary>
        internal bool IsSetBaseModel() => this.BaseModel != null;

        /// <summary>
        /// Gets and sets the property ContainerHostname. 
        /// <para>
        /// The DNS host name for the Docker container.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string ContainerHostname { get; set; }

        /// <summary>
        /// Checks to see if the ContainerHostname property is set.
        /// </summary>
        internal bool IsSetContainerHostname() => this.ContainerHostname != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container. Each key and value in the
        /// <c>Environment</c> string to string map can have length of up to 1024. We support
        /// up to 16 entries in the map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Framework. 
        /// <para>
        /// The machine learning framework of the model package container image.
        /// </para>
        /// </summary>
        public string Framework { get; set; }

        /// <summary>
        /// Checks to see if the Framework property is set.
        /// </summary>
        internal bool IsSetFramework() => this.Framework != null;

        /// <summary>
        /// Gets and sets the property FrameworkVersion. 
        /// <para>
        /// The framework version of the Model Package Container Image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 10)]
        public string FrameworkVersion { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkVersion property is set.
        /// </summary>
        internal bool IsSetFrameworkVersion() => this.FrameworkVersion != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The Amazon Elastic Container Registry (Amazon ECR) path where inference code is stored.
        /// </para>
        ///  
        /// <para>
        /// If you are using your own custom algorithm instead of an algorithm provided by SageMaker,
        /// the inference code must meet SageMaker requirements. SageMaker supports both <c>registry/repository[:tag]</c>
        /// and <c>registry/repository[@digest]</c> image path formats. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// An MD5 hash of the training algorithm that identifies the Docker image used for training.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 72)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ImageDigest property is set.
        /// </summary>
        internal bool IsSetImageDigest() => this.ImageDigest != null;

        /// <summary>
        /// Gets and sets the property IsCheckpoint. 
        /// <para>
        ///  Specifies whether the model data is a training checkpoint. 
        /// </para>
        /// </summary>
        public bool? IsCheckpoint { get; set; }

        /// <summary>
        /// Checks to see if the IsCheckpoint property is set.
        /// </summary>
        internal bool IsSetIsCheckpoint() => this.IsCheckpoint.HasValue;

        /// <summary>
        /// Gets and sets the property ModelDataETag. 
        /// <para>
        /// The ETag associated with Model Data URL.
        /// </para>
        /// </summary>
        public string ModelDataETag { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataETag property is set.
        /// </summary>
        internal bool IsSetModelDataETag() => this.ModelDataETag != null;

        /// <summary>
        /// Gets and sets the property ModelDataSource. 
        /// <para>
        /// Specifies the location of ML model data to deploy during endpoint creation.
        /// </para>
        /// </summary>
        public ModelDataSource ModelDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataSource property is set.
        /// </summary>
        internal bool IsSetModelDataSource() => this.ModelDataSource != null;

        /// <summary>
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The Amazon S3 path where the model artifacts, which result from model training, are
        /// stored. This path must point to a single <c>gzip</c> compressed tar archive (<c>.tar.gz</c>
        /// suffix).
        /// </para>
        ///  <note> 
        /// <para>
        /// The model artifacts must be in an S3 bucket that is in the same region as the model
        /// package.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ModelDataUrl { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataUrl property is set.
        /// </summary>
        internal bool IsSetModelDataUrl() => this.ModelDataUrl != null;

        /// <summary>
        /// Gets and sets the property ModelInput. 
        /// <para>
        /// A structure with Model Input details.
        /// </para>
        /// </summary>
        public ModelInput ModelInput { get; set; }

        /// <summary>
        /// Checks to see if the ModelInput property is set.
        /// </summary>
        internal bool IsSetModelInput() => this.ModelInput != null;

        /// <summary>
        /// Gets and sets the property NearestModelName. 
        /// <para>
        /// The name of a pre-trained machine learning benchmarked by Amazon SageMaker Inference
        /// Recommender model that matches your model. You can find a list of benchmarked models
        /// by calling <c>ListModelMetadata</c>.
        /// </para>
        /// </summary>
        public string NearestModelName { get; set; }

        /// <summary>
        /// Checks to see if the NearestModelName property is set.
        /// </summary>
        internal bool IsSetNearestModelName() => this.NearestModelName != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The Amazon Web Services Marketplace product ID of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;
    }
}
