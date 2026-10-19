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
    /// An object representing an artifact associated with a subject image.
    /// </summary>
    public partial class ImageReferrer
    {
        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// A map of annotations associated with the artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Annotations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Annotations property is set.
        /// </summary>
        internal bool IsSetAnnotations() => this.Annotations != null && (this.Annotations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ArtifactStatus. 
        /// <para>
        /// The status of the artifact. Valid values are <c>ACTIVE</c>, <c>ARCHIVED</c>, or <c>ACTIVATING</c>.
        /// </para>
        /// </summary>
        public ArtifactStatus ArtifactStatus { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactStatus property is set.
        /// </summary>
        internal bool IsSetArtifactStatus() => this.ArtifactStatus != null;

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// A string identifying the type of artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactType property is set.
        /// </summary>
        internal bool IsSetArtifactType() => this.ArtifactType != null;

        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        /// The digest of the artifact manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Digest { get; set; }

        /// <summary>
        /// Checks to see if the Digest property is set.
        /// </summary>
        internal bool IsSetDigest() => this.Digest != null;

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The media type of the artifact manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MediaType { get; set; }

        /// <summary>
        /// Checks to see if the MediaType property is set.
        /// </summary>
        internal bool IsSetMediaType() => this.MediaType != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size, in bytes, of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;
    }
}
