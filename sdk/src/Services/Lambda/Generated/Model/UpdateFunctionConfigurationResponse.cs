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
    /// Details about a function's configuration.
    /// </summary>
    public partial class UpdateFunctionConfigurationResponse : AmazonWebServiceResponse
    {
        private List<string> _architectures = new List<string>();
        private string _codeSha256;
        private long? _codeSize;
        private DeadLetterConfig _deadLetterConfig;
        private string _description;
        private EnvironmentResponse _environment;
        private EphemeralStorage _ephemeralStorage;
        private List<FileSystemConfig> _fileSystemConfigs = new List<FileSystemConfig>();
        private string _functionArn;
        private string _functionName;
        private string _handler;
        private ImageConfigResponse _imageConfigResponse;
        private string _kmsKeyArn;
        private string _lastModified;
        private LastUpdateStatus _lastUpdateStatus;
        private string _lastUpdateStatusReason;
        private LastUpdateStatusReasonCode _lastUpdateStatusReasonCode;
        private List<Layer> _layers = new List<Layer>();
        private string _masterArn;
        private int? _memorySize;
        private PackageType _packageType;
        private string _revisionId;
        private string _role;
        private Runtime _runtime;
        private RuntimeVersionConfig _runtimeVersionConfig;
        private string _signingJobArn;
        private string _signingProfileVersionArn;
        private SnapStartResponse _snapStart;
        private State _state;
        private string _stateReason;
        private StateReasonCode _stateReasonCode;
        private int? _timeout;
        private TracingConfigResponse _tracingConfig;
        private string _version;
        private VpcConfigDetail _vpcConfig;

        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The instruction set architecture that the function supports. Architecture is a string
        /// array with one of the valid values. The default architecture value is <code>x86_64</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Architectures
        {
            get { return this._architectures; }
            set { this._architectures = value; }
        }

        // Check to see if Architectures property is set
        internal bool IsSetArchitectures()
        {
            return this._architectures != null && this._architectures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CodeSha256. 
        /// <para>
        /// The SHA256 hash of the function's deployment package.
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
        /// The size of the function's deployment package, in bytes.
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
        /// The function's dead letter queue.
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
        /// The function's description.
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
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html">environment
        /// variables</a>. Omitted from CloudTrail logs.
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
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The size of the function’s <code>/tmp</code> directory in MB. The default value is
        /// 512, but it can be any whole number between 512 and 10,240 MB.
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
        /// Connection settings for an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html">Amazon
        /// EFS file system</a>.
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
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The function's Amazon Resource Name (ARN).
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
        /// The name of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=170)]
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
        /// The function that Lambda calls to begin running your function.
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
        /// Gets and sets the property ImageConfigResponse. 
        /// <para>
        /// The function's image configuration values.
        /// </para>
        /// </summary>
        public ImageConfigResponse ImageConfigResponse
        {
            get { return this._imageConfigResponse; }
            set { this._imageConfigResponse = value; }
        }

        // Check to see if ImageConfigResponse property is set
        internal bool IsSetImageConfigResponse()
        {
            return this._imageConfigResponse != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// The KMS key that's used to encrypt the function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html#configuration-envvars-encryption">environment
        /// variables</a>. When <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart-security.html">Lambda
        /// SnapStart</a> is activated, this key is also used to encrypt the function's snapshot.
        /// This key is returned only if you've configured a customer managed key.
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
        /// The date and time that the function was last updated, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
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
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// The status of the last update that was performed on the function. This is first set
        /// to <code>Successful</code> after function creation completes.
        /// </para>
        /// </summary>
        public LastUpdateStatus LastUpdateStatus
        {
            get { return this._lastUpdateStatus; }
            set { this._lastUpdateStatus = value; }
        }

        // Check to see if LastUpdateStatus property is set
        internal bool IsSetLastUpdateStatus()
        {
            return this._lastUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReason. 
        /// <para>
        /// The reason for the last update that was performed on the function.
        /// </para>
        /// </summary>
        public string LastUpdateStatusReason
        {
            get { return this._lastUpdateStatusReason; }
            set { this._lastUpdateStatusReason = value; }
        }

        // Check to see if LastUpdateStatusReason property is set
        internal bool IsSetLastUpdateStatusReason()
        {
            return this._lastUpdateStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReasonCode. 
        /// <para>
        /// The reason code for the last update that was performed on the function.
        /// </para>
        /// </summary>
        public LastUpdateStatusReasonCode LastUpdateStatusReasonCode
        {
            get { return this._lastUpdateStatusReasonCode; }
            set { this._lastUpdateStatusReasonCode = value; }
        }

        // Check to see if LastUpdateStatusReasonCode property is set
        internal bool IsSetLastUpdateStatusReasonCode()
        {
            return this._lastUpdateStatusReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property Layers. 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">layers</a>.
        /// </para>
        /// </summary>
        public List<Layer> Layers
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
        /// Gets and sets the property MasterArn. 
        /// <para>
        /// For Lambda@Edge functions, the ARN of the main function.
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
        /// The amount of memory available to the function at runtime.
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
        /// set <code>Zip</code> for .zip file archive.
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The latest updated revision of the function or alias.
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
        /// The function's execution role.
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
        /// Gets and sets the property RuntimeVersionConfig. 
        /// <para>
        /// The ARN of the runtime and any errors that occured.
        /// </para>
        /// </summary>
        public RuntimeVersionConfig RuntimeVersionConfig
        {
            get { return this._runtimeVersionConfig; }
            set { this._runtimeVersionConfig = value; }
        }

        // Check to see if RuntimeVersionConfig property is set
        internal bool IsSetRuntimeVersionConfig()
        {
            return this._runtimeVersionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SigningJobArn. 
        /// <para>
        /// The ARN of the signing job.
        /// </para>
        /// </summary>
        public string SigningJobArn
        {
            get { return this._signingJobArn; }
            set { this._signingJobArn = value; }
        }

        // Check to see if SigningJobArn property is set
        internal bool IsSetSigningJobArn()
        {
            return this._signingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property SigningProfileVersionArn. 
        /// <para>
        /// The ARN of the signing profile version.
        /// </para>
        /// </summary>
        public string SigningProfileVersionArn
        {
            get { return this._signingProfileVersionArn; }
            set { this._signingProfileVersionArn = value; }
        }

        // Check to see if SigningProfileVersionArn property is set
        internal bool IsSetSigningProfileVersionArn()
        {
            return this._signingProfileVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapStart. 
        /// <para>
        /// Set <code>ApplyOn</code> to <code>PublishedVersions</code> to create a snapshot of
        /// the initialized execution environment when you publish a function version. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html">Improving
        /// startup performance with Lambda SnapStart</a>.
        /// </para>
        /// </summary>
        public SnapStartResponse SnapStart
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the function. When the state is <code>Inactive</code>, you can
        /// reactivate the function by invoking it.
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the function's current state.
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property StateReasonCode. 
        /// <para>
        /// The reason code for the function's current state. When the code is <code>Creating</code>,
        /// you can't invoke or modify the function.
        /// </para>
        /// </summary>
        public StateReasonCode StateReasonCode
        {
            get { return this._stateReasonCode; }
            set { this._stateReasonCode = value; }
        }

        // Check to see if StateReasonCode property is set
        internal bool IsSetStateReasonCode()
        {
            return this._stateReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time in seconds that Lambda allows a function to run before stopping
        /// it.
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
        /// The function's X-Ray tracing configuration.
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
        [AWSProperty(Min=1, Max=1024)]
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
        /// The function's networking configuration.
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