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
    /// Object representing any Kubernetes overrides to a job definition that's used in a
    /// <a>SubmitJob</a> API operation.
    /// </summary>
    public partial class EksContainerOverride
    {
        private List<string> _args = new List<string>();
        private List<string> _command = new List<string>();
        private List<EksContainerEnvironmentVariable> _env = new List<EksContainerEnvironmentVariable>();
        private string _image;
        private EksContainerResourceRequirements _resources;

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// The arguments to the entrypoint to send to the container that overrides the default
        /// arguments from the Docker image or the job definition. For more information, see <a
        /// href="https://docs.docker.com/engine/reference/builder/#cmd">CMD</a> in the <i>Dockerfile
        /// reference</i> and <a href="https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/">Define
        /// a command an arguments for a pod</a> in the <i>Kubernetes documentation</i>.
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
        /// The command to send to the container that overrides the default command from the Docker
        /// image or the job definition.
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
        /// The environment variables to send to the container. You can add new environment variables,
        /// which are added to the container at launch. Or, you can override the existing environment
        /// variables from the Docker image or the job definition.
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
        /// The override of the Docker image that's used to start the container.
        /// </para>
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// The type and amount of resources to assign to a container. These override the settings
        /// in the job definition. The supported resources include <code>memory</code>, <code>cpu</code>,
        /// and <code>nvidia.com/gpu</code>. For more information, see <a href="https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/">Resource
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

    }
}