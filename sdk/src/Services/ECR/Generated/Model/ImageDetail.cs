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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object that describes an image returned by a <a>DescribeImages</a> operation.
    /// </summary>
    public partial class ImageDetail
    {
        private string _artifactMediaType;
        private string _imageDigest;
        private string _imageManifestMediaType;
        private DateTime? _imagePushedAt;
        private ImageScanFindingsSummary _imageScanFindingsSummary;
        private ImageScanStatus _imageScanStatus;
        private long? _imageSizeInBytes;
        private List<string> _imageTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastRecordedPullTime;
        private string _registryId;
        private string _repositoryName;

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
        /// The <c>sha256</c> digest of the image manifest.
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
        /// The date and time, expressed in standard JavaScript date format, at which the current
        /// image was pushed to the repository. 
        /// </para>
        /// </summary>
        public DateTime? ImagePushedAt
        {
            get { return this._imagePushedAt; }
            set { this._imagePushedAt = value; }
        }

        // Check to see if ImagePushedAt property is set
        internal bool IsSetImagePushedAt()
        {
            return this._imagePushedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageScanFindingsSummary. 
        /// <para>
        /// A summary of the last completed image scan.
        /// </para>
        /// </summary>
        public ImageScanFindingsSummary ImageScanFindingsSummary
        {
            get { return this._imageScanFindingsSummary; }
            set { this._imageScanFindingsSummary = value; }
        }

        // Check to see if ImageScanFindingsSummary property is set
        internal bool IsSetImageScanFindingsSummary()
        {
            return this._imageScanFindingsSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanStatus. 
        /// <para>
        /// The current state of the scan.
        /// </para>
        /// </summary>
        public ImageScanStatus ImageScanStatus
        {
            get { return this._imageScanStatus; }
            set { this._imageScanStatus = value; }
        }

        // Check to see if ImageScanStatus property is set
        internal bool IsSetImageScanStatus()
        {
            return this._imageScanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the image in the repository.
        /// </para>
        ///  
        /// <para>
        /// If the image is a manifest list, this will be the max size of all manifests in the
        /// list.
        /// </para>
        ///  <note> 
        /// <para>
        /// Starting with Docker version 1.9, the Docker client compresses image layers before
        /// pushing them to a V2 Docker registry. The output of the <c>docker images</c> command
        /// shows the uncompressed image size. Therefore, Docker might return a larger image than
        /// the image shown in the Amazon Web Services Management Console.
        /// </para>
        ///  </note>
        /// </summary>
        public long? ImageSizeInBytes
        {
            get { return this._imageSizeInBytes; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && (this._imageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastRecordedPullTime. 
        /// <para>
        /// The date and time, expressed in standard JavaScript date format, when Amazon ECR recorded
        /// the last image pull.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon ECR refreshes the last image pull timestamp at least once every 24 hours. For
        /// example, if you pull an image once a day then the <c>lastRecordedPullTime</c> timestamp
        /// will indicate the exact time that the image was last pulled. However, if you pull
        /// an image once an hour, because Amazon ECR refreshes the <c>lastRecordedPullTime</c>
        /// timestamp at least once every 24 hours, the result may not be the exact time that
        /// the image was last pulled.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? LastRecordedPullTime
        {
            get { return this._lastRecordedPullTime; }
            set { this._lastRecordedPullTime = value; }
        }

        // Check to see if LastRecordedPullTime property is set
        internal bool IsSetLastRecordedPullTime()
        {
            return this._lastRecordedPullTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry to which this image
        /// belongs.
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
        [AWSProperty(Min=2, Max=256)]
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