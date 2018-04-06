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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container properties are used in job definitions to describe the container that is
    /// launched as part of a job.
    /// </summary>
    public partial class ContainerProperties
    {
        private List<string> _command = new List<string>();
        private List<KeyValuePair> _environment = new List<KeyValuePair>();
        private string _image;
        private string _jobRoleArn;
        private int? _memory;
        private List<MountPoint> _mountPoints = new List<MountPoint>();
        private bool? _privileged;
        private bool? _readonlyRootFilesystem;
        private List<Ulimit> _ulimits = new List<Ulimit>();
        private string _user;
        private int? _vcpus;
        private List<Volume> _volumes = new List<Volume>();

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that is passed to the container. This parameter maps to <code>Cmd</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>COMMAND</code> parameter to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#cmd">https://docs.docker.com/engine/reference/builder/#cmd</a>.
        /// </para>
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && this._command.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container. This parameter maps to <code>Env</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--env</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// We do not recommend using plaintext environment variables for sensitive information,
        /// such as credential data.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Environment variables must not start with <code>AWS_BATCH</code>; this naming convention
        /// is reserved for variables that are set by the AWS Batch service.
        /// </para>
        ///  </note>
        /// </summary>
        public List<KeyValuePair> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. Images in the Docker Hub registry are available by default. Other repositories
        /// are specified with <code> <i>repository-url</i>/<i>image</i>:<i>tag</i> </code>. Up
        /// to 255 letters (uppercase and lowercase), numbers, hyphens, underscores, colons, periods,
        /// forward slashes, and number signs are allowed. This parameter maps to <code>Image</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>IMAGE</code> parameter of <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Images in Amazon ECR repositories use the full registry and repository URI (for example,
        /// <code>012345678910.dkr.ecr.&lt;region-name&gt;.amazonaws.com/&lt;repository-name&gt;</code>).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in official repositories on Docker Hub use a single name (for example, <code>ubuntu</code>
        /// or <code>mongo</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other repositories on Docker Hub are qualified with an organization name
        /// (for example, <code>amazon/amazon-ecs-agent</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other online repositories are qualified further by a domain name (for example,
        /// <code>quay.io/assemblyline/ubuntu</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property JobRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the container can assume for AWS
        /// permissions.
        /// </para>
        /// </summary>
        public string JobRoleArn
        {
            get { return this._jobRoleArn; }
            set { this._jobRoleArn = value; }
        }

        // Check to see if JobRoleArn property is set
        internal bool IsSetJobRoleArn()
        {
            return this._jobRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The hard limit (in MiB) of memory to present to the container. If your container attempts
        /// to exceed the memory specified here, the container is killed. This parameter maps
        /// to <code>Memory</code> in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--memory</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. You must specify at least 4 MiB of memory for a job.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are trying to maximize your resource utilization by providing your jobs as
        /// much memory as possible for a particular instance type, see <a href="http://docs.aws.amazon.com/batch/latest/userguide/memory-management.html">Memory
        /// Management</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public int Memory
        {
            get { return this._memory.GetValueOrDefault(); }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container. This parameter maps to <code>Volumes</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--volume</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public List<MountPoint> MountPoints
        {
            get { return this._mountPoints; }
            set { this._mountPoints = value; }
        }

        // Check to see if MountPoints property is set
        internal bool IsSetMountPoints()
        {
            return this._mountPoints != null && this._mountPoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated privileges on the host
        /// container instance (similar to the <code>root</code> user). This parameter maps to
        /// <code>Privileged</code> in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--privileged</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public bool Privileged
        {
            get { return this._privileged.GetValueOrDefault(); }
            set { this._privileged = value; }
        }

        // Check to see if Privileged property is set
        internal bool IsSetPrivileged()
        {
            return this._privileged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// When this parameter is true, the container is given read-only access to its root file
        /// system. This parameter maps to <code>ReadonlyRootfs</code> in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--read-only</code> option to <code>docker run</code>.
        /// </para>
        /// </summary>
        public bool ReadonlyRootFilesystem
        {
            get { return this._readonlyRootFilesystem.GetValueOrDefault(); }
            set { this._readonlyRootFilesystem = value; }
        }

        // Check to see if ReadonlyRootFilesystem property is set
        internal bool IsSetReadonlyRootFilesystem()
        {
            return this._readonlyRootFilesystem.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <code>ulimits</code> to set in the container. This parameter maps to <code>Ulimits</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--ulimit</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public List<Ulimit> Ulimits
        {
            get { return this._ulimits; }
            set { this._ulimits = value; }
        }

        // Check to see if Ulimits property is set
        internal bool IsSetUlimits()
        {
            return this._ulimits != null && this._ulimits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user name to use inside the container. This parameter maps to <code>User</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--user</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>.
        /// </para>
        /// </summary>
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

        /// <summary>
        /// Gets and sets the property Vcpus. 
        /// <para>
        /// The number of vCPUs reserved for the container. This parameter maps to <code>CpuShares</code>
        /// in the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/reference/api/docker_remote_api_v1.23/">Docker
        /// Remote API</a> and the <code>--cpu-shares</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. Each vCPU is equivalent to 1,024 CPU shares. You must specify at least one
        /// vCPU.
        /// </para>
        /// </summary>
        public int Vcpus
        {
            get { return this._vcpus.GetValueOrDefault(); }
            set { this._vcpus = value; }
        }

        // Check to see if Vcpus property is set
        internal bool IsSetVcpus()
        {
            return this._vcpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// A list of data volumes used in a job.
        /// </para>
        /// </summary>
        public List<Volume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && this._volumes.Count > 0; 
        }

    }
}