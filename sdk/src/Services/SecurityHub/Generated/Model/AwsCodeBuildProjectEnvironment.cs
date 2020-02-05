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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the build environment for this build project.
    /// </summary>
    public partial class AwsCodeBuildProjectEnvironment
    {
        private string _certificate;
        private string _imagePullCredentialsType;
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
        /// Gets and sets the property ImagePullCredentialsType. 
        /// <para>
        /// The type of credentials AWS CodeBuild uses to pull images in your build.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CODEBUILD</code> specifies that AWS CodeBuild uses its own credentials. This
        /// requires that you modify your ECR repository policy to trust the AWS CodeBuild service
        /// principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SERVICE_ROLE</code> specifies that AWS CodeBuild uses your build project's
        /// service role.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you use a cross-account or private registry image, you must use <code>SERVICE_ROLE</code>
        /// credentials. When you use an AWS CodeBuild curated image, you must use <code>CODEBUILD</code>
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
        /// The environment type <code>ARM_CONTAINER</code> is available only in regions US East
        /// (N. Virginia), US East (Ohio), US West (Oregon), Europe (Ireland), Asia Pacific (Mumbai),
        /// Asia Pacific (Tokyo), Asia Pacific (Sydney), and Europe (Frankfurt).
        /// </para>
        ///  
        /// <para>
        /// The environment type <code>LINUX_CONTAINER</code> with compute type build.general1.2xlarge
        /// is available only in regions US East (N. Virginia), US East (N. Virginia), US West
        /// (Oregon), Canada (Central), Europe (Ireland), Europe (London), Europe (Frankfurt),
        /// Asia Pacific (Tokyo), Asia Pacific (Seoul), Asia Pacific (Singapore), Asia Pacific
        /// (Sydney), China (Beijing), and China (Ningxia).
        /// </para>
        ///  
        /// <para>
        /// The environment type <code>LINUX_GPU_CONTAINER</code> is available only in regions
        /// US East (N. Virginia), US East (N. Virginia), US West (Oregon), Canada (Central),
        /// Europe (Ireland), Europe (London), Europe (Frankfurt), Asia Pacific (Tokyo), Asia
        /// Pacific (Seoul), Asia Pacific (Singapore), Asia Pacific (Sydney) , China (Beijing),
        /// and China (Ningxia).
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>WINDOWS_CONTAINER</code> | <code>LINUX_CONTAINER</code> | <code>LINUX_GPU_CONTAINER</code>
        /// | <code>ARM_CONTAINER</code> 
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