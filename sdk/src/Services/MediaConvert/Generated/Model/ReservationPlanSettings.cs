/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        /// Gets and sets the property Commitment. The length of time that you commit to when
        /// you set up a pricing plan contract for a reserved queue.
        /// </summary>
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
        /// Gets and sets the property RenewalType. Specifies whether the pricing plan contract
        /// for your reserved queue automatically renews (AUTO_RENEW) or expires (EXPIRE) at the
        /// end of the contract period.
        /// </summary>
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
        /// slots (RTSs) for this queue. The number of RTS determines how many jobs the queue
        /// can process in parallel; each RTS can process one job at a time. To increase this
        /// number, create a replacement contract through the AWS Elemental MediaConvert console.
        /// </summary>
        public int ReservedSlots
        {
            get { return this._reservedSlots.GetValueOrDefault(); }
            set { this._reservedSlots = value; }
        }

        // Check to see if ReservedSlots property is set
        internal bool IsSetReservedSlots()
        {
            return this._reservedSlots.HasValue; 
        }

    }
}