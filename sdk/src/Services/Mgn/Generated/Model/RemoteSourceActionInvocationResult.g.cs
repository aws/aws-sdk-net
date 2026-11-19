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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// The latest invocation result of a source action on a source server.
    /// </summary>
    public partial class RemoteSourceActionInvocationResult
    {
        /// <summary>
        /// Gets and sets the property ConnectorOwnerAccountID. 
        /// <para>
        /// The ID of the account that owns the connector that ran the source action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ConnectorOwnerAccountID { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOwnerAccountID property is set.
        /// </summary>
        internal bool IsSetConnectorOwnerAccountID() => this.ConnectorOwnerAccountID != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the command finished.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RemoteSourceActionID. 
        /// <para>
        /// The unique identifier of the source action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string RemoteSourceActionID { get; set; }

        /// <summary>
        /// Checks to see if the RemoteSourceActionID property is set.
        /// </summary>
        internal bool IsSetRemoteSourceActionID() => this.RemoteSourceActionID != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the command started running.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the latest invocation.
        /// </para>
        /// </summary>
        public RemoteSourceActionInvocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
