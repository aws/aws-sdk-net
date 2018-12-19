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
    /// Describes the container, as part of model definition.
    /// </summary>
    public partial class ContainerDefinition
    {
        private string _containerHostname;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private string _image;
        private string _modelDataUrl;
        private string _modelPackageName;

        /// <summary>
        /// Gets and sets the property ContainerHostname. 
        /// <para>
        /// The DNS host name for the container after Amazon SageMaker deploys it.
        /// </para>
        /// </summary>
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
        /// The Amazon EC2 Container Registry (Amazon ECR) path where inference code is stored.
        /// If you are using your own custom algorithm instead of an algorithm provided by Amazon
        /// SageMaker, the inference code must meet Amazon SageMaker requirements. Amazon SageMaker
        /// supports both <code>registry/repository[:tag]</code> and <code>registry/repository[@digest]</code>
        /// image path formats. For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a> 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The S3 path where the model artifacts, which result from model training, are stored.
        /// This path must point to a single gzip compressed tar archive (.tar.gz suffix). 
        /// </para>
        ///  
        /// <para>
        /// If you provide a value for this parameter, Amazon SageMaker uses AWS Security Token
        /// Service to download model artifacts from the S3 path you provide. AWS STS is activated
        /// in your IAM user account by default. If you previously deactivated AWS STS for a region,
        /// you need to reactivate AWS STS for that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
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
        /// The name of the model package to use to create the model.
        /// </para>
        /// </summary>
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

    }
}