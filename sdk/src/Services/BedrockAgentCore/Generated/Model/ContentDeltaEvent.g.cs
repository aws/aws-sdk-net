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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// An event that contains incremental output from a command execution. This event streams
    /// standard output and standard error content as it becomes available during command
    /// execution.
    /// </summary>
    public partial class ContentDeltaEvent
    {
        /// <summary>
        /// Gets and sets the property Stderr. 
        /// <para>
        /// The standard error content from the command execution. This field contains the incremental
        /// output written to stderr by the executing command.
        /// </para>
        /// </summary>
        public string Stderr { get; set; }

        /// <summary>
        /// Checks to see if the Stderr property is set.
        /// </summary>
        internal bool IsSetStderr() => this.Stderr != null;

        /// <summary>
        /// Gets and sets the property Stdout. 
        /// <para>
        /// The standard output content from the command execution. This field contains the incremental
        /// output written to stdout by the executing command.
        /// </para>
        /// </summary>
        public string Stdout { get; set; }

        /// <summary>
        /// Checks to see if the Stdout property is set.
        /// </summary>
        internal bool IsSetStdout() => this.Stdout != null;
    }
}
