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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The information about the AMI store task, including the progress of the task.
    /// </summary>
    public partial class StoreImageTaskResult
    {
        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the AMI that is being stored.
        /// </para>
        /// </summary>
        public string AmiId { get; set; }

        /// <summary>
        /// Checks to see if the AmiId property is set.
        /// </summary>
        internal bool IsSetAmiId() => this.AmiId != null;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket that contains the stored AMI object.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The progress of the task as a percentage.
        /// </para>
        /// </summary>
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercentage property is set.
        /// </summary>
        internal bool IsSetProgressPercentage() => this.ProgressPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property S3objectKey. 
        /// <para>
        /// The name of the stored AMI object in the bucket.
        /// </para>
        /// </summary>
        public string S3objectKey { get; set; }

        /// <summary>
        /// Checks to see if the S3objectKey property is set.
        /// </summary>
        internal bool IsSetS3objectKey() => this.S3objectKey != null;

        /// <summary>
        /// Gets and sets the property StoreTaskFailureReason. 
        /// <para>
        /// If the tasks fails, the reason for the failure is returned. If the task succeeds,
        /// <c>null</c> is returned.
        /// </para>
        /// </summary>
        public string StoreTaskFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the StoreTaskFailureReason property is set.
        /// </summary>
        internal bool IsSetStoreTaskFailureReason() => this.StoreTaskFailureReason != null;

        /// <summary>
        /// Gets and sets the property StoreTaskState. 
        /// <para>
        /// The state of the store task (<c>InProgress</c>, <c>Completed</c>, or <c>Failed</c>).
        /// </para>
        /// </summary>
        public string StoreTaskState { get; set; }

        /// <summary>
        /// Checks to see if the StoreTaskState property is set.
        /// </summary>
        internal bool IsSetStoreTaskState() => this.StoreTaskState != null;

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time the task started.
        /// </para>
        /// </summary>
        public DateTime? TaskStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartTime property is set.
        /// </summary>
        internal bool IsSetTaskStartTime() => this.TaskStartTime.HasValue;
    }
}
