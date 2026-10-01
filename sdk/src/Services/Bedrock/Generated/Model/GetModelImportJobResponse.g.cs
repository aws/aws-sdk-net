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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetModelImportJob operation.
    /// </summary>
    public partial class GetModelImportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time that the resource transitioned to terminal state.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Information about why the import job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property ImportedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string ImportedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportedModelArn property is set.
        /// </summary>
        internal bool IsSetImportedModelArn() => this.ImportedModelArn != null;

        /// <summary>
        /// Gets and sets the property ImportedModelKmsKeyArn. 
        /// <para>
        /// The imported model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ImportedModelKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportedModelKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetImportedModelKmsKeyArn() => this.ImportedModelKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ImportedModelName. 
        /// <para>
        /// The name of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ImportedModelName { get; set; }

        /// <summary>
        /// Checks to see if the ImportedModelName property is set.
        /// </summary>
        internal bool IsSetImportedModelName() => this.ImportedModelName != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Time the resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelDataSource. 
        /// <para>
        /// The data source for the imported model.
        /// </para>
        /// </summary>
        public ModelDataSource ModelDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataSource property is set.
        /// </summary>
        internal bool IsSetModelDataSource() => this.ModelDataSource != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with this job.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job. A successful job transitions from in-progress to completed
        /// when the imported model is ready to use. If the job failed, the failure message contains
        /// information about why the job failed.
        /// </para>
        /// </summary>
        public ModelImportJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The Virtual Private Cloud (VPC) configuration of the import model job.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
