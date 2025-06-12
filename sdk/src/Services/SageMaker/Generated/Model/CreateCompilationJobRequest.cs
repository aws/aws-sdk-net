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
    /// Container for the parameters to the CreateCompilationJob operation.
    /// Starts a model compilation job. After the model has been compiled, Amazon SageMaker
    /// AI saves the resulting model artifacts to an Amazon Simple Storage Service (Amazon
    /// S3) bucket that you specify. 
    /// 
    ///  
    /// <para>
    /// If you choose to host your model using Amazon SageMaker AI hosting services, you can
    /// use the resulting model artifacts as part of the model. You can also use the artifacts
    /// with Amazon Web Services IoT Greengrass. In that case, deploy them as an ML resource.
    /// </para>
    ///  
    /// <para>
    /// In the request body, you provide the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A name for the compilation job
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Information about the input model artifacts 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The output location for the compiled model and the device (target) that the model
    /// runs on 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker AI assumes to
    /// perform the model compilation job. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can also provide a <c>Tag</c> to track the model compilation job's resource use
    /// and costs. The response body contains the <c>CompilationJobArn</c> for the compiled
    /// job.
    /// </para>
    ///  
    /// <para>
    /// To stop a model compilation job, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_StopCompilationJob.html">StopCompilationJob</a>.
    /// To get information about a particular model compilation job, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeCompilationJob.html">DescribeCompilationJob</a>.
    /// To get information about multiple model compilation jobs, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListCompilationJobs.html">ListCompilationJobs</a>.
    /// </para>
    /// </summary>
    public partial class CreateCompilationJobRequest : AmazonSageMakerRequest
    {
        private string _compilationJobName;
        private InputConfig _inputConfig;
        private string _modelPackageVersionArn;
        private OutputConfig _outputConfig;
        private string _roleArn;
        private StoppingCondition _stoppingCondition;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private NeoVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// A name for the model compilation job. The name must be unique within the Amazon Web
        /// Services Region and within your Amazon Web Services account. 
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
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Provides information about the location of input model artifacts, the name and shape
        /// of the expected data inputs, and the framework in which the model was trained.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ModelPackageVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a versioned model package. Provide either a <c>ModelPackageVersionArn</c>
        /// or an <c>InputConfig</c> object in the request syntax. The presence of both objects
        /// in the <c>CreateCompilationJob</c> request will return an exception.
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
        /// Provides information about the output location for the compiled model and the target
        /// device the model runs on.
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
        /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker AI to
        /// perform tasks on your behalf. 
        /// </para>
        ///  
        /// <para>
        /// During model compilation, Amazon SageMaker AI needs your permission to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Read input data from an S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Write model artifacts to an S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Write logs to Amazon CloudWatch Logs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Publish metrics to Amazon CloudWatch
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You grant permissions for all of these tasks to an IAM role. To pass this role to
        /// Amazon SageMaker AI, the caller of this API must have the <c>iam:PassRole</c> permission.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">Amazon
        /// SageMaker AI Roles.</a> 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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