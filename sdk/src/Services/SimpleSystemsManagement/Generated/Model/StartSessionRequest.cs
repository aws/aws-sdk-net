/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the StartSession operation.
    /// Initiates a connection to a target (for example, an instance) for a Session Manager
    /// session. Returns a URL and token that can be used to open a WebSocket connection for
    /// sending input and receiving outputs.
    /// 
    ///  <note> 
    /// <para>
    /// AWS CLI usage: <code>start-session</code> is an interactive command that requires
    /// the Session Manager plugin to be installed on the client machine making the call.
    /// For information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html">
    /// Install the Session Manager Plugin for the AWS CLI</a> in the <i>AWS Systems Manager
    /// User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartSessionRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _documentName;
        private Dictionary<string, List<string>> _parameters = new Dictionary<string, List<string>>();
        private string _target;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the SSM document to define the parameters and plugin settings for the
        /// session. For example, <code>SSM-SessionManagerRunShell</code>. If no document name
        /// is provided, a shell to the instance is launched by default.
        /// </para>
        /// </summary>
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The instance to connect to for the session.
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}