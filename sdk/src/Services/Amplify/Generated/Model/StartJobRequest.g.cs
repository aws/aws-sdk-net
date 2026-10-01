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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the StartJob operation. Starts a new job for a branch
    /// of an Amplify app.
    /// </summary>
    public partial class StartJobRequest : AmazonAmplifyRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of the branch to use for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        ///  The commit ID from a third-party repository provider for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string CommitId { get; set; }

        /// <summary>
        /// Checks to see if the CommitId property is set.
        /// </summary>
        internal bool IsSetCommitId() => this.CommitId != null;

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        ///  The commit message from a third-party repository provider for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// Checks to see if the CommitMessage property is set.
        /// </summary>
        internal bool IsSetCommitMessage() => this.CommitMessage != null;

        /// <summary>
        /// Gets and sets the property CommitTime. 
        /// <para>
        ///  The commit date and time for the job. 
        /// </para>
        /// </summary>
        public DateTime? CommitTime { get; set; }

        /// <summary>
        /// Checks to see if the CommitTime property is set.
        /// </summary>
        internal bool IsSetCommitTime() => this.CommitTime.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique ID for an existing job. This is required if the value of <c>jobType</c>
        /// is <c>RETRY</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobReason. 
        /// <para>
        /// A descriptive reason for starting the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string JobReason { get; set; }

        /// <summary>
        /// Checks to see if the JobReason property is set.
        /// </summary>
        internal bool IsSetJobReason() => this.JobReason != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Describes the type for the job. The job type <c>RELEASE</c> starts a new job with
        /// the latest change from the specified branch. This value is available only for apps
        /// that are connected to a repository. 
        /// </para>
        ///  
        /// <para>
        /// The job type <c>RETRY</c> retries an existing job. If the job type value is <c>RETRY</c>,
        /// the <c>jobId</c> is also required. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;
    }
}
