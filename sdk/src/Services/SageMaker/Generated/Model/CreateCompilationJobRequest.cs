/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCompilationJob operation.
    /// Starts a model compilation job. After the model has been compiled, Amazon SageMaker
    /// saves the resulting model artifacts to an Amazon Simple Storage Service (Amazon S3)
    /// bucket that you specify. 
    /// 
    ///  
    /// <para>
    /// If you choose to host your model using Amazon SageMaker hosting services, you can
    /// use the resulting model artifacts as part of the model. You can also use the artifacts
    /// with AWS IoT Greengrass. In that case, deploy them as an ML resource.
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
    ///  <code>The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker assumes
    /// to perform the model compilation job</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can also provide a <code>Tag</code> to track the model compilation job's resource
    /// use and costs. The response body contains the <code>CompilationJobArn</code> for the
    /// compiled job.
    /// </para>
    ///  
    /// <para>
    /// To stop a model compilation job, use <a>StopCompilationJob</a>. To get information
    /// about a particular model compilation job, use <a>DescribeCompilationJob</a>. To get
    /// information about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
    /// </para>
    /// </summary>
    public partial class CreateCompilationJobRequest : AmazonSageMakerRequest
    {
        private string _compilationJobName;
        private InputConfig _inputConfig;
        private OutputConfig _outputConfig;
        private string _roleArn;
        private StoppingCondition _stoppingCondition;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// A name for the model compilation job. The name must be unique within the AWS Region
        /// and within your AWS account. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Provides information about the output location for the compiled model and the target
        /// device the model runs on.
        /// </para>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) of an IIAMAM role that enables Amazon SageMaker to
        /// perform tasks on your behalf. 
        /// </para>
        ///  
        /// <para>
        /// During model compilation, Amazon SageMaker needs your permission to:
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
        /// Amazon SageMaker, the caller of this API must have the <code>iam:PassRole</code> permission.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">Amazon
        /// SageMaker Roles.</a> 
        /// </para>
        /// </summary>
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
        /// The duration allowed for model compilation.
        /// </para>
        /// </summary>
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

    }
}