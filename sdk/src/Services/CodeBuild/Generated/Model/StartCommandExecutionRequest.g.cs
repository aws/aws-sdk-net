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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the StartCommandExecution operation. Starts a command
    /// execution.
    /// </summary>
    public partial class StartCommandExecutionRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that needs to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property SandboxId. 
        /// <para>
        /// A <c>sandboxId</c> or <c>sandboxArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string SandboxId { get; set; }

        /// <summary>
        /// Checks to see if the SandboxId property is set.
        /// </summary>
        internal bool IsSetSandboxId() => this.SandboxId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The command type.
        /// </para>
        /// </summary>
        public CommandType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
