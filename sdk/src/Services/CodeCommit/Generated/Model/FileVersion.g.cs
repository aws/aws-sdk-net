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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about a version of a file.
    /// </summary>
    public partial class FileVersion
    {
        /// <summary>
        /// Gets and sets the property BlobId. 
        /// <para>
        /// The blob ID of the object that represents the content of the file in this version.
        /// </para>
        /// </summary>
        public string BlobId { get; set; }

        /// <summary>
        /// Checks to see if the BlobId property is set.
        /// </summary>
        internal bool IsSetBlobId() => this.BlobId != null;

        /// <summary>
        /// Gets and sets the property Commit.
        /// </summary>
        public Commit Commit { get; set; }

        /// <summary>
        /// Checks to see if the Commit property is set.
        /// </summary>
        internal bool IsSetCommit() => this.Commit != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The name and path of the file at which this blob is indexed which contains the data
        /// for this version of the file. This value will vary between file versions if a file
        /// is renamed or if its path changes.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property RevisionChildren. 
        /// <para>
        /// An array of commit IDs that contain more recent versions of this file. If there are
        /// no additional versions of the file, this array will be empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RevisionChildren { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RevisionChildren property is set.
        /// </summary>
        internal bool IsSetRevisionChildren() => this.RevisionChildren != null && (this.RevisionChildren.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
