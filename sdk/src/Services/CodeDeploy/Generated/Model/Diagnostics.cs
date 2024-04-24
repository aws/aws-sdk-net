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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
        private LifecycleErrorCode _errorCode;
        private string _logTail;
        private string _message;
        private string _scriptName;

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
        public LifecycleErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

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
        public string LogTail
        {
            get { return this._logTail; }
            set { this._logTail = value; }
        }

        // Check to see if LogTail property is set
        internal bool IsSetLogTail()
        {
            return this._logTail != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message associated with the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptName. 
        /// <para>
        /// The name of the script.
        /// </para>
        /// </summary>
        public string ScriptName
        {
            get { return this._scriptName; }
            set { this._scriptName = value; }
        }

        // Check to see if ScriptName property is set
        internal bool IsSetScriptName()
        {
            return this._scriptName != null;
        }

    }
}