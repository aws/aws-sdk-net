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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _amiId;
        private string _bucket;
        private int? _progressPercentage;
        private string _s3objectKey;
        private string _storeTaskFailureReason;
        private string _storeTaskState;
        private DateTime? _taskStartTime;

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the AMI that is being stored.
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket that contains the stored AMI object.
        /// </para>
        /// </summary>
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The progress of the task as a percentage.
        /// </para>
        /// </summary>
        public int? ProgressPercentage
        {
            get { return this._progressPercentage; }
            set { this._progressPercentage = value; }
        }

        // Check to see if ProgressPercentage property is set
        internal bool IsSetProgressPercentage()
        {
            return this._progressPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3objectKey. 
        /// <para>
        /// The name of the stored AMI object in the bucket.
        /// </para>
        /// </summary>
        public string S3objectKey
        {
            get { return this._s3objectKey; }
            set { this._s3objectKey = value; }
        }

        // Check to see if S3objectKey property is set
        internal bool IsSetS3objectKey()
        {
            return this._s3objectKey != null;
        }

        /// <summary>
        /// Gets and sets the property StoreTaskFailureReason. 
        /// <para>
        /// If the tasks fails, the reason for the failure is returned. If the task succeeds,
        /// <c>null</c> is returned.
        /// </para>
        /// </summary>
        public string StoreTaskFailureReason
        {
            get { return this._storeTaskFailureReason; }
            set { this._storeTaskFailureReason = value; }
        }

        // Check to see if StoreTaskFailureReason property is set
        internal bool IsSetStoreTaskFailureReason()
        {
            return this._storeTaskFailureReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoreTaskState. 
        /// <para>
        /// The state of the store task (<c>InProgress</c>, <c>Completed</c>, or <c>Failed</c>).
        /// </para>
        /// </summary>
        public string StoreTaskState
        {
            get { return this._storeTaskState; }
            set { this._storeTaskState = value; }
        }

        // Check to see if StoreTaskState property is set
        internal bool IsSetStoreTaskState()
        {
            return this._storeTaskState != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time the task started.
        /// </para>
        /// </summary>
        public DateTime? TaskStartTime
        {
            get { return this._taskStartTime; }
            set { this._taskStartTime = value; }
        }

        // Check to see if TaskStartTime property is set
        internal bool IsSetTaskStartTime()
        {
            return this._taskStartTime.HasValue; 
        }

    }
}