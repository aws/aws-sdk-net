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

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains information about the replication status of a canary replica.
    /// </summary>
    public partial class ReplicationStatus
    {
        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The replication state of the replica. Valid values are <c>InProgress</c>, <c>InSync</c>,
        /// and <c>Inconsistent</c>.
        /// </para>
        /// </summary>
        public ReplicationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// A description that provides more detail about the current replication state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StateReasonCode. 
        /// <para>
        /// A code that provides more detail about the current replication state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StateReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the StateReasonCode property is set.
        /// </summary>
        internal bool IsSetStateReasonCode() => this.StateReasonCode != null;
    }
}
