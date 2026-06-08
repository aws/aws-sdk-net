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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Represents a single file within an asset, including its path, content, version, and
    /// timestamps.
    /// </summary>
    public partial class AssetFile
    {
        private AssetFileBody _content;
        private DateTime? _createdAt;
        private Amazon.Runtime.Documents.Document _metadata;
        private string _path;
        private DateTime? _updatedAt;
        private int? _version;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of this file
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetFileBody Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this file was created
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for this file
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return !this._metadata.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of this file within the asset
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when this file was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The asset version this file belongs to
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}