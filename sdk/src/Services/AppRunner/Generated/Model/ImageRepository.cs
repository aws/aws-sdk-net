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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes a source image repository.
    /// </summary>
    public partial class ImageRepository
    {
        private ImageConfiguration _imageConfiguration;
        private string _imageIdentifier;
        private ImageRepositoryType _imageRepositoryType;

        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// Configuration for running the identified image.
        /// </para>
        /// </summary>
        public ImageConfiguration ImageConfiguration
        {
            get { return this._imageConfiguration; }
            set { this._imageConfiguration = value; }
        }

        // Check to see if ImageConfiguration property is set
        internal bool IsSetImageConfiguration()
        {
            return this._imageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageIdentifier. 
        /// <para>
        /// The identifier of an image.
        /// </para>
        ///  
        /// <para>
        /// For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name.
        /// For the image name format, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/docker-pull-ecr-image.html">Pulling
        /// an image</a> in the <i>Amazon ECR User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ImageIdentifier
        {
            get { return this._imageIdentifier; }
            set { this._imageIdentifier = value; }
        }

        // Check to see if ImageIdentifier property is set
        internal bool IsSetImageIdentifier()
        {
            return this._imageIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ImageRepositoryType. 
        /// <para>
        /// The type of the image repository. This reflects the repository provider and whether
        /// the repository is private or public.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageRepositoryType ImageRepositoryType
        {
            get { return this._imageRepositoryType; }
            set { this._imageRepositoryType = value; }
        }

        // Check to see if ImageRepositoryType property is set
        internal bool IsSetImageRepositoryType()
        {
            return this._imageRepositoryType != null;
        }

    }
}