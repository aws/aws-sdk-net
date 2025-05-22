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
    /// Specifies the S3 location of ML model data to deploy.
    /// </summary>
    public partial class S3ModelDataSource
    {
        private ModelCompressionType _compressionType;
        private string _eTag;
        private InferenceHubAccessConfig _hubAccessConfig;
        private string _manifestEtag;
        private string _manifestS3Uri;
        private ModelAccessConfig _modelAccessConfig;
        private S3ModelDataType _s3DataType;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// Specifies how the ML model data is prepared.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>Gzip</c> and choose <c>S3Object</c> as the value of <c>S3DataType</c>,
        /// <c>S3Uri</c> identifies an object that is a gzip-compressed TAR archive. SageMaker
        /// will attempt to decompress and untar the object during model deployment.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>None</c> and chooose <c>S3Object</c> as the value of <c>S3DataType</c>,
        /// <c>S3Uri</c> identifies an object that represents an uncompressed ML model to deploy.
        /// </para>
        ///  
        /// <para>
        /// If you choose None and choose <c>S3Prefix</c> as the value of <c>S3DataType</c>, <c>S3Uri</c>
        /// identifies a key name prefix, under which all objects represents the uncompressed
        /// ML model to deploy.
        /// </para>
        ///  
        /// <para>
        /// If you choose None, then SageMaker will follow rules below when creating model data
        /// files under /opt/ml/model directory for use by your inference code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you choose <c>S3Object</c> as the value of <c>S3DataType</c>, then SageMaker will
        /// split the key of the S3 object referenced by <c>S3Uri</c> by slash (/), and use the
        /// last part as the filename of the file holding the content of the S3 object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you choose <c>S3Prefix</c> as the value of <c>S3DataType</c>, then for each S3
        /// object under the key name pefix referenced by <c>S3Uri</c>, SageMaker will trim its
        /// key by the prefix, and use the remainder as the path (relative to <c>/opt/ml/model</c>)
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
        /// A single dot (<c>.</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A double dot (<c>..</c>)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Ambiguous file names will result in model deployment failure. For example, if your
        /// uncompressed ML model consists of two S3 objects <c>s3://mybucket/model/weights</c>
        /// and <c>s3://mybucket/model/weights/part1</c> and you specify <c>s3://mybucket/model/</c>
        /// as the value of <c>S3Uri</c> and <c>S3Prefix</c> as the value of <c>S3DataType</c>,
        /// then it will result in name clash between <c>/opt/ml/model/weights</c> (a regular
        /// file) and <c>/opt/ml/model/weights/</c> (a directory).
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag associated with S3 URI.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property HubAccessConfig. 
        /// <para>
        /// Configuration information for hub access.
        /// </para>
        /// </summary>
        public InferenceHubAccessConfig HubAccessConfig
        {
            get { return this._hubAccessConfig; }
            set { this._hubAccessConfig = value; }
        }

        // Check to see if HubAccessConfig property is set
        internal bool IsSetHubAccessConfig()
        {
            return this._hubAccessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestEtag. 
        /// <para>
        /// The ETag associated with Manifest S3 URI.
        /// </para>
        /// </summary>
        public string ManifestEtag
        {
            get { return this._manifestEtag; }
            set { this._manifestEtag = value; }
        }

        // Check to see if ManifestEtag property is set
        internal bool IsSetManifestEtag()
        {
            return this._manifestEtag != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestS3Uri. 
        /// <para>
        /// The Amazon S3 URI of the manifest file. The manifest file is a CSV file that stores
        /// the artifact locations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ManifestS3Uri
        {
            get { return this._manifestS3Uri; }
            set { this._manifestS3Uri = value; }
        }

        // Check to see if ManifestS3Uri property is set
        internal bool IsSetManifestS3Uri()
        {
            return this._manifestS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property ModelAccessConfig. 
        /// <para>
        /// Specifies the access configuration file for the ML model. You can explicitly accept
        /// the model end-user license agreement (EULA) within the <c>ModelAccessConfig</c>. You
        /// are responsible for reviewing and complying with any applicable license terms and
        /// making sure they are acceptable for your use case before downloading or using a model.
        /// </para>
        /// </summary>
        public ModelAccessConfig ModelAccessConfig
        {
            get { return this._modelAccessConfig; }
            set { this._modelAccessConfig = value; }
        }

        // Check to see if ModelAccessConfig property is set
        internal bool IsSetModelAccessConfig()
        {
            return this._modelAccessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataType. 
        /// <para>
        /// Specifies the type of ML model data to deploy.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>S3Prefix</c>, <c>S3Uri</c> identifies a key name prefix. SageMaker
        /// uses all objects that match the specified key name prefix as part of the ML model
        /// data to deploy. A valid key name prefix identified by <c>S3Uri</c> always ends with
        /// a forward slash (/).
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>S3Object</c>, <c>S3Uri</c> identifies an object that is the ML model
        /// data to deploy.
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