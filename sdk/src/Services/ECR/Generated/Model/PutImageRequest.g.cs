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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the PutImage operation. Creates or updates the image
    /// manifest and tags associated with an image. <para> When an image is pushed and all
    /// new image layers have been uploaded, the PutImage API is called once to create or
    /// update the image manifest and the tags associated with the image. </para> <note> <para>
    /// This operation is used by the Amazon ECR proxy and is not generally used by customers
    /// for pulling and pushing images. In most cases, you should use the <c>docker</c> CLI
    /// to pull, tag, and push images. </para> </note>
    /// </summary>
    public partial class PutImageRequest : AmazonECRRequest
    {
        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The image digest of the image manifest corresponding to the image.
        /// </para>
        /// </summary>
        public string ImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ImageDigest property is set.
        /// </summary>
        internal bool IsSetImageDigest() => this.ImageDigest != null;

        /// <summary>
        /// Gets and sets the property ImageManifest. 
        /// <para>
        /// The image manifest corresponding to the image to be uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4194304)]
        public string ImageManifest { get; set; }

        /// <summary>
        /// Checks to see if the ImageManifest property is set.
        /// </summary>
        internal bool IsSetImageManifest() => this.ImageManifest != null;

        /// <summary>
        /// Gets and sets the property ImageManifestMediaType. 
        /// <para>
        /// The media type of the image manifest. If you push an image manifest that does not
        /// contain the <c>mediaType</c> field, you must specify the <c>imageManifestMediaType</c>
        /// in the request.
        /// </para>
        /// </summary>
        public string ImageManifestMediaType { get; set; }

        /// <summary>
        /// Checks to see if the ImageManifestMediaType property is set.
        /// </summary>
        internal bool IsSetImageManifestMediaType() => this.ImageManifestMediaType != null;

        /// <summary>
        /// Gets and sets the property ImageTag. 
        /// <para>
        /// The tag to associate with the image. This parameter is optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string ImageTag { get; set; }

        /// <summary>
        /// Checks to see if the ImageTag property is set.
        /// </summary>
        internal bool IsSetImageTag() => this.ImageTag != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the registry that contains the
        /// repository in which to put the image. If you do not specify a registry, the default
        /// registry is assumed.
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
        /// The name of the repository in which to put the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
