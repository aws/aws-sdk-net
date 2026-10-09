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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Summary information about a query session, including its identifier, name, and activity
    /// timestamps.
    /// </summary>
    public partial class SessionSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the session was created.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastActivityAt. The timestamp of the most recent activity
        /// in the session.
        /// </summary>
        public DateTime? LastActivityAt { get; set; }

        /// <summary>
        /// Checks to see if the LastActivityAt property is set.
        /// </summary>
        internal bool IsSetLastActivityAt() => this.LastActivityAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. The unique ID of the session.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionName. The human-readable name of the session. Names
        /// under `/aws/` are reserved for service integrations.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SessionName { get; set; }

        /// <summary>
        /// Checks to see if the SessionName property is set.
        /// </summary>
        internal bool IsSetSessionName() => this.SessionName != null;
    }
}
