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
    /// An object representing an artifact associated with a subject image.
    /// </summary>
    public partial class ImageReferrer
    {
        private Dictionary<string, string> _annotations = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ArtifactStatus _artifactStatus;
        private string _artifactType;
        private string _digest;
        private string _mediaType;
        private long? _size;

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// A map of annotations associated with the artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null && (this._annotations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ArtifactStatus. 
        /// <para>
        /// The status of the artifact. Valid values are <c>ACTIVE</c>, <c>ARCHIVED</c>, or <c>ACTIVATING</c>.
        /// </para>
        /// </summary>
        public ArtifactStatus ArtifactStatus
        {
            get { return this._artifactStatus; }
            set { this._artifactStatus = value; }
        }

        // Check to see if ArtifactStatus property is set
        internal bool IsSetArtifactStatus()
        {
            return this._artifactStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// A string identifying the type of artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ArtifactType
        {
            get { return this._artifactType; }
            set { this._artifactType = value; }
        }

        // Check to see if ArtifactType property is set
        internal bool IsSetArtifactType()
        {
            return this._artifactType != null;
        }

        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        /// The digest of the artifact manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Digest
        {
            get { return this._digest; }
            set { this._digest = value; }
        }

        // Check to see if Digest property is set
        internal bool IsSetDigest()
        {
            return this._digest != null;
        }

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The media type of the artifact manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MediaType
        {
            get { return this._mediaType; }
            set { this._mediaType = value; }
        }

        // Check to see if MediaType property is set
        internal bool IsSetMediaType()
        {
            return this._mediaType != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size, in bytes, of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}