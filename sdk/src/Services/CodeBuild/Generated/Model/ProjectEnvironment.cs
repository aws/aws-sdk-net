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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the build environment of the build project.
    /// </summary>
    public partial class ProjectEnvironment
    {
        private string _certificate;
        private ComputeConfiguration _computeConfiguration;
        private ComputeType _computeType;
        private DockerServer _dockerServer;
        private List<EnvironmentVariable> _environmentVariables = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;
        private ProjectFleet _fleet;
        private string _image;
        private ImagePullCredentialsType _imagePullCredentialsType;
        private bool? _privilegedMode;
        private RegistryCredential _registryCredential;
        private EnvironmentType _type;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The ARN of the Amazon S3 bucket, path prefix, and object key that contains the PEM-encoded
        /// certificate for the build project. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/create-project-cli.html#cli.environment.certificate">certificate</a>
        /// in the <i>CodeBuild User Guide</i>.
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
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration of the build project. This is only required if <c>computeType</c>
        /// is set to <c>ATTRIBUTE_BASED_COMPUTE</c>.
        /// </para>
        /// </summary>
        public ComputeConfiguration ComputeConfiguration
        {
            get { return this._computeConfiguration; }
            set { this._computeConfiguration = value; }
        }

        // Check to see if ComputeConfiguration property is set
        internal bool IsSetComputeConfiguration()
        {
            return this._computeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// Information about the compute resources the build project uses. Available values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ATTRIBUTE_BASED_COMPUTE</c>: Specify the amount of vCPUs, memory, disk space,
        /// and the type of machine.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you use <c>ATTRIBUTE_BASED_COMPUTE</c>, you must define your attributes by using
        /// <c>computeConfiguration</c>. CodeBuild will select the cheapest instance that satisfies
        /// your specified attributes. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html#environment-reserved-capacity.types">Reserved
        /// capacity environment types</a> in the <i>CodeBuild User Guide</i>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_SMALL</c>: Use up to 4 GiB memory and 2 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_MEDIUM</c>: Use up to 8 GiB memory and 4 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_LARGE</c>: Use up to 16 GiB memory and 8 vCPUs for builds, depending
        /// on your environment type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_XLARGE</c>: Use up to 72 GiB memory and 36 vCPUs for builds, depending
        /// on your environment type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_2XLARGE</c>: Use up to 144 GiB memory, 72 vCPUs, and 824 GB of
        /// SSD storage for builds. This compute type supports Docker images up to 100 GB uncompressed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_1GB</c>: Use up to 1 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_2GB</c>: Use up to 2 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_4GB</c>: Use up to 4 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_8GB</c>: Use up to 8 GiB memory for builds. Only available for environment
        /// type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_LAMBDA_10GB</c>: Use up to 10 GiB memory for builds. Only available for
        /// environment type <c>LINUX_LAMBDA_CONTAINER</c> and <c>ARM_LAMBDA_CONTAINER</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use <c>BUILD_GENERAL1_SMALL</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For environment type <c>LINUX_CONTAINER</c>, you can use up to 4 GiB memory and 2
        /// vCPUs for builds. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 16 GiB memory,
        /// 4 vCPUs, and 1 NVIDIA A10G Tensor Core GPU for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>ARM_CONTAINER</c>, you can use up to 4 GiB memory and 2 vCPUs
        /// on ARM-based processors for builds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use <c>BUILD_GENERAL1_LARGE</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For environment type <c>LINUX_CONTAINER</c>, you can use up to 16 GiB memory and
        /// 8 vCPUs for builds. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>LINUX_GPU_CONTAINER</c>, you can use up to 255 GiB memory,
        /// 32 vCPUs, and 4 NVIDIA Tesla V100 GPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For environment type <c>ARM_CONTAINER</c>, you can use up to 16 GiB memory and 8
        /// vCPUs on ARM-based processors for builds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html#environment.types">On-demand
        /// environment types</a> in the <i>CodeBuild User Guide.</i> 
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
        /// Gets and sets the property DockerServer. 
        /// <para>
        /// A DockerServer object to use for this build project.
        /// </para>
        /// </summary>
        public DockerServer DockerServer
        {
            get { return this._dockerServer; }
            set { this._dockerServer = value; }
        }

        // Check to see if DockerServer property is set
        internal bool IsSetDockerServer()
        {
            return this._dockerServer != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// A set of environment variables to make available to builds for this build project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariables
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
        /// Gets and sets the property Fleet. 
        /// <para>
        /// A ProjectFleet object to use for this build project.
        /// </para>
        /// </summary>
        public ProjectFleet Fleet
        {
            get { return this._fleet; }
            set { this._fleet = value; }
        }

        // Check to see if Fleet property is set
        internal bool IsSetFleet()
        {
            return this._fleet != null;
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image tag or image digest that identifies the Docker image to use for this build
        /// project. Use the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For an image tag: <c>&lt;registry&gt;/&lt;repository&gt;:&lt;tag&gt;</c>. For example,
        /// in the Docker repository that CodeBuild uses to manage its Docker images, this would
        /// be <c>aws/codebuild/standard:4.0</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an image digest: <c>&lt;registry&gt;/&lt;repository&gt;@&lt;digest&gt;</c>. For
        /// example, to specify an image with the digest "sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf,"
        /// use <c>&lt;registry&gt;/&lt;repository&gt;@sha256:cbbf2f9a99b47fc460d422812b6a5adff7dfee951d8fa2e4a98caa0382cfbdbf</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-available.html">Docker
        /// images provided by CodeBuild</a> in the <i>CodeBuild user guide</i>.
        /// </para>
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
        ///  The type of credentials CodeBuild uses to pull images in your build. There are two
        /// valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CODEBUILD</c> specifies that CodeBuild uses its own credentials. This requires
        /// that you modify your ECR repository policy to trust CodeBuild service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE_ROLE</c> specifies that CodeBuild uses your build project's service role.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  When you use a cross-account or private registry image, you must use SERVICE_ROLE
        /// credentials. When you use an CodeBuild curated image, you must use CODEBUILD credentials.
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
        /// interact with the Docker daemon fails. The default setting is <c>false</c>.
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
        ///  <c>- nohup /usr/local/bin/dockerd --host=unix:///var/run/docker.sock --host=tcp://0.0.0.0:2375
        /// --storage-driver=overlay&amp;</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>- timeout 15 sh -c "until docker info; do echo .; sleep 1; done"</c> 
        /// </para>
        ///  
        /// <para>
        /// If the operating system's base image is Alpine Linux and the previous command does
        /// not work, add the <c>-t</c> argument to <c>timeout</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>- nohup /usr/local/bin/dockerd --host=unix:///var/run/docker.sock --host=tcp://0.0.0.0:2375
        /// --storage-driver=overlay&amp;</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>- timeout -t 15 sh -c "until docker info; do echo .; sleep 1; done"</c> 
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
        ///  <note> 
        /// <para>
        /// If you're using compute fleets during project creation, <c>type</c> will be ignored.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-env-ref-compute-types.html">Build
        /// environment compute types</a> in the <i>CodeBuild user guide</i>.
        /// </para>
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