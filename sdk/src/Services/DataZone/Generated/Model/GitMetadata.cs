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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Git metadata for a notebook sync operation in Amazon SageMaker Unified Studio.
    /// Contains information about the Git repository, branch, and commit associated with
    /// the notebook.
    /// </summary>
    public partial class GitMetadata
    {
        private string _branch;
        private string _commitHash;
        private string _commitMessage;
        private DateTime? _committedAt;
        private string _connectionId;
        private string _fileName;
        private string _repository;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The name of the Git branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property CommitHash. 
        /// <para>
        /// The commit hash in the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CommitHash
        {
            get { return this._commitHash; }
            set { this._commitHash = value; }
        }

        // Check to see if CommitHash property is set
        internal bool IsSetCommitHash()
        {
            return this._commitHash != null;
        }

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// The commit message associated with the Git commit.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property CommittedAt. 
        /// <para>
        /// The timestamp of when the commit was made.
        /// </para>
        /// </summary>
        public DateTime? CommittedAt
        {
            get { return this._committedAt; }
            set { this._committedAt = value; }
        }

        // Check to see if CommittedAt property is set
        internal bool IsSetCommittedAt()
        {
            return this._committedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The identifier of the Git connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file in the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=512)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

    }
}