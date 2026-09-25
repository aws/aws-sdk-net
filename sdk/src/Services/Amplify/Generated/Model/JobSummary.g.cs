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
    /// Describes the summary for an execution job for an Amplify app.
    /// </summary>
    public partial class JobSummary
    {
        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        ///  The commit ID from a third-party repository provider for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
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
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// Checks to see if the CommitMessage property is set.
        /// </summary>
        internal bool IsSetCommitMessage() => this.CommitMessage != null;

        /// <summary>
        /// Gets and sets the property CommitTime. 
        /// <para>
        /// The commit date and time for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CommitTime { get; set; }

        /// <summary>
        /// Checks to see if the CommitTime property is set.
        /// </summary>
        internal bool IsSetCommitTime() => this.CommitTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end date and time for the job. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        ///  The unique ID for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        ///  The type for the job. If the value is <c>RELEASE</c>, the job was manually released
        /// from its source by using the <c>StartJob</c> API. This value is available only for
        /// apps that are connected to a repository.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>RETRY</c>, the job was manually retried using the <c>StartJob</c>
        /// API. If the value is <c>WEB_HOOK</c>, the job was automatically triggered by webhooks.
        /// If the value is <c>MANUAL</c>, the job is for a manually deployed app. Manually deployed
        /// apps are not connected to a Git repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// The source URL for the files to deploy. The source URL can be either an HTTP GET URL
        /// that is publicly accessible and downloads a single .zip file, or an Amazon S3 bucket
        /// and prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3000)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceUrl property is set.
        /// </summary>
        internal bool IsSetSourceUrl() => this.SourceUrl != null;

        /// <summary>
        /// Gets and sets the property SourceUrlType. 
        /// <para>
        /// The type of source specified by the <c>sourceURL</c>. If the value is <c>ZIP</c>,
        /// the source is a .zip file. If the value is <c>BUCKET_PREFIX</c>, the source is an
        /// Amazon S3 bucket and prefix. If no value is specified, the default is <c>ZIP</c>.
        /// </para>
        /// </summary>
        public SourceUrlType SourceUrlType { get; set; }

        /// <summary>
        /// Checks to see if the SourceUrlType property is set.
        /// </summary>
        internal bool IsSetSourceUrlType() => this.SourceUrlType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start date and time for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
