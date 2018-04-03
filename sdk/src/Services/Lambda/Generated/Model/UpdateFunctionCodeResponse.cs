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
    /// A complex type that describes function metadata.
    /// </summary>
    public partial class UpdateFunctionCodeResponse : AmazonWebServiceResponse
    {
        private string _codeSha256;
        private long? _codeSize;
        private DeadLetterConfig _deadLetterConfig;
        private string _description;
        private EnvironmentResponse _environment;
        private string _functionArn;
        private string _functionName;
        private string _handler;
        private string _kmsKeyArn;
        private string _lastModified;
        private string _masterArn;
        private int? _memorySize;
        private string _revisionId;
        private string _role;
        private Runtime _runtime;
        private int? _timeout;
        private TracingConfigResponse _tracingConfig;
        private string _version;
        private VpcConfigDetail _vpcConfig;

        /// <summary>
        /// Gets and sets the property CodeSha256. 
        /// <para>
        /// It is the SHA256 hash of your function deployment package.
        /// </para>
        /// </summary>
        public string CodeSha256
        {
            get { return this._codeSha256; }
            set { this._codeSha256 = value; }
        }

        // Check to see if CodeSha256 property is set
        internal bool IsSetCodeSha256()
        {
            return this._codeSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size, in bytes, of the function .zip file you uploaded.
        /// </para>
        /// </summary>
        public long CodeSize
        {
            get { return this._codeSize.GetValueOrDefault(); }
            set { this._codeSize = value; }
        }

        // Check to see if CodeSize property is set
        internal bool IsSetCodeSize()
        {
            return this._codeSize.HasValue; 
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
        /// The user-provided description.
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
        /// The parent object that contains your environment's configuration settings.
        /// </para>
        /// </summary>
        public EnvironmentResponse Environment
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
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the function.
        /// </para>
        /// </summary>
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function. Note that the length constraint applies only to the ARN.
        /// If you specify only the function name, it is limited to 64 characters in length.
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
        /// The function Lambda calls to begin executing your function.
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
        /// variables. If empty, it means you are using the AWS Lambda default service key.
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The time stamp of the last time you updated the function. The time stamp is conveyed
        /// as a string complying with ISO-8601 in this way YYYY-MM-DDThh:mm:ssTZD (e.g., 1997-07-16T19:20:30+01:00).
        /// For more information, see <a href="https://www.w3.org/TR/NOTE-datetime">Date and Time
        /// Formats</a>.
        /// </para>
        /// </summary>
        public string LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified != null;
        }

        /// <summary>
        /// Gets and sets the property MasterArn. 
        /// <para>
        /// Returns the ARN (Amazon Resource Name) of the master function.
        /// </para>
        /// </summary>
        public string MasterArn
        {
            get { return this._masterArn; }
            set { this._masterArn = value; }
        }

        // Check to see if MasterArn property is set
        internal bool IsSetMasterArn()
        {
            return this._masterArn != null;
        }

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The memory size, in MB, you configured for the function. Must be a multiple of 64
        /// MB.
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Represents the latest updated revision of the function or alias.
        /// </para>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Lambda assumes when it executes
        /// your function to access any other Amazon Web Services (AWS) resources.
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
        /// The runtime environment for the Lambda function.
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
        public TracingConfigResponse TracingConfig
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the Lambda function.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VPC configuration associated with your Lambda function.
        /// </para>
        /// </summary>
        public VpcConfigDetail VpcConfig
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