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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private List<AwsCodeBuildProjectArtifactsDetails> _artifacts = AWSConfigs.InitializeCollections ? new List<AwsCodeBuildProjectArtifactsDetails>() : null;
        private string _encryptionKey;
        private AwsCodeBuildProjectEnvironment _environment;
        private AwsCodeBuildProjectLogsConfigDetails _logsConfig;
        private string _name;
        private List<AwsCodeBuildProjectArtifactsDetails> _secondaryArtifacts = AWSConfigs.InitializeCollections ? new List<AwsCodeBuildProjectArtifactsDetails>() : null;
        private string _serviceRole;
        private AwsCodeBuildProjectSource _source;
        private AwsCodeBuildProjectVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// Information about the build artifacts for the CodeBuild project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCodeBuildProjectArtifactsDetails> Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }

        // Check to see if Artifacts property is set
        internal bool IsSetArtifacts()
        {
            return this._artifacts != null && (this._artifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information about the build environment for this build project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectEnvironment Environment
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
        /// Gets and sets the property LogsConfig. 
        /// <para>
        /// Information about logs for the build project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectLogsConfigDetails LogsConfig
        {
            get { return this._logsConfig; }
            set { this._logsConfig = value; }
        }

        // Check to see if LogsConfig property is set
        internal bool IsSetLogsConfig()
        {
            return this._logsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the build project.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        /// Information about the secondary artifacts for the CodeBuild project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCodeBuildProjectArtifactsDetails> SecondaryArtifacts
        {
            get { return this._secondaryArtifacts; }
            set { this._secondaryArtifacts = value; }
        }

        // Check to see if SecondaryArtifacts property is set
        internal bool IsSetSecondaryArtifacts()
        {
            return this._secondaryArtifacts != null && (this._secondaryArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The ARN of the IAM role that enables CodeBuild to interact with dependent Amazon Web
        /// Services services on behalf of the Amazon Web Services account.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the build input source code for this build project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Information about the VPC configuration that CodeBuild accesses.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectVpcConfig VpcConfig
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