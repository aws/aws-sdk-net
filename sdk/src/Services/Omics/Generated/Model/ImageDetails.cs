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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Information about the container image used for a task.
    /// </summary>
    public partial class ImageDetails
    {
        private string _image;
        private string _imageDigest;
        private string _sourceImage;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The URI of the container image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
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
        /// The container image digest. If the image URI was transformed, this will be the digest
        /// of the container image referenced by the transformed URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property SourceImage. 
        /// <para>
        /// URI of the source registry. If the URI is from a third-party registry, Amazon Web
        /// Services HealthOmics transforms the URI to the corresponding ECR path, using the pull-through
        /// cache mapping rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public string SourceImage
        {
            get { return this._sourceImage; }
            set { this._sourceImage = value; }
        }

        // Check to see if SourceImage property is set
        internal bool IsSetSourceImage()
        {
            return this._sourceImage != null;
        }

    }
}