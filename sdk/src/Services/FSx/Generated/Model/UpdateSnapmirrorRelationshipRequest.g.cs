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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSnapmirrorRelationship operation. Updates
    /// an Amazon FSx for NetApp ONTAP SnapMirror relationship.
    /// </summary>
    public partial class UpdateSnapmirrorRelationshipRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// Specifies the ID of the SnapMirror policy that the SnapMirror relationship uses.
        /// </para>
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property SnapmirrorRelationshipId. 
        /// <para>
        /// The ID of the SnapMirror relationship that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapmirrorRelationshipId { get; set; }

        /// <summary>
        /// Checks to see if the SnapmirrorRelationshipId property is set.
        /// </summary>
        internal bool IsSetSnapmirrorRelationshipId() => this.SnapmirrorRelationshipId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Specifies the state to set for the SnapMirror relationship:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SNAPMIRRORED</c> – Resumes a paused SnapMirror relationship, or resynchronizes
        /// a broken-off SnapMirror relationship.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAUSED</c> – Pauses SnapMirror transfers for the relationship.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BROKEN_OFF</c> – Breaks off the SnapMirror relationship, which makes the destination
        /// volume writable.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Setting <c>State</c> to <c>SNAPMIRRORED</c> on a relationship that is <c>BROKEN_OFF</c>
        /// might resynchronize the relationship. A resync overwrites the destination volume with
        /// data from the source volume, and discards any data written to the destination volume
        /// that isn't present on the source volume. Use caution when you resynchronize a relationship.
        /// </para>
        ///  </important>
        /// </summary>
        public UpdatableSnapmirrorRelationshipState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property ThrottleInKbps. 
        /// <para>
        /// Specifies the maximum bandwidth, in kilobytes per second (KBps), that SnapMirror uses
        /// to transfer data for the relationship. A value of <c>0</c> means that the bandwidth
        /// is unlimited. This value overrides the throttle of the SnapMirror policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ThrottleInKbps { get; set; }

        /// <summary>
        /// Checks to see if the ThrottleInKbps property is set.
        /// </summary>
        internal bool IsSetThrottleInKbps() => this.ThrottleInKbps.HasValue;

        /// <summary>
        /// Gets and sets the property TransferSchedule. 
        /// <para>
        /// Specifies the name of the ONTAP schedule that determines when SnapMirror transfers
        /// data for the relationship. This schedule overrides the transfer schedule of the SnapMirror
        /// policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TransferSchedule { get; set; }

        /// <summary>
        /// Checks to see if the TransferSchedule property is set.
        /// </summary>
        internal bool IsSetTransferSchedule() => this.TransferSchedule != null;
    }
}
