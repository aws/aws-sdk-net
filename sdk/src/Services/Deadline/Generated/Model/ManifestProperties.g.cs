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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of the manifest that links a job's source information.
    /// </summary>
    public partial class ManifestProperties
    {
        /// <summary>
        /// Gets and sets the property FileSystemLocationName. The file system location name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FileSystemLocationName { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemLocationName property is set.
        /// </summary>
        internal bool IsSetFileSystemLocationName() => this.FileSystemLocationName != null;

        /// <summary>
        /// Gets and sets the property InputManifestHash. The hash value of the file.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InputManifestHash { get; set; }

        /// <summary>
        /// Checks to see if the InputManifestHash property is set.
        /// </summary>
        internal bool IsSetInputManifestHash() => this.InputManifestHash != null;

        /// <summary>
        /// Gets and sets the property InputManifestPath. The file path.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string InputManifestPath { get; set; }

        /// <summary>
        /// Checks to see if the InputManifestPath property is set.
        /// </summary>
        internal bool IsSetInputManifestPath() => this.InputManifestPath != null;

        /// <summary>
        /// Gets and sets the property OutputRelativeDirectories. The file path relative to the
        /// directory.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> OutputRelativeDirectories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputRelativeDirectories property is set.
        /// </summary>
        internal bool IsSetOutputRelativeDirectories() => this.OutputRelativeDirectories != null && (this.OutputRelativeDirectories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RootPath. The file's root path.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string RootPath { get; set; }

        /// <summary>
        /// Checks to see if the RootPath property is set.
        /// </summary>
        internal bool IsSetRootPath() => this.RootPath != null;

        /// <summary>
        /// Gets and sets the property RootPathFormat. The format of the root path.
        /// </summary>
        [AWSProperty(Required = true)]
        public PathFormat RootPathFormat { get; set; }

        /// <summary>
        /// Checks to see if the RootPathFormat property is set.
        /// </summary>
        internal bool IsSetRootPathFormat() => this.RootPathFormat != null;
    }
}
