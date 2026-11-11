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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeThingRegistrationTask operation.
    /// </summary>
    public partial class DescribeThingRegistrationTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The task creation date.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCount. 
        /// <para>
        /// The number of things that failed to be provisioned.
        /// </para>
        /// </summary>
        public int? FailureCount { get; set; }

        /// <summary>
        /// Checks to see if the FailureCount property is set.
        /// </summary>
        internal bool IsSetFailureCount() => this.FailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property InputFileBucket. 
        /// <para>
        /// The S3 bucket that contains the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string InputFileBucket { get; set; }

        /// <summary>
        /// Checks to see if the InputFileBucket property is set.
        /// </summary>
        internal bool IsSetInputFileBucket() => this.InputFileBucket != null;

        /// <summary>
        /// Gets and sets the property InputFileKey. 
        /// <para>
        /// The input file key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string InputFileKey { get; set; }

        /// <summary>
        /// Checks to see if the InputFileKey property is set.
        /// </summary>
        internal bool IsSetInputFileKey() => this.InputFileKey != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the task was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property PercentageProgress. 
        /// <para>
        /// The progress of the bulk provisioning task expressed as a percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? PercentageProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentageProgress property is set.
        /// </summary>
        internal bool IsSetPercentageProgress() => this.PercentageProgress.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN that grants access to the input file bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the bulk thing provisioning task.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SuccessCount. 
        /// <para>
        /// The number of things successfully provisioned.
        /// </para>
        /// </summary>
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Checks to see if the SuccessCount property is set.
        /// </summary>
        internal bool IsSetSuccessCount() => this.SuccessCount.HasValue;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The task ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The task's template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;
    }
}
