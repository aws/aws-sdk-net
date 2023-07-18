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
    /// Specifies the S3 location of ML model data to deploy.
    /// </summary>
    public partial class S3ModelDataSource
    {
        private ModelCompressionType _compressionType;
        private S3ModelDataType _s3DataType;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// Specifies how the ML model data is prepared.
        /// </para>
        ///  
        /// <para>
        /// If you choose <code>Gzip</code> and choose <code>S3Object</code> as the value of <code>S3DataType</code>,
        /// <code>S3Uri</code> identifies an object that is a gzip-compressed TAR archive. SageMaker
        /// will attempt to decompress and untar the object during model deployment.
        /// </para>
        ///  
        /// <para>
        /// If you choose <code>None</code> and chooose <code>S3Object</code> as the value of
        /// <code>S3DataType</code>, <code>S3Uri</code> identifies an object that represents an
        /// uncompressed ML model to deploy.
        /// </para>
        ///  
        /// <para>
        /// If you choose None and choose <code>S3Prefix</code> as the value of <code>S3DataType</code>,
        /// <code>S3Uri</code> identifies a key name prefix, under which all objects represents
        /// the uncompressed ML model to deploy.
        /// </para>
        ///  
        /// <para>
        /// If you choose None, then SageMaker will follow rules below when creating model data
        /// files under /opt/ml/model directory for use by your inference code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you choose <code>S3Object</code> as the value of <code>S3DataType</code>, then
        /// SageMaker will split the key of the S3 object referenced by <code>S3Uri</code> by
        /// slash (/), and use the last part as the filename of the file holding the content of
        /// the S3 object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you choose <code>S3Prefix</code> as the value of <code>S3DataType</code>, then
        /// for each S3 object under the key name pefix referenced by <code>S3Uri</code>, SageMaker
        /// will trim its key by the prefix, and use the remainder as the path (relative to <code>/opt/ml/model</code>)
        /// of the file holding the content of the S3 object. SageMaker will split the remainder
        /// by slash (/), using intermediate parts as directory names and the last part as filename
        /// of the file holding the content of the S3 object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use any of the following as file names or directory names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An empty or blank string
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A string which contains null bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A string longer than 255 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A single dot (<code>.</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A double dot (<code>..</code>)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Ambiguous file names will result in model deployment failure. For example, if your
        /// uncompressed ML model consists of two S3 objects <code>s3://mybucket/model/weights</code>
        /// and <code>s3://mybucket/model/weights/part1</code> and you specify <code>s3://mybucket/model/</code>
        /// as the value of <code>S3Uri</code> and <code>S3Prefix</code> as the value of <code>S3DataType</code>,
        /// then it will result in name clash between <code>/opt/ml/model/weights</code> (a regular
        /// file) and <code>/opt/ml/model/weights/</code> (a directory).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not organize the model artifacts in <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-folders.html">S3
        /// console using folders</a>. When you create a folder in S3 console, S3 creates a 0-byte
        /// object with a key set to the folder name you provide. They key of the 0-byte object
        /// ends with a slash (/) which violates SageMaker restrictions on model artifact file
        /// names, leading to model deployment failure. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelCompressionType CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataType. 
        /// <para>
        /// Specifies the type of ML model data to deploy.
        /// </para>
        ///  
        /// <para>
        /// If you choose <code>S3Prefix</code>, <code>S3Uri</code> identifies a key name prefix.
        /// SageMaker uses all objects that match the specified key name prefix as part of the
        /// ML model data to deploy. A valid key name prefix identified by <code>S3Uri</code>
        /// always ends with a forward slash (/).
        /// </para>
        ///  
        /// <para>
        /// If you choose <code>S3Object</code>, <code>S3Uri</code> identifies an object that
        /// is the ML model data to deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3ModelDataType S3DataType
        {
            get { return this._s3DataType; }
            set { this._s3DataType = value; }
        }

        // Check to see if S3DataType property is set
        internal bool IsSetS3DataType()
        {
            return this._s3DataType != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// Specifies the S3 path of ML model data to deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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