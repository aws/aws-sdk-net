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
    /// Specifies mandatory fields for running an Inference Recommender job directly in the
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateInferenceRecommendationsJob.html">CreateInferenceRecommendationsJob</a>
    /// API. The fields specified in <c>ContainerConfig</c> override the corresponding fields
    /// in the model package. Use <c>ContainerConfig</c> if you want to specify these fields
    /// for the recommendation job but don't want to edit them in your model package.
    /// </summary>
    public partial class RecommendationJobContainerConfig
    {
        private string _dataInputConfig;
        private string _domain;
        private string _framework;
        private string _frameworkVersion;
        private string _nearestModelName;
        private RecommendationJobPayloadConfig _payloadConfig;
        private RecommendationJobSupportedEndpointType _supportedEndpointType;
        private List<string> _supportedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedResponseMIMETypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _task;

        /// <summary>
        /// Gets and sets the property DataInputConfig. 
        /// <para>
        /// Specifies the name and shape of the expected data inputs for your trained model with
        /// a JSON dictionary form. This field is used for optimizing your model using SageMaker
        /// Neo. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_InputConfig.html#sagemaker-Type-InputConfig-DataInputConfig">DataInputConfig</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DataInputConfig
        {
            get { return this._dataInputConfig; }
            set { this._dataInputConfig = value; }
        }

        // Check to see if DataInputConfig property is set
        internal bool IsSetDataInputConfig()
        {
            return this._dataInputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The machine learning domain of the model and its components.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>COMPUTER_VISION | NATURAL_LANGUAGE_PROCESSING | MACHINE_LEARNING</c>
        /// 
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Framework. 
        /// <para>
        /// The machine learning framework of the container image.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>TENSORFLOW | PYTORCH | XGBOOST | SAGEMAKER-SCIKIT-LEARN</c> 
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
        /// The framework version of the container image.
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
        /// Gets and sets the property NearestModelName. 
        /// <para>
        /// The name of a pre-trained machine learning model benchmarked by Amazon SageMaker Inference
        /// Recommender that matches your model.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>efficientnetb7 | unet | xgboost | faster-rcnn-resnet101 | nasnetlarge
        /// | vgg16 | inception-v3 | mask-rcnn | sagemaker-scikit-learn | densenet201-gluon |
        /// resnet18v2-gluon | xception | densenet201 | yolov4 | resnet152 | bert-base-cased |
        /// xceptionV1-keras | resnet50 | retinanet</c> 
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
        /// Gets and sets the property PayloadConfig. 
        /// <para>
        /// Specifies the <c>SamplePayloadUrl</c> and all other sample payload-related fields.
        /// </para>
        /// </summary>
        public RecommendationJobPayloadConfig PayloadConfig
        {
            get { return this._payloadConfig; }
            set { this._payloadConfig = value; }
        }

        // Check to see if PayloadConfig property is set
        internal bool IsSetPayloadConfig()
        {
            return this._payloadConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedEndpointType. 
        /// <para>
        /// The endpoint type to receive recommendations for. By default this is null, and the
        /// results of the inference recommendation job return a combined list of both real-time
        /// and serverless benchmarks. By specifying a value for this field, you can receive a
        /// longer list of benchmarks for the desired endpoint type.
        /// </para>
        /// </summary>
        public RecommendationJobSupportedEndpointType SupportedEndpointType
        {
            get { return this._supportedEndpointType; }
            set { this._supportedEndpointType = value; }
        }

        // Check to see if SupportedEndpointType property is set
        internal bool IsSetSupportedEndpointType()
        {
            return this._supportedEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedInstanceTypes. 
        /// <para>
        /// A list of the instance types that are used to generate inferences in real-time.
        /// </para>
        /// </summary>
        public List<string> SupportedInstanceTypes
        {
            get { return this._supportedInstanceTypes; }
            set { this._supportedInstanceTypes = value; }
        }

        // Check to see if SupportedInstanceTypes property is set
        internal bool IsSetSupportedInstanceTypes()
        {
            return this._supportedInstanceTypes != null && (this._supportedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedResponseMIMETypes. 
        /// <para>
        /// The supported MIME types for the output data.
        /// </para>
        /// </summary>
        public List<string> SupportedResponseMIMETypes
        {
            get { return this._supportedResponseMIMETypes; }
            set { this._supportedResponseMIMETypes = value; }
        }

        // Check to see if SupportedResponseMIMETypes property is set
        internal bool IsSetSupportedResponseMIMETypes()
        {
            return this._supportedResponseMIMETypes != null && (this._supportedResponseMIMETypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// The machine learning task that the model accomplishes.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>IMAGE_CLASSIFICATION | OBJECT_DETECTION | TEXT_GENERATION | IMAGE_SEGMENTATION
        /// | FILL_MASK | CLASSIFICATION | REGRESSION | OTHER</c> 
        /// </para>
        /// </summary>
        public string Task
        {
            get { return this._task; }
            set { this._task = value; }
        }

        // Check to see if Task property is set
        internal bool IsSetTask()
        {
            return this._task != null;
        }

    }
}