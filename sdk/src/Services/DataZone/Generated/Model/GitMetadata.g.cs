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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Git metadata for a notebook sync operation in Amazon SageMaker Unified Studio.
    /// Contains information about the Git repository, branch, and commit associated with
    /// the notebook.
    /// </summary>
    public partial class GitMetadata
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The name of the Git branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property CommitHash. 
        /// <para>
        /// The commit hash in the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CommitHash { get; set; }

        /// <summary>
        /// Checks to see if the CommitHash property is set.
        /// </summary>
        internal bool IsSetCommitHash() => this.CommitHash != null;

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        /// The commit message associated with the Git commit.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// Checks to see if the CommitMessage property is set.
        /// </summary>
        internal bool IsSetCommitMessage() => this.CommitMessage != null;

        /// <summary>
        /// Gets and sets the property CommittedAt. 
        /// <para>
        /// The timestamp of when the commit was made.
        /// </para>
        /// </summary>
        public DateTime? CommittedAt { get; set; }

        /// <summary>
        /// Checks to see if the CommittedAt property is set.
        /// </summary>
        internal bool IsSetCommittedAt() => this.CommittedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The identifier of the Git connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file in the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 512)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
