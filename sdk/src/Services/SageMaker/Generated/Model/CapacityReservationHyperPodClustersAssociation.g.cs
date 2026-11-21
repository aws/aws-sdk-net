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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The association between the SageMaker AI HyperPod clusters in your account and a SageMaker
    /// Capacity Reservation.
    /// </summary>
    public partial class CapacityReservationHyperPodClustersAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociatedTime. 
        /// <para>
        /// The time when SageMaker AI started the current association. This time resets when
        /// you add the association again after it was removed or after it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AssociatedTime { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedTime property is set.
        /// </summary>
        internal bool IsSetAssociatedTime() => this.AssociatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the most recent attempt to add or remove the association failed. This
        /// value is returned only when the most recent attempt failed. After a failure to add
        /// the association, the status is <c>Inactive</c>. After a failure to remove the association,
        /// the status is <c>Active</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the association. Valid values:
        /// </para>
        ///  <dl> <dt>Pending</dt> <dd> 
        /// <para>
        /// SageMaker AI is adding or removing the association.
        /// </para>
        ///  </dd> <dt>Active</dt> <dd> 
        /// <para>
        /// The resources are associated with the SageMaker Capacity Reservation and can use its
        /// instances.
        /// </para>
        ///  </dd> <dt>Inactive</dt> <dd> 
        /// <para>
        /// The resources are not associated with the SageMaker Capacity Reservation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityReservationOptInStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
