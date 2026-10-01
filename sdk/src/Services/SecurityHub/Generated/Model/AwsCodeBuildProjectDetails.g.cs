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
    /// Information about an CodeBuild project.
    /// </summary>
    public partial class AwsCodeBuildProjectDetails
    {
        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// Information about the build artifacts for the CodeBuild project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCodeBuildProjectArtifactsDetails> Artifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCodeBuildProjectArtifactsDetails>() : null;

        /// <summary>
        /// Checks to see if the Artifacts property is set.
        /// </summary>
        internal bool IsSetArtifacts() => this.Artifacts != null && (this.Artifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The KMS key used to encrypt the build output artifacts.
        /// </para>
        ///  
        /// <para>
        /// You can specify either the ARN of the KMS key or, if available, the KMS key alias
        /// (using the format alias/alias-name). 
        /// </para>
        /// </summary>
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information about the build environment for this build project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property LogsConfig. 
        /// <para>
        /// Information about logs for the build project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectLogsConfigDetails LogsConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogsConfig property is set.
        /// </summary>
        internal bool IsSetLogsConfig() => this.LogsConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the build project.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        /// Information about the secondary artifacts for the CodeBuild project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCodeBuildProjectArtifactsDetails> SecondaryArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCodeBuildProjectArtifactsDetails>() : null;

        /// <summary>
        /// Checks to see if the SecondaryArtifacts property is set.
        /// </summary>
        internal bool IsSetSecondaryArtifacts() => this.SecondaryArtifacts != null && (this.SecondaryArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The ARN of the IAM role that enables CodeBuild to interact with dependent Amazon Web
        /// Services services on behalf of the Amazon Web Services account.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the build input source code for this build project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Information about the VPC configuration that CodeBuild accesses.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectVpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
