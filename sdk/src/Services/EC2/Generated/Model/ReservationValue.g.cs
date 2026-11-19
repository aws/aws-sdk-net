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
    /// The cost associated with the Reserved Instance.
    /// </summary>
    public partial class ReservationValue
    {
        /// <summary>
        /// Gets and sets the property HourlyPrice. 
        /// <para>
        /// The hourly rate of the reservation.
        /// </para>
        /// </summary>
        public string HourlyPrice { get; set; }

        /// <summary>
        /// Checks to see if the HourlyPrice property is set.
        /// </summary>
        internal bool IsSetHourlyPrice() => this.HourlyPrice != null;

        /// <summary>
        /// Gets and sets the property RemainingTotalValue. 
        /// <para>
        /// The balance of the total value (the sum of remainingUpfrontValue + hourlyPrice * number
        /// of hours remaining).
        /// </para>
        /// </summary>
        public string RemainingTotalValue { get; set; }

        /// <summary>
        /// Checks to see if the RemainingTotalValue property is set.
        /// </summary>
        internal bool IsSetRemainingTotalValue() => this.RemainingTotalValue != null;

        /// <summary>
        /// Gets and sets the property RemainingUpfrontValue. 
        /// <para>
        /// The remaining upfront cost of the reservation.
        /// </para>
        /// </summary>
        public string RemainingUpfrontValue { get; set; }

        /// <summary>
        /// Checks to see if the RemainingUpfrontValue property is set.
        /// </summary>
        internal bool IsSetRemainingUpfrontValue() => this.RemainingUpfrontValue != null;
    }
}
