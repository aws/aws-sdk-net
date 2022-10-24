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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// EKS container properties are used in job definitions for Amazon EKS based job definitions
    /// to describe the properties for a container node in the pod that's launched as part
    /// of a job. This can't be specified for Amazon ECS based job definitions.
    /// </summary>
    public partial class EksContainer
    {
        private List<string> _args = new List<string>();
        private List<string> _command = new List<string>();
        private List<EksContainerEnvironmentVariable> _env = new List<EksContainerEnvironmentVariable>();
        private string _image;
        private string _imagePullPolicy;
        private string _name;
        private EksContainerResourceRequirements _resources;
        private EksContainerSecurityContext _securityContext;
        private List<EksContainerVolumeMount> _volumeMounts = new List<EksContainerVolumeMount>();

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// An array of arguments to the entrypoint. If this isn't specified, the <code>CMD</code>
        /// of the container image is used. This corresponds to the <code>args</code> member in
        /// the <a href="https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#entrypoint">Entrypoint</a>
        /// portion of the <a href="https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/">Pod</a>
        /// in Kubernetes. Environment variable references are expanded using the container's
        /// environment.
        /// </para>
        ///  
        /// <para>
        /// If the referenced environment variable doesn't exist, the reference in the command
        /// isn't changed. For example, if the reference is to "<code>$(NAME1)</code>" and the
        /// <code>NAME1</code> environment variable doesn't exist, the command string will remain
        /// "<code>$(NAME1)</code>." <code>$$</code> is replaced with <code>$</code>, and the
        /// resulting string isn't expanded. For example, <code>$$(VAR_NAME)</code> is passed
        /// as <code>$(VAR_NAME)</code> whether or not the <code>VAR_NAME</code> environment variable
        /// exists. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#cmd">CMD</a>
        /// in the <i>Dockerfile reference</i> and <a href="https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/">Define
        /// a command and arguments for a pod</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public List<string> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && this._args.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The entrypoint for the container. This isn't run within a shell. If this isn't specified,
        /// the <code>ENTRYPOINT</code> of the container image is used. Environment variable references
        /// are expanded using the container's environment.
        /// </para>
        ///  
        /// <para>
        /// If the referenced environment variable doesn't exist, the reference in the command
        /// isn't changed. For example, if the reference is to "<code>$(NAME1)</code>" and the
        /// <code>NAME1</code> environment variable doesn't exist, the command string will remain
        /// "<code>$(NAME1)</code>." <code>$$</code> is replaced with <code>$</code> and the resulting
        /// string isn't expanded. For example, <code>$$(VAR_NAME)</code> will be passed as <code>$(VAR_NAME)</code>
        /// whether or not the <code>VAR_NAME</code> environment variable exists. The entrypoint
        /// can't be updated. For more information, see <a href="https://docs.docker.com/engine/reference/builder/#entrypoint">ENTRYPOINT</a>
        /// in the <i>Dockerfile reference</i> and <a href="https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/">Define
        /// a command and arguments for a container</a> and <a href="https://kubernetes.io/docs/reference/kubernetes-api/workload-resources/pod-v1/#entrypoint">Entrypoint</a>
        /// in the <i>Kubernetes documentation</i>.
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
        /// Gets and sets the property Env. 
        /// <para>
        /// The environment variables to pass to a container.
        /// </para>
        ///  <note> 
        /// <para>
        /// Environment variables cannot start with "<code>AWS_BATCH</code>". This naming convention
        /// is reserved for variables that Batch sets.
        /// </para>
        ///  </note>
        /// </summary>
        public List<EksContainerEnvironmentVariable> Env
        {
            get { return this._env; }
            set { this._env = value; }
        }

        // Check to see if Env property is set
        internal bool IsSetEnv()
        {
            return this._env != null && this._env.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The Docker image used to start the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ImagePullPolicy. 
        /// <para>
        /// The image pull policy for the container. Supported values are <code>Always</code>,
        /// <code>IfNotPresent</code>, and <code>Never</code>. This parameter defaults to <code>IfNotPresent</code>.
        /// However, if the <code>:latest</code> tag is specified, it defaults to <code>Always</code>.
        /// For more information, see <a href="https://kubernetes.io/docs/concepts/containers/images/#updating-images">Updating
        /// images</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public string ImagePullPolicy
        {
            get { return this._imagePullPolicy; }
            set { this._imagePullPolicy = value; }
        }

        // Check to see if ImagePullPolicy property is set
        internal bool IsSetImagePullPolicy()
        {
            return this._imagePullPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container. If the name isn't specified, the default name "<code>Default</code>"
        /// is used. Each container in a pod must have a unique name.
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// The type and amount of resources to assign to a container. The supported resources
        /// include <code>memory</code>, <code>cpu</code>, and <code>nvidia.com/gpu</code>. For
        /// more information, see <a href="https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/">Resource
        /// management for pods and containers</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public EksContainerResourceRequirements Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityContext. 
        /// <para>
        /// The security context for a job. For more information, see <a href="https://kubernetes.io/docs/tasks/configure-pod-container/security-context/">Configure
        /// a security context for a pod or container</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public EksContainerSecurityContext SecurityContext
        {
            get { return this._securityContext; }
            set { this._securityContext = value; }
        }

        // Check to see if SecurityContext property is set
        internal bool IsSetSecurityContext()
        {
            return this._securityContext != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeMounts. 
        /// <para>
        /// The volume mounts for the container. Batch supports <code>emptyDir</code>, <code>hostPath</code>,
        /// and <code>secret</code> volume types. For more information about volumes and volume
        /// mounts in Kubernetes, see <a href="https://kubernetes.io/docs/concepts/storage/volumes/">Volumes</a>
        /// in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public List<EksContainerVolumeMount> VolumeMounts
        {
            get { return this._volumeMounts; }
            set { this._volumeMounts = value; }
        }

        // Check to see if VolumeMounts property is set
        internal bool IsSetVolumeMounts()
        {
            return this._volumeMounts != null && this._volumeMounts.Count > 0; 
        }

    }
}