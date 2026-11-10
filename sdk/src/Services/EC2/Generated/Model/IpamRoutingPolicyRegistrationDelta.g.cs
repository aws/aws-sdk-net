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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains information about a routing policy registration change, including the changes
    /// applied and their publication state.
    /// </summary>
    public partial class IpamRoutingPolicyRegistrationDelta
    {
        /// <summary>
        /// Gets and sets the property DeltaId. 
        /// <para>
        /// The unique identifier of the delta.
        /// </para>
        /// </summary>
        public string DeltaId { get; set; }

        /// <summary>
        /// Checks to see if the DeltaId property is set.
        /// </summary>
        internal bool IsSetDeltaId() => this.DeltaId != null;

        /// <summary>
        /// Gets and sets the property DeltaJson. 
        /// <para>
        /// The JSON specification describing the changes applied in this delta.
        /// </para>
        /// </summary>
        public string DeltaJson { get; set; }

        /// <summary>
        /// Checks to see if the DeltaJson property is set.
        /// </summary>
        internal bool IsSetDeltaJson() => this.DeltaJson != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the delta. Valid values: <c>pending</c> | <c>published</c> | <c>failed</c>.
        /// </para>
        /// </summary>
        public IpamRoutingPolicyRegistrationDeltaState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message describing the current state, including error information if the delta failed.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;
    }
}
