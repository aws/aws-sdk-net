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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeEdgePackagingJob operation.
    /// </summary>
    public partial class DescribeEdgePackagingJobResponse : AmazonWebServiceResponse
    {
        private string _compilationJobName;
        private DateTime? _creationTime;
        private string _edgePackagingJobArn;
        private string _edgePackagingJobName;
        private EdgePackagingJobStatus _edgePackagingJobStatus;
        private string _edgePackagingJobStatusMessage;
        private DateTime? _lastModifiedTime;
        private string _modelArtifact;
        private string _modelName;
        private string _modelSignature;
        private string _modelVersion;
        private EdgeOutputConfig _outputConfig;
        private EdgePresetDeploymentOutput _presetDeploymentOutput;
        private string _resourceKey;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the SageMaker Neo compilation job that is used to locate model artifacts
        /// that are being packaged.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string CompilationJobName
        {
            get { return this._compilationJobName; }
            set { this._compilationJobName = value; }
        }

        // Check to see if CompilationJobName property is set
        internal bool IsSetCompilationJobName()
        {
            return this._compilationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the packaging job was created.
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
        /// Gets and sets the property EdgePackagingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EdgePackagingJobArn
        {
            get { return this._edgePackagingJobArn; }
            set { this._edgePackagingJobArn = value; }
        }

        // Check to see if EdgePackagingJobArn property is set
        internal bool IsSetEdgePackagingJobArn()
        {
            return this._edgePackagingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property EdgePackagingJobName. 
        /// <para>
        /// The name of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgePackagingJobName
        {
            get { return this._edgePackagingJobName; }
            set { this._edgePackagingJobName = value; }
        }

        // Check to see if EdgePackagingJobName property is set
        internal bool IsSetEdgePackagingJobName()
        {
            return this._edgePackagingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property EdgePackagingJobStatus. 
        /// <para>
        /// The current status of the packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgePackagingJobStatus EdgePackagingJobStatus
        {
            get { return this._edgePackagingJobStatus; }
            set { this._edgePackagingJobStatus = value; }
        }

        // Check to see if EdgePackagingJobStatus property is set
        internal bool IsSetEdgePackagingJobStatus()
        {
            return this._edgePackagingJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EdgePackagingJobStatusMessage. 
        /// <para>
        /// Returns a message describing the job status and error messages.
        /// </para>
        /// </summary>
        public string EdgePackagingJobStatusMessage
        {
            get { return this._edgePackagingJobStatusMessage; }
            set { this._edgePackagingJobStatusMessage = value; }
        }

        // Check to see if EdgePackagingJobStatusMessage property is set
        internal bool IsSetEdgePackagingJobStatusMessage()
        {
            return this._edgePackagingJobStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of when the job was last updated.
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
        /// Gets and sets the property ModelArtifact. 
        /// <para>
        /// The Amazon Simple Storage (S3) URI where model artifacts ares stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ModelArtifact
        {
            get { return this._modelArtifact; }
            set { this._modelArtifact = value; }
        }

        // Check to see if ModelArtifact property is set
        internal bool IsSetModelArtifact()
        {
            return this._modelArtifact != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelSignature. 
        /// <para>
        /// The signature document of files in the model artifact.
        /// </para>
        /// </summary>
        public string ModelSignature
        {
            get { return this._modelSignature; }
            set { this._modelSignature = value; }
        }

        // Check to see if ModelSignature property is set
        internal bool IsSetModelSignature()
        {
            return this._modelSignature != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the edge packaging job.
        /// </para>
        /// </summary>
        public EdgeOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PresetDeploymentOutput. 
        /// <para>
        /// The output of a SageMaker Edge Manager deployable resource.
        /// </para>
        /// </summary>
        public EdgePresetDeploymentOutput PresetDeploymentOutput
        {
            get { return this._presetDeploymentOutput; }
            set { this._presetDeploymentOutput = value; }
        }

        // Check to see if PresetDeploymentOutput property is set
        internal bool IsSetPresetDeploymentOutput()
        {
            return this._presetDeploymentOutput != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceKey. 
        /// <para>
        /// The Amazon Web Services KMS key to use when encrypting the EBS volume the job run
        /// on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ResourceKey
        {
            get { return this._resourceKey; }
            set { this._resourceKey = value; }
        }

        // Check to see if ResourceKey property is set
        internal bool IsSetResourceKey()
        {
            return this._resourceKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker to download
        /// and upload the model, and to contact Neo.
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

    }
}