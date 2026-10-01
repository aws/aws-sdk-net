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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Summary information about a query session, including its identifier, name, and activity
    /// timestamps.
    /// </summary>
    public partial class SessionSummary
    {
        private DateTime? _createdAt;
        private DateTime? _lastActivityAt;
        private string _sessionId;
        private string _sessionName;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the session was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastActivityAt. 
        /// <para>
        /// The timestamp of the most recent activity in the session.
        /// </para>
        /// </summary>
        public DateTime? LastActivityAt
        {
            get { return this._lastActivityAt; }
            set { this._lastActivityAt = value; }
        }

        // Check to see if LastActivityAt property is set
        internal bool IsSetLastActivityAt()
        {
            return this._lastActivityAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The human-readable name of the session. Names under <c>/aws/</c> are reserved for
        /// service integrations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

    }
}