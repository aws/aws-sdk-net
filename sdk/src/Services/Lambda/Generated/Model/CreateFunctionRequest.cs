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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFunction operation.
    /// Creates a Lambda function. To create a function, you need a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html">deployment
    /// package</a> and an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-permission-model.html#lambda-intro-execution-role">execution
    /// role</a>. The deployment package is a .zip file archive or container image that contains
    /// your function code. The execution role grants the function permission to use AWS services,
    /// such as Amazon CloudWatch Logs for log streaming and AWS X-Ray for request tracing.
    /// 
    ///  
    /// <para>
    /// When you create a function, Lambda provisions an instance of the function and its
    /// supporting resources. If your function connects to a VPC, this process can take a
    /// minute or so. During this time, you can't invoke or modify the function. The <code>State</code>,
    /// <code>StateReason</code>, and <code>StateReasonCode</code> fields in the response
    /// from <a>GetFunctionConfiguration</a> indicate when the function is ready to invoke.
    /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Function
    /// States</a>.
    /// </para>
    ///  
    /// <para>
    /// A function has an unpublished version, and can have published versions and aliases.
    /// The unpublished version changes when you update your function's code and configuration.
    /// A published version is a snapshot of your function code and configuration that can't
    /// be changed. An alias is a named resource that maps to a version, and can be changed
    /// to map to a different version. Use the <code>Publish</code> parameter to create version
    /// <code>1</code> of your function from its initial configuration.
    /// </para>
    ///  
    /// <para>
    /// The other parameters let you configure version-specific and function-level settings.
    /// You can modify version-specific settings later with <a>UpdateFunctionConfiguration</a>.
    /// Function-level settings apply to both the unpublished and published versions of the
    /// function, and include tags (<a>TagResource</a>) and per-function concurrency limits
    /// (<a>PutFunctionConcurrency</a>).
    /// </para>
    ///  
    /// <para>
    /// You can use code signing if your deployment package is a .zip file archive. To enable
    /// code signing for this function, specify the ARN of a code-signing configuration. When
    /// a user attempts to deploy a code package with <a>UpdateFunctionCode</a>, Lambda checks
    /// that the code package has a valid signature from a trusted publisher. The code-signing
    /// configuration includes set set of signing profiles, which define the trusted publishers
    /// for this function.
    /// </para>
    ///  
    /// <para>
    /// If another account or an AWS service invokes your function, use <a>AddPermission</a>
    /// to grant permission by creating a resource-based IAM policy. You can grant permissions
    /// at the function level, on a version, or on an alias.
    /// </para>
    ///  
    /// <para>
    /// To invoke your function directly, use <a>Invoke</a>. To invoke your function in response
    /// to events in other AWS services, create an event source mapping (<a>CreateEventSourceMapping</a>),
    /// or configure a function trigger in the other service. For more information, see <a
    /// href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-invocation.html">Invoking
    /// Functions</a>.
    /// </para>
    /// </summary>
    public partial class CreateFunctionRequest : AmazonLambdaRequest
    {
        private FunctionCode _code;
        private string _codeSigningConfigArn;
        private DeadLetterConfig _deadLetterConfig;
        private string _description;
        private Environment _environment;
        private List<FileSystemConfig> _fileSystemConfigs = new List<FileSystemConfig>();
        private string _functionName;
        private string _handler;
        private ImageConfig _imageConfig;
        private string _kmsKeyArn;
        private List<string> _layers = new List<string>();
        private int? _memorySize;
        private PackageType _packageType;
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
        /// The code for the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CodeSigningConfigArn. 
        /// <para>
        /// To enable code signing for this function, specify the ARN of a code-signing configuration.
        /// A code-signing configuration includes a set of signing profiles, which define the
        /// trusted publishers for this function.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string CodeSigningConfigArn
        {
            get { return this._codeSigningConfigArn; }
            set { this._codeSigningConfigArn = value; }
        }

        // Check to see if CodeSigningConfigArn property is set
        internal bool IsSetCodeSigningConfigArn()
        {
            return this._codeSigningConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// A dead letter queue configuration that specifies the queue or topic where Lambda sends
        /// asynchronous events when they fail processing. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#dlq">Dead
        /// Letter Queues</a>.
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
        /// A description of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// <para>
        /// Environment variables that are accessible from function code during execution.
        /// </para>
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
        /// Gets and sets the property FileSystemConfigs. 
        /// <para>
        /// Connection settings for an Amazon EFS file system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<FileSystemConfig> FileSystemConfigs
        {
            get { return this._fileSystemConfigs; }
            set { this._fileSystemConfigs = value; }
        }

        // Check to see if FileSystemConfigs property is set
        internal bool IsSetFileSystemConfigs()
        {
            return this._fileSystemConfigs != null && this._fileSystemConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the Lambda function.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> - <code>my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> - <code>123456789012:function:my-function</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
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
        /// The name of the method within your code that Lambda calls to execute your function.
        /// The format includes the file name. It can also include namespaces and other qualifiers,
        /// depending on the runtime. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/programming-model-v2.html">Programming
        /// Model</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property ImageConfig. 
        /// <para>
        /// Configuration values that override the container image Dockerfile.
        /// </para>
        /// </summary>
        public ImageConfig ImageConfig
        {
            get { return this._imageConfig; }
            set { this._imageConfig = value; }
        }

        // Check to see if ImageConfig property is set
        internal bool IsSetImageConfig()
        {
            return this._imageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// The ARN of the AWS Key Management Service (AWS KMS) key that's used to encrypt your
        /// function's environment variables. If it's not provided, AWS Lambda uses a default
        /// service key.
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
        /// Gets and sets the property Layers. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">function
        /// layers</a> to add to the function's execution environment. Specify each layer by its
        /// ARN, including the version.
        /// </para>
        /// </summary>
        public List<string> Layers
        {
            get { return this._layers; }
            set { this._layers = value; }
        }

        // Check to see if Layers property is set
        internal bool IsSetLayers()
        {
            return this._layers != null && this._layers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The amount of memory available to the function at runtime. Increasing the function's
        /// memory also increases its CPU allocation. The default value is 128 MB. The value can
        /// be any multiple of 1 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=128, Max=10240)]
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
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of deployment package. Set to <code>Image</code> for container image and
        /// set <code>Zip</code> for ZIP archive.
        /// </para>
        /// </summary>
        public PackageType PackageType
        {
            get { return this._packageType; }
            set { this._packageType = value; }
        }

        // Check to see if PackageType property is set
        internal bool IsSetPackageType()
        {
            return this._packageType != null;
        }

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// Set to true to publish the first version of the function during creation.
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
        /// The Amazon Resource Name (ARN) of the function's execution role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier of the function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime</a>.
        /// </para>
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
        /// A list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// to apply to the function.
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
        /// The amount of time that Lambda allows a function to run before stopping it. The default
        /// is 3 seconds. The maximum allowed value is 900 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Set <code>Mode</code> to <code>Active</code> to sample and trace a subset of incoming
        /// requests with AWS X-Ray.
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
        /// For network connectivity to AWS resources in a VPC, specify a list of security groups
        /// and subnets in the VPC. When you connect a function to a VPC, it can only access resources
        /// and the internet through that VPC. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-vpc.html">VPC
        /// Settings</a>.
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