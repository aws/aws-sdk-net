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
    /// This is the response object from the DescribeCompilationJob operation.
    /// </summary>
    public partial class DescribeCompilationJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _compilationEndTime;
        private string _compilationJobArn;
        private string _compilationJobName;
        private CompilationJobStatus _compilationJobStatus;
        private DateTime? _compilationStartTime;
        private DateTime? _creationTime;
        private DerivedInformation _derivedInformation;
        private string _failureReason;
        private string _inferenceImage;
        private InputConfig _inputConfig;
        private DateTime? _lastModifiedTime;
        private ModelArtifacts _modelArtifacts;
        private ModelDigests _modelDigests;
        private string _modelPackageVersionArn;
        private OutputConfig _outputConfig;
        private string _roleArn;
        private StoppingCondition _stoppingCondition;
        private NeoVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property CompilationEndTime. 
        /// <para>
        /// The time when the model compilation job on a compilation job instance ended. For a
        /// successful or stopped job, this is when the job's model artifacts have finished uploading.
        /// For a failed job, this is when Amazon SageMaker AI detected that the job failed. 
        /// </para>
        /// </summary>
        public DateTime? CompilationEndTime
        {
            get { return this._compilationEndTime; }
            set { this._compilationEndTime = value; }
        }

        // Check to see if CompilationEndTime property is set
        internal bool IsSetCompilationEndTime()
        {
            return this._compilationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompilationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string CompilationJobArn
        {
            get { return this._compilationJobArn; }
            set { this._compilationJobArn = value; }
        }

        // Check to see if CompilationJobArn property is set
        internal bool IsSetCompilationJobArn()
        {
            return this._compilationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property CompilationJobStatus. 
        /// <para>
        /// The status of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompilationJobStatus CompilationJobStatus
        {
            get { return this._compilationJobStatus; }
            set { this._compilationJobStatus = value; }
        }

        // Check to see if CompilationJobStatus property is set
        internal bool IsSetCompilationJobStatus()
        {
            return this._compilationJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CompilationStartTime. 
        /// <para>
        /// The time when the model compilation job started the <c>CompilationJob</c> instances.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You are billed for the time between this timestamp and the timestamp in the <c>CompilationEndTime</c>
        /// field. In Amazon CloudWatch Logs, the start time might be later than this time. That's
        /// because it takes time to download the compilation job, which depends on the size of
        /// the compilation job container. 
        /// </para>
        /// </summary>
        public DateTime? CompilationStartTime
        {
            get { return this._compilationStartTime; }
            set { this._compilationStartTime = value; }
        }

        // Check to see if CompilationStartTime property is set
        internal bool IsSetCompilationStartTime()
        {
            return this._compilationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the model compilation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DerivedInformation. 
        /// <para>
        /// Information that SageMaker Neo automatically derived about the model.
        /// </para>
        /// </summary>
        public DerivedInformation DerivedInformation
        {
            get { return this._derivedInformation; }
            set { this._derivedInformation = value; }
        }

        // Check to see if DerivedInformation property is set
        internal bool IsSetDerivedInformation()
        {
            return this._derivedInformation != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a model compilation job failed, the reason it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceImage. 
        /// <para>
        /// The inference image to use when compiling a model. Specify an image only if the target
        /// device is a cloud instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string InferenceImage
        {
            get { return this._inferenceImage; }
            set { this._inferenceImage = value; }
        }

        // Check to see if InferenceImage property is set
        internal bool IsSetInferenceImage()
        {
            return this._inferenceImage != null;
        }

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Information about the location in Amazon S3 of the input model artifacts, the name
        /// and shape of the expected data inputs, and the framework in which the model was trained.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputConfig InputConfig
        {
            get { return this._inputConfig; }
            set { this._inputConfig = value; }
        }

        // Check to see if InputConfig property is set
        internal bool IsSetInputConfig()
        {
            return this._inputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time that the status of the model compilation job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ModelArtifacts. 
        /// <para>
        /// Information about the location in Amazon S3 that has been configured for storing the
        /// model artifacts used in the compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelArtifacts ModelArtifacts
        {
            get { return this._modelArtifacts; }
            set { this._modelArtifacts = value; }
        }

        // Check to see if ModelArtifacts property is set
        internal bool IsSetModelArtifacts()
        {
            return this._modelArtifacts != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDigests. 
        /// <para>
        /// Provides a BLAKE2 hash value that identifies the compiled model artifacts in Amazon
        /// S3.
        /// </para>
        /// </summary>
        public ModelDigests ModelDigests
        {
            get { return this._modelDigests; }
            set { this._modelDigests = value; }
        }

        // Check to see if ModelDigests property is set
        internal bool IsSetModelDigests()
        {
            return this._modelDigests != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the versioned model package that was provided to
        /// SageMaker Neo when you initiated a compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelPackageVersionArn
        {
            get { return this._modelPackageVersionArn; }
            set { this._modelPackageVersionArn = value; }
        }

        // Check to see if ModelPackageVersionArn property is set
        internal bool IsSetModelPackageVersionArn()
        {
            return this._modelPackageVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Information about the output location for the compiled model and the target device
        /// that the model runs on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputConfig OutputConfig
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker AI assumes to
        /// perform the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Specifies a limit to how long a model compilation job can run. When the job reaches
        /// the time limit, Amazon SageMaker AI ends the compilation job. Use this API to cap
        /// model training costs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that you want your compilation job to connect to. Control
        /// access to your models by configuring the VPC. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/neo-vpc.html">Protect
        /// Compilation Jobs by Using an Amazon Virtual Private Cloud</a>.
        /// </para>
        /// </summary>
        public NeoVpcConfig VpcConfig
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