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
    /// Describes the Docker container for the model package.
    /// </summary>
    public partial class ModelPackageContainerDefinition
    {
        private string _containerHostname;
        private string _image;
        private string _imageDigest;
        private string _modelDataUrl;
        private string _productId;

        /// <summary>
        /// Gets and sets the property ContainerHostname. 
        /// <para>
        /// The DNS host name for the Docker container.
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
        /// Gets and sets the property Image. 
        /// <para>
        /// The Amazon EC2 Container Registry path where inference code is stored.
        /// </para>
        ///  
        /// <para>
        /// If you are using your own custom algorithm instead of an algorithm provided by Amazon
        /// SageMaker, the inference code must meet Amazon SageMaker requirements. Amazon SageMaker
        /// supports both <code>registry/repository[:tag]</code> and <code>registry/repository[@digest]</code>
        /// image path formats. For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html">Using
        /// Your Own Algorithms with Amazon SageMaker</a>.
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
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// An MD5 hash of the training algorithm that identifies the Docker image used for training.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The Amazon S3 path where the model artifacts, which result from model training, are
        /// stored. This path must point to a single <code>gzip</code> compressed tar archive
        /// (<code>.tar.gz</code> suffix).
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
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The ID of the model package.
        /// </para>
        /// </summary>
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