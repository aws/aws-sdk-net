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
    /// Container for the parameters to the PutFile operation.
    /// Adds or updates a file in a branch in an CodeCommit repository, and generates a commit
    /// for the addition in the specified branch.
    /// </summary>
    public partial class PutFileRequest : AmazonCodeCommitRequest
    {
        private string _branchName;
        private string _commitMessage;
        private string _email;
        private MemoryStream _fileContent;
        private FileModeTypeEnum _fileMode;
        private string _filePath;
        private string _name;
        private string _parentCommitId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the branch where you want to add or update the file. If this is an empty
        /// repository, this branch is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// A message about why this file was added or updated. Although it is optional, a message
        /// makes the commit history for your repository more useful.
        /// </para>
        /// </summary>
        public string CommitMessage
        {
            get { return this._commitMessage; }
            set { this._commitMessage = value; }
        }

        // Check to see if CommitMessage property is set
        internal bool IsSetCommitMessage()
        {
            return this._commitMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// An email address for the person adding or updating the file.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property FileContent. 
        /// <para>
        /// The content of the file, in binary object format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=6291456)]
        public MemoryStream FileContent
        {
            get { return this._fileContent; }
            set { this._fileContent = value; }
        }

        // Check to see if FileContent property is set
        internal bool IsSetFileContent()
        {
            return this._fileContent != null;
        }

        /// <summary>
        /// Gets and sets the property FileMode. 
        /// <para>
        /// The file mode permissions of the blob. Valid file mode permissions are listed here.
        /// </para>
        /// </summary>
        public FileModeTypeEnum FileMode
        {
            get { return this._fileMode; }
            set { this._fileMode = value; }
        }

        // Check to see if FileMode property is set
        internal bool IsSetFileMode()
        {
            return this._fileMode != null;
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The name of the file you want to add or update, including the relative path to the
        /// file in the repository.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the path does not currently exist in the repository, the path is created as part
        /// of adding the file.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the person adding or updating the file. Although it is optional, a name
        /// makes the commit history for your repository more useful.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParentCommitId. 
        /// <para>
        /// The full commit ID of the head commit in the branch where you want to add or update
        /// the file. If this is an empty repository, no commit ID is required. If this is not
        /// an empty repository, a commit ID is required. 
        /// </para>
        ///  
        /// <para>
        /// The commit ID must match the ID of the head commit at the time of the operation. Otherwise,
        /// an error occurs, and the file is not added or updated.
        /// </para>
        /// </summary>
        public string ParentCommitId
        {
            get { return this._parentCommitId; }
            set { this._parentCommitId = value; }
        }

        // Check to see if ParentCommitId property is set
        internal bool IsSetParentCommitId()
        {
            return this._parentCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you want to add or update the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}