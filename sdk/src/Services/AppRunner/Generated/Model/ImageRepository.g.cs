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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes a source image repository.
    /// </summary>
    public partial class ImageRepository
    {
        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// Configuration for running the identified image.
        /// </para>
        /// </summary>
        public ImageConfiguration ImageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfiguration property is set.
        /// </summary>
        internal bool IsSetImageConfiguration() => this.ImageConfiguration != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ImageIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ImageIdentifier property is set.
        /// </summary>
        internal bool IsSetImageIdentifier() => this.ImageIdentifier != null;

        /// <summary>
        /// Gets and sets the property ImageRepositoryType. 
        /// <para>
        /// The type of the image repository. This reflects the repository provider and whether
        /// the repository is private or public.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageRepositoryType ImageRepositoryType { get; set; }

        /// <summary>
        /// Checks to see if the ImageRepositoryType property is set.
        /// </summary>
        internal bool IsSetImageRepositoryType() => this.ImageRepositoryType != null;
    }
}
