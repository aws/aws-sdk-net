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
    /// Container for the parameters to the UpdateFunctionConfiguration operation. Modifies
    /// the version-specific settings of a Lambda Event Function. <para> When you update a
    /// function, Lambda provisions an instance of the function and its supporting resources.
    /// If your function connects to a VPC, this process can take a minute. During this time,
    /// you can't modify the function, but you can still invoke it. The <c>LastUpdateStatus</c>,
    /// <c>LastUpdateStatusReason</c>, and <c>LastUpdateStatusReasonCode</c> fields in the
    /// response from <a>GetFunctionConfiguration</a> indicate when the update is complete
    /// and the function is processing events with the new configuration. For more information,
    /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
    /// function states</a>. </para> <para> These settings can vary between versions of a
    /// function and are locked when you publish a version. You can't modify the configuration
    /// of a published version, only the unpublished version. </para> <para> To configure
    /// function concurrency, use <a>PutFunctionConcurrency</a>. To grant invoke permissions
    /// to an Amazon Web Services account or Amazon Web Services service, use <a>AddPermission</a>.
    /// </para>
    /// </summary>
    public partial class UpdateFunctionConfigurationRequest : AmazonLambdaRequest
    {
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
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// A dead-letter queue configuration that specifies the queue or topic where Lambda sends
        /// asynchronous events when they fail processing. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq">Dead-letter
        /// queues</a>.
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
        /// A description of the function.
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
        /// Configuration settings for <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
        /// functions</a>, including execution timeout, retention period for execution history,
        /// and an optional ARN of the Key Management Service (KMS) customer managed key that
        /// is used to encrypt your durable execution's payload data, including input, output,
        /// and error payloads.
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
        /// Environment variables that are accessible from function code during execution.
        /// </para>
        /// </summary>
        public Environment Environment { get; set; }

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

        private List<FileSystemConfig> _FileSystemConfigs = AWSConfigs.InitializeCollections ? new List<FileSystemConfig>() : null;

        /// <summary>
        /// Gets and sets the property FileSystemConfigs. 
        /// <para>
        /// Connection settings for an Amazon EFS file system or an Amazon S3 Files file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<FileSystemConfig> FileSystemConfigs { get => this._FileSystemConfigs; set => this._FileSystemConfigs = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="FileSystemConfigs"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="FileSystemConfigs"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsFileSystemConfigsSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._FileSystemConfigs);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._FileSystemConfigs);
        }

        /// <summary>
        /// Checks to see if the FileSystemConfigs property is set.
        /// </summary>
        internal bool IsSetFileSystemConfigs() => this.IsFileSystemConfigsSet;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <c>my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <c>arn:aws:lambda:us-west-2:123456789012:function:my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <c>123456789012:function:my-function</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

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
        [AWSProperty(Min = 0, Max = 128)]
        public string Handler { get; set; }

        /// <summary>
        /// Checks to see if the Handler property is set.
        /// </summary>
        internal bool IsSetHandler() => this.Handler != null;

        /// <summary>
        /// Gets and sets the property ImageConfig. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-parms">Container
        /// image configuration values</a> that override the values in the container image Docker
        /// file.
        /// </para>
        /// </summary>
        public ImageConfig ImageConfig { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfig property is set.
        /// </summary>
        internal bool IsSetImageConfig() => this.ImageConfig != null;

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

        private List<string> _Layers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Layers. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">function
        /// layers</a> to add to the function's execution environment. Specify each layer by its
        /// ARN, including the version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Layers { get => this._Layers; set => this._Layers = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="Layers"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="Layers"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsLayersSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._Layers);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._Layers);
        }

        /// <summary>
        /// Checks to see if the Layers property is set.
        /// </summary>
        internal bool IsSetLayers() => this.IsLayersSet;

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
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The amount of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console">memory
        /// available to the function</a> at runtime. Increasing the function memory also increases
        /// its CPU allocation. The default value is 128 MB. The value can be any multiple of
        /// 1 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 128, Max = 32768)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// Checks to see if the MemorySize property is set.
        /// </summary>
        internal bool IsSetMemorySize() => this.MemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Update the function only if the revision ID matches the ID that's specified. Use this
        /// option to avoid modifying a function that has changed since you last read it.
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
        /// The Amazon Resource Name (ARN) of the function's execution role.
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
        /// Gets and sets the property SnapStart. 
        /// <para>
        /// The function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html">SnapStart</a>
        /// setting.
        /// </para>
        /// </summary>
        public SnapStart SnapStart { get; set; }

        /// <summary>
        /// Checks to see if the SnapStart property is set.
        /// </summary>
        internal bool IsSetSnapStart() => this.SnapStart != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time (in seconds) that Lambda allows a function to run before stopping
        /// it. The default is 3 seconds, and the maximum allowed value is 900 seconds. For functions
        /// using Lambda Managed Instances, asynchronous invocations and event source mapping
        /// invocations (except Amazon MQ and Amazon DocumentDB) support a maximum allowed value
        /// of 5,400 seconds (90 minutes). For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/runtimes-context.html">Lambda
        /// execution environment</a>.
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
        /// Set <c>Mode</c> to <c>Active</c> to sample and trace a subset of incoming requests
        /// with <a href="https://docs.aws.amazon.com/lambda/latest/dg/services-xray.html">X-Ray</a>.
        /// </para>
        /// </summary>
        public TracingConfig TracingConfig { get; set; }

        /// <summary>
        /// Checks to see if the TracingConfig property is set.
        /// </summary>
        internal bool IsSetTracingConfig() => this.TracingConfig != null;

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
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
