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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFunction operation.
    /// Creates a new Lambda function. The function metadata is created from the request parameters,
    /// and the code for the function is provided by a .zip file in the request body. If the
    /// function name already exists, the operation will fail. Note that the function name
    /// is case-sensitive.
    /// 
    ///  
    /// <para>
    ///  If you are using versioning, you can also publish a version of the Lambda function
    /// you are creating using the <code>Publish</code> parameter. For more information about
    /// versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
    /// Lambda Function Versioning and Aliases</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:CreateFunction</code> action.
    /// </para>
    /// </summary>
    public partial class CreateFunctionRequest : AmazonLambdaRequest
    {
        private FunctionCode _code;
        private DeadLetterConfig _deadLetterConfig;
        private string _description;
        private Environment _environment;
        private string _functionName;
        private string _handler;
        private string _kmsKeyArn;
        private int? _memorySize;
        private bool? _publish;
        private string _role;
        private Runtime _runtime;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private int? _timeout;
        private TracingConfig _tracingConfig;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code for the Lambda function.
        /// </para>
        /// </summary>
        public FunctionCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// The parent object that contains the target ARN (Amazon Resource Name) of an Amazon
        /// SQS queue or Amazon SNS topic. For more information, see <a>dlq</a>. 
        /// </para>
        /// </summary>
        public DeadLetterConfig DeadLetterConfig
        {
            get { return this._deadLetterConfig; }
            set { this._deadLetterConfig = value; }
        }

        // Check to see if DeadLetterConfig property is set
        internal bool IsSetDeadLetterConfig()
        {
            return this._deadLetterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short, user-defined function description. Lambda does not use this value. Assign
        /// a meaningful description as you see fit.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Environment.
        /// </summary>
        public Environment Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name you want to assign to the function you are uploading. The function names
        /// appear in the console and are returned in the <a>ListFunctions</a> API. Function names
        /// are used to specify functions to other AWS Lambda API operations, such as <a>Invoke</a>.
        /// Note that the length constraint applies only to the ARN. If you specify only the function
        /// name, it is limited to 64 characters in length. 
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property Handler. 
        /// <para>
        /// The function within your code that Lambda calls to begin execution. For Node.js, it
        /// is the <i>module-name</i>.<i>export</i> value in your function. For Java, it can be
        /// <code>package.class-name::handler</code> or <code>package.class-name</code>. For more
        /// information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/java-programming-model-handler-types.html">Lambda
        /// Function Handler (Java)</a>. 
        /// </para>
        /// </summary>
        public string Handler
        {
            get { return this._handler; }
            set { this._handler = value; }
        }

        // Check to see if Handler property is set
        internal bool IsSetHandler()
        {
            return this._handler != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt your function's environment
        /// variables. If not provided, AWS Lambda will use a default service key.
        /// </para>
        /// </summary>
        public string KMSKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KMSKeyArn property is set
        internal bool IsSetKMSKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The amount of memory, in MB, your Lambda function is given. Lambda uses this memory
        /// size to infer the amount of CPU and memory allocated to your function. Your function
        /// use-case determines your CPU and memory requirements. For example, a database operation
        /// might need less memory compared to an image processing function. The default value
        /// is 128 MB. The value must be a multiple of 64 MB.
        /// </para>
        /// </summary>
        public int MemorySize
        {
            get { return this._memorySize.GetValueOrDefault(); }
            set { this._memorySize = value; }
        }

        // Check to see if MemorySize property is set
        internal bool IsSetMemorySize()
        {
            return this._memorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// This boolean parameter can be used to request AWS Lambda to create the Lambda function
        /// and publish a version as an atomic operation.
        /// </para>
        /// </summary>
        public bool Publish
        {
            get { return this._publish.GetValueOrDefault(); }
            set { this._publish = value; }
        }

        // Check to see if Publish property is set
        internal bool IsSetPublish()
        {
            return this._publish.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Lambda assumes when it executes
        /// your function to access any other Amazon Web Services (AWS) resources. For more information,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
        /// Lambda: How it Works</a>. 
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime environment for the Lambda function you are uploading.
        /// </para>
        ///  
        /// <para>
        /// To use the Python runtime v3.6, set the value to "python3.6". To use the Python runtime
        /// v2.7, set the value to "python2.7". To use the Node.js runtime v6.10, set the value
        /// to "nodejs6.10". To use the Node.js runtime v4.3, set the value to "nodejs4.3". To
        /// use the .NET Core runtime v1.0, set the value to "dotnetcore1.0". To use the .NET
        /// Core runtime v2.0, set the value to "dotnetcore2.0".
        /// </para>
        ///  <note> 
        /// <para>
        /// Node v0.10.42 is currently marked as deprecated. You must migrate existing functions
        /// to the newer Node.js runtime versions available on AWS Lambda (nodejs4.3 or nodejs6.10)
        /// as soon as possible. Failure to do so will result in an invalid parameter error being
        /// returned. Note that you will have to follow this procedure for each region that contains
        /// functions written in the Node v0.10.42 runtime.
        /// </para>
        ///  </note>
        /// </summary>
        public Runtime Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags (key-value pairs) assigned to the new function. For more information,
        /// see <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">Tagging Lambda
        /// Functions</a> in the <b>AWS Lambda Developer Guide</b>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The function execution time at which Lambda should terminate the function. Because
        /// the execution time has cost implications, we recommend you set this value based on
        /// your expected execution time. The default is 3 seconds.
        /// </para>
        /// </summary>
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TracingConfig. 
        /// <para>
        /// The parent object that contains your function's tracing settings.
        /// </para>
        /// </summary>
        public TracingConfig TracingConfig
        {
            get { return this._tracingConfig; }
            set { this._tracingConfig = value; }
        }

        // Check to see if TracingConfig property is set
        internal bool IsSetTracingConfig()
        {
            return this._tracingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// If your Lambda function accesses resources in a VPC, you provide this parameter identifying
        /// the list of security group IDs and subnet IDs. These must belong to the same VPC.
        /// You must provide at least one security group and one subnet ID.
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