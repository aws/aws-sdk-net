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
    /// This is the response object from the GetFolder operation.
    /// </summary>
    public partial class GetFolderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full commit ID used as a reference for the returned version of the folder content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CommitId { get; set; }

        /// <summary>
        /// Checks to see if the CommitId property is set.
        /// </summary>
        internal bool IsSetCommitId() => this.CommitId != null;

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// The list of files in the specified folder, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<File> Files { get; set; } = AWSConfigs.InitializeCollections ? new List<File>() : null;

        /// <summary>
        /// Checks to see if the Files property is set.
        /// </summary>
        internal bool IsSetFiles() => this.Files != null && (this.Files.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FolderPath. 
        /// <para>
        /// The fully qualified path of the folder whose contents are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FolderPath { get; set; }

        /// <summary>
        /// Checks to see if the FolderPath property is set.
        /// </summary>
        internal bool IsSetFolderPath() => this.FolderPath != null;

        /// <summary>
        /// Gets and sets the property SubFolders. 
        /// <para>
        /// The list of folders that exist under the specified folder, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Folder> SubFolders { get; set; } = AWSConfigs.InitializeCollections ? new List<Folder>() : null;

        /// <summary>
        /// Checks to see if the SubFolders property is set.
        /// </summary>
        internal bool IsSetSubFolders() => this.SubFolders != null && (this.SubFolders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubModules. 
        /// <para>
        /// The list of submodules in the specified folder, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubModule> SubModules { get; set; } = AWSConfigs.InitializeCollections ? new List<SubModule>() : null;

        /// <summary>
        /// Checks to see if the SubModules property is set.
        /// </summary>
        internal bool IsSetSubModules() => this.SubModules != null && (this.SubModules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SymbolicLinks. 
        /// <para>
        /// The list of symbolic links to other files and folders in the specified folder, if
        /// any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SymbolicLink> SymbolicLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<SymbolicLink>() : null;

        /// <summary>
        /// Checks to see if the SymbolicLinks property is set.
        /// </summary>
        internal bool IsSetSymbolicLinks() => this.SymbolicLinks != null && (this.SymbolicLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TreeId. 
        /// <para>
        /// The full SHA-1 pointer of the tree information for the commit that contains the folder.
        /// </para>
        /// </summary>
        public string TreeId { get; set; }

        /// <summary>
        /// Checks to see if the TreeId property is set.
        /// </summary>
        internal bool IsSetTreeId() => this.TreeId != null;
    }
}
