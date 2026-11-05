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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Diagnostic information about executable scripts that are part of a deployment.
    /// </summary>
    public partial class Diagnostics
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The associated error code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Success: The specified script ran.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ScriptMissing: The specified script was not found in the specified location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ScriptNotExecutable: The specified script is not a recognized executable file type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ScriptTimedOut: The specified script did not finish running in the specified time
        /// period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ScriptFailed: The specified script failed to run as expected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UnknownError: The specified script did not run for an unknown reason.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LifecycleErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property LogTail. 
        /// <para>
        /// The last portion of the diagnostic log.
        /// </para>
        ///  
        /// <para>
        /// If available, CodeDeploy returns up to the last 4 KB of the diagnostic log.
        /// </para>
        /// </summary>
        public string LogTail { get; set; }

        /// <summary>
        /// Checks to see if the LogTail property is set.
        /// </summary>
        internal bool IsSetLogTail() => this.LogTail != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message associated with the error.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ScriptName. 
        /// <para>
        /// The name of the script.
        /// </para>
        /// </summary>
        public string ScriptName { get; set; }

        /// <summary>
        /// Checks to see if the ScriptName property is set.
        /// </summary>
        internal bool IsSetScriptName() => this.ScriptName != null;
    }
}
