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
    /// Container for the parameters to the SendBonus operation. The <c>SendBonus</c> operation
    /// issues a payment of money from your account to a Worker. This payment happens separately
    /// from the reward you pay to the Worker when you approve the Worker's assignment. The
    /// SendBonus operation requires the Worker's ID and the assignment ID as parameters to
    /// initiate payment of the bonus. You must include a message that explains the reason
    /// for the bonus payment, as the Worker may not be expecting the payment. Amazon Mechanical
    /// Turk collects a fee for bonus payments, similar to the HIT listing fee. This operation
    /// fails if your account does not have enough funds to pay for both the bonus and the
    /// fees.
    /// </summary>
    public partial class SendBonusRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        /// The ID of the assignment for which this bonus is paid.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AssignmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentId property is set.
        /// </summary>
        internal bool IsSetAssignmentId() => this.AssignmentId != null;

        /// <summary>
        /// Gets and sets the property BonusAmount. 
        /// <para>
        ///  The Bonus amount is a US Dollar amount specified using a string (for example, "5"
        /// represents $5.00 USD and "101.42" represents $101.42 USD). Do not include currency
        /// symbols or currency codes. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BonusAmount { get; set; }

        /// <summary>
        /// Checks to see if the BonusAmount property is set.
        /// </summary>
        internal bool IsSetBonusAmount() => this.BonusAmount != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message that explains the reason for the bonus payment. The Worker receiving the
        /// bonus can see this message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property UniqueRequestToken. 
        /// <para>
        /// A unique identifier for this request, which allows you to retry the call on error
        /// without granting multiple bonuses. This is useful in cases such as network timeouts
        /// where it is unclear whether or not the call succeeded on the server. If the bonus
        /// already exists in the system from a previous call using the same UniqueRequestToken,
        /// subsequent calls will return an error with a message containing the request ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string UniqueRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the UniqueRequestToken property is set.
        /// </summary>
        internal bool IsSetUniqueRequestToken() => this.UniqueRequestToken != null;

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The ID of the Worker being paid the bonus.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkerId property is set.
        /// </summary>
        internal bool IsSetWorkerId() => this.WorkerId != null;
    }
}
