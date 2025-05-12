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
    /// Contains information about the location of input model artifacts, the name and shape
    /// of the expected data inputs, and the framework in which the model was trained.
    /// </summary>
    public partial class InputConfig
    {
        private string _dataInputConfig;
        private Framework _framework;
        private string _frameworkVersion;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property DataInputConfig. 
        /// <para>
        /// Specifies the name and shape of the expected data inputs for your trained model with
        /// a JSON dictionary form. The data inputs are <c>Framework</c> specific. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TensorFlow</c>: You must specify the name and shape (NHWC format) of the expected
        /// data inputs using a dictionary format for your trained model. The dictionary formats
        /// required for the console and CLI are different.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Examples for one input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"input":[1,1024,1024,3]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"input\":[1,1024,1024,3]}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Examples for two inputs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"data1": [1,28,28,1], "data2":[1,28,28,1]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"data1\": [1,28,28,1], \"data2\":[1,28,28,1]}</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <c>KERAS</c>: You must specify the name and shape (NCHW format) of expected data
        /// inputs using a dictionary format for your trained model. Note that while Keras model
        /// artifacts should be uploaded in NHWC (channel-last) format, <c>DataInputConfig</c>
        /// should be specified in NCHW (channel-first) format. The dictionary formats required
        /// for the console and CLI are different.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Examples for one input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"input_1":[1,3,224,224]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"input_1\":[1,3,224,224]}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Examples for two inputs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"input_1": [1,3,224,224], "input_2":[1,3,224,224]} </c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"input_1\": [1,3,224,224], \"input_2\":[1,3,224,224]}</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <c>MXNET/ONNX/DARKNET</c>: You must specify the name and shape (NCHW format) of the
        /// expected data inputs in order using a dictionary format for your trained model. The
        /// dictionary formats required for the console and CLI are different.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Examples for one input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"data":[1,3,1024,1024]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"data\":[1,3,1024,1024]}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Examples for two inputs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"var1": [1,1,28,28], "var2":[1,1,28,28]} </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"var1\": [1,1,28,28], \"var2\":[1,1,28,28]}</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PyTorch</c>: You can either specify the name and shape (NCHW format) of expected
        /// data inputs in order using a dictionary format for your trained model or you can specify
        /// the shape only using a list format. The dictionary formats required for the console
        /// and CLI are different. The list formats for the console and CLI are the same.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Examples for one input in dictionary format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"input0":[1,3,224,224]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"input0\":[1,3,224,224]}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example for one input in list format: <c>[[1,3,224,224]]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Examples for two inputs in dictionary format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <c>{"input0":[1,3,224,224], "input1":[1,3,224,224]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <c>{\"input0\":[1,3,224,224], \"input1\":[1,3,224,224]} </c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example for two inputs in list format: <c>[[1,3,224,224], [1,3,224,224]]</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>XGBOOST</c>: input data name and shape are not needed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>DataInputConfig</c> supports the following parameters for <c>CoreML</c> <c>TargetDevice</c>
        /// (ML Model format):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>shape</c>: Input shape, for example <c>{"input_1": {"shape": [1,224,224,3]}}</c>.
        /// In addition to static input shapes, CoreML converter supports Flexible input shapes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Range Dimension. You can use the Range Dimension feature if you know the input shape
        /// will be within some specific interval in that dimension, for example: <c>{"input_1":
        /// {"shape": ["1..10", 224, 224, 3]}}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enumerated shapes. Sometimes, the models are trained to work only on a select set
        /// of inputs. You can enumerate all supported input shapes, for example: <c>{"input_1":
        /// {"shape": [[1, 224, 224, 3], [1, 160, 160, 3]]}}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>default_shape</c>: Default input shape. You can set a default shape during conversion
        /// for both Range Dimension and Enumerated Shapes. For example <c>{"input_1": {"shape":
        /// ["1..10", 224, 224, 3], "default_shape": [1, 224, 224, 3]}}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c>: Input type. Allowed values: <c>Image</c> and <c>Tensor</c>. By default,
        /// the converter generates an ML Model with inputs of type Tensor (MultiArray). User
        /// can set input type to be Image. Image input type requires additional input parameters
        /// such as <c>bias</c> and <c>scale</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bias</c>: If the input type is an Image, you need to provide the bias vector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>scale</c>: If the input type is an Image, you need to provide a scale factor.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// CoreML <c>ClassifierConfig</c> parameters can be specified using <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OutputConfig.html">OutputConfig</a>
        /// <c>CompilerOptions</c>. CoreML converter supports Tensorflow and PyTorch models. CoreML
        /// conversion examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tensor type input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"DataInputConfig": {"input_1": {"shape": [[1,224,224,3], [1,160,160,3]], "default_shape":
        /// [1,224,224,3]}}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Tensor type input without input name (PyTorch):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"DataInputConfig": [{"shape": [[1,3,224,224], [1,3,160,160]], "default_shape":
        /// [1,3,224,224]}]</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Image type input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"DataInputConfig": {"input_1": {"shape": [[1,224,224,3], [1,160,160,3]], "default_shape":
        /// [1,224,224,3], "type": "Image", "bias": [-1,-1,-1], "scale": 0.007843137255}}</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"CompilerOptions": {"class_labels": "imagenet_labels_1000.txt"}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Image type input without input name (PyTorch):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"DataInputConfig": [{"shape": [[1,3,224,224], [1,3,160,160]], "default_shape":
        /// [1,3,224,224], "type": "Image", "bias": [-1,-1,-1], "scale": 0.007843137255}]</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"CompilerOptions": {"class_labels": "imagenet_labels_1000.txt"}</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Depending on the model format, <c>DataInputConfig</c> requires the following parameters
        /// for <c>ml_eia2</c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OutputConfig.html#sagemaker-Type-OutputConfig-TargetDevice">OutputConfig:TargetDevice</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For TensorFlow models saved in the SavedModel format, specify the input names from
        /// <c>signature_def_key</c> and the input model shapes for <c>DataInputConfig</c>. Specify
        /// the <c>signature_def_key</c> in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OutputConfig.html#sagemaker-Type-OutputConfig-CompilerOptions">
        /// <c>OutputConfig:CompilerOptions</c> </a> if the model does not use TensorFlow's default
        /// signature def key. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"DataInputConfig": {"inputs": [1, 224, 224, 3]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"CompilerOptions": {"signature_def_key": "serving_custom"}</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For TensorFlow models saved as a frozen graph, specify the input tensor names and
        /// shapes in <c>DataInputConfig</c> and the output tensor names for <c>output_names</c>
        /// in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OutputConfig.html#sagemaker-Type-OutputConfig-CompilerOptions">
        /// <c>OutputConfig:CompilerOptions</c> </a>. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"DataInputConfig": {"input_tensor:0": [1, 224, 224, 3]}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"CompilerOptions": {"output_names": ["output_tensor:0"]}</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
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
        /// Gets and sets the property Framework. 
        /// <para>
        /// Identifies the framework in which the model was trained. For example: TENSORFLOW.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Framework Framework
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
        /// Specifies the framework version to use. This API field is only supported for the MXNet,
        /// PyTorch, TensorFlow and TensorFlow Lite frameworks.
        /// </para>
        ///  
        /// <para>
        /// For information about framework versions supported for cloud targets and edge devices,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/neo-supported-cloud.html">Cloud
        /// Supported Instance Types and Frameworks</a> and <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/neo-supported-devices-edge-frameworks.html">Edge
        /// Supported Frameworks</a>.
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
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The S3 path where the model artifacts, which result from model training, are stored.
        /// This path must point to a single gzip compressed tar archive (.tar.gz suffix).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}