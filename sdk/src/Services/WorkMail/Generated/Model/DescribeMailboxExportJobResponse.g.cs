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
    /// This is the response object from the DescribeMailboxExportJob operation.
    /// </summary>
    public partial class DescribeMailboxExportJobResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information for failed mailbox export jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

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
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the symmetric AWS Key Management Service (AWS KMS)
        /// key that encrypts the exported mailbox content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that grants write permission
        /// to the Amazon Simple Storage Service (Amazon S3) bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

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
        /// The path to the S3 bucket and file that the mailbox export job is exporting to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1023)]
        public string S3Path { get; set; }

        /// <summary>
        /// Checks to see if the S3Path property is set.
        /// </summary>
        internal bool IsSetS3Path() => this.S3Path != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The S3 bucket prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1023)]
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;

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
