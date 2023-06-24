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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateSession operation.
    /// Terminates an active session. A <code>TerminateSession</code> call on a session that
    /// is already inactive (for example, in a <code>FAILED</code>, <code>TERMINATED</code>
    /// or <code>TERMINATING</code> state) succeeds but has no effect. Calculations running
    /// in the session when <code>TerminateSession</code> is called are forcefully stopped,
    /// but may display as <code>FAILED</code> instead of <code>STOPPED</code>.
    /// </summary>
    public partial class TerminateSessionRequest : AmazonAthenaRequest
    {
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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