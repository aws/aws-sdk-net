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
    /// Returns information about a specific commit.
    /// </summary>
    public partial class Commit
    {
        private string _additionalData;
        private UserInfo _author;
        private string _commitId;
        private UserInfo _committer;
        private string _message;
        private List<string> _parents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _treeId;

        /// <summary>
        /// Gets and sets the property AdditionalData. 
        /// <para>
        /// Any other data associated with the specified commit.
        /// </para>
        /// </summary>
        public string AdditionalData
        {
            get { return this._additionalData; }
            set { this._additionalData = value; }
        }

        // Check to see if AdditionalData property is set
        internal bool IsSetAdditionalData()
        {
            return this._additionalData != null;
        }

        /// <summary>
        /// Gets and sets the property Author. 
        /// <para>
        /// Information about the author of the specified commit. Information includes the date
        /// in timestamp format with GMT offset, the name of the author, and the email address
        /// for the author, as configured in Git.
        /// </para>
        /// </summary>
        public UserInfo Author
        {
            get { return this._author; }
            set { this._author = value; }
        }

        // Check to see if Author property is set
        internal bool IsSetAuthor()
        {
            return this._author != null;
        }

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The full SHA ID of the specified commit. 
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
        /// Gets and sets the property Committer. 
        /// <para>
        /// Information about the person who committed the specified commit, also known as the
        /// committer. Information includes the date in timestamp format with GMT offset, the
        /// name of the committer, and the email address for the committer, as configured in Git.
        /// </para>
        ///  
        /// <para>
        /// For more information about the difference between an author and a committer in Git,
        /// see <a href="http://git-scm.com/book/ch2-3.html">Viewing the Commit History</a> in
        /// Pro Git by Scott Chacon and Ben Straub.
        /// </para>
        /// </summary>
        public UserInfo Committer
        {
            get { return this._committer; }
            set { this._committer = value; }
        }

        // Check to see if Committer property is set
        internal bool IsSetCommitter()
        {
            return this._committer != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The commit message associated with the specified commit.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Parents. 
        /// <para>
        /// A list of parent commits for the specified commit. Each parent commit ID is the full
        /// commit ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Parents
        {
            get { return this._parents; }
            set { this._parents = value; }
        }

        // Check to see if Parents property is set
        internal bool IsSetParents()
        {
            return this._parents != null && (this._parents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TreeId. 
        /// <para>
        /// Tree information for the specified commit.
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