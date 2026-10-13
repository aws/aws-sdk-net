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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// An object that describes an image that's returned by a <a>DescribeImages</a> operation.
    /// </summary>
    public partial class ImageDetail
    {
        /// <summary>
        /// Gets and sets the property ArtifactMediaType. 
        /// <para>
        /// The artifact media type of the image.
        /// </para>
        /// </summary>
        public string ArtifactMediaType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactMediaType property is set.
        /// </summary>
        internal bool IsSetArtifactMediaType() => this.ArtifactMediaType != null;

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The <c>sha256</c> digest of the image manifest.
        /// </para>
        /// </summary>
        public string ImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ImageDigest property is set.
        /// </summary>
        internal bool IsSetImageDigest() => this.ImageDigest != null;

        /// <summary>
        /// Gets and sets the property ImageManifestMediaType. 
        /// <para>
        /// The media type of the image manifest.
        /// </para>
        /// </summary>
        public string ImageManifestMediaType { get; set; }

        /// <summary>
        /// Checks to see if the ImageManifestMediaType property is set.
        /// </summary>
        internal bool IsSetImageManifestMediaType() => this.ImageManifestMediaType != null;

        /// <summary>
        /// Gets and sets the property ImagePushedAt. 
        /// <para>
        /// The date and time, expressed in standard JavaScript date format, that the current
        /// image was pushed to the repository at. 
        /// </para>
        /// </summary>
        public DateTime? ImagePushedAt { get; set; }

        /// <summary>
        /// Checks to see if the ImagePushedAt property is set.
        /// </summary>
        internal bool IsSetImagePushedAt() => this.ImagePushedAt.HasValue;

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
        /// pushing them to a V2 Docker registry. The output of the <c>docker images</c> command
        /// shows the uncompressed image size, so it might return a larger image size than the
        /// image sizes that are returned by <a>DescribeImages</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public long? ImageSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the ImageSizeInBytes property is set.
        /// </summary>
        internal bool IsSetImageSizeInBytes() => this.ImageSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The list of tags that's associated with this image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageTags property is set.
        /// </summary>
        internal bool IsSetImageTags() => this.ImageTags != null && (this.ImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the public registry where
        /// this image belongs.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where this image belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 205)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
