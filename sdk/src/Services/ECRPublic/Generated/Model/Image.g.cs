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
    /// An object that represents an Amazon ECR image.
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// An object that contains the image tag and image digest associated with an image.
        /// </para>
        /// </summary>
        public ImageIdentifier ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ImageManifest. 
        /// <para>
        /// The image manifest that's associated with the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4194304)]
        public string ImageManifest { get; set; }

        /// <summary>
        /// Checks to see if the ImageManifest property is set.
        /// </summary>
        internal bool IsSetImageManifest() => this.ImageManifest != null;

        /// <summary>
        /// Gets and sets the property ImageManifestMediaType. 
        /// <para>
        /// The manifest media type of the image.
        /// </para>
        /// </summary>
        public string ImageManifestMediaType { get; set; }

        /// <summary>
        /// Checks to see if the ImageManifestMediaType property is set.
        /// </summary>
        internal bool IsSetImageManifestMediaType() => this.ImageManifestMediaType != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the registry containing
        /// the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that's associated with the image.
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
