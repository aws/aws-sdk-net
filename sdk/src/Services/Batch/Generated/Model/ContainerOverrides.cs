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
    /// The overrides that should be sent to a container.
    /// </summary>
    public partial class ContainerOverrides
    {
        private List<string> _command = new List<string>();
        private List<KeyValuePair> _environment = new List<KeyValuePair>();
        private string _instanceType;
        private int? _memory;
        private int? _vcpus;

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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to send to the container. You can add new environment variables,
        /// which are added to the container at launch, or you can override the existing environment
        /// variables from the Docker image or the job definition.
        /// </para>
        ///  <note> 
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use for a multi-node parallel job. This parameter is not valid
        /// for single-node container jobs.
        /// </para>
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
        /// Gets and sets the property Memory. 
        /// <para>
        /// The number of MiB of memory reserved for the job. This value overrides the value set
        /// in the job definition.
        /// </para>
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
        /// Gets and sets the property Vcpus. 
        /// <para>
        /// The number of vCPUs to reserve for the container. This value overrides the value set
        /// in the job definition.
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

    }
}