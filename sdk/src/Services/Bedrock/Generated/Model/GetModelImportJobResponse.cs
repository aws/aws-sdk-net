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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _failureMessage;
        private string _importedModelArn;
        private string _importedModelKmsKeyArn;
        private string _importedModelName;
        private string _jobArn;
        private string _jobName;
        private DateTime? _lastModifiedTime;
        private ModelDataSource _modelDataSource;
        private string _roleArn;
        private ModelImportJobStatus _status;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time that the resource transitioned to terminal state.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Information about why the import job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1011)]
        public string ImportedModelArn
        {
            get { return this._importedModelArn; }
            set { this._importedModelArn = value; }
        }

        // Check to see if ImportedModelArn property is set
        internal bool IsSetImportedModelArn()
        {
            return this._importedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedModelKmsKeyArn. 
        /// <para>
        /// The imported model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ImportedModelKmsKeyArn
        {
            get { return this._importedModelKmsKeyArn; }
            set { this._importedModelKmsKeyArn = value; }
        }

        // Check to see if ImportedModelKmsKeyArn property is set
        internal bool IsSetImportedModelKmsKeyArn()
        {
            return this._importedModelKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedModelName. 
        /// <para>
        /// The name of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ImportedModelName
        {
            get { return this._importedModelName; }
            set { this._importedModelName = value; }
        }

        // Check to see if ImportedModelName property is set
        internal bool IsSetImportedModelName()
        {
            return this._importedModelName != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1011)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Time the resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelDataSource. 
        /// <para>
        /// The data source for the imported model.
        /// </para>
        /// </summary>
        public ModelDataSource ModelDataSource
        {
            get { return this._modelDataSource; }
            set { this._modelDataSource = value; }
        }

        // Check to see if ModelDataSource property is set
        internal bool IsSetModelDataSource()
        {
            return this._modelDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// The status of the job. A successful job transitions from in-progress to completed
        /// when the imported model is ready to use. If the job failed, the failure message contains
        /// information about why the job failed.
        /// </para>
        /// </summary>
        public ModelImportJobStatus Status
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The Virtual Private Cloud (VPC) configuration of the import model job.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}