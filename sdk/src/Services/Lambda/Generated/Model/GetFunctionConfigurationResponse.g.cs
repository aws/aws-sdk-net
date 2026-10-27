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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the GetFunctionConfiguration operation.
    /// </summary>
    public partial class GetFunctionConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The instruction set architecture that the function supports. Architecture is a string
        /// array with one of the valid values. The default architecture value is <c>x86_64</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> Architectures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Architectures property is set.
        /// </summary>
        internal bool IsSetArchitectures() => this.Architectures != null && (this.Architectures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityProviderConfig. 
        /// <para>
        /// Configuration for the capacity provider that manages compute resources for Lambda
        /// functions.
        /// </para>
        /// </summary>
        public CapacityProviderConfig CapacityProviderConfig { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderConfig property is set.
        /// </summary>
        internal bool IsSetCapacityProviderConfig() => this.CapacityProviderConfig != null;

        /// <summary>
        /// Gets and sets the property CodeSha256. 
        /// <para>
        /// The SHA256 hash of the function's deployment package.
        /// </para>
        /// </summary>
        public string CodeSha256 { get; set; }

        /// <summary>
        /// Checks to see if the CodeSha256 property is set.
        /// </summary>
        internal bool IsSetCodeSha256() => this.CodeSha256 != null;

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size of the function's deployment package, in bytes.
        /// </para>
        /// </summary>
        public long? CodeSize { get; set; }

        /// <summary>
        /// Checks to see if the CodeSize property is set.
        /// </summary>
        internal bool IsSetCodeSize() => this.CodeSize.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigSha256. 
        /// <para>
        /// The SHA256 hash of the function configuration.
        /// </para>
        /// </summary>
        public string ConfigSha256 { get; set; }

        /// <summary>
        /// Checks to see if the ConfigSha256 property is set.
        /// </summary>
        internal bool IsSetConfigSha256() => this.ConfigSha256 != null;

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// The function's dead letter queue.
        /// </para>
        /// </summary>
        public DeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterConfig property is set.
        /// </summary>
        internal bool IsSetDeadLetterConfig() => this.DeadLetterConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The function's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DurableConfig. 
        /// <para>
        /// The function's durable execution configuration settings, if the function is configured
        /// for durability.
        /// </para>
        /// </summary>
        public DurableConfig DurableConfig { get; set; }

        /// <summary>
        /// Checks to see if the DurableConfig property is set.
        /// </summary>
        internal bool IsSetDurableConfig() => this.DurableConfig != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html">environment
        /// variables</a>. Omitted from CloudTrail logs.
        /// </para>
        /// </summary>
        public EnvironmentResponse Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The size of the function's <c>/tmp</c> directory in MB. The default value is 512,
        /// but can be any whole number between 512 and 10,240 MB. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-ephemeral-storage">Configuring
        /// ephemeral storage (console)</a>.
        /// </para>
        /// </summary>
        public EphemeralStorage EphemeralStorage { get; set; }

        /// <summary>
        /// Checks to see if the EphemeralStorage property is set.
        /// </summary>
        internal bool IsSetEphemeralStorage() => this.EphemeralStorage != null;

        /// <summary>
        /// Gets and sets the property FileSystemConfigs. 
        /// <para>
        /// Connection settings for an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html">Amazon
        /// EFS file system</a> or an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html">Amazon
        /// S3 file system</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<FileSystemConfig> FileSystemConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<FileSystemConfig>() : null;

        /// <summary>
        /// Checks to see if the FileSystemConfigs property is set.
        /// </summary>
        internal bool IsSetFileSystemConfigs() => this.FileSystemConfigs != null && (this.FileSystemConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The function's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property Handler. 
        /// <para>
        /// The function that Lambda calls to begin running your function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Handler { get; set; }

        /// <summary>
        /// Checks to see if the Handler property is set.
        /// </summary>
        internal bool IsSetHandler() => this.Handler != null;

        /// <summary>
        /// Gets and sets the property ImageConfigResponse. 
        /// <para>
        /// The function's image configuration values.
        /// </para>
        /// </summary>
        public ImageConfigResponse ImageConfigResponse { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfigResponse property is set.
        /// </summary>
        internal bool IsSetImageConfigResponse() => this.ImageConfigResponse != null;

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// The ARN of the Key Management Service (KMS) customer managed key that's used to encrypt
        /// the following resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-envvars.html#configuration-envvars-encryption">environment
        /// variables</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart-security.html">Lambda
        /// SnapStart</a> snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When used with <c>SourceKMSKeyArn</c>, the unzipped version of the .zip deployment
        /// package that's used for function invocations. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/encrypt-zip-package.html#enable-zip-custom-encryption">
        /// Specifying a customer managed key for Lambda</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The optimized version of the container image that's used for function invocations.
        /// Note that this is not the same key that's used to protect your container image in
        /// the Amazon Elastic Container Registry (Amazon ECR). For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-lifecycle">Function
        /// lifecycle</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't provide a customer managed key, Lambda uses an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">Amazon
        /// Web Services owned key</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string KMSKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyArn property is set.
        /// </summary>
        internal bool IsSetKMSKeyArn() => this.KMSKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the function was last updated, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// The status of the last update that was performed on the function. This is first set
        /// to <c>Successful</c> after function creation completes.
        /// </para>
        /// </summary>
        public LastUpdateStatus LastUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatus property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatus() => this.LastUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReason. 
        /// <para>
        /// The reason for the last update that was performed on the function.
        /// </para>
        /// </summary>
        public string LastUpdateStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatusReason property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatusReason() => this.LastUpdateStatusReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReasonCode. 
        /// <para>
        /// The reason code for the last update that was performed on the function.
        /// </para>
        /// </summary>
        public LastUpdateStatusReasonCode LastUpdateStatusReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatusReasonCode property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatusReasonCode() => this.LastUpdateStatusReasonCode != null;

        /// <summary>
        /// Gets and sets the property Layers. 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">layers</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Layer> Layers { get; set; } = AWSConfigs.InitializeCollections ? new List<Layer>() : null;

        /// <summary>
        /// Checks to see if the Layers property is set.
        /// </summary>
        internal bool IsSetLayers() => this.Layers != null && (this.Layers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// The function's Amazon CloudWatch Logs configuration settings.
        /// </para>
        /// </summary>
        public LoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfig property is set.
        /// </summary>
        internal bool IsSetLoggingConfig() => this.LoggingConfig != null;

        /// <summary>
        /// Gets and sets the property MasterArn. 
        /// <para>
        /// For Lambda@Edge functions, the ARN of the main function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string MasterArn { get; set; }

        /// <summary>
        /// Checks to see if the MasterArn property is set.
        /// </summary>
        internal bool IsSetMasterArn() => this.MasterArn != null;

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The amount of memory available to the function at runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 128, Max = 32768)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// Checks to see if the MemorySize property is set.
        /// </summary>
        internal bool IsSetMemorySize() => this.MemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of deployment package. Set to <c>Image</c> for container image and set <c>Zip</c>
        /// for .zip file archive.
        /// </para>
        /// </summary>
        public PackageType PackageType { get; set; }

        /// <summary>
        /// Checks to see if the PackageType property is set.
        /// </summary>
        internal bool IsSetPackageType() => this.PackageType != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The latest updated revision of the function or alias.
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The function's execution role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The identifier of the function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">
        /// runtime</a>. Runtime is required if the deployment package is a .zip file archive.
        /// Specifying a runtime results in an error if you're deploying a function using a container
        /// image.
        /// </para>
        ///  
        /// <para>
        /// The following list includes deprecated runtimes. Lambda blocks creating new functions
        /// and updating existing functions shortly after each runtime is deprecated. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtime-deprecation-levels">Runtime
        /// use after deprecation</a>.
        /// </para>
        ///  
        /// <para>
        /// For a list of all currently supported runtimes, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtimes-supported">Supported
        /// runtimes</a>.
        /// </para>
        /// </summary>
        public Runtime Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersionConfig. 
        /// <para>
        /// The ARN of the runtime and any errors that occured.
        /// </para>
        /// </summary>
        public RuntimeVersionConfig RuntimeVersionConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersionConfig property is set.
        /// </summary>
        internal bool IsSetRuntimeVersionConfig() => this.RuntimeVersionConfig != null;

        /// <summary>
        /// Gets and sets the property SigningJobArn. 
        /// <para>
        /// The ARN of the signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string SigningJobArn { get; set; }

        /// <summary>
        /// Checks to see if the SigningJobArn property is set.
        /// </summary>
        internal bool IsSetSigningJobArn() => this.SigningJobArn != null;

        /// <summary>
        /// Gets and sets the property SigningProfileVersionArn. 
        /// <para>
        /// The ARN of the signing profile version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string SigningProfileVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SigningProfileVersionArn property is set.
        /// </summary>
        internal bool IsSetSigningProfileVersionArn() => this.SigningProfileVersionArn != null;

        /// <summary>
        /// Gets and sets the property SnapStart. 
        /// <para>
        /// Set <c>ApplyOn</c> to <c>PublishedVersions</c> to create a snapshot of the initialized
        /// execution environment when you publish a function version. For more information, see
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html">Improving startup
        /// performance with Lambda SnapStart</a>.
        /// </para>
        /// </summary>
        public SnapStartResponse SnapStart { get; set; }

        /// <summary>
        /// Checks to see if the SnapStart property is set.
        /// </summary>
        internal bool IsSetSnapStart() => this.SnapStart != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the function. When the state is <c>Inactive</c>, you can reactivate
        /// the function by invoking it.
        /// </para>
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the function's current state.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StateReasonCode. 
        /// <para>
        /// The reason code for the function's current state. When the code is <c>Creating</c>,
        /// you can't invoke or modify the function.
        /// </para>
        /// </summary>
        public StateReasonCode StateReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the StateReasonCode property is set.
        /// </summary>
        internal bool IsSetStateReasonCode() => this.StateReasonCode != null;

        /// <summary>
        /// Gets and sets the property TenancyConfig. 
        /// <para>
        /// The function's tenant isolation configuration settings. Determines whether the Lambda
        /// function runs on a shared or dedicated infrastructure per unique tenant.
        /// </para>
        /// </summary>
        public TenancyConfig TenancyConfig { get; set; }

        /// <summary>
        /// Checks to see if the TenancyConfig property is set.
        /// </summary>
        internal bool IsSetTenancyConfig() => this.TenancyConfig != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time in seconds that Lambda allows a function to run before stopping
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5400)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property TracingConfig. 
        /// <para>
        /// The function's X-Ray tracing configuration.
        /// </para>
        /// </summary>
        public TracingConfigResponse TracingConfig { get; set; }

        /// <summary>
        /// Checks to see if the TracingConfig property is set.
        /// </summary>
        internal bool IsSetTracingConfig() => this.TracingConfig != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The function's networking configuration.
        /// </para>
        /// </summary>
        public VpcConfigDetail VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
