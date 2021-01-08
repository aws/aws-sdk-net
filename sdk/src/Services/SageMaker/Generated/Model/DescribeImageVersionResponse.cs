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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeImageVersion operation.
    /// </summary>
    public partial class DescribeImageVersionResponse : AmazonWebServiceResponse
    {
        private string _baseImage;
        private string _containerImage;
        private DateTime? _creationTime;
        private string _failureReason;
        private string _imageArn;
        private string _imageVersionArn;
        private ImageVersionStatus _imageVersionStatus;
        private DateTime? _lastModifiedTime;
        private int? _version;

        /// <summary>
        /// Gets and sets the property BaseImage. 
        /// <para>
        /// The registry path of the container image on which this image version is based.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BaseImage
        {
            get { return this._baseImage; }
            set { this._baseImage = value; }
        }

        // Check to see if BaseImage property is set
        internal bool IsSetBaseImage()
        {
            return this._baseImage != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerImage. 
        /// <para>
        /// The registry path of the container image that contains this image version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ContainerImage
        {
            get { return this._containerImage; }
            set { this._containerImage = value; }
        }

        // Check to see if ContainerImage property is set
        internal bool IsSetContainerImage()
        {
            return this._containerImage != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the version was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// When a create or delete operation fails, the reason for the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image the version is based on.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersionArn. 
        /// <para>
        /// The ARN of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ImageVersionArn
        {
            get { return this._imageVersionArn; }
            set { this._imageVersionArn = value; }
        }

        // Check to see if ImageVersionArn property is set
        internal bool IsSetImageVersionArn()
        {
            return this._imageVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersionStatus. 
        /// <para>
        /// The status of the version.
        /// </para>
        /// </summary>
        public ImageVersionStatus ImageVersionStatus
        {
            get { return this._imageVersionStatus; }
            set { this._imageVersionStatus = value; }
        }

        // Check to see if ImageVersionStatus property is set
        internal bool IsSetImageVersionStatus()
        {
            return this._imageVersionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the version was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}