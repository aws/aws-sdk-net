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
    /// The request body structure for the <c>InvokeAgentRuntimeCommand</c> operation, containing
    /// the command to execute and optional configuration parameters.
    /// </summary>
    public partial class InvokeAgentRuntimeCommandRequestBody
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The shell command to execute on the agent runtime. This command is executed in the
        /// runtime environment and its output is streamed back to the caller.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public string Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The maximum duration in seconds to wait for the command to complete. If the command
        /// execution exceeds this timeout, it will be terminated. Default is 300 seconds. Minimum
        /// is 1 second. Maximum is 3600 seconds.
        /// </para>
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;
    }
}
