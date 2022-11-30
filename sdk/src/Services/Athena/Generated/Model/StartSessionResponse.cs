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
    /// This is the response object from the StartSession operation.
    /// </summary>
    public partial class StartSessionResponse : AmazonWebServiceResponse
    {
        private string _sessionId;
        private SessionState _state;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the session. A description of each state follows.
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATING</code> - The session is being started, including acquiring resources.
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATED</code> - The session has been started.
        /// </para>
        ///  
        /// <para>
        ///  <code>IDLE</code> - The session is able to accept a calculation.
        /// </para>
        ///  
        /// <para>
        ///  <code>BUSY</code> - The session is processing another task and is unable to accept
        /// a calculation.
        /// </para>
        ///  
        /// <para>
        ///  <code>TERMINATING</code> - The session is in the process of shutting down.
        /// </para>
        ///  
        /// <para>
        ///  <code>TERMINATED</code> - The session and its resources are no longer running.
        /// </para>
        ///  
        /// <para>
        ///  <code>DEGRADED</code> - The session has no healthy coordinators.
        /// </para>
        ///  
        /// <para>
        ///  <code>FAILED</code> - Due to a failure, the session and its resources are no longer
        /// running.
        /// </para>
        /// </summary>
        public SessionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}