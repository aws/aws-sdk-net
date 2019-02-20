/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCommit operation.
    /// Creates a commit for a repository on the tip of a specified branch.
    /// </summary>
    public partial class CreateCommitRequest : AmazonCodeCommitRequest
    {
        private string _authorName;
        private string _branchName;
        private string _commitMessage;
        private List<DeleteFileEntry> _deleteFiles = new List<DeleteFileEntry>();
        private string _email;
        private bool? _keepEmptyFolders;
        private string _parentCommitId;
        private List<PutFileEntry> _putFiles = new List<PutFileEntry>();
        private string _repositoryName;
        private List<SetFileModeEntry> _setFileModes = new List<SetFileModeEntry>();

        /// <summary>
        /// Gets and sets the property AuthorName. 
        /// <para>
        /// The name of the author who created the commit. This information will be used as both
        /// the author and committer for the commit.
        /// </para>
        /// </summary>
        public string AuthorName
        {
            get { return this._authorName; }
            set { this._authorName = value; }
        }

        // Check to see if AuthorName property is set
        internal bool IsSetAuthorName()
        {
            return this._authorName != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the branch where you will create the commit.
        /// </para>
        /// </summary>
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
        /// The commit message you want to include as part of creating the commit. Commit messages
        /// are limited to 256 KB. If no message is specified, a default message will be used.
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
        /// Gets and sets the property DeleteFiles. 
        /// <para>
        /// The files to delete in this commit. These files will still exist in prior commits.
        /// </para>
        /// </summary>
        public List<DeleteFileEntry> DeleteFiles
        {
            get { return this._deleteFiles; }
            set { this._deleteFiles = value; }
        }

        // Check to see if DeleteFiles property is set
        internal bool IsSetDeleteFiles()
        {
            return this._deleteFiles != null && this._deleteFiles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the person who created the commit.
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
        /// Gets and sets the property KeepEmptyFolders. 
        /// <para>
        /// If the commit contains deletions, whether to keep a folder or folder structure if
        /// the changes leave the folders empty. If this is specified as true, a .gitkeep file
        /// will be created for empty folders.
        /// </para>
        /// </summary>
        public bool KeepEmptyFolders
        {
            get { return this._keepEmptyFolders.GetValueOrDefault(); }
            set { this._keepEmptyFolders = value; }
        }

        // Check to see if KeepEmptyFolders property is set
        internal bool IsSetKeepEmptyFolders()
        {
            return this._keepEmptyFolders.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentCommitId. 
        /// <para>
        /// The ID of the commit that is the parent of the commit you will create. If this is
        /// an empty repository, this is not required.
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
        /// Gets and sets the property PutFiles. 
        /// <para>
        /// The files to add or update in this commit.
        /// </para>
        /// </summary>
        public List<PutFileEntry> PutFiles
        {
            get { return this._putFiles; }
            set { this._putFiles = value; }
        }

        // Check to see if PutFiles property is set
        internal bool IsSetPutFiles()
        {
            return this._putFiles != null && this._putFiles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you will create the commit.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SetFileModes. 
        /// <para>
        /// The file modes to update for files in this commit.
        /// </para>
        /// </summary>
        public List<SetFileModeEntry> SetFileModes
        {
            get { return this._setFileModes; }
            set { this._setFileModes = value; }
        }

        // Check to see if SetFileModes property is set
        internal bool IsSetSetFileModes()
        {
            return this._setFileModes != null && this._setFileModes.Count > 0; 
        }

    }
}