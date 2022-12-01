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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The overrides that are sent to a container.
    /// </summary>
    public partial class BatchContainerOverrides
    {
        private List<string> _command = new List<string>();
        private List<BatchEnvironmentVariable> _environment = new List<BatchEnvironmentVariable>();
        private string _instanceType;
        private List<BatchResourceRequirement> _resourceRequirements = new List<BatchResourceRequirement>();

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to send to the container that overrides the default command from the Docker
        /// image or the task definition.
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
        /// The environment variables to send to the container. You can add new environment variables,
        /// which are added to the container at launch, or you can override the existing environment
        /// variables from the Docker image or the task definition.
        /// </para>
        ///  <note> 
        /// <para>
        /// Environment variables cannot start with "<code>Batch</code>". This naming convention
        /// is reserved for variables that Batch sets.
        /// </para>
        ///  </note>
        /// </summary>
        public List<BatchEnvironmentVariable> Environment
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use for a multi-node parallel job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to single-node container jobs or jobs that run on
        /// Fargate resources, and shouldn't be provided.
        /// </para>
        ///  </note>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of resources to assign to a container. This overrides the settings
        /// in the job definition. The supported resources include <code>GPU</code>, <code>MEMORY</code>,
        /// and <code>VCPU</code>.
        /// </para>
        /// </summary>
        public List<BatchResourceRequirement> ResourceRequirements
        {
            get { return this._resourceRequirements; }
            set { this._resourceRequirements = value; }
        }

        // Check to see if ResourceRequirements property is set
        internal bool IsSetResourceRequirements()
        {
            return this._resourceRequirements != null && this._resourceRequirements.Count > 0; 
        }

    }
}