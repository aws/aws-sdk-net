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
    /// This is the response object from the CreateCommit operation.
    /// </summary>
    public partial class CreateCommitResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full commit ID of the commit that contains your committed file changes.
        /// </para>
        /// </summary>
        public string CommitId { get; set; }

        /// <summary>
        /// Checks to see if the CommitId property is set.
        /// </summary>
        internal bool IsSetCommitId() => this.CommitId != null;

        /// <summary>
        /// Gets and sets the property FilesAdded. 
        /// <para>
        /// The files added as part of the committed file changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileMetadata> FilesAdded { get; set; } = AWSConfigs.InitializeCollections ? new List<FileMetadata>() : null;

        /// <summary>
        /// Checks to see if the FilesAdded property is set.
        /// </summary>
        internal bool IsSetFilesAdded() => this.FilesAdded != null && (this.FilesAdded.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilesDeleted. 
        /// <para>
        /// The files deleted as part of the committed file changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileMetadata> FilesDeleted { get; set; } = AWSConfigs.InitializeCollections ? new List<FileMetadata>() : null;

        /// <summary>
        /// Checks to see if the FilesDeleted property is set.
        /// </summary>
        internal bool IsSetFilesDeleted() => this.FilesDeleted != null && (this.FilesDeleted.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilesUpdated. 
        /// <para>
        /// The files updated as part of the commited file changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileMetadata> FilesUpdated { get; set; } = AWSConfigs.InitializeCollections ? new List<FileMetadata>() : null;

        /// <summary>
        /// Checks to see if the FilesUpdated property is set.
        /// </summary>
        internal bool IsSetFilesUpdated() => this.FilesUpdated != null && (this.FilesUpdated.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TreeId. 
        /// <para>
        /// The full SHA-1 pointer of the tree information for the commit that contains the commited
        /// file changes.
        /// </para>
        /// </summary>
        public string TreeId { get; set; }

        /// <summary>
        /// Checks to see if the TreeId property is set.
        /// </summary>
        internal bool IsSetTreeId() => this.TreeId != null;
    }
}
