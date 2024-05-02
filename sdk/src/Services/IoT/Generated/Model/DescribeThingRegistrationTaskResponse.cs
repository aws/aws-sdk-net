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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeThingRegistrationTask operation.
    /// </summary>
    public partial class DescribeThingRegistrationTaskResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDate;
        private int? _failureCount;
        private string _inputFileBucket;
        private string _inputFileKey;
        private DateTime? _lastModifiedDate;
        private string _message;
        private int? _percentageProgress;
        private string _roleArn;
        private Status _status;
        private int? _successCount;
        private string _taskId;
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The task creation date.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCount. 
        /// <para>
        /// The number of things that failed to be provisioned.
        /// </para>
        /// </summary>
        public int? FailureCount
        {
            get { return this._failureCount; }
            set { this._failureCount = value; }
        }

        // Check to see if FailureCount property is set
        internal bool IsSetFailureCount()
        {
            return this._failureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputFileBucket. 
        /// <para>
        /// The S3 bucket that contains the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string InputFileBucket
        {
            get { return this._inputFileBucket; }
            set { this._inputFileBucket = value; }
        }

        // Check to see if InputFileBucket property is set
        internal bool IsSetInputFileBucket()
        {
            return this._inputFileBucket != null;
        }

        /// <summary>
        /// Gets and sets the property InputFileKey. 
        /// <para>
        /// The input file key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string InputFileKey
        {
            get { return this._inputFileKey; }
            set { this._inputFileKey = value; }
        }

        // Check to see if InputFileKey property is set
        internal bool IsSetInputFileKey()
        {
            return this._inputFileKey != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the task was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property PercentageProgress. 
        /// <para>
        /// The progress of the bulk provisioning task expressed as a percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? PercentageProgress
        {
            get { return this._percentageProgress; }
            set { this._percentageProgress = value; }
        }

        // Check to see if PercentageProgress property is set
        internal bool IsSetPercentageProgress()
        {
            return this._percentageProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN that grants access to the input file bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the bulk thing provisioning task.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessCount. 
        /// <para>
        /// The number of things successfully provisioned.
        /// </para>
        /// </summary>
        public int? SuccessCount
        {
            get { return this._successCount; }
            set { this._successCount = value; }
        }

        // Check to see if SuccessCount property is set
        internal bool IsSetSuccessCount()
        {
            return this._successCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The task ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=40)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The task's template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10240)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

    }
}