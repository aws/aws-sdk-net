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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
    public partial class ReservationPlanSettings
    {
        private Commitment _commitment;
        private RenewalType _renewalType;
        private int? _reservedSlots;

        /// <summary>
        /// Gets and sets the property Commitment. The length of the term of your reserved queue
        /// pricing plan commitment.
        /// </summary>
        [AWSProperty(Required=true)]
        public Commitment Commitment
        {
            get { return this._commitment; }
            set { this._commitment = value; }
        }

        // Check to see if Commitment property is set
        internal bool IsSetCommitment()
        {
            return this._commitment != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalType. Specifies whether the term of your reserved
        /// queue pricing plan is automatically extended (AUTO_RENEW) or expires (EXPIRE) at the
        /// end of the term. When your term is auto renewed, you extend your commitment by 12
        /// months from the auto renew date. You can cancel this commitment.
        /// </summary>
        [AWSProperty(Required=true)]
        public RenewalType RenewalType
        {
            get { return this._renewalType; }
            set { this._renewalType = value; }
        }

        // Check to see if RenewalType property is set
        internal bool IsSetRenewalType()
        {
            return this._renewalType != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedSlots. Specifies the number of reserved transcode
        /// slots (RTS) for this queue. The number of RTS determines how many jobs the queue can
        /// process in parallel; each RTS can process one job at a time. You can't decrease the
        /// number of RTS in your reserved queue. You can increase the number of RTS by extending
        /// your existing commitment with a new 12-month commitment for the larger number. The
        /// new commitment begins when you purchase the additional capacity. You can't cancel
        /// your commitment or revert to your original commitment after you increase the capacity.
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ReservedSlots
        {
            get { return this._reservedSlots; }
            set { this._reservedSlots = value; }
        }

        // Check to see if ReservedSlots property is set
        internal bool IsSetReservedSlots()
        {
            return this._reservedSlots.HasValue; 
        }

    }
}