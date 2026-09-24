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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Defines the Amazon Braket hybrid job to be created. Specifies the container image
    /// the job uses and the paths to the Python scripts used for entry and training.
    /// </summary>
    public partial class AlgorithmSpecification
    {
        /// <summary>
        /// Gets and sets the property ContainerImage. 
        /// <para>
        /// The container image used to create an Amazon Braket hybrid job.
        /// </para>
        /// </summary>
        public ContainerImage ContainerImage { get; set; }

        /// <summary>
        /// Checks to see if the ContainerImage property is set.
        /// </summary>
        internal bool IsSetContainerImage() => this.ContainerImage != null;

        /// <summary>
        /// Gets and sets the property ScriptModeConfig. 
        /// <para>
        /// Configures the paths to the Python scripts used for entry and training.
        /// </para>
        /// </summary>
        public ScriptModeConfig ScriptModeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScriptModeConfig property is set.
        /// </summary>
        internal bool IsSetScriptModeConfig() => this.ScriptModeConfig != null;
    }
}
