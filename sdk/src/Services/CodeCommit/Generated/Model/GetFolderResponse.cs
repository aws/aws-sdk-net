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
    /// This is the response object from the GetFolder operation.
    /// </summary>
    public partial class GetFolderResponse : AmazonWebServiceResponse
    {
        private string _commitId;
        private List<File> _files = AWSConfigs.InitializeCollections ? new List<File>() : null;
        private string _folderPath;
        private List<Folder> _subFolders = AWSConfigs.InitializeCollections ? new List<Folder>() : null;
        private List<SubModule> _subModules = AWSConfigs.InitializeCollections ? new List<SubModule>() : null;
        private List<SymbolicLink> _symbolicLinks = AWSConfigs.InitializeCollections ? new List<SymbolicLink>() : null;
        private string _treeId;

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full commit ID used as a reference for the returned version of the folder content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Files. 
        /// <para>
        /// The list of files in the specified folder, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<File> Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files != null && (this._files.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FolderPath. 
        /// <para>
        /// The fully qualified path of the folder whose contents are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FolderPath
        {
            get { return this._folderPath; }
            set { this._folderPath = value; }
        }

        // Check to see if FolderPath property is set
        internal bool IsSetFolderPath()
        {
            return this._folderPath != null;
        }

        /// <summary>
        /// Gets and sets the property SubFolders. 
        /// <para>
        /// The list of folders that exist under the specified folder, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Folder> SubFolders
        {
            get { return this._subFolders; }
            set { this._subFolders = value; }
        }

        // Check to see if SubFolders property is set
        internal bool IsSetSubFolders()
        {
            return this._subFolders != null && (this._subFolders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubModules. 
        /// <para>
        /// The list of submodules in the specified folder, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubModule> SubModules
        {
            get { return this._subModules; }
            set { this._subModules = value; }
        }

        // Check to see if SubModules property is set
        internal bool IsSetSubModules()
        {
            return this._subModules != null && (this._subModules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SymbolicLinks. 
        /// <para>
        /// The list of symbolic links to other files and folders in the specified folder, if
        /// any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SymbolicLink> SymbolicLinks
        {
            get { return this._symbolicLinks; }
            set { this._symbolicLinks = value; }
        }

        // Check to see if SymbolicLinks property is set
        internal bool IsSetSymbolicLinks()
        {
            return this._symbolicLinks != null && (this._symbolicLinks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TreeId. 
        /// <para>
        /// The full SHA-1 pointer of the tree information for the commit that contains the folder.
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