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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the build environment of the build project.
    /// </summary>
    public partial class ProjectEnvironment
    {
        private string _certificate;
        private ComputeType _computeType;
        private List<EnvironmentVariable> _environmentVariables = new List<EnvironmentVariable>();
        private string _image;
        private ImagePullCredentialsType _imagePullCredentialsType;
        private bool? _privilegedMode;
        private RegistryCredential _registryCredential;
        private EnvironmentType _type;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The ARN of the Amazon Simple Storage Service (Amazon S3) bucket, path prefix, and
        /// object key that contains the PEM-encoded certificate for the build project. For more
        /// information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/create-project-cli.html#cli.environment.certificate">certificate</a>
        /// in the <i>AWS CodeBuild User Guide</i>.
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
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// Information about the compute resources the build project uses. Available values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BUILD_GENERAL1_SMALL</code>: Use up to 3 GB memory and 2 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BUILD_GENERAL1_MEDIUM</code>: Use up to 7 GB memory and 4 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BUILD_GENERAL1_LARGE</code>: Use up to 16 GB memory and 8 vCPUs for builds,
        /// depending on your environment type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BUILD_GENERAL1_2XLARGE</code>: Use up to 145 GB memory, 72 vCPUs, and 824 GB
        /// of SSD storage for builds. This compute type supports Docker images up to 100 GB uncompressed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use <code>BUILD_GENERAL1_LARGE</code>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For environment type <code>LINUX_CONTAINER</code>, you can use up to 15 GB memory
        /// and 8 vCPUs for builds. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <code>LINUX_GPU_CONTAINER</code>, you can use up to 255 GB memory,
        /// 32 vCPUs, and 4 NVIDIA Tesla V100 GPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <code>ARM_CONTAINER</code>, you can use up to 16 GB memory and
        /// 8 vCPUs on ARM-based processors for builds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// Environment Compute Types</a> in the <i>AWS CodeBuild User Guide.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// A set of environment variables to make available to builds for this build project.
        /// </para>
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && this._environmentVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image tag or image digest that identifies the Docker image to use for this build
        /// project. Use the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For an image tag: <code>&lt;registry&gt;/&lt;repository&gt;:&lt;tag&gt;</code>. For
        /// example, in the Docker repository that CodeBuild uses to manage its Docker images,
        /// this would be <code>aws/codebuild/standard:4.0</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an image digest: <code>&lt;registry&gt;/&lt;repository&gt;@&lt;digest&gt;</code>.
        /// For example, to specify an image with the digest "sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf,"
        /// use <code>&lt;registry&gt;/&lt;repository&gt;@sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePullCredentialsType. 
        /// <para>
        ///  The type of credentials AWS CodeBuild uses to pull images in your build. There are
        /// two valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CODEBUILD</code> specifies that AWS CodeBuild uses its own credentials. This
        /// requires that you modify your ECR repository policy to trust AWS CodeBuild's service
        /// principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SERVICE_ROLE</code> specifies that AWS CodeBuild uses your build project's
        /// service role. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  When you use a cross-account or private registry image, you must use SERVICE_ROLE
        /// credentials. When you use an AWS CodeBuild curated image, you must use CODEBUILD credentials.
        /// 
        /// </para>
        /// </summary>
        public ImagePullCredentialsType ImagePullCredentialsType
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
        /// Enables running the Docker daemon inside a Docker container. Set to true only if the
        /// build project is used to build Docker images. Otherwise, a build that attempts to
        /// interact with the Docker daemon fails. The default setting is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// You can initialize the Docker daemon during the install phase of your build by adding
        /// one of the following sets of commands to the install phase of your buildspec file:
        /// </para>
        ///  
        /// <para>
        /// If the operating system's base image is Ubuntu Linux:
        /// </para>
        ///  
        /// <para>
        ///  <code>- nohup /usr/local/bin/dockerd --host=unix:///var/run/docker.sock --host=tcp://0.0.0.0:2375
        /// --storage-driver=overlay&amp;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>- timeout 15 sh -c "until docker info; do echo .; sleep 1; done"</code> 
        /// </para>
        ///  
        /// <para>
        /// If the operating system's base image is Alpine Linux and the previous command does
        /// not work, add the <code>-t</code> argument to <code>timeout</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>- nohup /usr/local/bin/dockerd --host=unix:///var/run/docker.sock --host=tcp://0.0.0.0:2375
        /// --storage-driver=overlay&amp;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>- timeout -t 15 sh -c "until docker info; do echo .; sleep 1; done"</code>
        /// 
        /// </para>
        /// </summary>
        public bool PrivilegedMode
        {
            get { return this._privilegedMode.GetValueOrDefault(); }
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
        ///  The credentials for access to a private registry.
        /// </para>
        /// </summary>
        public RegistryCredential RegistryCredential
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
        ///  <ul> <li> 
        /// <para>
        /// The environment type <code>ARM_CONTAINER</code> is available only in regions US East
        /// (N. Virginia), US East (Ohio), US West (Oregon), EU (Ireland), Asia Pacific (Mumbai),
        /// Asia Pacific (Tokyo), Asia Pacific (Sydney), and EU (Frankfurt).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <code>LINUX_CONTAINER</code> with compute type <code>build.general1.2xlarge</code>
        /// is available only in regions US East (N. Virginia), US East (Ohio), US West (Oregon),
        /// Canada (Central), EU (Ireland), EU (London), EU (Frankfurt), Asia Pacific (Tokyo),
        /// Asia Pacific (Seoul), Asia Pacific (Singapore), Asia Pacific (Sydney), China (Beijing),
        /// and China (Ningxia).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The environment type <code>LINUX_GPU_CONTAINER</code> is available only in regions
        /// US East (N. Virginia), US East (Ohio), US West (Oregon), Canada (Central), EU (Ireland),
        /// EU (London), EU (Frankfurt), Asia Pacific (Tokyo), Asia Pacific (Seoul), Asia Pacific
        /// (Singapore), Asia Pacific (Sydney) , China (Beijing), and China (Ningxia).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentType Type
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