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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// An object that describes the image tag details that are returned by a <a>DescribeImageTags</a>
    /// action.
    /// </summary>
    public partial class ReferencedImageDetail
    {
        private string _artifactMediaType;
        private string _imageDigest;
        private string _imageManifestMediaType;
        private DateTime? _imagePushedAt;
        private long? _imageSizeInBytes;

        /// <summary>
        /// Gets and sets the property ArtifactMediaType. 
        /// <para>
        /// The artifact media type of the image.
        /// </para>
        /// </summary>
        public string ArtifactMediaType
        {
            get { return this._artifactMediaType; }
            set { this._artifactMediaType = value; }
        }

        // Check to see if ArtifactMediaType property is set
        internal bool IsSetArtifactMediaType()
        {
            return this._artifactMediaType != null;
        }

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The <code>sha256</code> digest of the image manifest.
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
        /// Gets and sets the property ImageManifestMediaType. 
        /// <para>
        /// The media type of the image manifest.
        /// </para>
        /// </summary>
        public string ImageManifestMediaType
        {
            get { return this._imageManifestMediaType; }
            set { this._imageManifestMediaType = value; }
        }

        // Check to see if ImageManifestMediaType property is set
        internal bool IsSetImageManifestMediaType()
        {
            return this._imageManifestMediaType != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePushedAt. 
        /// <para>
        /// The date and time, expressed in standard JavaScript date format, which the current
        /// image tag was pushed to the repository at.
        /// </para>
        /// </summary>
        public DateTime ImagePushedAt
        {
            get { return this._imagePushedAt.GetValueOrDefault(); }
            set { this._imagePushedAt = value; }
        }

        // Check to see if ImagePushedAt property is set
        internal bool IsSetImagePushedAt()
        {
            return this._imagePushedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the image in the repository.
        /// </para>
        ///  
        /// <para>
        /// If the image is a manifest list, this is the max size of all manifests in the list.
        /// </para>
        ///  <note> 
        /// <para>
        /// Beginning with Docker version 1.9, the Docker client compresses image layers before
        /// pushing them to a V2 Docker registry. The output of the <code>docker images</code>
        /// command shows the uncompressed image size, so it might return a larger image size
        /// than the image sizes that are returned by <a>DescribeImages</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long ImageSizeInBytes
        {
            get { return this._imageSizeInBytes.GetValueOrDefault(); }
            set { this._imageSizeInBytes = value; }
        }

        // Check to see if ImageSizeInBytes property is set
        internal bool IsSetImageSizeInBytes()
        {
            return this._imageSizeInBytes.HasValue; 
        }

    }
}