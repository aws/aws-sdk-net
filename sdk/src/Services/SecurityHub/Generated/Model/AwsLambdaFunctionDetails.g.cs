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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Lambda function's configuration.
    /// </summary>
    public partial class AwsLambdaFunctionDetails
    {
        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The instruction set architecture that the function uses. Valid values are <c>x86_64</c>
        /// or <c>arm64</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Architectures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Architectures property is set.
        /// </summary>
        internal bool IsSetArchitectures() => this.Architectures != null && (this.Architectures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// An <c>AwsLambdaFunctionCode</c> object.
        /// </para>
        /// </summary>
        public AwsLambdaFunctionCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

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
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// The function's dead letter queue.
        /// </para>
        /// </summary>
        public AwsLambdaFunctionDeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterConfig property is set.
        /// </summary>
        internal bool IsSetDeadLetterConfig() => this.DeadLetterConfig != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The function's environment variables.
        /// </para>
        /// </summary>
        public AwsLambdaFunctionEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function.
        /// </para>
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property Handler. 
        /// <para>
        /// The function that Lambda calls to begin executing your function.
        /// </para>
        /// </summary>
        public string Handler { get; set; }

        /// <summary>
        /// Checks to see if the Handler property is set.
        /// </summary>
        internal bool IsSetHandler() => this.Handler != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The KMS key that is used to encrypt the function's environment variables. This key
        /// is only returned if you've configured a customer managed customer managed key.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Indicates when the function was last updated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property Layers. 
        /// <para>
        /// The function's layers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsLambdaFunctionLayer> Layers { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsLambdaFunctionLayer>() : null;

        /// <summary>
        /// Checks to see if the Layers property is set.
        /// </summary>
        internal bool IsSetLayers() => this.Layers != null && (this.Layers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MasterArn. 
        /// <para>
        /// For Lambda@Edge functions, the ARN of the master function.
        /// </para>
        /// </summary>
        public string MasterArn { get; set; }

        /// <summary>
        /// Checks to see if the MasterArn property is set.
        /// </summary>
        internal bool IsSetMasterArn() => this.MasterArn != null;

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The memory that is allocated to the function.
        /// </para>
        /// </summary>
        public int? MemorySize { get; set; }

        /// <summary>
        /// Checks to see if the MemorySize property is set.
        /// </summary>
        internal bool IsSetMemorySize() => this.MemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property PackageType. 
        /// <para>
        /// The type of deployment package that's used to deploy the function code to Lambda.
        /// Set to <c>Image</c> for a container image and <c>Zip</c> for a .zip file archive.
        /// 
        /// </para>
        /// </summary>
        public string PackageType { get; set; }

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
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime environment for the Lambda function.
        /// </para>
        /// </summary>
        public string Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time that Lambda allows a function to run before stopping it.
        /// </para>
        /// </summary>
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
        public AwsLambdaFunctionTracingConfig TracingConfig { get; set; }

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
        public AwsLambdaFunctionVpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
