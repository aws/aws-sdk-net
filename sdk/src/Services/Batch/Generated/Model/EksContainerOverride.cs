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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Object representing any Kubernetes overrides to a job definition that's used in a
    /// <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_SubmitJob.html">SubmitJob</a>
    /// API operation.
    /// </summary>
    public partial class EksContainerOverride
    {
        private List<string> _args = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<EksContainerEnvironmentVariable> _env = AWSConfigs.InitializeCollections ? new List<EksContainerEnvironmentVariable>() : null;
        private string _image;
        private string _name;
        private EksContainerResourceRequirements _resources;

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// The arguments to the entrypoint to send to the container that overrides the default
        /// arguments from the Docker image or the job definition. For more information, see <a
        /// href="https://docs.docker.com/engine/reference/builder/#cmd">Dockerfile reference:
        /// CMD</a> and <a href="https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/">Define
        /// a command an arguments for a pod</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && (this._args.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to send to the container that overrides the default command from the Docker
        /// image or the job definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Environment variables cannot start with "<c>AWS_BATCH</c>". This naming convention
        /// is reserved for variables that Batch sets.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksContainerEnvironmentVariable> Env
        {
            get { return this._env; }
            set { this._env = value; }
        }

        // Check to see if Env property is set
        internal bool IsSetEnv()
        {
            return this._env != null && (this._env.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A pointer to the container that you want to override. The name must match a unique
        /// container name that you wish to override.
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
        /// The type and amount of resources to assign to a container. These override the settings
        /// in the job definition. The supported resources include <c>memory</c>, <c>cpu</c>,
        /// and <c>nvidia.com/gpu</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/">Resource
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