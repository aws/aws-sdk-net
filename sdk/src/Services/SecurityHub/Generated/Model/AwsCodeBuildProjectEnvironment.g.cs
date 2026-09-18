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
    /// Information about the build environment for this build project.
    /// </summary>
    public partial class AwsCodeBuildProjectEnvironment
    {
        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The certificate to use with this build project.
        /// </para>
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// A set of environment variables to make available to builds for the build project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetails> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetails>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public string ImagePullCredentialsType { get; set; }

        /// <summary>
        /// Checks to see if the ImagePullCredentialsType property is set.
        /// </summary>
        internal bool IsSetImagePullCredentialsType() => this.ImagePullCredentialsType != null;

        /// <summary>
        /// Gets and sets the property PrivilegedMode. 
        /// <para>
        /// Whether to allow the Docker daemon to run inside a Docker container. Set to <c>true</c>
        /// if the build project is used to build Docker images.
        /// </para>
        /// </summary>
        public bool? PrivilegedMode { get; set; }

        /// <summary>
        /// Checks to see if the PrivilegedMode property is set.
        /// </summary>
        internal bool IsSetPrivilegedMode() => this.PrivilegedMode.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryCredential. 
        /// <para>
        /// The credentials for access to a private registry.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectEnvironmentRegistryCredential RegistryCredential { get; set; }

        /// <summary>
        /// Checks to see if the RegistryCredential property is set.
        /// </summary>
        internal bool IsSetRegistryCredential() => this.RegistryCredential != null;

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
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
