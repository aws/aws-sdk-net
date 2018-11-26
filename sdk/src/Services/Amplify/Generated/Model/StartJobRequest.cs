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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the StartJob operation.
    /// Starts a new job for a branch, part of an Amplify App.
    /// </summary>
    public partial class StartJobRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private string _branchName;
        private string _commitId;
        private string _commitMessage;
        private DateTime? _commitTime;
        private string _jobId;
        private string _jobReason;
        private JobType _jobType;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  Unique Id for an Amplify App. 
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        ///  Name for the branch, for the Job. 
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
        /// Gets and sets the property CommitId. 
        /// <para>
        ///  Commit Id from 3rd party repository provider for the Job. 
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
        /// Gets and sets the property CommitMessage. 
        /// <para>
        ///  Commit message from 3rd party repository provider for the Job. 
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
        /// Gets and sets the property CommitTime. 
        /// <para>
        ///  Commit date / time for the Job. 
        /// </para>
        /// </summary>
        public DateTime CommitTime
        {
            get { return this._commitTime.GetValueOrDefault(); }
            set { this._commitTime = value; }
        }

        // Check to see if CommitTime property is set
        internal bool IsSetCommitTime()
        {
            return this._commitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        ///  Unique Id for the Job. 
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobReason. 
        /// <para>
        ///  Reason for the Job. 
        /// </para>
        /// </summary>
        public string JobReason
        {
            get { return this._jobReason; }
            set { this._jobReason = value; }
        }

        // Check to see if JobReason property is set
        internal bool IsSetJobReason()
        {
            return this._jobReason != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        ///  Type for the Job. 
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

    }
}