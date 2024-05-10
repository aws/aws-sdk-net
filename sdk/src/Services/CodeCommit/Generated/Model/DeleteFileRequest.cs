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
    /// Container for the parameters to the DeleteFile operation.
    /// Deletes a specified file from a specified branch. A commit is created on the branch
    /// that contains the revision. The file still exists in the commits earlier to the commit
    /// that contains the deletion.
    /// </summary>
    public partial class DeleteFileRequest : AmazonCodeCommitRequest
    {
        private string _branchName;
        private string _commitMessage;
        private string _email;
        private string _filePath;
        private bool? _keepEmptyFolders;
        private string _name;
        private string _parentCommitId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the branch where the commit that deletes the file is made.
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
        /// The commit message you want to include as part of deleting the file. Commit messages
        /// are limited to 256 KB. If no message is specified, a default message is used.
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
        /// The email address for the commit that deletes the file. If no email address is specified,
        /// the email address is left blank.
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
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The fully qualified path to the file that to be deleted, including the full name and
        /// extension of that file. For example, /examples/file.md is a fully qualified path to
        /// a file named file.md in a folder named examples.
        /// </para>
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
        /// Gets and sets the property KeepEmptyFolders. 
        /// <para>
        /// If a file is the only object in the folder or directory, specifies whether to delete
        /// the folder or directory that contains the file. By default, empty folders are deleted.
        /// This includes empty folders that are part of the directory structure. For example,
        /// if the path to a file is dir1/dir2/dir3/dir4, and dir2 and dir3 are empty, deleting
        /// the last file in dir4 also deletes the empty folders dir4, dir3, and dir2.
        /// </para>
        /// </summary>
        public bool? KeepEmptyFolders
        {
            get { return this._keepEmptyFolders; }
            set { this._keepEmptyFolders = value; }
        }

        // Check to see if KeepEmptyFolders property is set
        internal bool IsSetKeepEmptyFolders()
        {
            return this._keepEmptyFolders.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the author of the commit that deletes the file. If no name is specified,
        /// the user's ARN is used as the author name and committer name.
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
        /// The ID of the commit that is the tip of the branch where you want to create the commit
        /// that deletes the file. This must be the HEAD commit for the branch. The commit that
        /// deletes the file is created from this commit ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the repository that contains the file to delete.
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