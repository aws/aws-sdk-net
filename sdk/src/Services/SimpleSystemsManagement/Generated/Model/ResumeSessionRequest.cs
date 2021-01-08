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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ResumeSession operation.
    /// Reconnects a session to an instance after it has been disconnected. Connections can
    /// be resumed for disconnected sessions, but not terminated sessions.
    /// 
    ///  <note> 
    /// <para>
    /// This command is primarily for use by client machines to automatically reconnect during
    /// intermittent network issues. It is not intended for any other use.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ResumeSessionRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the disconnected session to resume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=96)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}