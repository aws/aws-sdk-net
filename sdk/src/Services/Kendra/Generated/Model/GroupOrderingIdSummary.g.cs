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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Summary information on the processing of <c>PUT</c> and <c>DELETE</c> actions for
    /// mapping users to their groups.
    /// </summary>
    public partial class GroupOrderingIdSummary
    {
        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason an action could not be processed. An action can be a <c>PUT</c> or <c>DELETE</c>
        /// action for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The Unix timestamp when an action was last updated. An action can be a <c>PUT</c>
        /// or <c>DELETE</c> action for mapping users to their groups.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property OrderingId. 
        /// <para>
        /// The order in which actions should complete processing. An action can be a <c>PUT</c>
        /// or <c>DELETE</c> action for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32535158400000)]
        public long? OrderingId { get; set; }

        /// <summary>
        /// Checks to see if the OrderingId property is set.
        /// </summary>
        internal bool IsSetOrderingId() => this.OrderingId.HasValue;

        /// <summary>
        /// Gets and sets the property ReceivedAt. 
        /// <para>
        /// The Unix timestamp when an action was received by Amazon Kendra. An action can be
        /// a <c>PUT</c> or <c>DELETE</c> action for mapping users to their groups.
        /// </para>
        /// </summary>
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedAt property is set.
        /// </summary>
        internal bool IsSetReceivedAt() => this.ReceivedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current processing status of actions for mapping users to their groups. The status
        /// can be either <c>PROCESSING</c>, <c>SUCCEEDED</c>, <c>DELETING</c>, <c>DELETED</c>,
        /// or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public PrincipalMappingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
