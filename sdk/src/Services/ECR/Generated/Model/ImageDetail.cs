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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object that describes an image returned by a <a>DescribeImages</a> operation.
    /// </summary>
    public partial class ImageDetail
    {
        private string _imageDigest;
        private DateTime? _imagePushedAt;
        private long? _imageSizeInBytes;
        private List<string> _imageTags = new List<string>();
        private string _registryId;
        private string _repositoryName;

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
        /// Gets and sets the property ImagePushedAt. 
        /// <para>
        /// The date and time, expressed in standard JavaScript date format, at which the current
        /// image was pushed to the repository. 
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
        ///  <note> 
        /// <para>
        /// Beginning with Docker version 1.9, the Docker client compresses image layers before
        /// pushing them to a V2 Docker registry. The output of the <code>docker images</code>
        /// command shows the uncompressed image size, so it may return a larger image size than
        /// the image sizes returned by <a>DescribeImages</a>.
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

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The list of tags associated with this image.
        /// </para>
        /// </summary>
        public List<string> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && this._imageTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The AWS account ID associated with the registry to which this image belongs.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository to which this image belongs.
        /// </para>
        /// </summary>
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}