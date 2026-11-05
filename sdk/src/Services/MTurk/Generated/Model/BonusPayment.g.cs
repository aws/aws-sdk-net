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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// An object representing a Bonus payment paid to a Worker.
    /// </summary>
    public partial class BonusPayment
    {
        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        /// The ID of the assignment associated with this bonus payment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AssignmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentId property is set.
        /// </summary>
        internal bool IsSetAssignmentId() => this.AssignmentId != null;

        /// <summary>
        /// Gets and sets the property BonusAmount.
        /// </summary>
        public string BonusAmount { get; set; }

        /// <summary>
        /// Checks to see if the BonusAmount property is set.
        /// </summary>
        internal bool IsSetBonusAmount() => this.BonusAmount != null;

        /// <summary>
        /// Gets and sets the property GrantTime. 
        /// <para>
        /// The date and time of when the bonus was granted.
        /// </para>
        /// </summary>
        public DateTime? GrantTime { get; set; }

        /// <summary>
        /// Checks to see if the GrantTime property is set.
        /// </summary>
        internal bool IsSetGrantTime() => this.GrantTime.HasValue;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The Reason text given when the bonus was granted, if any.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The ID of the Worker to whom the bonus was paid.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkerId property is set.
        /// </summary>
        internal bool IsSetWorkerId() => this.WorkerId != null;
    }
}
