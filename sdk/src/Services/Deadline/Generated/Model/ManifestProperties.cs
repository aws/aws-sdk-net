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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of the manifest that links a job's source information.
    /// </summary>
    public partial class ManifestProperties
    {
        private string _fileSystemLocationName;
        private string _inputManifestHash;
        private string _inputManifestPath;
        private List<string> _outputRelativeDirectories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _rootPath;
        private PathFormat _rootPathFormat;

        /// <summary>
        /// Gets and sets the property FileSystemLocationName. 
        /// <para>
        /// The file system location name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FileSystemLocationName
        {
            get { return this._fileSystemLocationName; }
            set { this._fileSystemLocationName = value; }
        }

        // Check to see if FileSystemLocationName property is set
        internal bool IsSetFileSystemLocationName()
        {
            return this._fileSystemLocationName != null;
        }

        /// <summary>
        /// Gets and sets the property InputManifestHash. 
        /// <para>
        /// The hash value of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InputManifestHash
        {
            get { return this._inputManifestHash; }
            set { this._inputManifestHash = value; }
        }

        // Check to see if InputManifestHash property is set
        internal bool IsSetInputManifestHash()
        {
            return this._inputManifestHash != null;
        }

        /// <summary>
        /// Gets and sets the property InputManifestPath. 
        /// <para>
        /// The file path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string InputManifestPath
        {
            get { return this._inputManifestPath; }
            set { this._inputManifestPath = value; }
        }

        // Check to see if InputManifestPath property is set
        internal bool IsSetInputManifestPath()
        {
            return this._inputManifestPath != null;
        }

        /// <summary>
        /// Gets and sets the property OutputRelativeDirectories. 
        /// <para>
        /// The file path relative to the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> OutputRelativeDirectories
        {
            get { return this._outputRelativeDirectories; }
            set { this._outputRelativeDirectories = value; }
        }

        // Check to see if OutputRelativeDirectories property is set
        internal bool IsSetOutputRelativeDirectories()
        {
            return this._outputRelativeDirectories != null && (this._outputRelativeDirectories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RootPath. 
        /// <para>
        /// The file's root path.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string RootPath
        {
            get { return this._rootPath; }
            set { this._rootPath = value; }
        }

        // Check to see if RootPath property is set
        internal bool IsSetRootPath()
        {
            return this._rootPath != null;
        }

        /// <summary>
        /// Gets and sets the property RootPathFormat. 
        /// <para>
        /// The format of the root path.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PathFormat RootPathFormat
        {
            get { return this._rootPathFormat; }
            set { this._rootPathFormat = value; }
        }

        // Check to see if RootPathFormat property is set
        internal bool IsSetRootPathFormat()
        {
            return this._rootPathFormat != null;
        }

    }
}