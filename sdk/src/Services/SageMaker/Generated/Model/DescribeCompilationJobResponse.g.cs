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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeCompilationJob operation.
    /// </summary>
    public partial class DescribeCompilationJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompilationEndTime. 
        /// <para>
        /// The time when the model compilation job on a compilation job instance ended. For a
        /// successful or stopped job, this is when the job's model artifacts have finished uploading.
        /// For a failed job, this is when Amazon SageMaker AI detected that the job failed. 
        /// </para>
        /// </summary>
        public DateTime? CompilationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the CompilationEndTime property is set.
        /// </summary>
        internal bool IsSetCompilationEndTime() => this.CompilationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property CompilationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string CompilationJobArn { get; set; }

        /// <summary>
        /// Checks to see if the CompilationJobArn property is set.
        /// </summary>
        internal bool IsSetCompilationJobArn() => this.CompilationJobArn != null;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string CompilationJobName { get; set; }

        /// <summary>
        /// Checks to see if the CompilationJobName property is set.
        /// </summary>
        internal bool IsSetCompilationJobName() => this.CompilationJobName != null;

        /// <summary>
        /// Gets and sets the property CompilationJobStatus. 
        /// <para>
        /// The status of the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CompilationJobStatus CompilationJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the CompilationJobStatus property is set.
        /// </summary>
        internal bool IsSetCompilationJobStatus() => this.CompilationJobStatus != null;

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
        public DateTime? CompilationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the CompilationStartTime property is set.
        /// </summary>
        internal bool IsSetCompilationStartTime() => this.CompilationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the model compilation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DerivedInformation. 
        /// <para>
        /// Information that SageMaker Neo automatically derived about the model.
        /// </para>
        /// </summary>
        public DerivedInformation DerivedInformation { get; set; }

        /// <summary>
        /// Checks to see if the DerivedInformation property is set.
        /// </summary>
        internal bool IsSetDerivedInformation() => this.DerivedInformation != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a model compilation job failed, the reason it failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property InferenceImage. 
        /// <para>
        /// The inference image to use when compiling a model. Specify an image only if the target
        /// device is a cloud instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InferenceImage { get; set; }

        /// <summary>
        /// Checks to see if the InferenceImage property is set.
        /// </summary>
        internal bool IsSetInferenceImage() => this.InferenceImage != null;

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Information about the location in Amazon S3 of the input model artifacts, the name
        /// and shape of the expected data inputs, and the framework in which the model was trained.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputConfig InputConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputConfig property is set.
        /// </summary>
        internal bool IsSetInputConfig() => this.InputConfig != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time that the status of the model compilation job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelArtifacts. 
        /// <para>
        /// Information about the location in Amazon S3 that has been configured for storing the
        /// model artifacts used in the compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelArtifacts ModelArtifacts { get; set; }

        /// <summary>
        /// Checks to see if the ModelArtifacts property is set.
        /// </summary>
        internal bool IsSetModelArtifacts() => this.ModelArtifacts != null;

        /// <summary>
        /// Gets and sets the property ModelDigests. 
        /// <para>
        /// Provides a BLAKE2 hash value that identifies the compiled model artifacts in Amazon
        /// S3.
        /// </para>
        /// </summary>
        public ModelDigests ModelDigests { get; set; }

        /// <summary>
        /// Checks to see if the ModelDigests property is set.
        /// </summary>
        internal bool IsSetModelDigests() => this.ModelDigests != null;

        /// <summary>
        /// Gets and sets the property ModelPackageVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the versioned model package that was provided to
        /// SageMaker Neo when you initiated a compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ModelPackageVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageVersionArn property is set.
        /// </summary>
        internal bool IsSetModelPackageVersionArn() => this.ModelPackageVersionArn != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Information about the output location for the compiled model and the target device
        /// that the model runs on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker AI assumes to
        /// perform the model compilation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// Specifies a limit to how long a model compilation job can run. When the job reaches
        /// the time limit, Amazon SageMaker AI ends the compilation job. Use this API to cap
        /// model training costs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html">VpcConfig</a>
        /// object that specifies the VPC that you want your compilation job to connect to. Control
        /// access to your models by configuring the VPC. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/neo-vpc.html">Protect
        /// Compilation Jobs by Using an Amazon Virtual Private Cloud</a>.
        /// </para>
        /// </summary>
        public NeoVpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
