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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
    /// Container for the parameters to the StartCommandExecution operation.
    /// Starts a command execution.
    /// </summary>
    public partial class StartCommandExecutionRequest : AmazonCodeBuildRequest
    {
        private string _command;
        private string _sandboxId;
        private CommandType _type;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that needs to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property SandboxId. 
        /// <para>
        /// A <c>sandboxId</c> or <c>sandboxArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string SandboxId
        {
            get { return this._sandboxId; }
            set { this._sandboxId = value; }
        }

        // Check to see if SandboxId property is set
        internal bool IsSetSandboxId()
        {
            return this._sandboxId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The command type.
        /// </para>
        /// </summary>
        public CommandType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}