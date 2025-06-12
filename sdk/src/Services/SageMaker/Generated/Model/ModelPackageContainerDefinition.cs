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
    /// Describes the Docker container for the model package.
    /// </summary>
    public partial class ModelPackageContainerDefinition
    {
        private AdditionalS3DataSource _additionalS3DataSource;
        private string _containerHostname;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _framework;
        private string _frameworkVersion;
        private string _image;
        private string _imageDigest;
        private string _modelDataETag;
        private ModelDataSource _modelDataSource;
        private string _modelDataUrl;
        private ModelInput _modelInput;
        private string _nearestModelName;
        private string _productId;

        /// <summary>
        /// Gets and sets the property AdditionalS3DataSource. 
        /// <para>
        /// The additional data source that is used during inference in the Docker container for
        /// your model package.
        /// </para>
        /// </summary>
        public AdditionalS3DataSource AdditionalS3DataSource
        {
            get { return this._additionalS3DataSource; }
            set { this._additionalS3DataSource = value; }
        }

        // Check to see if AdditionalS3DataSource property is set
        internal bool IsSetAdditionalS3DataSource()
        {
            return this._additionalS3DataSource != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerHostname. 
        /// <para>
        /// The DNS host name for the Docker container.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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
        /// <c>Environment</c> string to string map can have length of up to 1024. We support
        /// up to 16 entries in the map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property Framework. 
        /// <para>
        /// The machine learning framework of the model package container image.
        /// </para>
        /// </summary>
        public string Framework
        {
            get { return this._framework; }
            set { this._framework = value; }
        }

        // Check to see if Framework property is set
        internal bool IsSetFramework()
        {
            return this._framework != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkVersion. 
        /// <para>
        /// The framework version of the Model Package Container Image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=10)]
        public string FrameworkVersion
        {
            get { return this._frameworkVersion; }
            set { this._frameworkVersion = value; }
        }

        // Check to see if FrameworkVersion property is set
        internal bool IsSetFrameworkVersion()
        {
            return this._frameworkVersion != null;
        }

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
        [AWSProperty(Required=true, Min=0, Max=255)]
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
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// An MD5 hash of the training algorithm that identifies the Docker image used for training.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=72)]
        public string ImageDigest
        {
            get { return this._imageDigest; }
            set { this._imageDigest = value; }
        }

        // Check to see if ImageDigest property is set
        internal bool IsSetImageDigest()
        {
            return this._imageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDataETag. 
        /// <para>
        /// The ETag associated with Model Data URL.
        /// </para>
        /// </summary>
        public string ModelDataETag
        {
            get { return this._modelDataETag; }
            set { this._modelDataETag = value; }
        }

        // Check to see if ModelDataETag property is set
        internal bool IsSetModelDataETag()
        {
            return this._modelDataETag != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDataSource. 
        /// <para>
        /// Specifies the location of ML model data to deploy during endpoint creation.
        /// </para>
        /// </summary>
        public ModelDataSource ModelDataSource
        {
            get { return this._modelDataSource; }
            set { this._modelDataSource = value; }
        }

        // Check to see if ModelDataSource property is set
        internal bool IsSetModelDataSource()
        {
            return this._modelDataSource != null;
        }

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
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property ModelInput. 
        /// <para>
        /// A structure with Model Input details.
        /// </para>
        /// </summary>
        public ModelInput ModelInput
        {
            get { return this._modelInput; }
            set { this._modelInput = value; }
        }

        // Check to see if ModelInput property is set
        internal bool IsSetModelInput()
        {
            return this._modelInput != null;
        }

        /// <summary>
        /// Gets and sets the property NearestModelName. 
        /// <para>
        /// The name of a pre-trained machine learning benchmarked by Amazon SageMaker Inference
        /// Recommender model that matches your model. You can find a list of benchmarked models
        /// by calling <c>ListModelMetadata</c>.
        /// </para>
        /// </summary>
        public string NearestModelName
        {
            get { return this._nearestModelName; }
            set { this._nearestModelName = value; }
        }

        // Check to see if NearestModelName property is set
        internal bool IsSetNearestModelName()
        {
            return this._nearestModelName != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The Amazon Web Services Marketplace product ID of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

    }
}