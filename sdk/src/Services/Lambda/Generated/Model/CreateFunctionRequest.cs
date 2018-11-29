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
    /// Creates a new Lambda function. The function configuration is created from the request
    /// parameters, and the code for the function is provided by a .zip file. The function
    /// name is case-sensitive.
    /// 
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
        private List<string> _layers = new List<string>();
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
        /// The code for the function.
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
        /// A dead letter queue configuration that specifies the queue or topic where Lambda sends
        /// asynchronous events when they fail processing. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/dlq.html">Dead
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
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the Lambda function.
        /// </para>
        ///  <p class="title"> <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> - <code>MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> - <code>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> - <code>123456789012:function:MyFunction</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
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
        /// The name of the method within your code that Lambda calls to execute your function.
        /// For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/programming-model-v2.html">Programming
        /// Model</a>.
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
        /// The ARN of the KMS key used to encrypt your function's environment variables. If not
        /// provided, AWS Lambda will use a default service key.
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
        /// A list of <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">function
        /// layers</a> to add to the function's execution environment.
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
        /// The amount of memory that your function has access to. Increasing the function's memory
        /// also increases it's CPU allocation. The default value is 128 MB. The value must be
        /// a multiple of 64 MB.
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
        /// The Amazon Resource Name (ARN) of the function's <a href="http://docs.aws.amazon.com/lambda/latest/dg/intro-permission-model.html#lambda-intro-execution-role">execution
        /// role</a>.
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
        /// The runtime version for the function.
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
        /// The amount of time that Lambda allows a function to run before terminating it. The
        /// default is 3 seconds. The maximum allowed value is 900 seconds.
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