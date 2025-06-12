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
    /// The overrides that should be sent to a container.
    /// 
    ///  
    /// <para>
    /// For information about using Batch overrides when you connect event sources to targets,
    /// see <a href="https://docs.aws.amazon.com/eventbridge/latest/pipes-reference/API_BatchContainerOverrides.html">BatchContainerOverrides</a>.
    /// </para>
    /// </summary>
    public partial class TaskContainerOverrides
    {
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<KeyValuePair> _environment = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;
        private string _name;
        private List<ResourceRequirement> _resourceRequirements = AWSConfigs.InitializeCollections ? new List<ResourceRequirement>() : null;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to send to the container that overrides the default command from the Docker
        /// image or the job definition.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter can't contain an empty string.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to send to the container. You can add new environment variables,
        /// which are added to the container at launch, or you can override the existing environment
        /// variables from the Docker image or the job definition.
        /// </para>
        ///  <note> 
        /// <para>
        /// Environment variables cannot start with <c>AWS_BATCH</c>. This naming convention is
        /// reserved for variables that Batch sets.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A pointer to the container that you want to override. The container's name provides
        /// a unique identifier for the container being used.
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
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of resources to assign to a container. This overrides the settings
        /// in the job definition. The supported resources include <c>GPU</c>, <c>MEMORY</c>,
        /// and <c>VCPU</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceRequirement> ResourceRequirements
        {
            get { return this._resourceRequirements; }
            set { this._resourceRequirements = value; }
        }

        // Check to see if ResourceRequirements property is set
        internal bool IsSetResourceRequirements()
        {
            return this._resourceRequirements != null && (this._resourceRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}