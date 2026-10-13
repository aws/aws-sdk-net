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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// The details of a mailbox export job, including the user or resource ID associated
    /// with the mailbox and the S3 bucket that the mailbox contents are exported to.
    /// </summary>
    public partial class MailboxExportJob
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The mailbox export job description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1023)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The mailbox export job end timestamp.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the user or resource associated with the mailbox.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EstimatedProgress. 
        /// <para>
        /// The estimated progress of the mailbox export job, in percentage points.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? EstimatedProgress { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedProgress property is set.
        /// </summary>
        internal bool IsSetEstimatedProgress() => this.EstimatedProgress.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier of the mailbox export job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3Path. 
        /// <para>
        /// The path to the S3 bucket and file that the mailbox export job exports to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1023)]
        public string S3Path { get; set; }

        /// <summary>
        /// Checks to see if the S3Path property is set.
        /// </summary>
        internal bool IsSetS3Path() => this.S3Path != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The mailbox export job start timestamp.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the mailbox export job.
        /// </para>
        /// </summary>
        public MailboxExportJobState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
