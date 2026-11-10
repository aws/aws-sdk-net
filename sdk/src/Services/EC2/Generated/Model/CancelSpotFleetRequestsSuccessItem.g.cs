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
    /// Describes a Spot Fleet request that was successfully canceled.
    /// </summary>
    public partial class CancelSpotFleetRequestsSuccessItem
    {
        /// <summary>
        /// Gets and sets the property CurrentSpotFleetRequestState. 
        /// <para>
        /// The current state of the Spot Fleet request.
        /// </para>
        /// </summary>
        public BatchState CurrentSpotFleetRequestState { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSpotFleetRequestState property is set.
        /// </summary>
        internal bool IsSetCurrentSpotFleetRequestState() => this.CurrentSpotFleetRequestState != null;

        /// <summary>
        /// Gets and sets the property PreviousSpotFleetRequestState. 
        /// <para>
        /// The previous state of the Spot Fleet request.
        /// </para>
        /// </summary>
        public BatchState PreviousSpotFleetRequestState { get; set; }

        /// <summary>
        /// Checks to see if the PreviousSpotFleetRequestState property is set.
        /// </summary>
        internal bool IsSetPreviousSpotFleetRequestState() => this.PreviousSpotFleetRequestState != null;

        /// <summary>
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot Fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId { get; set; }

        /// <summary>
        /// Checks to see if the SpotFleetRequestId property is set.
        /// </summary>
        internal bool IsSetSpotFleetRequestId() => this.SpotFleetRequestId != null;
    }
}
