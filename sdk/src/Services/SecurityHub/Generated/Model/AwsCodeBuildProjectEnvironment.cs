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
    /// Information about the build environment for this build project.
    /// </summary>
    public partial class AwsCodeBuildProjectEnvironment
    {
        private string _certificate;
        private List<AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetails> _environmentVariables = AWSConfigs.InitializeCollections ? new List<AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetails>() : null;
        private string _imagePullCredentialsType;
        private bool? _privilegedMode;
        private AwsCodeBuildProjectEnvironmentRegistryCredential _registryCredential;
        private string _type;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The certificate to use with this build project.
        /// </para>
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// A set of environment variables to make available to builds for the build project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetails> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImagePullCredentialsType. 
        /// <para>
        /// The type of credentials CodeBuild uses to pull images in your build.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CODEBUILD</c> specifies that CodeBuild uses its own credentials. This requires
        /// that you modify your ECR repository policy to trust the CodeBuild service principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE_ROLE</c> specifies that CodeBuild uses your build project's service role.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you use a cross-account or private registry image, you must use <c>SERVICE_ROLE</c>
        /// credentials. When you use an CodeBuild curated image, you must use <c>CODEBUILD</c>
        /// credentials.
        /// </para>
        /// </summary>
        public string ImagePullCredentialsType
        {
            get { return this._imagePullCredentialsType; }
            set { this._imagePullCredentialsType = value; }
        }

        // Check to see if ImagePullCredentialsType property is set
        internal bool IsSetImagePullCredentialsType()
        {
            return this._imagePullCredentialsType != null;
        }

        /// <summary>
        /// Gets and sets the property PrivilegedMode. 
        /// <para>
        /// Whether to allow the Docker daemon to run inside a Docker container. Set to <c>true</c>
        /// if the build project is used to build Docker images.
        /// </para>
        /// </summary>
        public bool? PrivilegedMode
        {
            get { return this._privilegedMode; }
            set { this._privilegedMode = value; }
        }

        // Check to see if PrivilegedMode property is set
        internal bool IsSetPrivilegedMode()
        {
            return this._privilegedMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryCredential. 
        /// <para>
        /// The credentials for access to a private registry.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectEnvironmentRegistryCredential RegistryCredential
        {
            get { return this._registryCredential; }
            set { this._registryCredential = value; }
        }

        // Check to see if RegistryCredential property is set
        internal bool IsSetRegistryCredential()
        {
            return this._registryCredential != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of build environment to use for related builds.
        /// </para>
        ///  
        /// <para>
        /// The environment type <c>ARM_CONTAINER</c> is available only in Regions US East (N.
        /// Virginia), US East (Ohio), US West (Oregon), Europe (Ireland), Asia Pacific (Mumbai),
        /// Asia Pacific (Tokyo), Asia Pacific (Sydney), and Europe (Frankfurt).
        /// </para>
        ///  
        /// <para>
        /// The environment type <c>LINUX_CONTAINER</c> with compute type build.general1.2xlarge
        /// is available only in Regions US East (N. Virginia), US East (N. Virginia), US West
        /// (Oregon), Canada (Central), Europe (Ireland), Europe (London), Europe (Frankfurt),
        /// Asia Pacific (Tokyo), Asia Pacific (Seoul), Asia Pacific (Singapore), Asia Pacific
        /// (Sydney), China (Beijing), and China (Ningxia).
        /// </para>
        ///  
        /// <para>
        /// The environment type <c>LINUX_GPU_CONTAINER</c> is available only in Regions US East
        /// (N. Virginia), US East (N. Virginia), US West (Oregon), Canada (Central), Europe (Ireland),
        /// Europe (London), Europe (Frankfurt), Asia Pacific (Tokyo), Asia Pacific (Seoul), Asia
        /// Pacific (Singapore), Asia Pacific (Sydney), China (Beijing), and China (Ningxia).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>WINDOWS_CONTAINER</c> | <c>LINUX_CONTAINER</c> | <c>LINUX_GPU_CONTAINER</c>
        /// | <c>ARM_CONTAINER</c> 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}