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
    /// Contains information about the location of input model artifacts, the name and shape
    /// of the expected data inputs, and the framework in which the model was trained.
    /// </summary>
    public partial class InputConfig
    {
        private string _dataInputConfig;
        private Framework _framework;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property DataInputConfig. 
        /// <para>
        /// Specifies the name and shape of the expected data inputs for your trained model with
        /// a JSON dictionary form. The data inputs are <a>InputConfig$Framework</a> specific.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TensorFlow</code>: You must specify the name and shape (NHWC format) of the
        /// expected data inputs using a dictionary format for your trained model. The dictionary
        /// formats required for the console and CLI are different.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Examples for one input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <code>{"input":[1,1024,1024,3]}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <code>{\"input\":[1,1024,1024,3]}</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Examples for two inputs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <code>{"data1": [1,28,28,1], "data2":[1,28,28,1]}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <code>{\"data1\": [1,28,28,1], \"data2\":[1,28,28,1]}</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <code>MXNET/ONNX</code>: You must specify the name and shape (NCHW format) of the
        /// expected data inputs in order using a dictionary format for your trained model. The
        /// dictionary formats required for the console and CLI are different.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Examples for one input:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <code>{"data":[1,3,1024,1024]}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <code>{\"data\":[1,3,1024,1024]}</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Examples for two inputs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <code>{"var1": [1,1,28,28], "var2":[1,1,28,28]} </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <code>{\"var1\": [1,1,28,28], \"var2\":[1,1,28,28]}</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <code>PyTorch</code>: You can either specify the name and shape (NCHW format) of
        /// expected data inputs in order using a dictionary format for your trained model or
        /// you can specify the shape only using a list format. The dictionary formats required
        /// for the console and CLI are different. The list formats for the console and CLI are
        /// the same.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Examples for one input in dictionary format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <code>{"input0":[1,3,224,224]}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <code>{\"input0\":[1,3,224,224]}</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example for one input in list format: <code>[[1,3,224,224]]</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Examples for two inputs in dictionary format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If using the console, <code>{"input0":[1,3,224,224], "input1":[1,3,224,224]}</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using the CLI, <code>{\"input0\":[1,3,224,224], \"input1\":[1,3,224,224]} </code>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example for two inputs in list format: <code>[[1,3,224,224], [1,3,224,224]]</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>XGBOOST</code>: input data name and shape are not needed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The S3 path where the model artifacts, which result from model training, are stored.
        /// This path must point to a single gzip compressed tar archive (.tar.gz suffix).
        /// </para>
        /// </summary>
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