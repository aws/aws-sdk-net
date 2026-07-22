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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// A script to run during a compute node lifecycle stage.
    /// </summary>
    public partial class NodeLifecycleScript
    {
        private List<string> _arguments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ExecutionPolicy _executionPolicy;
        private string _name;
        private OnError _onError;
        private ScriptSource _scriptSource;

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The command-line arguments to pass to the script. You can specify up to 20 arguments,
        /// and each argument can be up to 256 characters long.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && (this._arguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionPolicy. 
        /// <para>
        /// The policy that determines when the script runs. The default value is <c>FIRST_BOOT_ONLY</c>.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FIRST_BOOT_ONLY</c> – Runs the script only the first time the compute node boots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EVERY_BOOT</c> – Runs the script every time the compute node boots, including
        /// reboots.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionPolicy ExecutionPolicy
        {
            get { return this._executionPolicy; }
            set { this._executionPolicy = value; }
        }

        // Check to see if ExecutionPolicy property is set
        internal bool IsSetExecutionPolicy()
        {
            return this._executionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the script. The name can be up to 64 characters long. Valid characters
        /// are letters, numbers, spaces, underscores (<c>_</c>), and hyphens (<c>-</c>). The
        /// first character must be a letter or a number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property OnError. 
        /// <para>
        /// The behavior when the script fails. The default value is <c>TERMINATE</c>. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TERMINATE</c> – Terminates the compute node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOP_SEQUENCE</c> – Stops running subsequent scripts in the sequence but doesn't
        /// terminate the compute node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTINUE</c> – Ignores the error and continues running the next script.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OnError OnError
        {
            get { return this._onError; }
            set { this._onError = value; }
        }

        // Check to see if OnError property is set
        internal bool IsSetOnError()
        {
            return this._onError != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptSource. 
        /// <para>
        /// The source location and integrity information for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScriptSource ScriptSource
        {
            get { return this._scriptSource; }
            set { this._scriptSource = value; }
        }

        // Check to see if ScriptSource property is set
        internal bool IsSetScriptSource()
        {
            return this._scriptSource != null;
        }

    }
}