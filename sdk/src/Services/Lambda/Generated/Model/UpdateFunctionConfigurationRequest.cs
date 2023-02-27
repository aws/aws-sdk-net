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
    /// Container for the parameters to the UpdateFunctionConfiguration operation.
    /// Modify the version-specific settings of a Lambda function.
    /// 
    ///  
    /// <para>
    /// When you update a function, Lambda provisions an instance of the function and its
    /// supporting resources. If your function connects to a VPC, this process can take a
    /// minute. During this time, you can't modify the function, but you can still invoke
    /// it. The <code>LastUpdateStatus</code>, <code>LastUpdateStatusReason</code>, and <code>LastUpdateStatusReasonCode</code>
    /// fields in the response from <a>GetFunctionConfiguration</a> indicate when the update
    /// is complete and the function is processing events with the new configuration. For
    /// more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
    /// function states</a>.
    /// </para>
    ///  
    /// <para>
    /// These settings can vary between versions of a function and are locked when you publish
    /// a version. You can't modify the configuration of a published version, only the unpublished
    /// version.
    /// </para>
    ///  
    /// <para>
    /// To configure function concurrency, use <a>PutFunctionConcurrency</a>. To grant invoke
    /// permissions to an Amazon Web Services account or Amazon Web Service, use <a>AddPermission</a>.
    /// </para>
    /// </summary>
    public partial class UpdateFunctionConfigurationRequest : AmazonLambdaRequest
    {
        private DeadLetterConfig _deadLetterConfig;
        private string _description;
        private Environment _environment;
        private EphemeralStorage _ephemeralStorage;
        private List<FileSystemConfig> _fileSystemConfigs = new List<FileSystemConfig>();
        private string _functionName;
        private string _handler;
        private ImageConfig _imageConfig;
        private string _kmsKeyArn;
        private List<string> _layers = new List<string>();
        private int? _memorySize;
        private string _revisionId;
        private string _role;
        private Runtime _runtime;
        private SnapStart _snapStart;
        private int? _timeout;
        private TracingConfig _tracingConfig;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// A dead-letter queue configuration that specifies the queue or topic where Lambda sends
        /// asynchronous events when they fail processing. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq">Dead-letter
        /// queues</a>.
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
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The size of the function's <code>/tmp</code> directory in MB. The default value is
        /// 512, but can be any whole number between 512 and 10,240 MB.
        /// </para>
        /// </summary>
        public EphemeralStorage EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage != null;
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

        /// <summary>
        /// This property is set to true if the property <seealso cref="FileSystemConfigs"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsFileSystemConfigsSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._fileSystemConfigs);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._fileSystemConfigs);
            }
        }

        // Check to see if FileSystemConfigs property is set
        internal bool IsSetFileSystemConfigs()
        {
            return this.IsFileSystemConfigsSet; 
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
        ///  <b>Function name</b> – <code>my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>.
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
        /// The name of the method within your code that Lambda calls to run your function. Handler
        /// is required if the deployment package is a .zip file archive. The format includes
        /// the file name. It can also include namespaces and other qualifiers, depending on the
        /// runtime. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/foundation-progmodel.html">Lambda
        /// programming model</a>.
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
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/images-parms.html">Container
        /// image configuration values</a> that override the values in the container image Docker
        /// file.
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
        /// The ARN of the Key Management Service (KMS) customer managed key that's used to encrypt
        /// your function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html#configuration-envvars-encryption">environment
        /// variables</a>. When <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart-security.html">Lambda
        /// SnapStart</a> is activated, this key is also used to encrypt your function's snapshot.
        /// If you don't provide a customer managed key, Lambda uses a default service key.
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

        /// <summary>
        /// This property is set to true if the property <seealso cref="Layers"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsLayersSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._layers);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._layers);
            }
        }

        // Check to see if Layers property is set
        internal bool IsSetLayers()
        {
            return this.IsLayersSet; 
        }

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The amount of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console">memory
        /// available to the function</a> at runtime. Increasing the function memory also increases
        /// its CPU allocation. The default value is 128 MB. The value can be any multiple of
        /// 1 MB.
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Update the function only if the revision ID matches the ID that's specified. Use this
        /// option to avoid modifying a function that has changed since you last read it.
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
        /// The Amazon Resource Name (ARN) of the function's execution role.
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
        /// The identifier of the function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime</a>.
        /// Runtime is required if the deployment package is a .zip file archive.
        /// </para>
        ///  
        /// <para>
        /// The following list includes deprecated runtimes. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtime-support-policy">Runtime
        /// deprecation policy</a>.
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
        /// Gets and sets the property SnapStart. 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html">SnapStart</a>
        /// setting.
        /// </para>
        /// </summary>
        public SnapStart SnapStart
        {
            get { return this._snapStart; }
            set { this._snapStart = value; }
        }

        // Check to see if SnapStart property is set
        internal bool IsSetSnapStart()
        {
            return this._snapStart != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time (in seconds) that Lambda allows a function to run before stopping
        /// it. The default is 3 seconds. The maximum allowed value is 900 seconds. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-context.html">Lambda
        /// execution environment</a>.
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
        /// requests with <a href="https://docs.aws.amazon.com/lambda/latest/dg/services-xray.html">X-Ray</a>.
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
        /// For network connectivity to Amazon Web Services resources in a VPC, specify a list
        /// of security groups and subnets in the VPC. When you connect a function to a VPC, it
        /// can access resources and the internet only through that VPC. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-vpc.html">Configuring
        /// a Lambda function to access resources in a VPC</a>.
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