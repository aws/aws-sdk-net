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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
        private string _commitId;
        private List<FileMetadata> _filesAdded = AWSConfigs.InitializeCollections ? new List<FileMetadata>() : null;
        private List<FileMetadata> _filesDeleted = AWSConfigs.InitializeCollections ? new List<FileMetadata>() : null;
        private List<FileMetadata> _filesUpdated = AWSConfigs.InitializeCollections ? new List<FileMetadata>() : null;
        private string _treeId;

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full commit ID of the commit that contains your committed file changes.
        /// </para>
        /// </summary>
        public string CommitId
        {
            get { return this._commitId; }
            set { this._commitId = value; }
        }

        // Check to see if CommitId property is set
        internal bool IsSetCommitId()
        {
            return this._commitId != null;
        }

        /// <summary>
        /// Gets and sets the property FilesAdded. 
        /// <para>
        /// The files added as part of the committed file changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileMetadata> FilesAdded
        {
            get { return this._filesAdded; }
            set { this._filesAdded = value; }
        }

        // Check to see if FilesAdded property is set
        internal bool IsSetFilesAdded()
        {
            return this._filesAdded != null && (this._filesAdded.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilesDeleted. 
        /// <para>
        /// The files deleted as part of the committed file changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileMetadata> FilesDeleted
        {
            get { return this._filesDeleted; }
            set { this._filesDeleted = value; }
        }

        // Check to see if FilesDeleted property is set
        internal bool IsSetFilesDeleted()
        {
            return this._filesDeleted != null && (this._filesDeleted.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilesUpdated. 
        /// <para>
        /// The files updated as part of the commited file changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileMetadata> FilesUpdated
        {
            get { return this._filesUpdated; }
            set { this._filesUpdated = value; }
        }

        // Check to see if FilesUpdated property is set
        internal bool IsSetFilesUpdated()
        {
            return this._filesUpdated != null && (this._filesUpdated.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TreeId. 
        /// <para>
        /// The full SHA-1 pointer of the tree information for the commit that contains the commited
        /// file changes.
        /// </para>
        /// </summary>
        public string TreeId
        {
            get { return this._treeId; }
            set { this._treeId = value; }
        }

        // Check to see if TreeId property is set
        internal bool IsSetTreeId()
        {
            return this._treeId != null;
        }

    }
}