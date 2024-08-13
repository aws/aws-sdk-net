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
    /// Contains information about the debug session for a build. For more information, see
    /// <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/session-manager.html">Viewing
    /// a running build in Session Manager</a>.
    /// </summary>
    public partial class DebugSession
    {
        private bool? _sessionEnabled;
        private string _sessionTarget;

        /// <summary>
        /// Gets and sets the property SessionEnabled. 
        /// <para>
        /// Specifies if session debugging is enabled for this build.
        /// </para>
        /// </summary>
        public bool? SessionEnabled
        {
            get { return this._sessionEnabled; }
            set { this._sessionEnabled = value; }
        }

        // Check to see if SessionEnabled property is set
        internal bool IsSetSessionEnabled()
        {
            return this._sessionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionTarget. 
        /// <para>
        /// Contains the identifier of the Session Manager session used for the build. To work
        /// with the paused build, you open this session to examine, control, and resume the build.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SessionTarget
        {
            get { return this._sessionTarget; }
            set { this._sessionTarget = value; }
        }

        // Check to see if SessionTarget property is set
        internal bool IsSetSessionTarget()
        {
            return this._sessionTarget != null;
        }

    }
}