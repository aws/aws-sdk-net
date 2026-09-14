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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Details about the pricing plan for your reserved queue. Required for reserved queues
    /// and not applicable to on-demand queues.
    /// </summary>
    public partial class ReservationPlan
    {
        /// <summary>
        /// Gets and sets the property Commitment. The length of the term of your reserved queue
        /// pricing plan commitment.
        /// </summary>
        public Commitment Commitment { get; set; }

        /// <summary>
        /// Checks to see if the Commitment property is set.
        /// </summary>
        internal bool IsSetCommitment() => this.Commitment != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. The timestamp in epoch seconds for when the
        /// current pricing plan term for this reserved queue expires.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property PurchasedAt. The timestamp in epoch seconds for when you
        /// set up the current pricing plan for this reserved queue.
        /// </summary>
        public DateTime? PurchasedAt { get; set; }

        /// <summary>
        /// Checks to see if the PurchasedAt property is set.
        /// </summary>
        internal bool IsSetPurchasedAt() => this.PurchasedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RenewalType. Specifies whether the term of your reserved
        /// queue pricing plan is automatically extended (AUTO_RENEW) or expires (EXPIRE) at the
        /// end of the term.
        /// </summary>
        public RenewalType RenewalType { get; set; }

        /// <summary>
        /// Checks to see if the RenewalType property is set.
        /// </summary>
        internal bool IsSetRenewalType() => this.RenewalType != null;

        /// <summary>
        /// Gets and sets the property ReservedSlots. Specifies the number of reserved transcode
        /// slots (RTS) for this queue. The number of RTS determines how many jobs the queue can
        /// process in parallel; each RTS can process one job at a time. When you increase this
        /// number, you extend your existing commitment with a new 12-month commitment for a larger
        /// number of RTS. The new commitment begins when you purchase the additional capacity.
        /// You can't decrease the number of RTS in your reserved queue.
        /// </summary>
        public int? ReservedSlots { get; set; }

        /// <summary>
        /// Checks to see if the ReservedSlots property is set.
        /// </summary>
        internal bool IsSetReservedSlots() => this.ReservedSlots.HasValue;

        /// <summary>
        /// Gets and sets the property Status. Specifies whether the pricing plan for your reserved
        /// queue is ACTIVE or EXPIRED.
        /// </summary>
        public ReservationPlanStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
